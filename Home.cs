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
    public partial class Home : Form
    {
        public string MaNV {  get; set; }
        public string TenNV { get; set; }
        public string CongViec { get; set; }
        
        public Home()
        {
            InitializeComponent();
            this.Load += Home_Load;
            QLNV.Visible = false;
           

            //this.BackgroundImage = Image.FromFile(@"C:\Users\tam tran\source\repos\BTL LTTQ VIP\imglttq\backroundhome.jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch; // Để hình ảnh giãn theo kích thước form
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien(TenNV, CongViec);
            qlnv.Show();
            //this.Hide();

        }

        private void QLNCC_Click(object sender, EventArgs e)
        {
            QuanLyNhaCungCap qlncc = new QuanLyNhaCungCap(TenNV, CongViec);
            qlncc.Show();
            //this.Hide();
        }

        private void QLKH_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang qlkh = new QuanLyKhachHang(TenNV, CongViec);
            qlkh.Show();
            //this.Hide();
        }

        private void QLHDN_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonNhap quanLyHoaDonNhap = new QuanLyHoaDonNhap(TenNV, CongViec);
            quanLyHoaDonNhap.Show();
            //this.Hide();
        }

        private void QLDMHH_Click(object sender, EventArgs e)
        {
            QuanLyDanhMucHangHoa qlhh = new QuanLyDanhMucHangHoa(TenNV, CongViec);
            qlhh.Show();
            //this.Hide();
        }

        private void QLHDB_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonBan qlhdb = new QuanLyHoaDonBan(TenNV,MaNV, CongViec);
            qlhdb.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        public void UpdateUI()
        {

            lbTenNV.Text = TenNV ?? "Không có tên";
            lbCV.Text = CongViec ?? "Không có công việc";

            if (CongViec == "Nhân viên bán hàng")
            {
                QLNV.Visible = false;
            }
            else if (CongViec == "Quản lý")
            {
                QLNV.Visible = true;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemHangHoa themHangHoa = new ThemHangHoa();
            themHangHoa.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
		public void HienThiTongDoanhThu()
		{
			
			string query = "SELECT SUM(TongTien) AS TongDoanhThu FROM HoaDonBan";

			using (SqlConnection connection = new SqlConnection(databaselink.ConnectionString))
			{
				try
				{
					connection.Open();
					SqlCommand command = new SqlCommand(query, connection);
					object result = command.ExecuteScalar();

					if (result != DBNull.Value)
					{
						decimal tongDoanhThu = Convert.ToDecimal(result);
						txtDoanhThu.Text = tongDoanhThu.ToString("N2"); // Hiển thị định dạng tiền tệ
					}
					else
					{
						txtDoanhThu.Text = "0";
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message);
				}
			}
		}
		private void button9_Click(object sender, EventArgs e)
        {
            QuanLyDanhMucHangHoa qlhh = new QuanLyDanhMucHangHoa(TenNV, CongViec);
            qlhh.Show();
            //this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonBan quanLyHoaDonBan = new QuanLyHoaDonBan();
            quanLyHoaDonBan.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonNhap quanLyHoaDonNhap = new QuanLyHoaDonNhap(TenNV, CongViec);
            quanLyHoaDonNhap.Show();
            //this.Hide();
        }

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void MenuQL_Enter(object sender, EventArgs e)
		{

		}

        private void plTenNV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTenNV_Click(object sender, EventArgs e)
        {

        }
    }
}
