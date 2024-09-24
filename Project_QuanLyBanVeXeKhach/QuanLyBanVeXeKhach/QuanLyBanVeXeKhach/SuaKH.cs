using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{
    public partial class SuaKH : Form
    {
        public string maKH { get ;  set; }
        public string tenKH;
        public string DiaChiKH;
        public string SDTKH;

        public SuaKH(string MaKH)
        {
            InitializeComponent();
            this.maKH = MaKH;
        }
        private void UpdateButtonState()
        {
            // Kiểm tra nếu cả hai TextBox đều có giá trị
            if (!string.IsNullOrWhiteSpace(txtTenKH.Text) &&
                !string.IsNullOrWhiteSpace(txtDT.Text) &&
                !string.IsNullOrWhiteSpace(txtDC.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tenKH = txtTenKH.Text;
            DiaChiKH = txtDC.Text;
            SDTKH = txtDT.Text;
            this.Close();
        }


        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();

        }

        private void txtDT_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();

        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaKH_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = maKH;
        }
    }
}
