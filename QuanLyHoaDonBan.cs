using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Bouncycastlefips;
using iText.Bouncycastle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace BTL_LTTQ_VIP
{
    public partial class QuanLyHoaDonBan : Form
    {

		public QuanLyHoaDonBan()
        {
            InitializeComponent();
			LoadData();
        }
		private void LoadData()
		{
			using (SqlConnection conn = new SqlConnection(databaselink.ConnectionString))
			{
				try
				{
					conn.Open();

					//string query = @"SELECT hdb.SoHDB, hdb.MaNV, hdb.NgayBan, hdb.MaKhach, 
					//                               cthdb.MaHang, cthdb.SoLuong, cthdb.GiamGia, cthdb.ThanhTien
					//                           FROM HoaDonBan hdb
					//                           INNER JOIN ChiTietHoaDonBan cthdb ON hdb.SoHDB = cthdb.SoHDB";

					string query = @"SELECT 
					hdb.SoHDB,
					hdb.MaNV,
					hdb.NgayBan,
					hdb.MaKhach,
					SUM(ct.Soluong) AS TongSoLuongSanPham,
					hdb.TongTien AS ThanhTien
				FROM 
					HoaDonBan hdb
				JOIN 
					ChiTietHoaDonBan ct ON hdb.SoHDB = ct.SoHDB
				GROUP BY 
					hdb.SoHDB, hdb.MaNV, hdb.NgayBan, hdb.MaKhach, hdb.TongTien;
";


					// Tạo một SqlDataAdapter để lấy dữ liệu
					SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

					// Tạo một DataTable để chứa dữ liệu
					DataTable dt = new DataTable();

					// Điền dữ liệu vào DataTable
					adapter.Fill(dt);

					// Gán dữ liệu cho DataGridView
					dataGridView1.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
				}
			}
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		//Xem chi tiet hoa don ban
		private void btnXemChiTiet_Click(object sender, EventArgs e)
		{
			ChiTietHoaDonBan chiTietHoaDon= new ChiTietHoaDonBan();
			chiTietHoaDon.StartPosition = FormStartPosition.Manual;
			chiTietHoaDon.Location = this.Location;
			chiTietHoaDon.Show();
			this.Hide();
		}

	

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dataGridView1.Columns[e.ColumnIndex].Name == "TongTien")
			{
				if (e.Value != DBNull.Value && e.Value != null)
				{
					decimal value = Convert.ToDecimal(e.Value);

					if (value % 1 == 0)
					{
						e.Value = value.ToString("0"); 
					}
					else
					{
						e.Value = value.ToString("0.##");  
					}
					e.FormattingApplied = true;
				}
			}
		}

		private void btnThemHD_Click(object sender, EventArgs e)
		{
			HoaDonBan hoaDonBan = new HoaDonBan();
			hoaDonBan.Show();
			this.Hide();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnXoaHD_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
				string soHDB = selectedRow.Cells["SoHDB"].Value.ToString(); // "SoHDB" là tên cột chứa mã hóa đơn
				DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
					{
						try
						{
							connection.Open();
							SqlTransaction transaction = connection.BeginTransaction(); // Bắt đầu giao dịch

							string deleteChiTietQuery = "DELETE FROM ChiTietHoaDonBan WHERE SoHDB = @SoHDB";
							SqlCommand deleteChiTietCommand = new SqlCommand(deleteChiTietQuery, connection, transaction);
							deleteChiTietCommand.Parameters.AddWithValue("@SoHDB", soHDB);
							deleteChiTietCommand.ExecuteNonQuery();

							string deleteHoaDonQuery = "DELETE FROM HoaDonBan WHERE SoHDB = @SoHDB";
							SqlCommand deleteHoaDonCommand = new SqlCommand(deleteHoaDonQuery, connection, transaction);
							deleteHoaDonCommand.Parameters.AddWithValue("@SoHDB", soHDB);
							int result = deleteHoaDonCommand.ExecuteNonQuery();

							if (result > 0)
							{
								transaction.Commit(); // Xác nhận giao dịch
								MessageBox.Show("Xóa hóa đơn thành công.");
								LoadData(); // Tải lại dữ liệu sau khi xóa
							}
							else
							{
								transaction.Rollback(); // Hủy giao dịch nếu không thành công
								MessageBox.Show("Xóa hóa đơn thất bại.");
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
				MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.");
			}
		}

		

		private void btnExportInvoice_Click_1(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
				string soHDB = selectedRow.Cells["SoHDB"].Value.ToString();

				// Lấy thông tin chi tiết hóa đơn từ database
				string query = @"
            SELECT 
                hdb.NgayBan, 
                kh.TenKhach, 
                dh.TenHang, 
                cthdb.SoLuong, 
                cthdb.ThanhTien
            FROM 
                HoaDonBan hdb
            JOIN 
                KhachHang kh ON hdb.MaKhach = kh.MaKhach
            JOIN 
                ChiTietHoaDonBan cthdb ON hdb.SoHDB = cthdb.SoHDB
            JOIN 
                DanhMucHangHoa dh ON cthdb.MaHang = dh.MaHang
            WHERE 
                hdb.SoHDB = @SoHDB";

				using (SqlConnection conn = new SqlConnection(databaselink.ConnectionString))
				{
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@SoHDB", soHDB);
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					if (dt.Rows.Count > 0)
					{
						// In thông tin hóa đơn
						PrintDocument printDocument = new PrintDocument();
						printDocument.PrintPage += (s, ev) =>
						{
							float yPosition = ev.MarginBounds.Top;
							float lineHeight = ev.Graphics.MeasureString("Test", new Font("Arial", 12)).Height;

							// Thêm tiêu đề hóa đơn
							ev.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, ev.MarginBounds.Left, yPosition);
							yPosition += lineHeight * 2; // Tăng thêm khoảng cách

							ev.Graphics.DrawString($"Mã Hóa Đơn: {soHDB}", new Font("Arial", 12), Brushes.Black, ev.MarginBounds.Left, yPosition);
							yPosition += lineHeight;

							ev.Graphics.DrawString($"Tên Khách Hàng: {dt.Rows[0]["TenKhach"]}", new Font("Arial", 12), Brushes.Black, ev.MarginBounds.Left, yPosition);
							yPosition += lineHeight;

							ev.Graphics.DrawString($"Ngày Bán: {Convert.ToDateTime(dt.Rows[0]["NgayBan"]).ToString("dd/MM/yyyy")}", new Font("Arial", 12), Brushes.Black, ev.MarginBounds.Left, yPosition);
							yPosition += lineHeight;

							ev.Graphics.DrawString("--------------------------------------------------", new Font("Arial", 12), Brushes.Black, ev.MarginBounds.Left, yPosition);
							yPosition += lineHeight;

							ev.Graphics.DrawString("Tên Hàng | Số Lượng | Thành Tiền", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, ev.MarginBounds.Left, yPosition);
							yPosition += lineHeight;

							ev.Graphics.DrawString("--------------------------------------------------", new Font("Arial", 12), Brushes.Black, ev.MarginBounds.Left, yPosition);
							yPosition += lineHeight;

							foreach (DataRow row in dt.Rows)
							{
								ev.Graphics.DrawString($"{row["TenHang"]} | {row["SoLuong"]} | {row["ThanhTien"]}", new Font("Arial", 12), Brushes.Black, ev.MarginBounds.Left, yPosition);
								yPosition += lineHeight;
							}
						};

						// Hiển thị hộp thoại in
						PrintDialog printDialog = new PrintDialog();
						printDialog.Document = printDocument;

						if (printDialog.ShowDialog() == DialogResult.OK)
						{
							printDocument.Print();
						}
					}
					else
					{
						MessageBox.Show("Không tìm thấy chi tiết hóa đơn.");
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn hóa đơn cần in.");
			}


			
		}
	}
}
