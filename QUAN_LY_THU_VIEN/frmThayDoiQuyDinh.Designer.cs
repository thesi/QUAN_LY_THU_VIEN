namespace QUAN_LY_THU_VIEN
{
    partial class frmThayDoiQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThayDoiQuyDinh));
            this.tbxCapThe = new System.Windows.Forms.TextBox();
            this.cbbTenNhom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNgay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxGiaHan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxHu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxMat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxCapThe
            // 
            this.tbxCapThe.Location = new System.Drawing.Point(157, 122);
            this.tbxCapThe.Name = "tbxCapThe";
            this.tbxCapThe.Size = new System.Drawing.Size(204, 20);
            this.tbxCapThe.TabIndex = 0;
            // 
            // cbbTenNhom
            // 
            this.cbbTenNhom.FormattingEnabled = true;
            this.cbbTenNhom.Location = new System.Drawing.Point(157, 72);
            this.cbbTenNhom.Name = "cbbTenNhom";
            this.cbbTenNhom.Size = new System.Drawing.Size(154, 21);
            this.cbbTenNhom.TabIndex = 1;
            this.cbbTenNhom.TextChanged += new System.EventHandler(this.cbbTenNhom_TextChanged);
            this.cbbTenNhom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbTenNhom_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thay đổi quy định";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhóm";
            // 
            // button1
            // 
            this.button1.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(268, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cập nhật";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lệ phí cấp thẻ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số ngày mượn tối đa";
            // 
            // tbxNgay
            // 
            this.tbxNgay.Location = new System.Drawing.Point(157, 192);
            this.tbxNgay.Name = "tbxNgay";
            this.tbxNgay.Size = new System.Drawing.Size(204, 20);
            this.tbxNgay.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lệ phí gia hạn thẻ";
            // 
            // tbxGiaHan
            // 
            this.tbxGiaHan.Location = new System.Drawing.Point(157, 157);
            this.tbxGiaHan.Name = "tbxGiaHan";
            this.tbxGiaHan.Size = new System.Drawing.Size(204, 20);
            this.tbxGiaHan.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số sách mượn tối đa";
            // 
            // tbxSach
            // 
            this.tbxSach.Location = new System.Drawing.Point(157, 228);
            this.tbxSach.Name = "tbxSach";
            this.tbxSach.Size = new System.Drawing.Size(204, 20);
            this.tbxSach.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số tiền phạt trễ 1 ngày";
            // 
            // tbxTre
            // 
            this.tbxTre.Location = new System.Drawing.Point(157, 266);
            this.tbxTre.Name = "tbxTre";
            this.tbxTre.Size = new System.Drawing.Size(204, 20);
            this.tbxTre.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số tiền phạt làm hư sách";
            // 
            // tbxHu
            // 
            this.tbxHu.Location = new System.Drawing.Point(157, 302);
            this.tbxHu.Name = "tbxHu";
            this.tbxHu.Size = new System.Drawing.Size(204, 20);
            this.tbxHu.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Số tiền phạt làm mất sách";
            // 
            // tbxMat
            // 
            this.tbxMat.Location = new System.Drawing.Point(157, 338);
            this.tbxMat.Name = "tbxMat";
            this.tbxMat.Size = new System.Drawing.Size(204, 20);
            this.tbxMat.TabIndex = 16;
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUAN_LY_THU_VIEN.Properties.Resources.hinh_nen_form_phu;
            this.ClientSize = new System.Drawing.Size(448, 453);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxMat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxHu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxTre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxGiaHan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTenNhom);
            this.Controls.Add(this.tbxCapThe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThayDoiQuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi quy định";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCapThe;
        private System.Windows.Forms.ComboBox cbbTenNhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxGiaHan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxHu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMat;
    }
}