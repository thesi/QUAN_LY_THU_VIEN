namespace QUAN_LY_THU_VIEN
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMKCu = new System.Windows.Forms.TextBox();
            this.tbxMKMoi = new System.Windows.Forms.TextBox();
            this.tbxMKMoiXN = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(132, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập Mật Khẩu Cũ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập Mật Khẩu Mới :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xác Nhận lại :";
            // 
            // tbxMKCu
            // 
            this.tbxMKCu.Location = new System.Drawing.Point(199, 91);
            this.tbxMKCu.Name = "tbxMKCu";
            this.tbxMKCu.Size = new System.Drawing.Size(138, 20);
            this.tbxMKCu.TabIndex = 5;
            this.tbxMKCu.UseSystemPasswordChar = true;
            // 
            // tbxMKMoi
            // 
            this.tbxMKMoi.Location = new System.Drawing.Point(199, 128);
            this.tbxMKMoi.Name = "tbxMKMoi";
            this.tbxMKMoi.Size = new System.Drawing.Size(138, 20);
            this.tbxMKMoi.TabIndex = 6;
            this.tbxMKMoi.UseSystemPasswordChar = true;
            // 
            // tbxMKMoiXN
            // 
            this.tbxMKMoiXN.Location = new System.Drawing.Point(199, 165);
            this.tbxMKMoiXN.Name = "tbxMKMoiXN";
            this.tbxMKMoiXN.Size = new System.Drawing.Size(138, 20);
            this.tbxMKMoiXN.TabIndex = 7;
            this.tbxMKMoiXN.UseSystemPasswordChar = true;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1;
            this.btnDoiMK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoiMK.Location = new System.Drawing.Point(99, 207);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(99, 64);
            this.btnDoiMK.TabIndex = 8;
            this.btnDoiMK.Text = "Xác nhận mật khẩu mới";
            this.btnDoiMK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1364801780_button_cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(220, 207);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 64);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đây là lần đăng nhập đầu tiên của bạn, mời bạn vui lòng đổi mật khẩu";
            this.label5.Visible = false;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUAN_LY_THU_VIEN.Properties.Resources.hinh_nen_form_phu;
            this.ClientSize = new System.Drawing.Size(414, 299);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.tbxMKMoiXN);
            this.Controls.Add(this.tbxMKMoi);
            this.Controls.Add(this.tbxMKCu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMKCu;
        private System.Windows.Forms.TextBox tbxMKMoi;
        private System.Windows.Forms.TextBox tbxMKMoiXN;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label5;
    }
}