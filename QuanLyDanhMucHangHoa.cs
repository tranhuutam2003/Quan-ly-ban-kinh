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
    public partial class QuanLyDanhMucHangHoa : Form
    {
        private string connectionString = "Data Source=LAPTOP-7NSHMMSK;Initial Catalog=quanlybankinh;Integrated Security=True";
        private string TenNV;
        private string CongViec;
        public QuanLyDanhMucHangHoa()
        {
            InitializeComponent();
            loadData();
        }

        public QuanLyDanhMucHangHoa(string tenNV, string congViec)
        {
            InitializeComponent();
            TenNV = tenNV;   // Set user information
            CongViec = congViec;
            loadData();
        }

        private void loadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Truy vấn kết hợp để lấy tên từ các bảng liên quan
                    string query = @"
                        SELECT 
                            dh.MaHang,
                            dh.TenHang,
                            lk.TenLoai AS TenLoai,
                            gm.TenLoaiGong AS TenLoaiGong,
                            hd.TenDangMat AS TenDangMat,
                            cl.TenChatLieu AS TenChatLieu,
                            di.TenDiop AS TenDiop,
                            cd.TenCongDung AS CongDung,
                            dc.TenDacDiem AS TenDacDiem,
                            ms.TenMau AS TenMau,
                            ns.TenNuocSX AS TenNuocSX,
                            dh.SoLuong,
                            dh.DonGiaNhap,
                            dh.DonGiaBan,
                            dh.ThoiGianBaoHanh,
                            dh.GhiChu
                        FROM 
                            DanhMucHangHoa dh
                        LEFT JOIN 
                            LoaiKinh lk ON dh.MaLoai = lk.MaLoai
                        LEFT JOIN 
                            GongMat gm ON dh.MaLoaiGong = gm.MaLoaiGong
                        LEFT JOIN 
                            HinhDangMat hd ON dh.MaDangMat = hd.MaDangMat
                        LEFT JOIN 
                            ChatLieu cl ON dh.MaChatLieu = cl.MaChatLieu
                        LEFT JOIN 
                            Diop di ON dh.MaDiop = di.MaDiop
                        LEFT JOIN 
                            CongDung cd ON dh.MaCongDung = cd.MaCongDung
                        LEFT JOIN 
                            DacDiem dc ON dh.MaDacDiem = dc.MaDacDiem
                        LEFT JOIN 
                            MauSac ms ON dh.MaMau = ms.MaMau
                        LEFT JOIN 
                            NuocSanXuat ns ON dh.MaNuocSX = ns.MaNuocSX";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Gán dữ liệu cho DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Đặt tên hiển thị cho các cột
                    dataGridView1.Columns["MaHang"].HeaderText = "Mã Sản Phẩm";
                    dataGridView1.Columns["TenHang"].HeaderText = "Tên Hàng";
                    dataGridView1.Columns["TenLoai"].HeaderText = "Loại Kính";
                    dataGridView1.Columns["TenLoaiGong"].HeaderText = "Loại Gọng";
                    dataGridView1.Columns["TenDangMat"].HeaderText = "Hình Dáng";
                    dataGridView1.Columns["TenChatLieu"].HeaderText = "Chất Liệu";
                    dataGridView1.Columns["TenDiop"].HeaderText = "Diop";
                    dataGridView1.Columns["CongDung"].HeaderText = "Công Dụng";
                    dataGridView1.Columns["TenDacDiem"].HeaderText = "Đặc Điểm";
                    dataGridView1.Columns["TenMau"].HeaderText = "Màu Sắc";
                    dataGridView1.Columns["TenNuocSX"].HeaderText = "Nước Sản Xuất";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                }
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            ThemHangHoa thh = new ThemHangHoa();
            thh.Show();
            this.Close();
        }

        private void Sua_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home
            {
                TenNV = TenNV,
                CongViec = CongViec
            };
            homeForm.Show();
            this.Close();
        }
    }
}
