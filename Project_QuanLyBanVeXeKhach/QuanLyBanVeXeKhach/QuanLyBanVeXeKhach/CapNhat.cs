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
    public partial class CapNhat : Form
    {
        public string MatKhau { get; private set; }
        public string ChucVu { get; private set; }
        public string TaiKhoan { get; private set; }

        public CapNhat(string tenTaiKhoan)
        {
            InitializeComponent();
            this.TaiKhoan = tenTaiKhoan;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text;
            button1.Enabled = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
            button1.Enabled = true;

        }

        private void CapNhat_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBox1.Text = TaiKhoan.ToString();
            textBox1.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Gán giá trị mới cho các thuộc tính
            MatKhau = textBox2.Text;
            ChucVu = comboBox1.SelectedItem.ToString();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
