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
    public partial class CapNhatNV : Form
    {
        public string maNV { get; private set; }

        public string Ten { get; private set; }
        public string DiaChi { get; private set; }
        public string SoDT { get; private set; }
        public CapNhatNV(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        private void UpdateButtonState()
        {
            // Kiểm tra nếu cả hai TextBox đều có giá trị
            if (!string.IsNullOrWhiteSpace(txtTenNV.Text) &&
                !string.IsNullOrWhiteSpace(txtDiaChi.Text) &&
                !string.IsNullOrWhiteSpace(txtSoDT.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();

        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();

        }

        private void CapNhatNV_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = maNV;
            txtMaNV.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ten = txtTenNV.Text;
            DiaChi = txtDiaChi.Text;
            SoDT = txtSoDT.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
