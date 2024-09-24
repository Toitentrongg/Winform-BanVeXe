using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.qLBVXDataSet.NhanVien);
            this.nhanVienTableAdapter.Fill(this.qLBVXDataSet.NhanVien);
            try
            {
                using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
                {
                    connection.Open();

                    // Thực hiện truy vấn để lấy dữ liệu từ bảng KhachHang
                    string query = "SELECT * FROM NhanVien";
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
        }

        public void ThemNhanVienVaoDataTable(string maNV, string tenNV, string DiaChi, string SoDT)
        {
            SqlConnection con = new SqlConnection(Connectionstring.Conn);
            con.Open();
            DataRow newRow = qLBVXDataSet.NhanVien.NewRow();
            newRow["MaNV"] = maNV;
            newRow["TenNV"] = tenNV;
            newRow["DiaChi"] = DiaChi;
            newRow["SoDT"] = SoDT;

            qLBVXDataSet.NhanVien.Rows.Add(newRow);

            // Cập nhật cơ sở dữ liệu
            string insertQuery = "INSERT INTO NhanVien (MaNV, TenNV, DiaChi,SoDT) VALUES (@maNV, @tenNV, @DiaChi,@SoDT)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@tenNV", tenNV);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@SoDT", SoDT);

                cmd.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Them = new AddNV(this);
            Them.ShowDialog();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                // Có ít nhất một ô được chọn
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                // Không có ô nào được chọn
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                SqlConnection con = new SqlConnection(Connectionstring.Conn);
                con.Open();
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                if (selectedRow.Cells["MaNV1"].Value is string maNV)
                {
                    Form formCapNhat = new CapNhatNV(maNV);
                    formCapNhat.ShowDialog();

                    // Sau khi formCapNhat được đóng, đọc giá trị từ các biến public
                    string TenNVMoi = ((CapNhatNV)formCapNhat).Ten;
                    string DiaChiMoi = ((CapNhatNV)formCapNhat).DiaChi;
                    string soDTMoi = ((CapNhatNV)formCapNhat).SoDT;
                    // Thực hiện các hành động cập nhật dữ liệu trong form QLNguoiDung
                    // Ví dụ: Cập nhật dữ liệu trong DataGridView
                    // Hãy thay đổi dòng này dựa vào cách bạn lưu trữ dữ liệu (DataTable, Entity Framework, ...).
                    dataGridView2.CurrentRow.Cells["TenNV1"].Value = TenNVMoi;
                    dataGridView2.CurrentRow.Cells["DiaChi1"].Value = DiaChiMoi;
                    dataGridView2.CurrentRow.Cells["SoDT1"].Value = soDTMoi;

                    // Hoặc cập nhật vào cơ sở dữ liệu nếu cần thiết
                    string updateQuery = "UPDATE NhanVien SET TenNV = @TenNV, DiaChi = @DiaChi ,SoDT = @SoDT WHERE MaNV = @MaNV";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@TenNV", TenNVMoi);
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring.Conn);
            con.Open();
            string MaNV = dataGridView2.SelectedRows[0].Cells["MaNV1"].Value.ToString();
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                dataGridView2.Rows.Remove(selectedRow);
                string deleteQuery = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MaNV", MaNV);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
