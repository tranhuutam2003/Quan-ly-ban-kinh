using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_LTTQ_VIP
{
    public partial class QuanLyNhanVien : Form
    {
        private string connectionString = "Data Source=LAPTOP-7NSHMMSK;Initial Catalog=quanlybankinh;Integrated Security=True";

        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM NhanVien";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện khi click vào cell nếu cần
        }

        private void ThemNV_Click(object sender, EventArgs e)
        {
            ThemNV themNV = new ThemNV();

            themNV.Show();
            this.Hide();
        }


        private void SuaNV_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maNV = selectedRow.Cells["MaNV"].Value.ToString();
                string tenNV = selectedRow.Cells["TenNV"].Value.ToString();
                string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                string dienThoai = selectedRow.Cells["DienThoai"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string maCV = selectedRow.Cells["MaCV"].Value.ToString();

                // Mở form ThongTinNV với các thông tin cần sửa
                SuaNV suaNV = new SuaNV(maNV, tenNV, gioiTinh, ngaySinh, dienThoai, diaChi, maCV);
                suaNV.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.");
            }
        }


        private void XoaNV_Click(object sender, EventArgs e)
        {

        }

        private void exitNV_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
