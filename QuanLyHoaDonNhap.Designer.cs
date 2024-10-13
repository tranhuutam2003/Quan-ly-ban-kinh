namespace BTL_LTTQ_VIP
{
	partial class QuanLyHoaDonNhap
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button4 = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(31, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(926, 367);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnXemChiTiet
			// 
			this.button4.Location = new System.Drawing.Point(422, 484);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(156, 49);
			this.button4.TabIndex = 10;
			this.button4.Text = "Xem Chi Tiết Hóa Đơn";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(790, 402);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(156, 49);
			this.exit.TabIndex = 9;
			this.exit.Text = "Quay lại";
			this.exit.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(542, 402);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(156, 49);
			this.button3.TabIndex = 8;
			this.button3.Text = "Xóa Hóa Đơn";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(301, 402);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(156, 49);
			this.button2.TabIndex = 7;
			this.button2.Text = "Sửa Hóa Đơn";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(48, 402);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 49);
			this.button1.TabIndex = 6;
			this.button1.Text = "Thêm Hóa Đơn";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// QuanLyHoaDonNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(996, 578);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "QuanLyHoaDonNhap";
			this.Text = "QuanLyHoaDonNhap";
			this.Load += new System.EventHandler(this.QuanLyHoaDonNhap_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}