namespace BTL_LTTQ_VIP
{
    partial class TimSanPham
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
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxMaHang = new System.Windows.Forms.ComboBox();
            this.comboBoxTenHang = new System.Windows.Forms.ComboBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.listViewKetQua = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxMaHang
            // 
            this.comboBoxMaHang.FormattingEnabled = true;
            this.comboBoxMaHang.Location = new System.Drawing.Point(532, 81);
            this.comboBoxMaHang.Name = "comboBoxMaHang";
            this.comboBoxMaHang.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaHang.TabIndex = 8;
            this.comboBoxMaHang.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaHang_SelectedIndexChanged);
            // 
            // comboBoxTenHang
            // 
            this.comboBoxTenHang.FormattingEnabled = true;
            this.comboBoxTenHang.Location = new System.Drawing.Point(331, 81);
            this.comboBoxTenHang.Name = "comboBoxTenHang";
            this.comboBoxTenHang.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTenHang.TabIndex = 6;
            this.comboBoxTenHang.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenHang_SelectedIndexChanged);
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(321, 127);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 5;
            this.buttonTim.Text = "Tìm ";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // listViewKetQua
            // 
            this.listViewKetQua.HideSelection = false;
            this.listViewKetQua.Location = new System.Drawing.Point(30, 237);
            this.listViewKetQua.Name = "listViewKetQua";
            this.listViewKetQua.Size = new System.Drawing.Size(838, 387);
            this.listViewKetQua.TabIndex = 10;
            this.listViewKetQua.UseCompatibleStateImageBehavior = false;
            // 
            // TimSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 658);
            this.Controls.Add(this.listViewKetQua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxMaHang);
            this.Controls.Add(this.comboBoxTenHang);
            this.Controls.Add(this.buttonTim);
            this.Name = "TimSanPham";
            this.Text = "TimSanPham_";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxMaHang;
        private System.Windows.Forms.ComboBox comboBoxTenHang;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.ListView listViewKetQua;
    }
}