namespace BTL_LTTQ_VIP
{
    partial class ResetPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NLMKMoi = new System.Windows.Forms.TextBox();
            this.MKMoi = new System.Windows.Forms.TextBox();
            this.MaXacNhan = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.xacnhan = new System.Windows.Forms.Button();
            this.sendemailcode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NLMKMoi);
            this.panel1.Controls.Add(this.MKMoi);
            this.panel1.Controls.Add(this.MaXacNhan);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Location = new System.Drawing.Point(138, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 317);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã xác nhận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // NLMKMoi
            // 
            this.NLMKMoi.Location = new System.Drawing.Point(212, 223);
            this.NLMKMoi.Name = "NLMKMoi";
            this.NLMKMoi.Size = new System.Drawing.Size(250, 22);
            this.NLMKMoi.TabIndex = 3;
            // 
            // MKMoi
            // 
            this.MKMoi.Location = new System.Drawing.Point(212, 153);
            this.MKMoi.Name = "MKMoi";
            this.MKMoi.Size = new System.Drawing.Size(250, 22);
            this.MKMoi.TabIndex = 2;
            // 
            // MaXacNhan
            // 
            this.MaXacNhan.Location = new System.Drawing.Point(212, 88);
            this.MaXacNhan.Name = "MaXacNhan";
            this.MaXacNhan.Size = new System.Drawing.Size(250, 22);
            this.MaXacNhan.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(212, 24);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(250, 22);
            this.Email.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(138, 367);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 30);
            this.exit.TabIndex = 8;
            this.exit.Text = "Trở lại";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // xacnhan
            // 
            this.xacnhan.Location = new System.Drawing.Point(519, 367);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(125, 30);
            this.xacnhan.TabIndex = 9;
            this.xacnhan.Text = "Xác nhận";
            this.xacnhan.UseVisualStyleBackColor = true;
            this.xacnhan.Click += new System.EventHandler(this.xacnhan_Click);
            // 
            // sendemailcode
            // 
            this.sendemailcode.Location = new System.Drawing.Point(329, 367);
            this.sendemailcode.Name = "sendemailcode";
            this.sendemailcode.Size = new System.Drawing.Size(125, 30);
            this.sendemailcode.TabIndex = 10;
            this.sendemailcode.Text = "Gửi mã xác nhận";
            this.sendemailcode.UseVisualStyleBackColor = true;
            this.sendemailcode.Click += new System.EventHandler(this.sendemailcode_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xacnhan);
            this.Controls.Add(this.sendemailcode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NLMKMoi;
        private System.Windows.Forms.TextBox MKMoi;
        private System.Windows.Forms.TextBox MaXacNhan;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button xacnhan;
        private System.Windows.Forms.Button sendemailcode;
    }
}