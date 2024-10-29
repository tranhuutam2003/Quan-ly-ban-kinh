namespace BTL_LTTQ_VIP
{
    partial class ThemChatLieu
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
            this.Ma = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.TextBox();
            this.xacnhan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chất liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chất liệu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thêm chất liệu";
            // 
            // Ma
            // 
            this.Ma.Location = new System.Drawing.Point(128, 104);
            this.Ma.Name = "Ma";
            this.Ma.Size = new System.Drawing.Size(250, 22);
            this.Ma.TabIndex = 3;
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(128, 143);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(250, 22);
            this.Ten.TabIndex = 4;
            // 
            // xacnhan
            // 
            this.xacnhan.Location = new System.Drawing.Point(284, 216);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(125, 30);
            this.xacnhan.TabIndex = 5;
            this.xacnhan.Text = "Xác nhận";
            this.xacnhan.UseVisualStyleBackColor = true;
            this.xacnhan.Click += new System.EventHandler(this.xacnhan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Trở lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThemChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 426);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.xacnhan);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.Ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemChatLieu";
            this.Text = "ThemChatLieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ma;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.Button xacnhan;
        private System.Windows.Forms.Button button2;
    }
}