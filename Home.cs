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
        public Home()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"C:\Users\tam tran\source\repos\BTL LTTQ VIP\imglttq\backroundhome.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch; // Để hình ảnh giãn theo kích thước form
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.Show();
            this.Hide();
        }

        private void QLNCC_Click(object sender, EventArgs e)
        {
            QuanLyNhaCungCap qlncc = new QuanLyNhaCungCap();
            qlncc.Show();
            this.Hide();
        }

        private void QLKH_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            qlkh.Show();
            this.Hide();
        }

        private void QLHDN_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonNhap qlhdn = new QuanLyHoaDonNhap();
            qlhdn.Show();
            this.Hide();
        }

        private void QLDMHH_Click(object sender, EventArgs e)
        {
            QuanLyDanhMucHangHoa qldmhh = new QuanLyDanhMucHangHoa();
            qldmhh.Show();
            this.Hide();
        }

        private void QLHDB_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonBan qlhdb = new QuanLyHoaDonBan();
            qlhdb.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
