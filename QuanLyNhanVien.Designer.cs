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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ThemNV = new System.Windows.Forms.Button();
            this.SuaNV = new System.Windows.Forms.Button();
            this.XoaNV = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exitNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 435);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ThemNV
            // 
            this.ThemNV.Location = new System.Drawing.Point(948, 37);
            this.ThemNV.Name = "ThemNV";
            this.ThemNV.Size = new System.Drawing.Size(145, 46);
            this.ThemNV.TabIndex = 1;
            this.ThemNV.Text = "Thêm nhân viên";
            this.ThemNV.UseVisualStyleBackColor = true;
            this.ThemNV.Click += new System.EventHandler(this.ThemNV_Click);
            // 
            // SuaNV
            // 
            this.SuaNV.Location = new System.Drawing.Point(948, 113);
            this.SuaNV.Name = "SuaNV";
            this.SuaNV.Size = new System.Drawing.Size(145, 46);
            this.SuaNV.TabIndex = 2;
            this.SuaNV.Text = "Sửa thông tin nhân viên";
            this.SuaNV.UseVisualStyleBackColor = true;
            this.SuaNV.Click += new System.EventHandler(this.SuaNV_Click);
            // 
            // XoaNV
            // 
            this.XoaNV.Location = new System.Drawing.Point(948, 193);
            this.XoaNV.Name = "XoaNV";
            this.XoaNV.Size = new System.Drawing.Size(145, 46);
            this.XoaNV.TabIndex = 3;
            this.XoaNV.Text = "Xóa nhân viên";
            this.XoaNV.UseVisualStyleBackColor = true;
            this.XoaNV.Click += new System.EventHandler(this.XoaNV_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(351, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(430, 60);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Quản lý nhân viên";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // exitNV
            // 
            this.exitNV.Location = new System.Drawing.Point(948, 271);
            this.exitNV.Name = "exitNV";
            this.exitNV.Size = new System.Drawing.Size(145, 46);
            this.exitNV.TabIndex = 5;
            this.exitNV.Text = "Quay lại";
            this.exitNV.UseVisualStyleBackColor = true;
            this.exitNV.Click += new System.EventHandler(this.exitNV_Click);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 555);
            this.Controls.Add(this.exitNV);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.XoaNV);
            this.Controls.Add(this.SuaNV);
            this.Controls.Add(this.ThemNV);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyNhanVien";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ThemNV;
        private System.Windows.Forms.Button SuaNV;
        private System.Windows.Forms.Button XoaNV;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button exitNV;
    }
}

