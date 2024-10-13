namespace BTL_LTTQ_VIP
{
    partial class QuanLyNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ThemNV = new System.Windows.Forms.Button();
            this.SuaNV = new System.Windows.Forms.Button();
            this.XoaNV = new System.Windows.Forms.Button();
            this.exitNV = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ThemNV
            // 
            this.ThemNV.Location = new System.Drawing.Point(471, 3);
            this.ThemNV.Name = "ThemNV";
            this.ThemNV.Size = new System.Drawing.Size(150, 35);
            this.ThemNV.TabIndex = 1;
            this.ThemNV.Text = "Thêm nhân viên";
            this.ThemNV.UseVisualStyleBackColor = true;
            this.ThemNV.Click += new System.EventHandler(this.ThemNV_Click);
            // 
            // SuaNV
            // 
            this.SuaNV.Location = new System.Drawing.Point(315, 3);
            this.SuaNV.Name = "SuaNV";
            this.SuaNV.Size = new System.Drawing.Size(150, 35);
            this.SuaNV.TabIndex = 2;
            this.SuaNV.Text = "Sửa thông tin nhân viên";
            this.SuaNV.UseVisualStyleBackColor = true;
            this.SuaNV.Click += new System.EventHandler(this.SuaNV_Click);
            // 
            // XoaNV
            // 
            this.XoaNV.Location = new System.Drawing.Point(159, 3);
            this.XoaNV.Name = "XoaNV";
            this.XoaNV.Size = new System.Drawing.Size(150, 35);
            this.XoaNV.TabIndex = 3;
            this.XoaNV.Text = "Xóa nhân viên";
            this.XoaNV.UseVisualStyleBackColor = true;
            this.XoaNV.Click += new System.EventHandler(this.XoaNV_Click);
            // 
            // exitNV
            // 
            this.exitNV.Location = new System.Drawing.Point(3, 3);
            this.exitNV.Name = "exitNV";
            this.exitNV.Size = new System.Drawing.Size(150, 35);
            this.exitNV.TabIndex = 5;
            this.exitNV.Text = "Quay lại";
            this.exitNV.UseVisualStyleBackColor = true;
            this.exitNV.Click += new System.EventHandler(this.exitNV_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 71);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quản lý nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 82);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(58, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 387);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.exitNV);
            this.flowLayoutPanel1.Controls.Add(this.XoaNV);
            this.flowLayoutPanel1.Controls.Add(this.SuaNV);
            this.flowLayoutPanel1.Controls.Add(this.ThemNV);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 481);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(626, 41);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 555);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyNhanVien";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ThemNV;
        private System.Windows.Forms.Button SuaNV;
        private System.Windows.Forms.Button XoaNV;
        private System.Windows.Forms.Button exitNV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

