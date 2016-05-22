namespace QUAN_LY_THU_VIEN
{
    partial class frmMoKhoaThe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoKhoaThe));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMaDocGia = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxNgaySinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMoKhoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Mã đọc giả :";
            // 
            // cbbMaDocGia
            // 
            this.cbbMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDocGia.FormattingEnabled = true;
            this.cbbMaDocGia.Location = new System.Drawing.Point(154, 25);
            this.cbbMaDocGia.Name = "cbbMaDocGia";
            this.cbbMaDocGia.Size = new System.Drawing.Size(121, 21);
            this.cbbMaDocGia.TabIndex = 1;
            this.cbbMaDocGia.TextChanged += new System.EventHandler(this.cbbMaDocGia_TextChanged);
            this.cbbMaDocGia.Click += new System.EventHandler(this.cbbMaDocGia_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1364801780_button_cancel;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(205, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 65);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 155);
            this.groupBox1.TabIndex = 10;
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
            // btnMoKhoa
            // 
            this.btnMoKhoa.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1364801961_user_login;
            this.btnMoKhoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoKhoa.Location = new System.Drawing.Point(60, 272);
            this.btnMoKhoa.Name = "btnMoKhoa";
            this.btnMoKhoa.Size = new System.Drawing.Size(91, 65);
            this.btnMoKhoa.TabIndex = 2;
            this.btnMoKhoa.Text = "Mở Khóa";
            this.btnMoKhoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoKhoa.UseVisualStyleBackColor = true;
            this.btnMoKhoa.Click += new System.EventHandler(this.btnMoKhoa_Click);
            // 
            // frmMoKhoaThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUAN_LY_THU_VIEN.Properties.Resources.hinh_nen_form_phu;
            this.ClientSize = new System.Drawing.Size(332, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMoKhoa);
            this.Controls.Add(this.cbbMaDocGia);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMoKhoaThe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mở Khóa Thẻ";
            this.Load += new System.EventHandler(this.frmMoKhoaThe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaDocGia;
        private System.Windows.Forms.Button btnMoKhoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.Label label4;
    }
}