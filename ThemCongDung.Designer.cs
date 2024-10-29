namespace BTL_LTTQ_VIP
{
    partial class ThemCongDung
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
            this.Ma = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.xacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã công dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên công dụng";
            // 
            // Ma
            // 
            this.Ma.Location = new System.Drawing.Point(130, 84);
            this.Ma.Name = "Ma";
            this.Ma.Size = new System.Drawing.Size(250, 22);
            this.Ma.TabIndex = 2;
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(130, 112);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(250, 22);
            this.Ten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thêm công dụng";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(15, 168);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 30);
            this.exit.TabIndex = 5;
            this.exit.Text = "Trở lại";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // xacnhan
            // 
            this.xacnhan.Location = new System.Drawing.Point(285, 168);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(125, 30);
            this.xacnhan.TabIndex = 6;
            this.xacnhan.Text = "Xác nhận";
            this.xacnhan.UseVisualStyleBackColor = true;
            this.xacnhan.Click += new System.EventHandler(this.xacnhan_Click);
            // 
            // ThemCongDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 399);
            this.Controls.Add(this.xacnhan);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.Ma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemCongDung";
            this.Text = "ThemCongDung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ma;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button xacnhan;
    }
}