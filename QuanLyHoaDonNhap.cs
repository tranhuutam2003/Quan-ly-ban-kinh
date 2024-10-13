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
    public partial class QuanLyHoaDonNhap : Form
    {
        public QuanLyHoaDonNhap()
        {
            InitializeComponent();
			LoadData();
        }

		private void QuanLyHoaDonNhap_Load(object sender, EventArgs e)
		{

		}
		private void LoadData()
		{
			using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
			{
				try
				{
					connection.Open();
					string query = "SELECT * from HoaDonNhap";
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
	}
}
