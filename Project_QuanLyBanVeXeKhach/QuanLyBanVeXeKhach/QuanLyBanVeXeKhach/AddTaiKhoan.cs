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
    public partial class AddTaiKhoan : Form
    {
        private TaiKhoan QuanLyTK;

        public AddTaiKhoan(TaiKhoan quanLyForm)
        {
            InitializeComponent();
            this.QuanLyTK = quanLyForm;

        }
        private void UpdateButtonState()
        {
            // Kiểm tra nếu cả hai TextBox đều có giá trị
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                (!string.IsNullOrWhiteSpace(textBox2.Text) || !string.IsNullOrWhiteSpace(textBox3.Text)))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(" "))
            {
                MessageBox.Show("Tài Khoản không được có khoản trắng ! ", "Thông Báo");
            }
            UpdateButtonState();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text;

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được có khoản trắng ! ", "Thông Báo");
            }
            textBox3.Text = textBox2.Text;
            UpdateButtonState();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Visible = true;
                textBox3.Visible = false;
            }
            else
            {
                textBox2.Visible = false;
                textBox3.Visible = true;
            }
        }

        private void AddTaiKhoan_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string tenDN = textBox1.Text;
            string matkhau = textBox2.Text;
            string chucvu = comboBox1.SelectedItem.ToString();
            QuanLyTK.ThemTaiKhoanVaoDataTable(tenDN, matkhau, chucvu);
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
