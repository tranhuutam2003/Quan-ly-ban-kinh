using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_LTTQ_VIP
{
	public partial class QuanLyHoaDonNhap : Form
	{
		private string TenNV;
		private string CongViec;
		public QuanLyHoaDonNhap()
		{
			InitializeComponent();
			LoadData();
		}

		public QuanLyHoaDonNhap(string tenNV, string congViec)
		{
			InitializeComponent();
			TenNV = tenNV;   // Set user information
			CongViec = congViec;
			LoadData();
		}

		private void LoadData()
		{
			using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
			{
				try
				{
					connection.Open();
					// Truy vấn lấy dữ liệu từ cả bảng HoaDonNhap và ChiTietHoaDonNhap
					string query = @"SELECT hdn.SoHDN, hdn.MaNV, hdn.NgayNhap, hdn.MaNCC, 
                                    cthn.MaHang, cthn.SoLuong, cthn.DonGia, cthn.GiamGia, 
                                    cthn.ThanhTien
                             FROM HoaDonNhap hdn
                             INNER JOIN ChiTietHoaDonNhap cthn ON hdn.SoHDN = cthn.SoHDN";

					SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
					DataTable dataTable = new DataTable();
					dataAdapter.Fill(dataTable);

					// Đặt nguồn dữ liệu cho DataGridView
					dataGridView1.DataSource = dataTable;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Mở form ThemChiTietHoaDonNhap để thêm mới
			ThemChiTietHoaDonNhap themChiTietHoaDonNhap = new ThemChiTietHoaDonNhap();
			themChiTietHoaDonNhap.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Lấy dữ liệu từ hàng được chọn
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
				string soHDN = selectedRow.Cells["SoHDN"].Value.ToString();
				int maNV = Convert.ToInt32(selectedRow.Cells["MaNV"].Value);
				int maHang = Convert.ToInt32(selectedRow.Cells["MaHang"].Value);
				int maNCC= Convert.ToInt32(selectedRow.Cells["MaNCC"].Value);
                int soLuong = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);
				decimal donGia = Convert.ToDecimal(selectedRow.Cells["DonGia"].Value);
				decimal giamGia = Convert.ToDecimal(selectedRow.Cells["GiamGia"].Value);
				decimal thanhTien = Convert.ToDecimal(selectedRow.Cells["ThanhTien"].Value);
				DateTime ngayNhap = Convert.ToDateTime(selectedRow.Cells["NgayNhap"].Value);

				ThemChiTietHoaDonNhap themChiTietHoaDonNhap = new ThemChiTietHoaDonNhap(true, soHDN, maHang,maNCC, soLuong, donGia, giamGia, thanhTien, ngayNhap, maNV);
				themChiTietHoaDonNhap.Show();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn hóa đơn cần sửa.");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
				string soHDN = selectedRow.Cells["SoHDN"].Value.ToString(); // "SoHDN" là tên cột chứa mã hóa đơn nhập
				DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn nhập này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
					{
						try
						{
							connection.Open();
							SqlTransaction transaction = connection.BeginTransaction(); // Bắt đầu giao dịch

							// Bước 1: Xóa các chi tiết hóa đơn nhập
							string deleteChiTietQuery = "DELETE FROM ChiTietHoaDonNhap WHERE SoHDN = @SoHDN";
							SqlCommand deleteChiTietCommand = new SqlCommand(deleteChiTietQuery, connection, transaction);
							deleteChiTietCommand.Parameters.AddWithValue("@SoHDN", soHDN);
							deleteChiTietCommand.ExecuteNonQuery();

							// Bước 2: Xóa hóa đơn nhập
							string deleteHoaDonQuery = "DELETE FROM HoaDonNhap WHERE SoHDN = @SoHDN";
							SqlCommand deleteHoaDonCommand = new SqlCommand(deleteHoaDonQuery, connection, transaction);
							deleteHoaDonCommand.Parameters.AddWithValue("@SoHDN", soHDN);
							int result = deleteHoaDonCommand.ExecuteNonQuery();

							if (result > 0)
							{
								transaction.Commit(); // Xác nhận giao dịch
								MessageBox.Show("Xóa hóa đơn nhập thành công.");
								LoadData(); // Tải lại dữ liệu sau khi xóa
							}
							else
							{
								transaction.Rollback(); // Hủy giao dịch nếu không thành công
								MessageBox.Show("Xóa hóa đơn nhập thất bại.");
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn hóa đơn nhập cần xóa.");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ChiTietHoaDonNhap chiTietHoaDonNhap = new ChiTietHoaDonNhap();
			chiTietHoaDonNhap.StartPosition = FormStartPosition.Manual;
			chiTietHoaDonNhap.Location = this.Location;
			chiTietHoaDonNhap.Show();
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dataGridView1.Columns[e.ColumnIndex].Name == "TongTien")
			{
				// Kiểm tra nếu giá trị không phải là DBNull
				if (e.Value != DBNull.Value && e.Value != null)
				{
					// Chuyển đổi giá trị thành decimal
					decimal value = Convert.ToDecimal(e.Value);

					// Định dạng lại giá trị nếu là số nguyên
					e.Value = value % 1 == 0 ? value.ToString("0") : value.ToString("0.##");
					e.FormattingApplied = true;
				}
			}
			if (dataGridView1.Columns[e.ColumnIndex].Name == "DonGia")
			{
				if (e.Value != DBNull.Value && e.Value != null)
				{
					decimal value = Convert.ToDecimal(e.Value);

					e.Value = value % 1 == 0 ? value.ToString("0") : value.ToString("0.##");
					e.FormattingApplied = true;
				}
			}
		}

		

		private void exit_Click_1(object sender, EventArgs e)
		{
			//Home home=new Home();	
			//home.Show();
			this.Close();

		}
	}
}
