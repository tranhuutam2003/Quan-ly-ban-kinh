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
	public partial class ChiTietHoaDonNhap : Form
	{
		public ChiTietHoaDonNhap()
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
					string query = "SELECT * from ChiTietHoaDonNhap";
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
		

		
		private void button1_Click(object sender, EventArgs e)
		{
			ThemChiTietHoaDonNhap themChiTietHoaDonNhap= new ThemChiTietHoaDonNhap();
			themChiTietHoaDonNhap.ShowDialog();
			

		}

		private void button4_Click(object sender, EventArgs e)
		{
			QuanLyHoaDonNhap quanLyHoaDonNhap= new QuanLyHoaDonNhap();
			quanLyHoaDonNhap.StartPosition = FormStartPosition.Manual;
			quanLyHoaDonNhap.Location= this.Location;
			quanLyHoaDonNhap.Show();
			this.Close();
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
		}
	}
}
