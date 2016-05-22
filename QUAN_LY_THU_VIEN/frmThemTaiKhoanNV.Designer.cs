namespace QUAN_LY_THU_VIEN
{
    partial class frmThemTaiKhoanNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTaiKhoanNV));
            this.tbxTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapTK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxTenDangNhap
            // 
            this.tbxTenDangNhap.Location = new System.Drawing.Point(116, 55);
            this.tbxTenDangNhap.Name = "tbxTenDangNhap";
            this.tbxTenDangNhap.Size = new System.Drawing.Size(125, 20);
            this.tbxTenDangNhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu :";
            // 
            // tbxMatKhau
            // 
            this.tbxMatKhau.Location = new System.Drawing.Point(116, 91);
            this.tbxMatKhau.Name = "tbxMatKhau";
            this.tbxMatKhau.Size = new System.Drawing.Size(125, 20);
            this.tbxMatKhau.TabIndex = 2;
            this.tbxMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cung Cấp thông tin tài khoản";
            // 
            // btnCapTK
            // 
            this.btnCapTK.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1;
            this.btnCapTK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapTK.Location = new System.Drawing.Point(92, 175);
            this.btnCapTK.Name = "btnCapTK";
            this.btnCapTK.Size = new System.Drawing.Size(86, 59);
            this.btnCapTK.TabIndex = 5;
            this.btnCapTK.Text = "Cấp Tài Khoản";
            this.btnCapTK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapTK.UseVisualStyleBackColor = true;
            this.btnCapTK.Click += new System.EventHandler(this.btnCapTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quyền truy cập :";
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Items.AddRange(new object[] {
            "Quản lý hệ thống",
            "Quản lý thẻ",
            "Quản lý đọc giả",
            "Quản lý sách"});
            this.cbbQuyen.Location = new System.Drawing.Point(116, 125);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(125, 21);
            this.cbbQuyen.TabIndex = 7;
            // 
            // frmThemTaiKhoanNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUAN_LY_THU_VIEN.Properties.Resources.hinh_nen_form_phu;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cbbQuyen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCapTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTenDangNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemTaiKhoanNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tài khoản nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbQuyen;
    }
}