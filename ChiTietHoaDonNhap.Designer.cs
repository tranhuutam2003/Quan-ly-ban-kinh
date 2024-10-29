namespace BTL_LTTQ_VIP
{
	partial class ChiTietHoaDonNhap
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
			this.button4 = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(425, 484);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(156, 49);
			this.button4.TabIndex = 16;
			this.button4.Text = "Quay Lại";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(793, 402);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(156, 49);
			this.exit.TabIndex = 15;
			this.exit.Text = "Thoát";
			this.exit.UseVisualStyleBackColor = true;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(545, 402);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(156, 49);
			this.button3.TabIndex = 14;
			this.button3.Text = "Xóa Hóa Đơn";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(304, 402);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(156, 49);
			this.button2.TabIndex = 13;
			this.button2.Text = "Sửa Hóa Đơn";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(51, 402);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 49);
			this.button1.TabIndex = 12;
			this.button1.Text = "Thêm Hóa Đơn";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(34, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(926, 367);
			this.dataGridView1.TabIndex = 11;
			// 
			// ChiTietHoaDonNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 568);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ChiTietHoaDonNhap";
			this.Text = "ChiTietHoaDonNhap";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}