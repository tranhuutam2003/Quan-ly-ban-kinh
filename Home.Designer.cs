namespace BTL_LTTQ_VIP
{
    partial class Home
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
            this.QLNV = new System.Windows.Forms.Button();
            this.QLKH = new System.Windows.Forms.Button();
            this.QLHDB = new System.Windows.Forms.Button();
            this.QLHDN = new System.Windows.Forms.Button();
            this.QLNCC = new System.Windows.Forms.Button();
            this.QLDMHH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QLNV
            // 
            this.QLNV.Location = new System.Drawing.Point(32, 30);
            this.QLNV.Name = "QLNV";
            this.QLNV.Size = new System.Drawing.Size(167, 73);
            this.QLNV.TabIndex = 0;
            this.QLNV.Text = "Quản lý nhân viên";
            this.QLNV.UseVisualStyleBackColor = true;
            this.QLNV.Click += new System.EventHandler(this.QLNV_Click);
            // 
            // QLKH
            // 
            this.QLKH.Location = new System.Drawing.Point(32, 142);
            this.QLKH.Name = "QLKH";
            this.QLKH.Size = new System.Drawing.Size(167, 73);
            this.QLKH.TabIndex = 1;
            this.QLKH.Text = "Quản lý khách hàng";
            this.QLKH.UseVisualStyleBackColor = true;
            this.QLKH.Click += new System.EventHandler(this.QLKH_Click);
            // 
            // QLHDB
            // 
            this.QLHDB.Location = new System.Drawing.Point(32, 252);
            this.QLHDB.Name = "QLHDB";
            this.QLHDB.Size = new System.Drawing.Size(167, 73);
            this.QLHDB.TabIndex = 2;
            this.QLHDB.Text = "Quản lý hóa đơn bán";
            this.QLHDB.UseVisualStyleBackColor = true;
            this.QLHDB.Click += new System.EventHandler(this.QLHDB_Click);
            // 
            // QLHDN
            // 
            this.QLHDN.Location = new System.Drawing.Point(930, 30);
            this.QLHDN.Name = "QLHDN";
            this.QLHDN.Size = new System.Drawing.Size(167, 73);
            this.QLHDN.TabIndex = 3;
            this.QLHDN.Text = "Quản lý hóa đơn nhập";
            this.QLHDN.UseVisualStyleBackColor = true;
            this.QLHDN.Click += new System.EventHandler(this.QLHDN_Click);
            // 
            // QLNCC
            // 
            this.QLNCC.Location = new System.Drawing.Point(930, 142);
            this.QLNCC.Name = "QLNCC";
            this.QLNCC.Size = new System.Drawing.Size(167, 73);
            this.QLNCC.TabIndex = 4;
            this.QLNCC.Text = "Quản lý nhà cung cấp";
            this.QLNCC.UseVisualStyleBackColor = true;
            this.QLNCC.Click += new System.EventHandler(this.QLNCC_Click);
            // 
            // QLDMHH
            // 
            this.QLDMHH.Location = new System.Drawing.Point(930, 252);
            this.QLDMHH.Name = "QLDMHH";
            this.QLDMHH.Size = new System.Drawing.Size(167, 73);
            this.QLDMHH.TabIndex = 5;
            this.QLDMHH.Text = "Quản lý danh mục hàng hóa";
            this.QLDMHH.UseVisualStyleBackColor = true;
            this.QLDMHH.Click += new System.EventHandler(this.QLDMHH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 71);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý bán kính";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(472, 366);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(167, 73);
            this.exit.TabIndex = 9;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 561);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QLDMHH);
            this.Controls.Add(this.QLNCC);
            this.Controls.Add(this.QLHDN);
            this.Controls.Add(this.QLHDB);
            this.Controls.Add(this.QLKH);
            this.Controls.Add(this.QLNV);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QLNV;
        private System.Windows.Forms.Button QLKH;
        private System.Windows.Forms.Button QLHDB;
        private System.Windows.Forms.Button QLHDN;
        private System.Windows.Forms.Button QLNCC;
        private System.Windows.Forms.Button QLDMHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
    }
}