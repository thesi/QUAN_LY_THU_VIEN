namespace QUAN_LY_THU_VIEN
{
    partial class frmChuyenNhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenNhom));
            this.tbxTenNhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenNhomChuyen = new System.Windows.Forms.ComboBox();
            this.btnChuyenNhom = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbbMaDocGia = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxNgaySinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxTenNhom
            // 
            this.tbxTenNhom.Enabled = false;
            this.tbxTenNhom.Location = new System.Drawing.Point(142, 82);
            this.tbxTenNhom.Name = "tbxTenNhom";
            this.tbxTenNhom.Size = new System.Drawing.Size(138, 20);
            this.tbxTenNhom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Đọc Giả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhóm hiện tại : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Muốn chuyển tới nhóm :";
            // 
            // cbbTenNhomChuyen
            // 
            this.cbbTenNhomChuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNhomChuyen.Enabled = false;
            this.cbbTenNhomChuyen.FormattingEnabled = true;
            this.cbbTenNhomChuyen.Location = new System.Drawing.Point(142, 146);
            this.cbbTenNhomChuyen.Name = "cbbTenNhomChuyen";
            this.cbbTenNhomChuyen.Size = new System.Drawing.Size(140, 21);
            this.cbbTenNhomChuyen.TabIndex = 5;
            this.cbbTenNhomChuyen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbTenNhomChuyen_MouseClick);
            // 
            // btnChuyenNhom
            // 
            this.btnChuyenNhom.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1;
            this.btnChuyenNhom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChuyenNhom.Location = new System.Drawing.Point(61, 208);
            this.btnChuyenNhom.Name = "btnChuyenNhom";
            this.btnChuyenNhom.Size = new System.Drawing.Size(85, 62);
            this.btnChuyenNhom.TabIndex = 6;
            this.btnChuyenNhom.Text = "Chuyển";
            this.btnChuyenNhom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChuyenNhom.UseVisualStyleBackColor = true;
            this.btnChuyenNhom.Click += new System.EventHandler(this.btnChuyenNhom_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1364801780_button_cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(187, 208);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 62);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbbMaDocGia
            // 
            this.cbbMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDocGia.FormattingEnabled = true;
            this.cbbMaDocGia.Location = new System.Drawing.Point(142, 24);
            this.cbbMaDocGia.Name = "cbbMaDocGia";
            this.cbbMaDocGia.Size = new System.Drawing.Size(140, 21);
            this.cbbMaDocGia.TabIndex = 8;
            this.cbbMaDocGia.SelectedIndexChanged += new System.EventHandler(this.cbbMaDocGia_SelectedIndexChanged);
            this.cbbMaDocGia.TextChanged += new System.EventHandler(this.cbbMaDocGia_TextChanged);
            this.cbbMaDocGia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbMaDocGia_MouseClick);
            this.cbbMaDocGia.MouseLeave += new System.EventHandler(this.cbbMaDocGia_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbxNgaySinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxSDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxHoTen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(345, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 155);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Độc Giả";
            // 
            // tbxNgaySinh
            // 
            this.tbxNgaySinh.Enabled = false;
            this.tbxNgaySinh.Location = new System.Drawing.Point(123, 63);
            this.tbxNgaySinh.Name = "tbxNgaySinh";
            this.tbxNgaySinh.Size = new System.Drawing.Size(62, 20);
            this.tbxNgaySinh.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Sinh :";
            // 
            // tbxSDT
            // 
            this.tbxSDT.Enabled = false;
            this.tbxSDT.Location = new System.Drawing.Point(123, 100);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(152, 20);
            this.tbxSDT.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Điện Thoại :";
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Enabled = false;
            this.tbxHoTen.Location = new System.Drawing.Point(123, 28);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.Size = new System.Drawing.Size(152, 20);
            this.tbxHoTen.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Và Tên :";
            // 
            // frmChuyenNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUAN_LY_THU_VIEN.Properties.Resources.hinh_nen_form_phu;
            this.ClientSize = new System.Drawing.Size(663, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbMaDocGia);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChuyenNhom);
            this.Controls.Add(this.cbbTenNhomChuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTenNhom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChuyenNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển nhóm";
            this.Load += new System.EventHandler(this.frmChuyenNhom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTenNhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTenNhomChuyen;
        private System.Windows.Forms.Button btnChuyenNhom;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbbMaDocGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.Label label4;
    }
}