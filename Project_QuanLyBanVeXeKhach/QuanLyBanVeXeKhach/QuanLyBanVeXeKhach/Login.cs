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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu
            string tenDangNhap = TenTaiKhoan.Text;
            string matKhau = MatKhau.Text;
            GiaoDien ownerForm = this.Owner as GiaoDien;

            // Kết nối đến cơ sở dữ liệu SQL Server
            using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
            {
                connection.Open();

                // Truy vấn SQL để kiểm tra thông tin đăng nhập
                string query = "SELECT QuyenHan FROM Users WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    // Thực hiện truy vấn và lấy giá trị quyền hạn từ cơ sở dữ liệu
                    object roleObject = command.ExecuteScalar();

                    if (roleObject != null)
                    {
                        string role = roleObject.ToString();

                        // Hiển thị thông báo đăng nhập thành công và lưu giữ quyền hạn
                        MessageBox.Show($"Đăng nhập thành công với quyền hạn: {role}");
                        if (role == "Quan Tri")
                        {
                            Role.IsAdmin = true;
                            Role.IsNV = false;
                        }
                        else
                        {
                            if (role == "Nhan Vien")
                            {
                                Role.IsNV = true;
                                Role.IsAdmin = false;
                            }
                        }
                        // Đóng form đăng nhập
                        Form GiaoDien = new GiaoDien();
                        GiaoDien.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Hiển thị thông báo lỗi khi tên đăng nhập hoặc mật khẩu không chính xác
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.");
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MatKhau.Visible = false;
                MatKhau2.Visible = true;
            }
            else
            {
                MatKhau.Visible = true;
                MatKhau2.Visible = false;
            }
        }

        private void MatKhau2_TextChanged(object sender, EventArgs e)
        {
            MatKhau.Text = MatKhau2.Text;

        }

        private void MatKhau_TextChanged(object sender, EventArgs e)
        {
            MatKhau2.Text = MatKhau.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Role.IsAdmin = false;
            Role.IsNV = false;
        }
    }
}
