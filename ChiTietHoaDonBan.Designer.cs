namespace BTL_LTTQ_VIP
{
	partial class ChiTietHoaDonBan
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
			this.Quaylai = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(873, 286);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			// 
			// Quaylai
			// 
			this.Quaylai.Location = new System.Drawing.Point(390, 441);
			this.Quaylai.Name = "Quaylai";
			this.Quaylai.Size = new System.Drawing.Size(139, 47);
			this.Quaylai.TabIndex = 1;
			this.Quaylai.Text = "Quay lại";
			this.Quaylai.UseVisualStyleBackColor = true;
			this.Quaylai.Click += new System.EventHandler(this.Quaylai_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 339);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 49);
			this.button1.TabIndex = 2;
			this.button1.Text = "Thêm Hóa Đơn";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(260, 339);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(156, 49);
			this.button2.TabIndex = 3;
			this.button2.Text = "Sửa Hóa Đơn";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(499, 339);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(156, 49);
			this.button3.TabIndex = 4;
			this.button3.Text = "Xóa Hóa Đơn";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(729, 339);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(156, 49);
			this.exit.TabIndex = 5;
			this.exit.Text = "Thoát";
			this.exit.UseVisualStyleBackColor = true;
			// 
			// ChiTietHoaDonBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 537);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Quaylai);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ChiTietHoaDonBan";
			this.Text = "ChiTietHoaDonBan";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Quaylai;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button exit;
	}
}