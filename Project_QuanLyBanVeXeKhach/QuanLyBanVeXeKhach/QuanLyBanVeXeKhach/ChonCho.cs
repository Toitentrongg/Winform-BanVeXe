using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{
    public partial class ChonCho : Form
    {
        int giave;
        int x, y;
        int yP;
        string source;
        int temp;
        int Sove;
        int soTT;
        List<bool> list = new List<bool>();
        List<bool> xedaban = new List<bool>();
        List<string>ListVeXe = new List<string>();
        string mavexe;
        int slGhe { get; set; }
        string macx { get; set; }
        DateTime NgayMua;
        string matuyen;
        public ChonCho(string maCX, int SLGhe)
        {
            InitializeComponent();
            this.macx = maCX;
            this.slGhe = SLGhe;
        }
        void CheckPic(bool xechuachon)
        {
            if (xechuachon)
            {
                source = @"D:\C#\XeKhach\Pic\XeKhachChuaChon.png";
            }
            else
            {
                source = @"D:\C#\XeKhach\Pic\XeKhachChon.png";
            }
        }

        void CheckXe(bool xedaban)
        {
            if (xedaban)
            {
                source = @"D:\C#\XeKhach\Pic\XeKhachDaBan.png";
            }
            else
            {
                source = @"D:\C#\XeKhach\Pic\XeKhachChuaChon.png";
            }
        }

        void LayTrangThai(int sott)
        {
            int trangThai = -1;
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();

                string query = @"SELECT TrangThai FROM VeXe WHERE MaChuyenXe = @MaChuyenXe AND SoGhe = @SoGhe";

                using (SqlCommand cmdSelect = new SqlCommand(query, con))
                {
                    cmdSelect.Parameters.AddWithValue("@MaChuyenXe", macx);
                    cmdSelect.Parameters.AddWithValue("@SoGhe", sott);

                    object result = cmdSelect.ExecuteScalar();

                    if (result != null)
                    {
                        trangThai = Convert.ToInt32(result);
                    }
                }
            }

            if (trangThai == 1)
            {
                xedaban.Add(true);
            }
            else if (trangThai == 0)
            {
                xedaban.Add(false);
            }
            else if (trangThai == -1)
            {
                MessageBox.Show("Lỗi SQL", "Thông Báo");
            }
        }
        string laymavexe (string chuyenxe,int SoGhe)
        {
            string mave = "";
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();
                string query = "select MaVeXe\r\nFROM VeXe \r\nWHERE SoGhe = @SoGhe and MaChuyenXe = @MaChuyenXe";
                using (SqlCommand cmdSelect = new SqlCommand(query, con))
                {
                    cmdSelect.Parameters.AddWithValue("@SoGhe", SoGhe);
                    cmdSelect.Parameters.AddWithValue("@MaChuyenXe", chuyenxe);

                    object result = cmdSelect.ExecuteScalar();
                    if (result != null)
                    {

                        mave = Convert.ToString(result);
                    }
                }
            }
            return mave;
        }
        string  laymaTuyen (string macx)
        {
            string matuyen=""; 
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();

                string query = $"SELECT MaTuyen FROM ChuyenXe WHERE MaChuyenXe = '{macx}'";

                using (SqlCommand cmdSelect = new SqlCommand(query, con))
                {

                    object result = cmdSelect.ExecuteScalar();

                    if (result != null)
                    {
                        matuyen = Convert.ToString(result);
                    }
                }
            }
            return matuyen;
        }
        int LayGiaVe(DateTime NgayMua, string MaTuyen)
        {
            int GiaVe = 0;
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();
                string query = "SELECT TOP 1 GiaVe\r\nFROM QLGiaVe\r\nWHERE CONVERT(DATE, NgayApDung, 103) <= @NgayMua AND MaTuyen = @MaTuyen \r\nORDER BY NgayApDung DESC";
                using (SqlCommand cmdSelect = new SqlCommand(query, con))
                {
                    cmdSelect.Parameters.AddWithValue("@NgayMua", NgayMua);
                    cmdSelect.Parameters.AddWithValue("@MaTuyen", MaTuyen);

                    object result = cmdSelect.ExecuteScalar();
                    if (result != null)
                    {
                        GiaVe = Convert.ToInt32(result);
                    }
                }
            }
            return GiaVe;
        }
        public void reload()
        {
            Sove = 0;
            xedaban.Clear();
            Chuyen.Text = $"Chuyến Xe {macx}";
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            txtSoVe.Text = "";
            txtGiaVe.Text = "";
            x = 24; y = 96;
            temp = 0;
            yP = 230;
            soTT = 1;

            PictureBox pic = new PictureBox();
            pic.ImageLocation = @"D:\C#\XeKhach\Pic\BacTai.png";
            pic.Size = new Size(42, 43);
            pic.Location = new Point(24, 19);
            panel2.Controls.Add(pic);

            temp = slGhe;
            source = @"D:\C#\XeKhach\Pic\XeKhachChuaChon.png";
            int temp2 = temp / 2;
            list.Add(true);
            while (temp > temp2)
            {
                panel2.Size = new Size(218, yP);

                if (x > 170)
                {
                    x = 24;
                    y += 72;
                    yP += 69;
                }

                LayTrangThai(soTT);
                CheckXe(xedaban[soTT -1]);

                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = source;
                pictureBox.Size = new Size(26, 40);
                pictureBox.Location = new Point(x, y);
                pictureBox.Name = soTT.ToString();
                if (source == @"D:\C#\XeKhach\Pic\XeKhachDaBan.png")
                {
                    pictureBox.Enabled = false;
                }
                // Đăng ký sự kiện Click cho PictureBox
                pictureBox.Click += PictureBox_Click;

                x += 69;
                panel2.Controls.Add(pictureBox);
                list.Add(true);
                temp--;
                soTT += 1;
            }

            x = 24; y = 96;
            yP = 230;

            while (temp2 > 0)
            {
                panel3.Size = new Size(218, yP);

                if (x > 170)
                {
                    x = 24;
                    y += 72;
                    yP += 69;
                }
                LayTrangThai(soTT);
                CheckXe(xedaban[soTT -1]);

                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = source;
                pictureBox.Size = new Size(26, 40);
                pictureBox.Location = new Point(x, y);
                pictureBox.Name = soTT.ToString();
                if (source == @"D:\C#\XeKhach\Pic\XeKhachDaBan.png")
                {
                    pictureBox.Enabled = false;
                }
                // Đăng ký sự kiện Click cho PictureBox
                pictureBox.Click += PictureBox_Click;

                x += 69;
                panel3.Controls.Add(pictureBox);
                list.Add(true);
                temp2--;
                soTT += 1;
            }
        }
        private void ChonCho_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giave = int.Parse(txtGiaVe.Text);
            Form banve = new BanVe(ListVeXe,NgayMua,giave);
            banve.ShowDialog();
            Console.WriteLine(xedaban.Count);
            reload();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi PictureBox được nhấp vào
            PictureBox clickedPictureBox = (PictureBox)sender;
            string pictureBoxName = clickedPictureBox.Name;
            NgayMua = dateTGNgayMua.Value;
            DateTime NgayHienTai = DateTime.Now;
            matuyen = laymaTuyen(macx);
            giave = LayGiaVe(NgayMua, matuyen);
            if (list[int.Parse(pictureBoxName)])
            {
                list[int.Parse(pictureBoxName)] = false;
                mavexe = laymavexe(macx, int.Parse(pictureBoxName));
                ListVeXe.Add(mavexe);
                Sove += 1;
            }
            else
            {
                list[int.Parse(pictureBoxName)] = true;
                Sove -= 1;
                mavexe = laymavexe(macx, int.Parse(pictureBoxName));
                ListVeXe.Remove(mavexe);
            }
            txtGiaVe.Text = $"{giave * Sove}";
            txtSoVe.Text = Sove.ToString();
            CheckPic(list[int.Parse(pictureBoxName)]);
            clickedPictureBox.Image = Image.FromFile(source);
        }
    }
}
