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
					//string query = "SELECT * from ChiTietHoaDonBan";
					string query = @"SELECT hdb.SoHDB, hdb.MaNV, hdb.NgayBan, hdb.MaKhach, 
                                    cthdb.MaHang, cthdb.SoLuong, cthdb.GiamGia, cthdb.ThanhTien
                                FROM HoaDonBan hdb
                                INNER JOIN ChiTietHoaDonBan cthdb ON hdb.SoHDB = cthdb.SoHDB";
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

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		
	}
}
