namespace BTL_LTTQ_VIP
{
    partial class SuaKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.TextBox();
            this.TenKH = new System.Windows.Forms.TextBox();
            this.DiaChiKH = new System.Windows.Forms.TextBox();
            this.SDTKH = new System.Windows.Forms.TextBox();
            this.Xacnhan = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sửa khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điện thoại";
            // 
            // MaKH
            // 
            this.MaKH.Location = new System.Drawing.Point(151, 88);
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Size = new System.Drawing.Size(250, 22);
            this.MaKH.TabIndex = 5;
            // 
            // TenKH
            // 
            this.TenKH.Location = new System.Drawing.Point(151, 116);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(250, 22);
            this.TenKH.TabIndex = 6;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.Location = new System.Drawing.Point(151, 144);
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.Size = new System.Drawing.Size(250, 22);
            this.DiaChiKH.TabIndex = 7;
            // 
            // SDTKH
            // 
            this.SDTKH.Location = new System.Drawing.Point(151, 172);
            this.SDTKH.Name = "SDTKH";
            this.SDTKH.Size = new System.Drawing.Size(250, 22);
            this.SDTKH.TabIndex = 8;
            // 
            // Xacnhan
            // 
            this.Xacnhan.Location = new System.Drawing.Point(303, 242);
            this.Xacnhan.Name = "Xacnhan";
            this.Xacnhan.Size = new System.Drawing.Size(125, 30);
            this.Xacnhan.TabIndex = 34;
            this.Xacnhan.Text = "Xác nhận";
            this.Xacnhan.UseVisualStyleBackColor = true;
            this.Xacnhan.Click += new System.EventHandler(this.Xacnhan_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(36, 242);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 30);
            this.exit.TabIndex = 35;
            this.exit.Text = "Trở lại";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // SuaKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 390);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Xacnhan);
            this.Controls.Add(this.SDTKH);
            this.Controls.Add(this.DiaChiKH);
            this.Controls.Add(this.TenKH);
            this.Controls.Add(this.MaKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuaKH";
            this.Text = "SuaKH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaKH;
        private System.Windows.Forms.TextBox TenKH;
        private System.Windows.Forms.TextBox DiaChiKH;
        private System.Windows.Forms.TextBox SDTKH;
        private System.Windows.Forms.Button Xacnhan;
        private System.Windows.Forms.Button exit;
    }
}