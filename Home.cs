using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ_VIP
{
    public partial class Home : Form
    {
        public string TenNV { get; set; }
        public string CongViec { get; set; }
        public Home()
        {
            InitializeComponent();
            this.Load += Home_Load;
            MenuNV.Visible = false; 
            MenuQL.Visible = false;

            //this.BackgroundImage = Image.FromFile(@"C:\Users\tam tran\source\repos\BTL LTTQ VIP\imglttq\backroundhome.jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch; // Để hình ảnh giãn theo kích thước form
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien(TenNV, CongViec);
            qlnv.Show();
            this.Hide();

        }

        private void QLNCC_Click(object sender, EventArgs e)
        {
            QuanLyNhaCungCap qlncc = new QuanLyNhaCungCap();
            qlncc.Show();
            
        }

        private void QLKH_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            qlkh.Show();
            
        }

        private void QLHDN_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonNhap qlhdn = new QuanLyHoaDonNhap();
            qlhdn.Show();
            
        }

        private void QLDMHH_Click(object sender, EventArgs e)
        {
            QuanLyDanhMucHangHoa qlhh = new QuanLyDanhMucHangHoa(TenNV, CongViec);
            qlhh.Show();
            this.Hide();
        }

        private void QLHDB_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonBan qlhdb = new QuanLyHoaDonBan();
            qlhdb.Show();
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }

        private void Home_Load()
        {
            
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
                MenuNV.Visible = true;  // Show sales staff menu
                MenuQL.Visible = false; // Hide manager menu
            }
            else if (CongViec == "Quản lý")
            {
                MenuNV.Visible = false; // Hide sales staff menu
                MenuQL.Visible = true;  // Show manager menu
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

        private void button9_Click(object sender, EventArgs e)
        {
            QuanLyDanhMucHangHoa qlhh = new QuanLyDanhMucHangHoa(TenNV, CongViec);
            qlhh.Show();
            this.Hide();
        }
    }
}
