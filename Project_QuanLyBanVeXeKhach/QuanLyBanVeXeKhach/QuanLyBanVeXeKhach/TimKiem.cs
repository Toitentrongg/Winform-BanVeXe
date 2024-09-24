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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        public void TimKiem1(string Ma,string query)
        {
            // Kiểm tra xem mã chuyến xe có giá trị không
            if (!string.IsNullOrEmpty(Ma))
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
                {
                    con.Open();

                    // Xây dựng câu truy vấn SQL
                   // string query = "SELECT * FROM VeXe WHERE MaChuyenXe = @ma";

                    // Thực hiện truy vấn SQL
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ma", Ma);

                        // Sử dụng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                        adapter.Fill(dataTable);

                        // Đổ dữ liệu từ DataTable vào DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text;
            string query = "SELECT * FROM KhachHang WHERE MaKH = @ma";

            TimKiem1(MaKH, query);
        }

        private void btnTimCX_Click(object sender, EventArgs e)
        {
            string MaCX = txtMaCX.Text;
            string query = "SELECT * FROM ChuyenXe WHERE MaChuyenXe = @ma";
            TimKiem1(MaCX, query);

        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            string query = "SELECT * FROM NhanVien WHERE MaNV = @ma";
            TimKiem1(MaNV, query);
        }

        private void btnTimVX_Click(object sender, EventArgs e)
        {
            string MaVeXe = txtMaVX.Text;
            string query = "SELECT * FROM VeXe WHERE MaVeXe = @ma";
            TimKiem1(MaVeXe, query);
        }
    }
}
