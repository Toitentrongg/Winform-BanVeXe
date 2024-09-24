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
    public partial class VeXe : Form
    {
        public static string maNV;
        public static DateTime NgayMua;
        public static int GiaVe;
        private string MaVeXe { get; set; }
        private string MaKH { get; set; }
        public VeXe(string maVeXe,string maKH)
        {
            InitializeComponent();
            this.MaVeXe = maVeXe;
            this.MaKH = maKH;
        }

        private void VeXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVXDataSet6.KhachHang' table. You can move, or remove it, as needed.
            txtMaKH.Text = MaKH;
            txtmaVeXe.Text = MaVeXe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn Mã NV hay chưa
            if (cbMaNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Mã NV.");
                return;
            }

            maNV = cbMaNV.SelectedValue.ToString();
            NgayMua = dateTimePicker1.Value;

            // Kiểm tra xem GiaVe có phải là một số nguyên hay không
            if (!int.TryParse(TxtGiaVe.Text, out GiaVe))
            {
                MessageBox.Show("Giá Vé không hợp lệ.");
                return;
            }

            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();

                string updateQuery = "UPDATE VeXe SET TrangThai = 1, MaNV = @MaNV, NgayMua = @NgayMua, GiaVe = @GiaVe, MaKH = @MaKH WHERE MaVeXe = @MaVeXe";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MaVeXe", MaVeXe);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@NgayMua", NgayMua);
                    cmd.Parameters.AddWithValue("@GiaVe", GiaVe);
                    cmd.Parameters.AddWithValue("@MaKH", MaKH);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bán Vé Thành Công.");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                        MessageBox.Show(maNV, "1");
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
