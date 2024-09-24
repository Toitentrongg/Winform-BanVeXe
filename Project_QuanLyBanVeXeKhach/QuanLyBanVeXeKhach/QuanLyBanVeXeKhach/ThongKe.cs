using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            NgayHienTai.Text = DateTime.Now.ToString();
        }

        private void btnThongKeTheoTuyen_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
            {
                SqlCommand lenh = new SqlCommand();
                lenh.Connection = connection;

                lenh.CommandType = CommandType.StoredProcedure;
                lenh.CommandText = "GetDoanhThuTheoTuyen";
                lenh.Parameters.Clear();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = lenh;

                connection.Open();

                da.Fill(dt);

                connection.Close();

                rptDoanhThuTheoTuyen r = new rptDoanhThuTheoTuyen();
                r.SetDataSource(dt);

                FormThongKe f = new FormThongKe();
                f.crystalReportViewer1.ReportSource = r;
                f.ShowDialog();
            }
        }

        private void btnDoanhThuTheoChuyen_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
            {
                SqlCommand lenh = new SqlCommand();
                lenh.Connection = connection;

                lenh.CommandType = CommandType.StoredProcedure;
                lenh.CommandText = "GetDoanhThuTheoChuyenXe";
                lenh.Parameters.Clear();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = lenh;

                connection.Open();

                da.Fill(dt);

                connection.Close();

                rptDoanhThuTheoChuyen r = new rptDoanhThuTheoChuyen();
                r.SetDataSource(dt);

                FormThongKe f = new FormThongKe();
                f.crystalReportViewer1.ReportSource = r;
                f.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
            {
                SqlCommand lenh = new SqlCommand();
                lenh.Connection = connection;

                lenh.CommandType = CommandType.StoredProcedure;
                lenh.CommandText = "GetDoanhThuTheoThang";
                lenh.Parameters.Clear();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = lenh;

                connection.Open();

                da.Fill(dt);

                connection.Close();

                rptDoanhThuTheoThangNam r = new rptDoanhThuTheoThangNam();
                r.SetDataSource(dt);

                FormThongKe f = new FormThongKe();
                f.crystalReportViewer1.ReportSource = r;
                f.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
            {
                SqlCommand lenh = new SqlCommand();
                lenh.Connection = connection;

                lenh.CommandType = CommandType.StoredProcedure;
                lenh.CommandText = "GetDoanhThuTheoNam";
                lenh.Parameters.Clear();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = lenh;

                connection.Open();

                da.Fill(dt);

                connection.Close();

                RPTDoanhThuTheoNam r = new RPTDoanhThuTheoNam();
                r.SetDataSource(dt);
                FormThongKe f = new FormThongKe();
                this.Hide();
                f.crystalReportViewer1.ReportSource = r;
                f.ShowDialog();
            }
        }
    }
}
