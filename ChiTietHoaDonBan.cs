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
	public partial class ChiTietHoaDonBan : Form
	{
		
		public ChiTietHoaDonBan()
		{
			InitializeComponent();
			LoadData();
		}
		private void LoadData()
		{
			using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
			{
				try
				{
					connection.Open();
					string query = "SELECT * from ChiTietHoaDonBan";
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

		private void Quaylai_Click(object sender, EventArgs e)
		{
			//QuanLyNhanVien quanLyNV = new QuanLyNhanVien();
			//quanLyNV.Show();
			//this.Close();

			QuanLyHoaDonBan quanLyHoaDonBan = new QuanLyHoaDonBan();
			quanLyHoaDonBan.StartPosition = FormStartPosition.Manual;
			quanLyHoaDonBan.Location = this.Location;
			quanLyHoaDonBan.Show();
			this.Close();
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
		}
	}
}
