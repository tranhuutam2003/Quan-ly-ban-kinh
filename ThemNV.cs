using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BTL_LTTQ_VIP
{
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
            LoadCongViec(); // Load danh sách công việc
            LoadGioiTinh(); // Load danh sách giới tính
        }

        // Hàm load danh sách công việc từ bảng CongViec vào ComboBox
        private void LoadCongViec()
        {
            using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaCV, TenCV FROM CongViec";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Hiển thị TenCV trong ComboBox, giá trị sẽ là MaCV
                        CongViec.Items.Add(new { MaCV = reader["MaCV"], TenCV = reader["TenCV"].ToString() });
                    }

                    CongViec.DisplayMember = "TenCV";
                    CongViec.ValueMember = "MaCV"; // Lấy MaCV làm giá trị khi chọn
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy danh sách công việc: " + ex.Message);
                }
            }
        }

        // Hàm load danh sách giới tính vào ComboBox
        private void LoadGioiTinh()
        {
            Sex.Items.Add("Nam");
            Sex.Items.Add("Nữ");

            // Lựa chọn mặc định (nếu cần)
            Sex.SelectedIndex = 0; // Mặc định chọn "Nam"
        }

        private void exit_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien quanLyNV = new QuanLyNhanVien();
            quanLyNV.Show();
            this.Close();
        }

        private void Xacnhan_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra số điện thoại
            if (!Regex.IsMatch(Dienthoai.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải có 10 số và bắt đầu bằng số 0.");
                return;
            }

            // Lấy ngày sinh từ DateTimePicker và kiểm tra tuổi
            DateTime ngaySinh = Ngaysinh.Value;
            int tuoi = DateTime.Now.Year - ngaySinh.Year;
            if (ngaySinh > DateTime.Now.AddYears(-tuoi)) tuoi--; // Kiểm tra nếu ngày sinh chưa qua trong năm nay

            if (tuoi < 18)
            {
                MessageBox.Show("Nhân viên phải đủ 18 tuổi trở lên.");
                return;
            }

            // Lấy mã công việc từ ComboBox
            if (CongViec.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn công việc cho nhân viên.");
                return;
            }
            int maCongViec = (int)((dynamic)CongViec.SelectedItem).MaCV;

            // Lấy giới tính từ ComboBox
            string gioiTinh = Sex.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO NhanVien (MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, DiaChi, MaCV) " +
                                   "VALUES (@MaNV, @TenNV, @GioiTinh, @NgaySinh, @DienThoai, @DiaChi, @MaCV)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho câu truy vấn
                        command.Parameters.AddWithValue("@MaNV", MaNV.Text);
                        command.Parameters.AddWithValue("@TenNV", tenNV.Text);
                        command.Parameters.AddWithValue("@GioiTinh", gioiTinh); // Lấy từ ComboBox giới tính
                        command.Parameters.AddWithValue("@NgaySinh", Ngaysinh.Value); // Sử dụng DateTimePicker
                        command.Parameters.AddWithValue("@DienThoai", Dienthoai.Text);
                        command.Parameters.AddWithValue("@DiaChi", Diachi.Text);
                        command.Parameters.AddWithValue("@MaCV", maCongViec);

                        // Thực thi câu lệnh
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhân viên thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
                }
            }
        }

		private void ThemNV_Load(object sender, EventArgs e)
		{

		}
	}
}
