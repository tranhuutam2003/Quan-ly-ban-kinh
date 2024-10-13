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

namespace BTL_LTTQ_VIP
{
    public partial class QuanLyHoaDonBan : Form
    {
        string connectionString = "Data Source=THUCVIVO;Initial Catalog=quanlybankinh;Integrated Security=True";

		public QuanLyHoaDonBan()
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
					string query = "SELECT * from HoaDonBan";
					SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
					DataTable dataTable = new DataTable();
					dataAdapter.Fill(dataTable);

					dataGridView1.DataSource = dataTable;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
				}
			}
		}

		private void exit_Click(object sender, EventArgs e)
		{
			
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

		private void btnSuaHD_Click(object sender, EventArgs e)
		{
			
				if (dataGridView1.SelectedRows.Count > 0)
				{
					// Lấy dữ liệu từ hàng được chọn
					DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
					string soHDB= selectedRow.Cells["SoHDB"].Value.ToString();
					string maNV = selectedRow.Cells["MaNV"].Value.ToString();
					DateTime ngayBan= Convert.ToDateTime(selectedRow.Cells["NgayBan"].Value);
					string maKhach = selectedRow.Cells["MaKhach"].Value.ToString();
					string tongTien = selectedRow.Cells["TongTien"].Value.ToString();


					// Mở form ThongTinNV với các thông tin cần sửa
					ThemHoaDonBan themHoaDonBan = new ThemHoaDonBan(soHDB,maNV, ngayBan, maKhach, tongTien);
					themHoaDonBan.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Vui lòng chọn nhân viên cần sửa.");
				}
			
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//if (dataGridView1.Columns[e.ColumnIndex].Name == "TongTien")
			//{
			//	// Lấy giá trị từ cell và định dạng lại
			//	decimal value = Convert.ToDecimal(e.Value);
			//	if (value % 1 == 0)
			//	{
			//		e.Value = value.ToString("0");  // Hiển thị phần nguyên nếu không có phần thập phân
			//	}
			//	else
			//	{
			//		e.Value = value.ToString("0.##");  // Hiển thị cả phần thập phân nếu có
			//	}
			//	e.FormattingApplied = true;
			//}

			if (dataGridView1.Columns[e.ColumnIndex].Name == "TongTien")
			{
				// Kiểm tra nếu giá trị không phải là DBNull
				if (e.Value != DBNull.Value && e.Value != null)
				{
					// Chuyển đổi giá trị thành decimal
					decimal value = Convert.ToDecimal(e.Value);

					// Định dạng lại giá trị nếu là số nguyên
					if (value % 1 == 0)
					{
						e.Value = value.ToString("0");  // Hiển thị phần nguyên nếu không có phần thập phân
					}
					else
					{
						e.Value = value.ToString("0.##");  // Hiển thị cả phần thập phân nếu có
					}
					e.FormattingApplied = true;
				}
			}
		}

		private void btnThemHD_Click(object sender, EventArgs e)
		{
			ThemHoaDonBan themHoaDonBanForm = new ThemHoaDonBan(false); // false để chỉ ra rằng đây là chế độ thêm
			themHoaDonBanForm.Show();
			this.Hide();
		}
	}
}
