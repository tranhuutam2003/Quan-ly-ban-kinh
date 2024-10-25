using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_LTTQ_VIP
{
	public partial class HoaDonNhap : Form
	{
		// Chuỗi kết nối tới cơ sở dữ liệu
		public HoaDonNhap()
		{
			InitializeComponent();
			LoadComboBoxNhanVien(); // Tải dữ liệu nhân viên vào combobox
			LoadComboBoxMaHang();   // Tải dữ liệu mã hàng vào combobox
		}

		// Tải dữ liệu nhân viên vào ComboBox
		private void LoadComboBoxNhanVien()
		{
			using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand("SELECT MaNV, TenNV FROM NhanVien", connection);
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					comboBoxMaNV.DataSource = dt;
					comboBoxMaNV.DisplayMember = "TenNV";
					comboBoxMaNV.ValueMember = "MaNV";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi tải dữ liệu nhân viên: " + ex.Message);
				}
			}
		}

		// Tải dữ liệu mã hàng vào ComboBox
		private void LoadComboBoxMaHang()
		{
			using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand("SELECT MaHang, TenHang FROM DanhMucHangHoa", connection);
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					//comboBox1.DataSource = dt;
					//comboBox1.DisplayMember = "TenHang";
					//comboBox1.ValueMember = "MaHang";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi tải dữ liệu mã hàng: " + ex.Message);
				}
			}
		}

		// Sự kiện thay đổi Mã hàng để tự động hiển thị đơn giá và mã NCC
		private void comboBoxMaHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		// Hàm để tải dữ liệu mã NCC và đơn giá theo Mã hàng
		private void LoadHangHoaData(int maHang)
		{
			//using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
			//{
			//	try
			//	{
			//		connection.Open();
			//		SqlCommand cmd = new SqlCommand("SELECT MaNCC, DonGiaNhap FROM DanhMucHangHoa WHERE MaHang = @MaHang", connection);
			//		cmd.Parameters.AddWithValue("@MaHang", maHang);

			//		SqlDataReader reader = cmd.ExecuteReader();
			//		if (reader.Read())
			//		{
			//			textBoxMaNCC.Text = reader["MaNCC"].ToString();
			//			textBoxDonGia.Text = reader["DonGiaNhap"].ToString();
			//		}
			//		reader.Close();
			//	}
			//	catch (Exception ex)
			//	{
			//		MessageBox.Show("Lỗi khi tải dữ liệu hàng hóa: " + ex.Message);
			//	}
			//}
			using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand("SELECT MaNCC, DonGiaNhap FROM DanhMucHangHoa WHERE MaHang = @MaHang", connection);
					cmd.Parameters.AddWithValue("@MaHang", maHang);

					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						textBoxMaNCC.Text = reader["MaNCC"].ToString();
						textBoxDonGia.Text = reader["DonGiaNhap"].ToString();
					}
					else
					{
						// Nếu không tìm thấy mã hàng
						MessageBox.Show($"Không tìm thấy thông tin hàng hóa cho Mã Hàng: {maHang}", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					reader.Close();
				}
				catch (Exception ex)
				{
					// Hiển thị lỗi khi có vấn đề trong việc tải dữ liệu Mã NCC
					MessageBox.Show($"Lỗi khi tải dữ liệu hàng hóa (Mã NCC) cho Mã Hàng {maHang}.\nChi tiết lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// Sự kiện tính toán Thành tiền khi thay đổi Số lượng hoặc Đơn giá
		private void textBoxSoLuong_TextChanged(object sender, EventArgs e)
		{
			CalculateThanhTien();
		}

		private void textBoxDonGia_TextChanged(object sender, EventArgs e)
		{
			CalculateThanhTien();
		}

		// Hàm tính toán Thành tiền
		private void CalculateThanhTien()
		{
			if (decimal.TryParse(textBoxSoLuong.Text, out decimal soLuong) &&
				decimal.TryParse(textBoxDonGia.Text, out decimal donGia))
			{
				decimal thanhTien = soLuong * donGia;
				textBoxThanhTien.Text = thanhTien.ToString("0.00");
			}
		}
		private void label5_Click(object sender, EventArgs e)
		{

		}
		// Sự kiện nút Thêm hóa đơn nhập
		private void button2_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
			{
				try
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand("INSERT INTO HoaDonNhap (SoHDN, MaNV, NgayNhap, MaNCC, TongTien) VALUES (@SoHDN, @MaNV, @NgayNhap, @MaNCC, @TongTien)", connection);
					cmd.Parameters.AddWithValue("@SoHDN", textBoxSoHDN.Text);
					cmd.Parameters.AddWithValue("@MaNV", comboBoxMaNV.SelectedValue);
					cmd.Parameters.AddWithValue("@NgayNhap", dateTimePickerNgayNhap.Value);
					cmd.Parameters.AddWithValue("@MaNCC", textBoxMaNCC.Text);
					cmd.Parameters.AddWithValue("@TongTien", textBoxThanhTien.Text);

					cmd.ExecuteNonQuery();
					MessageBox.Show("Thêm hóa đơn nhập thành công!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi thêm hóa đơn nhập: " + ex.Message);
				}
			}
		}

		private void comboBoxMaHang_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}
	}
}
