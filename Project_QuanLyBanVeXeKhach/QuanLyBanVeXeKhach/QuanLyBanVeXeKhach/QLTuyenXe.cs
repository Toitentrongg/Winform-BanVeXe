using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXeKhach
{
    public partial class QLTuyenXe : Form
    {
        public QLTuyenXe()
        {
            InitializeComponent();
        }

        private void QLTuyenXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBVXDataSet.TuyenXe' table. You can move, or remove it, as needed.
            this.tuyenXeTableAdapter.Fill(this.qLBVXDataSet.TuyenXe);
            try
            {
                using (SqlConnection connection = new SqlConnection(Connectionstring.Conn))
                {
                    connection.Open();

                    // Thực hiện truy vấn để lấy dữ liệu từ bảng KhachHang
                    string query = "SELECT * FROM TuyenXe";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private bool KiemTraTonTai(string check, DataGridView dataGridView, string tenCot)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[tenCot].Value != null &&
                    row.Cells[tenCot].Value.ToString() == check)
                {
                    return true; // Giá trị đã tồn tại
                }
            }
            return false; // Giá trị chưa tồn tại
        }

        public void ThemTuyenXeVaoDataTable(string MaTuyenXe, string DiemBatDau, string DiemKetThuc)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();

                DataRow newRow = qLBVXDataSet.TuyenXe.NewRow();
                newRow["MaTuyen"] = MaTuyenXe;
                newRow["DiemBatDau"] = DiemBatDau;
                newRow["DiemKetThuc"] = DiemKetThuc;

                qLBVXDataSet.TuyenXe.Rows.Add(newRow);

                // Cập nhật cơ sở dữ liệu
                string insertQuery = "INSERT INTO TuyenXe (MaTuyen,DiemBatDau, DiemKetThuc) " +
                                     "VALUES (@MaTuyen, @DiemBatDau, @DiemKetThuc )";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MaTuyen", MaTuyenXe);
                    cmd.Parameters.AddWithValue("@DiemBatDau", DiemBatDau);
                    cmd.Parameters.AddWithValue("@DiemKetThuc", DiemKetThuc);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MaTuyenXe = txtMaTuyen.Text;
            string DiemBatDau = cbDiemBatDau.Text;
            string DiemKetThuc = cbDiemKetThuc.Text;

            if (!(KiemTraTonTai(MaTuyenXe, dataGridView1, "MaTuyen1")))
            {
                ThemTuyenXeVaoDataTable(MaTuyenXe, DiemBatDau, DiemKetThuc);
            }
            else
            {
                MessageBox.Show("Mã Chuyến Xe đã tồn tại trong database", "Thông Báo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring.Conn);
            con.Open();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Matuyen = dataGridView1.SelectedRows[0].Cells["MaTuyen1"].Value.ToString();

                // Kiểm tra xem có chuyến xe liên kết với tuyến đó không
                if (IsChuyenXeLinkedToTuyen(Matuyen))
                {
                    MessageBox.Show("Đang có chuyến xe liên kết với tuyến này. Hãy chỉnh sửa chuyến xe trước khi xóa!", "Thông báo");
                    return; 
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(selectedRow);

                string deleteQuery = "DELETE FROM TuyenXe WHERE MaTuyen = @MaTuyen";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MaTuyen", Matuyen);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
            }
        }

        private bool IsChuyenXeLinkedToTuyen(string maTuyen)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();

                string selectQuery = "SELECT COUNT(*) FROM ChuyenXe WHERE MaTuyen = @MaTuyen";
                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MaTuyen", maTuyen);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void ReloadDataGridView()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(Connectionstring.Conn))
            {
                con.Open();
                string selectQuery = "SELECT * FROM TuyenXe";
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con))
                {
                    adapter.Fill(dataTable);
                }
            }

            // Gán lại nguồn dữ liệu cho DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connectionstring.Conn);
            con.Open();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Matuyen = dataGridView1.SelectedRows[0].Cells["MaTuyen1"].Value.ToString();

                // Kiểm tra xem cbDiemBatDau và cbDiemKetThuc đã được khởi tạo chưa
                if (cbDiemBatDau != null && cbDiemKetThuc != null)
                {
                    // Lấy giá trị từ ComboBox, sử dụng Text thay vì SelectedValue nếu không có giá trị nào được chọn
                    string DiemBatDau = cbDiemBatDau.Text;
                    string DiemKetThuc = cbDiemKetThuc.Text;

                    string updateQuery = "UPDATE TuyenXe SET DiemBatDau = @DiemBatDau, DiemKetThuc = @DiemKetThuc WHERE MaTuyen = @MaTuyen";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@DiemBatDau", DiemBatDau);
                        cmd.Parameters.AddWithValue("@DiemKetThuc", DiemKetThuc);
                        cmd.Parameters.AddWithValue("@MaTuyen", Matuyen);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            ReloadDataGridView();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị từ cột MaTuyen, DiemBatDau và DiemKetThuc trong dòng được chọn
                string maTuyen = selectedRow.Cells["MaTuyen1"].Value.ToString();
                string DiemBatDau = selectedRow.Cells["DiemBatDau1"].Value.ToString();
                string DiemKetThuc = selectedRow.Cells["DiemKetThuc1"].Value.ToString();

                // Hiển thị giá trị lên các TextBox và ComboBox
                txtMaTuyen.Text = maTuyen;
                txtMaTuyen.Enabled = false; 
                cbDiemBatDau.Text = DiemBatDau;
                cbDiemKetThuc.Text = DiemKetThuc;
            }

        }
    }
}
