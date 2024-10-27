namespace BTL_LTTQ_VIP
{
	partial class HoaDonBan
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.txtSoHDB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cbMaNV = new System.Windows.Forms.ComboBox();
			this.cbMaKhach = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.txtGiamGia = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.BackgroundImageTiled = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader4,
			this.columnHeader5,
			this.columnHeader6,
			this.columnHeader7,
			this.columnHeader8,
			this.columnHeader9});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(31, 203);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1090, 330);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Mã hàng";
			this.columnHeader4.Width = 88;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Tên hàng";
			this.columnHeader5.Width = 102;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Số Lượng";
			this.columnHeader6.Width = 91;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Giảm giá";
			this.columnHeader7.Width = 96;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Đơn giá";
			this.columnHeader8.Width = 93;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Thành Tiền";
			this.columnHeader9.Width = 125;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(219, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Số HDB";
			// 
			// txtSoHDB
			// 
			this.txtSoHDB.Location = new System.Drawing.Point(373, 38);
			this.txtSoHDB.Name = "txtSoHDB";
			this.txtSoHDB.Size = new System.Drawing.Size(100, 22);
			this.txtSoHDB.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(219, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mã NV";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(219, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ngày Bán";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(744, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Mã Khách";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(373, 149);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// cbMaNV
			// 
			this.cbMaNV.FormattingEnabled = true;
			this.cbMaNV.Location = new System.Drawing.Point(373, 97);
			this.cbMaNV.Name = "cbMaNV";
			this.cbMaNV.Size = new System.Drawing.Size(157, 24);
			this.cbMaNV.TabIndex = 8;
			this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
			// 
			// cbMaKhach
			// 
			this.cbMaKhach.FormattingEnabled = true;
			this.cbMaKhach.Location = new System.Drawing.Point(835, 41);
			this.cbMaKhach.Name = "cbMaKhach";
			this.cbMaKhach.Size = new System.Drawing.Size(156, 24);
			this.cbMaKhach.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(741, 148);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Số Lượng";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(835, 148);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
			this.txtSoLuong.TabIndex = 14;
			this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
			// 
			// txtGiamGia
			// 
			this.txtGiamGia.Location = new System.Drawing.Point(835, 94);
			this.txtGiamGia.Name = "txtGiamGia";
			this.txtGiamGia.Size = new System.Drawing.Size(100, 22);
			this.txtGiamGia.TabIndex = 15;
			this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(741, 94);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 16);
			this.label7.TabIndex = 16;
			this.label7.Text = "Giảm giá";
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.Location = new System.Drawing.Point(254, 577);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(147, 41);
			this.btnXacNhan.TabIndex = 17;
			this.btnXacNhan.Text = "Xác Nhận";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(669, 577);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(133, 41);
			this.btnBack.TabIndex = 19;
			this.btnBack.Text = "Quay Lại";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// HoaDonBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1154, 672);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnXacNhan);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtGiamGia);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbMaKhach);
			this.Controls.Add(this.cbMaNV);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSoHDB);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.Name = "HoaDonBan";
			this.Text = "HoaDonBan";
			this.Load += new System.EventHandler(this.HoaDonBan_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSoHDB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cbMaNV;
		private System.Windows.Forms.ComboBox cbMaKhach;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.TextBox txtGiamGia;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.Button btnBack;
	}
}