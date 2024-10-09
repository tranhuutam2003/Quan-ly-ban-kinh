namespace BTL_LTTQ_VIP
{
    partial class ThemKH
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
            this.MaKH = new System.Windows.Forms.TextBox();
            this.TenKH = new System.Windows.Forms.TextBox();
            this.DiaChiKH = new System.Windows.Forms.TextBox();
            this.SDTKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Xacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaKH
            // 
            this.MaKH.Location = new System.Drawing.Point(131, 86);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(244, 22);
            this.MaKH.TabIndex = 2;
            // 
            // TenKH
            // 
            this.TenKH.Location = new System.Drawing.Point(131, 114);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(244, 22);
            this.TenKH.TabIndex = 3;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.Location = new System.Drawing.Point(131, 142);
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.Size = new System.Drawing.Size(244, 22);
            this.DiaChiKH.TabIndex = 4;
            // 
            // SDTKH
            // 
            this.SDTKH.Location = new System.Drawing.Point(131, 170);
            this.SDTKH.Name = "SDTKH";
            this.SDTKH.Size = new System.Drawing.Size(244, 22);
            this.SDTKH.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thêm khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điện thoại";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(15, 249);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(92, 39);
            this.exit.TabIndex = 33;
            this.exit.Text = "Trở lại";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Xacnhan
            // 
            this.Xacnhan.Location = new System.Drawing.Point(283, 249);
            this.Xacnhan.Name = "Xacnhan";
            this.Xacnhan.Size = new System.Drawing.Size(92, 39);
            this.Xacnhan.TabIndex = 34;
            this.Xacnhan.Text = "Xác nhận";
            this.Xacnhan.UseVisualStyleBackColor = true;
            this.Xacnhan.Click += new System.EventHandler(this.Xacnhan_Click);
            // 
            // ThemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 483);
            this.Controls.Add(this.Xacnhan);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SDTKH);
            this.Controls.Add(this.DiaChiKH);
            this.Controls.Add(this.TenKH);
            this.Controls.Add(this.MaKH);
            this.Name = "ThemKH";
            this.Text = "ThemKH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaKH;
        private System.Windows.Forms.TextBox TenKH;
        private System.Windows.Forms.TextBox DiaChiKH;
        private System.Windows.Forms.TextBox SDTKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Xacnhan;
    }
}