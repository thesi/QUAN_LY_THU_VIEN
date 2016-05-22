namespace QUAN_LY_THU_VIEN
{
    partial class frmTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraSach));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMaDG = new System.Windows.Forms.TextBox();
            this.tbxNgayTra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNgayPhaiTra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNgayMuon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMaPhieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.lbxDanhSach = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxNTra = new System.Windows.Forms.TextBox();
            this.tbxNMuon = new System.Windows.Forms.TextBox();
            this.lbxMaSach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // tbxMaDG
            // 
            this.tbxMaDG.Location = new System.Drawing.Point(105, 41);
            this.tbxMaDG.Name = "tbxMaDG";
            this.tbxMaDG.Size = new System.Drawing.Size(100, 20);
            this.tbxMaDG.TabIndex = 1;
            this.tbxMaDG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxNgayTra
            // 
            this.tbxNgayTra.Enabled = false;
            this.tbxNgayTra.Location = new System.Drawing.Point(105, 218);
            this.tbxNgayTra.Name = "tbxNgayTra";
            this.tbxNgayTra.Size = new System.Drawing.Size(100, 20);
            this.tbxNgayTra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày trả";
            // 
            // tbxNgayPhaiTra
            // 
            this.tbxNgayPhaiTra.Enabled = false;
            this.tbxNgayPhaiTra.Location = new System.Drawing.Point(105, 174);
            this.tbxNgayPhaiTra.Name = "tbxNgayPhaiTra";
            this.tbxNgayPhaiTra.Size = new System.Drawing.Size(100, 20);
            this.tbxNgayPhaiTra.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày phải trả";
            // 
            // tbxNgayMuon
            // 
            this.tbxNgayMuon.Enabled = false;
            this.tbxNgayMuon.Location = new System.Drawing.Point(105, 127);
            this.tbxNgayMuon.Name = "tbxNgayMuon";
            this.tbxNgayMuon.Size = new System.Drawing.Size(100, 20);
            this.tbxNgayMuon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày mượn";
            // 
            // tbxMaPhieu
            // 
            this.tbxMaPhieu.Enabled = false;
            this.tbxMaPhieu.Location = new System.Drawing.Point(105, 83);
            this.tbxMaPhieu.Name = "tbxMaPhieu";
            this.tbxMaPhieu.Size = new System.Drawing.Size(100, 20);
            this.tbxMaPhieu.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã phiếu";
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(115, 295);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(89, 51);
            this.btnDanhSach.TabIndex = 10;
            this.btnDanhSach.Text = "Hiển thị danh sách sách mượn";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // lbxDanhSach
            // 
            this.lbxDanhSach.FormattingEnabled = true;
            this.lbxDanhSach.Location = new System.Drawing.Point(259, 65);
            this.lbxDanhSach.Name = "lbxDanhSach";
            this.lbxDanhSach.Size = new System.Drawing.Size(265, 173);
            this.lbxDanhSach.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quản lý trả sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Danh sách sách mượn";
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(243, 295);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(89, 51);
            this.btnTra.TabIndex = 14;
            this.btnTra.Text = "Trả sách";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(349, 295);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 51);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(457, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 51);
            this.button3.TabIndex = 15;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(21, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(354, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Độc giả chưa mượn sách hoặc đã trả hết sách rồi";
            this.label8.Visible = false;
            // 
            // tbxNTra
            // 
            this.tbxNTra.Enabled = false;
            this.tbxNTra.Location = new System.Drawing.Point(12, 311);
            this.tbxNTra.Name = "tbxNTra";
            this.tbxNTra.Size = new System.Drawing.Size(100, 20);
            this.tbxNTra.TabIndex = 17;
            this.tbxNTra.Visible = false;
            // 
            // tbxNMuon
            // 
            this.tbxNMuon.Enabled = false;
            this.tbxNMuon.Location = new System.Drawing.Point(104, 149);
            this.tbxNMuon.Name = "tbxNMuon";
            this.tbxNMuon.Size = new System.Drawing.Size(100, 20);
            this.tbxNMuon.TabIndex = 18;
            this.tbxNMuon.Visible = false;
            // 
            // lbxMaSach
            // 
            this.lbxMaSach.FormattingEnabled = true;
            this.lbxMaSach.Location = new System.Drawing.Point(506, 207);
            this.lbxMaSach.Name = "lbxMaSach";
            this.lbxMaSach.Size = new System.Drawing.Size(72, 82);
            this.lbxMaSach.TabIndex = 19;
            this.lbxMaSach.Visible = false;
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUAN_LY_THU_VIEN.Properties.Resources.hinh_nen_form_phu;
            this.ClientSize = new System.Drawing.Size(590, 358);
            this.Controls.Add(this.lbxMaSach);
            this.Controls.Add(this.tbxNMuon);
            this.Controls.Add(this.tbxNTra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbxDanhSach);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.tbxMaPhieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxNgayMuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNgayPhaiTra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNgayTra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMaDG);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraSach";
            this.Text = "Trả sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMaDG;
        private System.Windows.Forms.TextBox tbxNgayTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNgayPhaiTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNgayMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMaPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.ListBox lbxDanhSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxNTra;
        private System.Windows.Forms.TextBox tbxNMuon;
        private System.Windows.Forms.ListBox lbxMaSach;
    }
}