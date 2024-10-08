﻿using System;
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
    public partial class QuanLyKhachHang : Form
    {
        private string connectionString = "Data Source=LAPTOP-7NSHMMSK;Initial Catalog=quanlybankinh;Integrated Security=True";
        public QuanLyKhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaKhach,TenKhach,DiaChi,DienThoai FROM KhachHang WHERE IsActive = 1";
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

        private void themKH_Click(object sender, EventArgs e)
        {
            ThemKH themkh = new ThemKH();
            themkh.Show();
            this.Close();
        }

        private void suaKH_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maKH = selectedRow.Cells["MaKhach"].Value.ToString();
                string tenKH = selectedRow.Cells["TenKhach"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string dienThoai = selectedRow.Cells["DienThoai"].Value.ToString();

                // Mở form ThongTinNV với các thông tin cần sửa
                SuaKH suaKH = new SuaKH(maKH, tenKH, diaChi, dienThoai);
                suaKH.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Home h = new Home();   
            h.Show();
            this.Close();
        }

        private void xoaKH_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy mã khách hàng từ hàng được chọn
                string maKhach = dataGridView1.SelectedRows[0].Cells["MaKhach"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            // Sử dụng câu lệnh UPDATE để thực hiện soft delete
                            string query = "UPDATE KhachHang SET IsActive = 0 WHERE MaKhach = @MaKhach";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@MaKhach", maKhach);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Khách hàng đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Cập nhật lại DataGridView
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
