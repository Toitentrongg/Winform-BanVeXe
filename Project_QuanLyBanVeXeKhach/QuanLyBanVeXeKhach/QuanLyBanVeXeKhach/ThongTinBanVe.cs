using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{
    public partial class ThongTinBanVe : Form
    {
        public ThongTinBanVe()
        {
            InitializeComponent();
        }
        public void TimKiem1(string query)
        {
            
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM ChuyenXe INNER JOIN TuyenXe ON ChuyenXe.MaTuyen = TuyenXe.MaTuyen WHERE DiemBatDau = N'{cbDiemBatDau.Text}' AND DiemKetThuc = N'{cbDiemKetThuc.Text}' and ThoiGianXuatPhat = '{dateTGXuatPhat.Value.Date}'";
            TimKiem1(query);
            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["MaChuyenXe"].Value is string maCX &&
                    selectedRow.Cells["SoLuongGhe"].Value is int Slghe)
                {
                    Form banve = new ChonCho(maCX,Slghe);
                    banve.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng chọn chuyến xe muốn bán ! ", "Thông Báo ");
            }
        }

        private void ThongTinBanVe_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
