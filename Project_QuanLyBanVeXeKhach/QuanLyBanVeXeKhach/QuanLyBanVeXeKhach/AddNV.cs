using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBanVeXeKhach
{
    public partial class AddNV : Form
    {
        private QLNhanVien QuanLyNV;

        public AddNV(QLNhanVien quanLyForm)
        {
            InitializeComponent();
            this.QuanLyNV = quanLyForm;
        }
        private void UpdateButtonState()
        {
            if (!string.IsNullOrWhiteSpace(txtMaNV.Text) &&
                !string.IsNullOrWhiteSpace(txtTenNV.Text) &&
                !string.IsNullOrWhiteSpace(txtDiaChi.Text)&&
                !string.IsNullOrWhiteSpace(txtSoDT.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void TxtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Contains(" "))
            {
                MessageBox.Show("Mã nhân viên không được có khoản trắng ! ", "Thông Báo");
            }
            UpdateButtonState();
        }

        private void TxtTenNV_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void TxtDiaChi_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void TxtSoDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDT.Text.Contains(" "))
            {
                MessageBox.Show("Số Điện Thoại không được có khoản trắng ! ", "Thông Báo");
            }
            UpdateButtonState();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string DiaChi = txtDiaChi.Text;
            string SoDT = txtSoDT.Text;
            QuanLyNV.ThemNhanVienVaoDataTable(maNV, tenNV, DiaChi, SoDT);
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        static bool CheckmaNV(string maNV)
        {
            // Kiểm tra xem mã nhân viên có bắt đầu bằng "NV" hay không
            return maNV.Length >= 4 && maNV.Substring(0, 2).Equals("NV", StringComparison.OrdinalIgnoreCase);
        }
        private void TxtMaNV_Leave(object sender, EventArgs e)
        {
            if (!(CheckmaNV(txtMaNV.Text)))
            {
                MessageBox.Show("Mã nhân viên phải có NV ở đầu !", "Thông Báo ");
                button1.Enabled= false;
            }
            else
            {
                button1.Enabled= true;
            }
        }
    }
}
