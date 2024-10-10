namespace BTL_LTTQ_VIP
{
    partial class QuanLyNhaCungCap
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
            this.ThemNCC = new System.Windows.Forms.Button();
            this.SuaNCC = new System.Windows.Forms.Button();
            this.XoaNCC = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // ThemNCC
            // 
            this.ThemNCC.Location = new System.Drawing.Point(814, 90);
            this.ThemNCC.Name = "ThemNCC";
            this.ThemNCC.Size = new System.Drawing.Size(139, 61);
            this.ThemNCC.TabIndex = 1;
            this.ThemNCC.Text = "Thêm nhà cung cấp";
            this.ThemNCC.UseVisualStyleBackColor = true;
            this.ThemNCC.Click += new System.EventHandler(this.ThemNCC_Click);
            // 
            // SuaNCC
            // 
            this.SuaNCC.Location = new System.Drawing.Point(814, 186);
            this.SuaNCC.Name = "SuaNCC";
            this.SuaNCC.Size = new System.Drawing.Size(139, 61);
            this.SuaNCC.TabIndex = 2;
            this.SuaNCC.Text = "Sửa nhà cung cáp";
            this.SuaNCC.UseVisualStyleBackColor = true;
            // 
            // XoaNCC
            // 
            this.XoaNCC.Location = new System.Drawing.Point(814, 286);
            this.XoaNCC.Name = "XoaNCC";
            this.XoaNCC.Size = new System.Drawing.Size(139, 61);
            this.XoaNCC.TabIndex = 3;
            this.XoaNCC.Text = "Xóa nhà cung cấp";
            this.XoaNCC.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(814, 391);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(139, 61);
            this.exit.TabIndex = 4;
            this.exit.Text = "Trở lại";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thôn tin nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 71);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quản lý nhà cung cấp";
            // 
            // QuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 574);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.XoaNCC);
            this.Controls.Add(this.SuaNCC);
            this.Controls.Add(this.ThemNCC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyNhaCungCap";
            this.Text = "QuanLyNhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ThemNCC;
        private System.Windows.Forms.Button SuaNCC;
        private System.Windows.Forms.Button XoaNCC;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}