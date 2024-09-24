using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{
    public partial class SuaCX : Form
    {
        public string maCXe { get; private set; }
        public string MaTuyen { get; private set; }
        public DateTime ThoiGianXuatPhat { get; private set; }
        public string ThoiGianDi { get; private set; }
        public int SoLuongGhe { get; private set; }
        public int SoV { get; private set; }
        public int GiaV { get; private set; }

        public SuaCX(string maCX)
        {
            InitializeComponent();
            this.maCXe = maCX;
        }
        private void UpdateButtonState()
        {
            // Kiểm tra nếu cả hai TextBox đều có giá trị
            if (
                !string.IsNullOrWhiteSpace(SoVeCon.Text) 
                )
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void SuaCX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVXDataSet.TuyenXe' table. You can move, or remove it, as needed.
            this.tuyenXeTableAdapter.Fill(this.qLBVXDataSet.TuyenXe);
            // TODO: This line of code loads data into the 'qLBVXDataSet3.TuyenXe' table. You can move, or remove it, as needed.
            MaCX.Text = maCXe;
            MaCX.Enabled = false;
        }

        private void DiemXP_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void DiemDen_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void GiaVe_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void SLGhe_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void SoVeCon_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThoiGianXuatPhat = DateTime.ParseExact(dateTGXuatPhat.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ThoiGianDi = DateTGDi.Text;
            SoLuongGhe = int.Parse(cbSLGhe.Text);
            SoV = int.Parse(SoVeCon.Text);
            MaTuyen = cbMaTuyen.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
