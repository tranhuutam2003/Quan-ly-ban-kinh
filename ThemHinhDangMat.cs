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
    public partial class ThemHinhDangMat : Form
    {
        //private string connectionString = "Data Source=LAPTOP-7NSHMMSK;Initial Catalog=quanlybankinh;Integrated Security=True";
        public ThemHinhDangMat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO HinhDangMat (MaDangMat, TenDangMat) " +
                                   "VALUES (@MaDangMat, @TenDangMat)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho câu truy vấn
                        command.Parameters.AddWithValue("@MaDangMat", Ma.Text);
                        command.Parameters.AddWithValue("@TenDangMat", Ten.Text);
                        // Thực thi câu lệnh
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm công dụng thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm công dụng: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemHangHoa qlhh = new ThemHangHoa();
            qlhh.Show();
            this.Close();
        }
    }
}
