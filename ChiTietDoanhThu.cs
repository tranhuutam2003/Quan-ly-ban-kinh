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
    public partial class ChiTietDoanhThu : Form
    {
        private DateTime fromDate;
        private DateTime toDate;
        public ChiTietDoanhThu()
        {
            InitializeComponent();
        }

        public ChiTietDoanhThu(DateTime from, DateTime to)
        {
            InitializeComponent();
            fromDate = from;
            toDate = to;
        }

        private void ChiTietDoanhThu_Load(object sender, EventArgs e)
        {
            // Hiển thị khoảng thời gian đã chọn trên Label
            labelThoiGian.Text = $"Doanh thu từ {fromDate:dd/MM/yyyy} đến {toDate:dd/MM/yyyy}";

            string query = @"
                SELECT 
                    NgayThang,
                    DoanhThuBan,
                    DoanhThuNhap,
                    DoanhThuThuần
                FROM 
                    DoanhThu
                WHERE 
                    NgayThang BETWEEN @fromDate AND @toDate
                ORDER BY 
                    NgayThang;";

            using (SqlConnection conn = new SqlConnection(databaselink.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Xóa dữ liệu biểu đồ cũ
                chartChiTietDoanhThu.Series["DoanhThuBan"].Points.Clear();
                chartChiTietDoanhThu.Series["DoanhThuNhap"].Points.Clear();
                chartChiTietDoanhThu.Series["DoanhThuThuần"].Points.Clear();

                decimal totalDoanhThuBan = 0, totalDoanhThuNhap = 0, totalDoanhThuThuan = 0;

                while (reader.Read())
                {
                    DateTime ngay = (DateTime)reader["NgayThang"];
                    decimal doanhThuBan = (decimal)reader["DoanhThuBan"];
                    decimal doanhThuNhap = (decimal)reader["DoanhThuNhap"];
                    decimal doanhThuThuan = (decimal)reader["DoanhThuThuần"];

                    // Cộng dồn tổng doanh thu
                    totalDoanhThuBan += doanhThuBan;
                    totalDoanhThuNhap += doanhThuNhap;
                    totalDoanhThuThuan += doanhThuThuan;

                    // Thêm điểm vào biểu đồ
                    chartChiTietDoanhThu.Series["DoanhThuBan"].Points.AddXY(ngay, doanhThuBan);
                    chartChiTietDoanhThu.Series["DoanhThuNhap"].Points.AddXY(ngay, doanhThuNhap);
                    chartChiTietDoanhThu.Series["DoanhThuThuần"].Points.AddXY(ngay, doanhThuThuan);
                }

                // Đóng reader
                reader.Close();

                // Cập nhật giá trị cho Label
                labelDoanhThuBan.Text = $"Doanh Thu Bán: {totalDoanhThuBan:C}";
                labelDoanhThuNhap.Text = $"Doanh Thu Nhập: {totalDoanhThuNhap:C}";
                labelDoanhThuThuan.Text = $"Doanh Thu Thuần: {totalDoanhThuThuan:C}";

                chartChiTietDoanhThu.ChartAreas[0].AxisX.Minimum = fromDate.ToOADate();
                chartChiTietDoanhThu.ChartAreas[0].AxisX.Maximum = toDate.ToOADate();

            }
        }
    }
}
