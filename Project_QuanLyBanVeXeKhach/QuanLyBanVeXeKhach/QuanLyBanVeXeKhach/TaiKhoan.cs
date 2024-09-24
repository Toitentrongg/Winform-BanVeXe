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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVXDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.qLBVXDataSet.Users);
            // TODO: This line of code loads data into the 'qLBVXDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.qLBVXDataSet.Users);
            // TODO: This line of code loads data into the 'qLBVXDataSet.Users' table. You can move, or remove it, as needed.
            button2.Enabled = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
                {
                    connection.Open();

                    // Thực hiện truy vấn để lấy dữ liệu từ bảng KhachHang
                    string query = "SELECT * FROM Users";
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
        public void ThemTaiKhoanVaoDataTable(string tenDangNhap, string matKhau, string chucvu)
        {
            SqlConnection con = new SqlConnection(Connectionstring.Conn);
            con.Open();
            DataRow newRow = qLBVXDataSet.Users.NewRow();
            newRow["TenDangNhap"] = tenDangNhap;
            newRow["MatKhau"] = matKhau;
            newRow["QuyenHan"] = chucvu;

            qLBVXDataSet.Users.Rows.Add(newRow);

            // Cập nhật cơ sở dữ liệu
            string insertQuery = "INSERT INTO Users (TenDangNhap, MatKhau, QuyenHan) VALUES (@TenDangNhap, @MatKhau, @QuyenHan)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@QuyenHan", chucvu);

                cmd.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Them = new AddTaiKhoan(this);
            Them.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Có ít nhất một ô được chọn
                button2.Enabled = true;
            }
            else
            {
                // Không có ô nào được chọn
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SqlConnection con = new SqlConnection(Connectionstring.Conn);
                con.Open();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells["TenDangNhap"].Value is string tenDangNhap)
                {
                    Form formCapNhat = new CapNhat(tenDangNhap);
                    formCapNhat.ShowDialog();

                    // Sau khi formCapNhat được đóng, đọc giá trị từ các biến public
                    string matKhauMoi = ((CapNhat)formCapNhat).MatKhau;
                    string chucVuMoi = ((CapNhat)formCapNhat).ChucVu;

                    // Thực hiện các hành động cập nhật dữ liệu trong form QLNguoiDung
                    // Ví dụ: Cập nhật dữ liệu trong DataGridView
                    // Hãy thay đổi dòng này dựa vào cách bạn lưu trữ dữ liệu (DataTable, Entity Framework, ...).
                    dataGridView1.CurrentRow.Cells["MatKhau"].Value = matKhauMoi;
                    dataGridView1.CurrentRow.Cells["QuyenHan"].Value = chucVuMoi;

                    // Hoặc cập nhật vào cơ sở dữ liệu nếu cần thiết
                    string updateQuery = "UPDATE Users SET MatKhau = @MatKhau, QuyenHan = @QuyenHan WHERE TenDangNhap = @TenDangNhap";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhauMoi);
                        cmd.Parameters.AddWithValue("@QuyenHan", chucVuMoi);

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ trong dòng được chọn.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring.Conn);
            con.Open();
            string tendangnhap = dataGridView1.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(selectedRow);
                string deleteQuery = "DELETE FROM Users WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tendangnhap);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
