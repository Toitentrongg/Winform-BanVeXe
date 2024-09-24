using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{
    public partial class GiaoDien : Form
    {
        int temp = -196;
        public static bool IsQuanTri { get; private set; }
        public GiaoDien()
        {
            InitializeComponent();
        }
        void LoadForm()
        {
            if (Role.IsAdmin)
            {
                // Thực hiện các hành động tương ứng với quản trị
                QLNV.Enabled = true;
                QLTK.Enabled = true;
                DangXuat.Enabled = true;
                DangNhap.Enabled = false;
                Ve.Enabled = true;
                btnTimKiem.Enabled = true;
                btnThongKe.Enabled = true;
            }
            else
            {
                if (Role.IsNV)
                {
                    DangXuat.Enabled = true;
                    QLNV.Enabled = false;
                    QLTK.Enabled = false;
                    DangNhap.Enabled = false;
                    Ve.Enabled = true;
                    btnTimKiem.Enabled = true;
                    btnThongKe.Enabled = false;
                }
                else
                {
                    DangNhap.Enabled = true;
                    QLTK.Enabled = false;
                    DangXuat.Enabled = false;
                    QLNV.Enabled = false;
                    Ve.Enabled = false;
                    btnTimKiem.Enabled = false;
                    btnThongKe.Enabled = false;


                }

            }
        }
        private void DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form DangNhap1 = new Login();
            DangNhap1.ShowDialog();
            LoadForm();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng Xuất Thành Công");
            DangNhap.Enabled = true;
            DangXuat.Enabled = false;
            QLNV.Enabled = false;
            QLTK.Enabled = false;
            OUT.Enabled = true;
        }

        private void QLTK_Click(object sender, EventArgs e)
        {
            Form QuanLy = new TaiKhoan();
            QuanLy.ShowDialog();
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            Form QLNV = new QLNhanVien();
            QLNV.ShowDialog();
        }

        private void OUT_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string labelText = label1.Text;

            if (!string.IsNullOrEmpty(labelText))
            {
                char lastChar = labelText[labelText.Length - 1];
                label1.Text = lastChar + labelText.Substring(0, labelText.Length - 1);
            }
            temp += 20;
/*            pictureBox1.Location = new Point(temp, 120);
            if (temp > 790)
            {
                temp = -196;
            }*/
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Form DT = new ThongKe();
            label1.Text += "            ";
            DT.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form F1 = new TimKiem();
            F1.ShowDialog();
        }

        private void BanVe_Click(object sender, EventArgs e)
        {
            /*Form BanVe = new BanVe();
            BanVe.ShowDialog();*/
            Form BanVe = new ThongTinBanVe();
            BanVe.ShowDialog();
        }

        private void CTCX_Click(object sender, EventArgs e)
        {
            Form ThemVe = new ThemVe();
            ThemVe.ShowDialog();
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadForm();
        }

        private void QLTuyen_Click(object sender, EventArgs e)
        {
            Form Tuyen = new QLTuyenXe();
            Tuyen.ShowDialog(); 
        }
    }
}
