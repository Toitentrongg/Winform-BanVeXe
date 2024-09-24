using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBanVeXeKhach
{
    public partial class ThemVe : Form
    {

        public ThemVe()
        {
            InitializeComponent();
        }

        private void ThemVe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVXDataSet.TuyenXe' table. You can move, or remove it, as needed.
            this.tuyenXeTableAdapter.Fill(this.qLBVXDataSet.TuyenXe);
            // TODO: This line of code loads data into the 'qLBVXDataSet.ChuyenXe' table. You can move, or remove it, as needed.
            this.chuyenXeTableAdapter.Fill(this.qLBVXDataSet.ChuyenXe);
            try
            {
                using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
                {
                    connection.Open();

                    // Thực hiện truy vấn để lấy dữ liệu từ bảng KhachHang
                    string query = "SELECT * FROM ChuyenXe";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateButtonState()
        {
            // Kiểm tra nếu cả hai TextBox đều có giá trị
            if (!string.IsNullOrWhiteSpace(MaCX.Text) &&
                !string.IsNullOrWhiteSpace(SoVeCon.Text)
                )
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void MaCX_TextChanged(object sender, EventArgs e)
        {
            if (MaCX.Text.Contains(" "))
            {
                MessageBox.Show("Mã Chuyến Xe không được có khoản trắng ! ", "Thông Báo");
            }
            UpdateButtonState();
        }
        static bool checkmaCX(string maCX)
        {
            // Kiểm tra xem mã chuyến xe có bắt đầu bằng "C" và có 4 kí tự hay không
            return maCX.Length >= 4 && maCX.Substring(0, 1).Equals("C", StringComparison.OrdinalIgnoreCase);
        }
        private void MaCX_Leave(object sender, EventArgs e)
        {
            if (!(checkmaCX(MaCX.Text)) )
            {
                MessageBox.Show("Mã chuyến xe phải bắt đầu bằng kí tự 'C' ");
                button1.Enabled=false;
            }
            else
            {
                button1.Enabled=true;   
            }
        }

        private void DiemXP_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void DiemDen_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();

        }

        private void GiaVe_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();

        }

        private void SLGhe_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();

        }

        private void SoVeCon_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();

        }
        public void ThemChuyenXeVaoDataTable(string maCX, string MaTuyen, DateTime ThoiGianXuatPhat, string ThoiGianDi, int SLGhe, int SoVeCon)
         {
             using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
             {
                 con.Open();

                 DataRow newRow = qLBVXDataSet.ChuyenXe.NewRow();
                 newRow["MaChuyenXe"] = maCX;
                 newRow["MaTuyen"] = MaTuyen;
                 newRow["ThoiGianXuatPhat"] = ThoiGianXuatPhat;
                 newRow["ThoiGianDi"] = TimeSpan.Parse(ThoiGianDi); // Chuyển đổi thành kiểu TimeSpan
                 newRow["SoLuongGhe"] = SLGhe;
                 newRow["SoVeCon"] = SoVeCon;
                 qLBVXDataSet.ChuyenXe.Rows.Add(newRow);

                 // Cập nhật cơ sở dữ liệu
                 string insertQuery = "INSERT INTO ChuyenXe (MaChuyenXe,MaTuyen, ThoiGianXuatPhat, ThoiGianDi, SoLuongGhe, SoVeCon) " +
                                      "VALUES (@maCX, @MaTuyen, @ThoiGianXuatPhat, @ThoiGianDi, @SLGhe, @SoVeCon )";
                 using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                 {
                     cmd.Parameters.AddWithValue("@maCX", maCX);
                     cmd.Parameters.AddWithValue("@MaTuyen", MaTuyen);
                     cmd.Parameters.AddWithValue("@ThoiGianXuatPhat", ThoiGianXuatPhat);
                     cmd.Parameters.AddWithValue("@ThoiGianDi", TimeSpan.Parse(ThoiGianDi)); // Chuyển đổi thành kiểu TimeSpan
                     cmd.Parameters.AddWithValue("@SLGhe", SLGhe);
                     cmd.Parameters.AddWithValue("@SoVeCon", SoVeCon);

                     cmd.ExecuteNonQuery();
                 }
             }
         }

        public void TaoVX(string maCX, int SLGhe)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("InsertVeXe", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaCX", maCX);
                    cmd.Parameters.AddWithValue("@SLGhe", SLGhe);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool KiemTraTonTai(string check, DataGridView dataGridView, string tenCot)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[tenCot].Value != null &&
                    row.Cells[tenCot].Value.ToString() == check)
                {
                    return true; // Giá trị đã tồn tại
                }
            }
            return false; // Giá trị chưa tồn tại
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maCX = MaCX.Text;
            string maTuyen = cbMaTuyen.SelectedValue.ToString();
            DateTime thoiGianXP = DateTime.ParseExact(dateTGXuatPhat.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ThoiGianDi = DateTGDi.Text;
            int SoLuongGhe = int.Parse(cbSLGhe.SelectedItem.ToString());
            int SoVeC = int.Parse(SoVeCon.Text);
            if (!(KiemTraTonTai(maCX, dataGridView1, "MaChuyenXe1")))
            {
                ThemChuyenXeVaoDataTable(maCX, maTuyen, thoiGianXP, ThoiGianDi, SoLuongGhe, SoVeC);
                TaoVX(maCX, SoLuongGhe);
            }
            else
            {
                MessageBox.Show("Mã Chuyến Xe đã tồn tại trong database", "Thông Báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SqlConnection con = new SqlConnection(Connectionstring.Conn);
                con.Open();

                string maCX = dataGridView1.SelectedRows[0].Cells["MaChuyenXe1"].Value.ToString();

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(selectedRow);
                string deleteQuery = "DELETE FROM VeXe WHERE MaChuyenXe = @MaChuyenXe";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MaChuyenXe", maCX);

                    cmd.ExecuteNonQuery();
                }
                string deleteQuery1 = "DELETE FROM ChuyenXe WHERE MaChuyenXe = @MaChuyenXe";
                using (SqlCommand cmd = new SqlCommand(deleteQuery1, con))
                {
                    cmd.Parameters.AddWithValue("@MaChuyenXe", maCX);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SqlConnection con = new SqlConnection(Connectionstring.Conn);
                con.Open();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells["MaChuyenXe1"].Value is string maCX)
                {
                    Form formSua = new SuaCX(maCX);
                    formSua.ShowDialog();

                    // Sau khi formCapNhat được đóng, đọc giá trị từ các biến public
                    string MaTuyenMoi = ((SuaCX)formSua).MaTuyen;
                    DateTime TGXPMoi = ((SuaCX)formSua).ThoiGianXuatPhat;
                    string TGDiMoi = ((SuaCX)formSua).ThoiGianDi;
                    int SLGheMoi = ((SuaCX)formSua).SoLuongGhe;
                    int SoVeConMoi = ((SuaCX)formSua).SoV;
                    int GiaVeMoi = ((SuaCX)formSua).GiaV;

                    // Thực hiện các hành động cập nhật dữ liệu trong form QLNguoiDung
                    // Ví dụ: Cập nhật dữ liệu trong DataGridView
                    // Hãy thay đổi dòng này dựa vào cách bạn lưu trữ dữ liệu (DataTable, Entity Framework, ...).
                    dataGridView1.CurrentRow.Cells["MaTuyen1"].Value = MaTuyenMoi;
                    dataGridView1.CurrentRow.Cells["ThoiGianXuatPhat1"].Value = TGXPMoi;
                    dataGridView1.CurrentRow.Cells["ThoiGianDi1"].Value = TGDiMoi;
                    dataGridView1.CurrentRow.Cells["SoLuongGhe1"].Value = SLGheMoi;
                    dataGridView1.CurrentRow.Cells["SoVeCon2"].Value = SoVeConMoi;
                    // Hoặc cập nhật vào cơ sở dữ liệu nếu cần thiết
                    string updateQuery = "UPDATE ChuyenXe SET MaTuyen = @MaTuyen,ThoiGianXuatPhat = @ThoiGianXuatPhat,ThoiGianDi = @ThoiGianDi ," +
                        " SoLuongGhe = @SoLuongGhe , SoVeCon = @SoVeCon WHERE MaChuyenXe = @MaChuyenXe";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MaChuyenXe", maCX);
                        cmd.Parameters.AddWithValue("@MaTuyen", MaTuyenMoi);
                        cmd.Parameters.AddWithValue("@ThoiGianXuatPhat", TGXPMoi);
                        cmd.Parameters.AddWithValue("@ThoiGianDi", TGDiMoi);
                        cmd.Parameters.AddWithValue("@SoLuongGhe", SLGheMoi);
                        cmd.Parameters.AddWithValue("@SoVeCon", SoVeConMoi);
                        cmd.Parameters.AddWithValue("@GiaVe", GiaVeMoi);

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

        private void btnThemTuyen_Click(object sender, EventArgs e)
        {
            Form tuyen = new QLTuyenXe();
            tuyen.ShowDialog();
        }
    }
}
