namespace BTL_LTTQ_VIP
{
    partial class DoanhThu
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
            this.dtpngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.dtpngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.btnxemdoanhthu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblTongDoanhThuBan = new System.Windows.Forms.Label();
            this.lblTongDoanhThuNhap = new System.Windows.Forms.Label();
            this.lblTongDoanhThuThuan = new System.Windows.Forms.Label();
            this.btnxemdoanhthutheothang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpngayketthuc
            // 
            this.dtpngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngayketthuc.Location = new System.Drawing.Point(514, 255);
            this.dtpngayketthuc.Name = "dtpngayketthuc";
            this.dtpngayketthuc.Size = new System.Drawing.Size(250, 22);
            this.dtpngayketthuc.TabIndex = 0;
            // 
            // dtpngaybatdau
            // 
            this.dtpngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaybatdau.Location = new System.Drawing.Point(113, 255);
            this.dtpngaybatdau.Name = "dtpngaybatdau";
            this.dtpngaybatdau.Size = new System.Drawing.Size(250, 22);
            this.dtpngaybatdau.TabIndex = 1;
            // 
            // btnxemdoanhthu
            // 
            this.btnxemdoanhthu.Location = new System.Drawing.Point(22, 305);
            this.btnxemdoanhthu.Name = "btnxemdoanhthu";
            this.btnxemdoanhthu.Size = new System.Drawing.Size(217, 34);
            this.btnxemdoanhthu.TabIndex = 2;
            this.btnxemdoanhthu.Text = "Xem doanh thu";
            this.btnxemdoanhthu.UseVisualStyleBackColor = true;
            this.btnxemdoanhthu.Click += new System.EventHandler(this.btnxemdoanhthu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 221);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày kết thúc";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(22, 404);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(217, 34);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Trở lại";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblTongDoanhThuBan
            // 
            this.lblTongDoanhThuBan.AutoSize = true;
            this.lblTongDoanhThuBan.Location = new System.Drawing.Point(305, 305);
            this.lblTongDoanhThuBan.Name = "lblTongDoanhThuBan";
            this.lblTongDoanhThuBan.Size = new System.Drawing.Size(140, 16);
            this.lblTongDoanhThuBan.TabIndex = 7;
            this.lblTongDoanhThuBan.Text = "lblTongDoanhThuBan";
            this.lblTongDoanhThuBan.Visible = false;
            // 
            // lblTongDoanhThuNhap
            // 
            this.lblTongDoanhThuNhap.AutoSize = true;
            this.lblTongDoanhThuNhap.Location = new System.Drawing.Point(305, 346);
            this.lblTongDoanhThuNhap.Name = "lblTongDoanhThuNhap";
            this.lblTongDoanhThuNhap.Size = new System.Drawing.Size(149, 16);
            this.lblTongDoanhThuNhap.TabIndex = 8;
            this.lblTongDoanhThuNhap.Text = "lblTongDoanhThuNhap";
            this.lblTongDoanhThuNhap.Visible = false;
            // 
            // lblTongDoanhThuThuan
            // 
            this.lblTongDoanhThuThuan.AutoSize = true;
            this.lblTongDoanhThuThuan.Location = new System.Drawing.Point(305, 382);
            this.lblTongDoanhThuThuan.Name = "lblTongDoanhThuThuan";
            this.lblTongDoanhThuThuan.Size = new System.Drawing.Size(154, 16);
            this.lblTongDoanhThuThuan.TabIndex = 9;
            this.lblTongDoanhThuThuan.Text = "lblTongDoanhThuThuan";
            this.lblTongDoanhThuThuan.Visible = false;
            // 
            // btnxemdoanhthutheothang
            // 
            this.btnxemdoanhthutheothang.Location = new System.Drawing.Point(22, 355);
            this.btnxemdoanhthutheothang.Name = "btnxemdoanhthutheothang";
            this.btnxemdoanhthutheothang.Size = new System.Drawing.Size(217, 34);
            this.btnxemdoanhthutheothang.TabIndex = 10;
            this.btnxemdoanhthutheothang.Text = "Xem doanh thu theo tháng";
            this.btnxemdoanhthutheothang.UseVisualStyleBackColor = true;
            this.btnxemdoanhthutheothang.Click += new System.EventHandler(this.btnxemdoanhthutheothang_Click);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxemdoanhthutheothang);
            this.Controls.Add(this.lblTongDoanhThuThuan);
            this.Controls.Add(this.lblTongDoanhThuNhap);
            this.Controls.Add(this.lblTongDoanhThuBan);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnxemdoanhthu);
            this.Controls.Add(this.dtpngaybatdau);
            this.Controls.Add(this.dtpngayketthuc);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpngayketthuc;
        private System.Windows.Forms.DateTimePicker dtpngaybatdau;
        private System.Windows.Forms.Button btnxemdoanhthu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblTongDoanhThuBan;
        private System.Windows.Forms.Label lblTongDoanhThuNhap;
        private System.Windows.Forms.Label lblTongDoanhThuThuan;
        private System.Windows.Forms.Button btnxemdoanhthutheothang;
    }
}