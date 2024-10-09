namespace BTL_LTTQ_VIP
{
    partial class QuanLyKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.themKH = new System.Windows.Forms.Button();
            this.suaKH = new System.Windows.Forms.Button();
            this.xoaKH = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(684, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // themKH
            // 
            this.themKH.Location = new System.Drawing.Point(761, 107);
            this.themKH.Name = "themKH";
            this.themKH.Size = new System.Drawing.Size(138, 67);
            this.themKH.TabIndex = 3;
            this.themKH.Text = "Thêm khách hàng";
            this.themKH.UseVisualStyleBackColor = true;
            this.themKH.Click += new System.EventHandler(this.themKH_Click);
            // 
            // suaKH
            // 
            this.suaKH.Location = new System.Drawing.Point(761, 220);
            this.suaKH.Name = "suaKH";
            this.suaKH.Size = new System.Drawing.Size(138, 67);
            this.suaKH.TabIndex = 4;
            this.suaKH.Text = "Sửa thông tin khách hàng";
            this.suaKH.UseVisualStyleBackColor = true;
            this.suaKH.Click += new System.EventHandler(this.suaKH_Click);
            // 
            // xoaKH
            // 
            this.xoaKH.Location = new System.Drawing.Point(761, 334);
            this.xoaKH.Name = "xoaKH";
            this.xoaKH.Size = new System.Drawing.Size(138, 67);
            this.xoaKH.TabIndex = 5;
            this.xoaKH.Text = "Xóa khách hàng";
            this.xoaKH.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(761, 435);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(138, 67);
            this.exit.TabIndex = 6;
            this.exit.Text = "Trở lại";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 71);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quản lý khách hàng";
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.xoaKH);
            this.Controls.Add(this.suaKH);
            this.Controls.Add(this.themKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyKhachHang";
            this.Text = "QuanLyKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button themKH;
        private System.Windows.Forms.Button suaKH;
        private System.Windows.Forms.Button xoaKH;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
    }
}