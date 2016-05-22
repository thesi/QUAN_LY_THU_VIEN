namespace QUAN_LY_THU_VIEN
{
    partial class frmGiaHanThe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaHanThe));
            this.cbbMaDocGia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNgayHetHan = new System.Windows.Forms.TextBox();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNamGiaHan = new System.Windows.Forms.ComboBox();
            this.tbxPhi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbMaDocGia
            // 
            this.cbbMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDocGia.FormattingEnabled = true;
            this.cbbMaDocGia.Location = new System.Drawing.Point(124, 32);
            this.cbbMaDocGia.Name = "cbbMaDocGia";
            this.cbbMaDocGia.Size = new System.Drawing.Size(121, 21);
            this.cbbMaDocGia.TabIndex = 14;
            this.cbbMaDocGia.SelectionChangeCommitted += new System.EventHandler(this.cbbMaDocGia_SelectionChangeCommitted);
            this.cbbMaDocGia.TextChanged += new System.EventHandler(this.cbbMaDocGia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Đọc Giả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày hết hạn";
            // 
            // tbxNgayHetHan
            // 
            this.tbxNgayHetHan.Enabled = false;
            this.tbxNgayHetHan.Location = new System.Drawing.Point(124, 76);
            this.tbxNgayHetHan.Name = "tbxNgayHetHan";
            this.tbxNgayHetHan.Size = new System.Drawing.Size(121, 20);
            this.tbxNgayHetHan.TabIndex = 16;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1;
            this.btnGiaHan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiaHan.Location = new System.Drawing.Point(62, 195);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(86, 58);
            this.btnGiaHan.TabIndex = 17;
            this.btnGiaHan.Text = "Gia Hạn\r\n";
            this.btnGiaHan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaHan.UseVisualStyleBackColor = true;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1364801780_button_cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(213, 195);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 58);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Số năm muốn gia hạn";
            // 
            // cbbNamGiaHan
            // 
            this.cbbNamGiaHan.DisplayMember = "0";
            this.cbbNamGiaHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNamGiaHan.FormattingEnabled = true;
            this.cbbNamGiaHan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbNamGiaHan.Location = new System.Drawing.Point(150, 118);
            this.cbbNamGiaHan.Name = "cbbNamGiaHan";
            this.cbbNamGiaHan.Size = new System.Drawing.Size(38, 21);
            this.cbbNamGiaHan.TabIndex = 20;
            this.cbbNamGiaHan.ValueMember = "0";
            this.cbbNamGiaHan.TextChanged += new System.EventHandler(this.cbbNamGiaHan_TextChanged);
            // 
            // tbxPhi
            // 
            this.tbxPhi.Enabled = false;
            this.tbxPhi.Location = new System.Drawing.Point(124, 155);
            this.tbxPhi.Name = "tbxPhi";
            this.tbxPhi.Size = new System.Drawing.Size(104, 20);
            this.tbxPhi.TabIndex = 22;
            this.tbxPhi.Text = "0";
            this.tbxPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Phí : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "VND";
            // 
            // frmGiaHanThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUAN_LY_THU_VIEN.Properties.Resources.hinh_nen_form_phu;
            this.ClientSize = new System.Drawing.Size(355, 277);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPhi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbNamGiaHan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.tbxNgayHetHan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbMaDocGia);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiaHanThe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gia hạn thẻ";
            this.Load += new System.EventHandler(this.frmGiaHanThe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNgayHetHan;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNamGiaHan;
        private System.Windows.Forms.TextBox tbxPhi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}