using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{

    public partial class BanVe : Form
    {
        private List<string> danhSachVeXe;
        DateTime ngaymua;
        int giave{ get ; set; }
        public event EventHandler TicketsSoldSuccessfully;

        public BanVe(List<string> listVeXe,DateTime NgayMua,int Giave )
        {
            InitializeComponent();
            danhSachVeXe = listVeXe;
            this.ngaymua = NgayMua;
            this.giave = Giave;

        }

        private void BanVe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVXDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLBVXDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qLBVXDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLBVXDataSet.KhachHang);
            try
            {
                using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
                {
                    connection.Open();

                    // Thực hiện truy vấn để lấy dữ liệu từ bảng KhachHang
                    string query = "SELECT * FROM KhachHang";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            txtmaVeXe.Text = string.Join(", ", danhSachVeXe);
            TxtGiaVe.Text = giave.ToString();
        }
        public void ThemKhachHangVaoData(string MaKH, string TenKH, string DiaChi, string SoDT)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();

                DataRow newRow = qLBVXDataSet.KhachHang.NewRow();
                newRow["MaKH2"] = MaKH;
                newRow["TenKH2"] = TenKH;
                newRow["DiaChi2"] = DiaChi;
                newRow["SoDT2"] = SoDT;
                newRow["SoVeMua2"] = 0;

                qLBVXDataSet.KhachHang.Rows.Add(newRow);

                // Cập nhật cơ sở dữ liệu
                string insertQuery = "INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT, SoVeMua) " +
                                     "VALUES (@MaKH, @TenKH, @DiaChi, @SoDT, @SoVeMua)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MaKH", MaKH);
                    cmd.Parameters.AddWithValue("@TenKH", TenKH);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                    cmd.Parameters.AddWithValue("@SoDT", SoDT);
                    cmd.Parameters.AddWithValue("@SoVeMua", 0);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtKH.Text;
            string diachi = txtDiaChi.Text;
            string soDT = txtSDT.Text;
            ThemKhachHangVaoData(maKH,tenKH, diachi,soDT);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn không
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Lấy mã khách hàng từ dòng đầu tiên được chọn
                string maKH = dataGridView2.SelectedRows[0].Cells["MaKH"].Value.ToString();

                using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
                {
                    con.Open();

                    // Thực hiện UPDATE trong bảng "VeXe" để cập nhật các giá trị thành NULL
                    string updateQuery = "UPDATE VeXe SET MaNV = @MaNV, MaKH = @MaKH1, NgayMua = @NgayMua, TrangThai = @TrangThai WHERE MaKH = @MaKH";
                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
                    {
                        cmdUpdate.Parameters.AddWithValue("@MaKH", maKH);
                        cmdUpdate.Parameters.AddWithValue("@MaNV", DBNull.Value);
                        cmdUpdate.Parameters.AddWithValue("@MaKH1", DBNull.Value);
                        cmdUpdate.Parameters.AddWithValue("@NgayMua", DBNull.Value);
                        cmdUpdate.Parameters.AddWithValue("@TrangThai", 0);
                        cmdUpdate.Parameters.AddWithValue("@GiaVe", DBNull.Value);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    // Xóa dòng khỏi dataGridView2
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    dataGridView2.Rows.Remove(selectedRow);

                    // Thực hiện truy vấn xóa trong bảng "KhachHang"
                    string deleteQuery = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                    using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, con))
                    {
                        cmdDelete.Parameters.AddWithValue("@MaKH", maKH);

                        cmdDelete.ExecuteNonQuery();
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Khách Hàng để xóa.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                SqlConnection con = new SqlConnection(Connectionstring.Conn);
                con.Open();
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                if (selectedRow.Cells["MaKH1"].Value is string MaKH)
                {
                    Form Formsua = new SuaKH(MaKH);
                    Formsua.ShowDialog();

                    // Sau khi formCapNhat được đóng, đọc giá trị từ các biến public
                    string TenKHMoi = ((SuaKH)Formsua).tenKH;
                    string DiaChiMoi = ((SuaKH)Formsua).DiaChiKH;
                    string soDTMoi = ((SuaKH)Formsua).SDTKH;
                    // Thực hiện các hành động cập nhật dữ liệu trong form QLNguoiDung
                    // Ví dụ: Cập nhật dữ liệu trong DataGridView
                    // Hãy thay đổi dòng này dựa vào cách bạn lưu trữ dữ liệu (DataTable, Entity Framework, ...).
                    dataGridView2.CurrentRow.Cells["TenKH2"].Value = TenKHMoi;
                    dataGridView2.CurrentRow.Cells["DiaChi2"].Value = DiaChiMoi;
                    dataGridView2.CurrentRow.Cells["SoDT2"].Value = soDTMoi;

                    // Hoặc cập nhật vào cơ sở dữ liệu nếu cần thiết
                    string updateQuery = "UPDATE KhachHang SET TenKH = @TenNV, DiaChi = @DiaChi ,SoDT = @SoDT WHERE MaKH = @MaKH";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", MaKH);
                        cmd.Parameters.AddWithValue("@TenNV", TenKHMoi);
                        cmd.Parameters.AddWithValue("@DiaChi", DiaChiMoi);
                        cmd.Parameters.AddWithValue("@SoDT", soDTMoi);

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ trong dòng được chọn.");
                }
            }
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            if (!txtMaKH.Text.StartsWith("KH"))
            {
                MessageBox.Show("Mã KH phải bắt đầu bằng 'KH'.");
                txtMaKH.Focus();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH1.Text))
            {
                // TextBox rỗng, thực hiện hành động tương ứng, ví dụ: hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng Chọn 1 khách hàng.");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
                {
                    con.Open();

                    foreach (string i in danhSachVeXe)
                    {
                        // Thực hiện UPDATE trong bảng "VeXe" để cập nhật các giá trị  
                        string updateQuery = "UPDATE VeXe SET MaNV = @MaNV, MaKH = @MaKH, NgayMua = @NgayMua, TrangThai = @TrangThai WHERE MaVeXe = @MaVeXe";
                        using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
                        {
                            cmdUpdate.Parameters.AddWithValue("@MaKH", txtMaKH1.Text); // Use txtMaKH1.Text directly
                            cmdUpdate.Parameters.AddWithValue("@MaNV", cbMaNV.SelectedValue);
                            cmdUpdate.Parameters.AddWithValue("@MaVeXe", i);
                            cmdUpdate.Parameters.AddWithValue("@NgayMua", ngaymua);
                            cmdUpdate.Parameters.AddWithValue("@TrangThai", 1);

                            cmdUpdate.ExecuteNonQuery();
                        }
                    }
                }

                TicketsSoldSuccessfully?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Bán Vé Thành Công ", "Thông Báo");
                this.Close();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Lấy mã khách hàng từ dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Kiểm tra xem ô giá trị có tồn tại không
                if (selectedRow.Cells["MaKH2"].Value is string maKH)
                {
                    txtMaKH1.Text = maKH;
                }
                else
                {
                    // Xử lý trường hợp giá trị không phải là string
                    txtMaKH1.Text = string.Empty;
                }
            }
        }


    }
}
