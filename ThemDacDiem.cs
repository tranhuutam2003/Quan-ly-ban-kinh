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
    public partial class ThemDacDiem : Form
    {
        public ThemDacDiem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO DacDiem (MaDacDiem, TenDacDiem) " +
                                   "VALUES (@MaDacDiem, @TenDacDiem)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho câu truy vấn
                        command.Parameters.AddWithValue("@MaDacDiem", Ma.Text);
                        command.Parameters.AddWithValue("@TenDacDiem", Ten.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ThemHangHoa thh = new ThemHangHoa();
            thh.Show();
            this.Close();
        }
    }
}
