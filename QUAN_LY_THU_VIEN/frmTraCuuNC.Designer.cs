namespace QUAN_LY_THU_VIEN
{
    partial class frmTraCuuNC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuNC));
            this.cbbNgonNgu = new System.Windows.Forms.ComboBox();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.btnTimKiemNC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxTenKeSach = new System.Windows.Forms.TextBox();
            this.tbxNamXB = new System.Windows.Forms.TextBox();
            this.tbxTenLoaiSach = new System.Windows.Forms.TextBox();
            this.tbxSoTrang = new System.Windows.Forms.TextBox();
            this.tbxChuyenNganh = new System.Windows.Forms.TextBox();
            this.tbxNgonNgu = new System.Windows.Forms.TextBox();
            this.tbxTenNXB = new System.Windows.Forms.TextBox();
            this.tbxTenCuonSach = new System.Windows.Forms.TextBox();
            this.tbxMaCuonSach = new System.Windows.Forms.TextBox();
            this.tbxMaDauSach = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbNgonNgu
            // 
            this.cbbNgonNgu.FormattingEnabled = true;
            this.cbbNgonNgu.Location = new System.Drawing.Point(140, 12);
            this.cbbNgonNgu.Name = "cbbNgonNgu";
            this.cbbNgonNgu.Size = new System.Drawing.Size(121, 21);
            this.cbbNgonNgu.TabIndex = 0;
            this.cbbNgonNgu.TextChanged += new System.EventHandler(this.cbbNgonNgu_TextChanged);
            this.cbbNgonNgu.Click += new System.EventHandler(this.cbbNgonNgu_Click);
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Location = new System.Drawing.Point(669, 12);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(121, 21);
            this.cbbTacGia.TabIndex = 1;
            this.cbbTacGia.Click += new System.EventHandler(this.cbbTacGia_Click);
            // 
            // cbbLoaiSach
            // 
            this.cbbLoaiSach.FormattingEnabled = true;
            this.cbbLoaiSach.Location = new System.Drawing.Point(396, 12);
            this.cbbLoaiSach.Name = "cbbLoaiSach";
            this.cbbLoaiSach.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiSach.TabIndex = 2;
            this.cbbLoaiSach.Click += new System.EventHandler(this.cbbLoaiSach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Ngôn Ngữ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn Loại Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn Tác Giả";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvTimKiem);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(24, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 232);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả tìm kiếm";
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTimKiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimKiem.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTimKiem.GridColor = System.Drawing.Color.Blue;
            this.dgvTimKiem.Location = new System.Drawing.Point(20, 19);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimKiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTimKiem.Size = new System.Drawing.Size(927, 197);
            this.dgvTimKiem.TabIndex = 0;
            this.dgvTimKiem.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimKiem_CellMouseClick);
            // 
            // btnTimKiemNC
            // 
            this.btnTimKiemNC.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1364802496_Search;
            this.btnTimKiemNC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiemNC.Location = new System.Drawing.Point(831, 9);
            this.btnTimKiemNC.Name = "btnTimKiemNC";
            this.btnTimKiemNC.Size = new System.Drawing.Size(75, 63);
            this.btnTimKiemNC.TabIndex = 9;
            this.btnTimKiemNC.Text = "Tìm Kiếm";
            this.btnTimKiemNC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiemNC.UseVisualStyleBackColor = true;
            this.btnTimKiemNC.Click += new System.EventHandler(this.btnTimKiemNC_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblTrangThai);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbxTenKeSach);
            this.groupBox3.Controls.Add(this.tbxNamXB);
            this.groupBox3.Controls.Add(this.tbxTenLoaiSach);
            this.groupBox3.Controls.Add(this.tbxSoTrang);
            this.groupBox3.Controls.Add(this.tbxChuyenNganh);
            this.groupBox3.Controls.Add(this.tbxNgonNgu);
            this.groupBox3.Controls.Add(this.tbxTenNXB);
            this.groupBox3.Controls.Add(this.tbxTenCuonSach);
            this.groupBox3.Controls.Add(this.tbxMaCuonSach);
            this.groupBox3.Controls.Add(this.tbxMaDauSach);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(24, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 220);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chi Tiết Sách";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lblTrangThai.Location = new System.Drawing.Point(684, 38);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(84, 20);
            this.lblTrangThai.TabIndex = 22;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mã Đầu Sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mã Cuốn Sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên Loại Sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tên Kệ Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số Trang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tác Giả ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngôn Ngữ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Năm XB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tên Cuốn Sách";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tên NXB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(582, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Trạng Thái : ";
            // 
            // tbxTenKeSach
            // 
            this.tbxTenKeSach.Enabled = false;
            this.tbxTenKeSach.Location = new System.Drawing.Point(381, 194);
            this.tbxTenKeSach.Name = "tbxTenKeSach";
            this.tbxTenKeSach.Size = new System.Drawing.Size(155, 20);
            this.tbxTenKeSach.TabIndex = 9;
            // 
            // tbxNamXB
            // 
            this.tbxNamXB.Enabled = false;
            this.tbxNamXB.Location = new System.Drawing.Point(107, 194);
            this.tbxNamXB.Name = "tbxNamXB";
            this.tbxNamXB.Size = new System.Drawing.Size(155, 20);
            this.tbxNamXB.TabIndex = 8;
            // 
            // tbxTenLoaiSach
            // 
            this.tbxTenLoaiSach.Enabled = false;
            this.tbxTenLoaiSach.Location = new System.Drawing.Point(381, 156);
            this.tbxTenLoaiSach.Name = "tbxTenLoaiSach";
            this.tbxTenLoaiSach.Size = new System.Drawing.Size(155, 20);
            this.tbxTenLoaiSach.TabIndex = 7;
            // 
            // tbxSoTrang
            // 
            this.tbxSoTrang.Enabled = false;
            this.tbxSoTrang.Location = new System.Drawing.Point(381, 116);
            this.tbxSoTrang.Name = "tbxSoTrang";
            this.tbxSoTrang.Size = new System.Drawing.Size(155, 20);
            this.tbxSoTrang.TabIndex = 6;
            // 
            // tbxChuyenNganh
            // 
            this.tbxChuyenNganh.Enabled = false;
            this.tbxChuyenNganh.Location = new System.Drawing.Point(381, 76);
            this.tbxChuyenNganh.Name = "tbxChuyenNganh";
            this.tbxChuyenNganh.Size = new System.Drawing.Size(155, 20);
            this.tbxChuyenNganh.TabIndex = 5;
            // 
            // tbxNgonNgu
            // 
            this.tbxNgonNgu.Enabled = false;
            this.tbxNgonNgu.Location = new System.Drawing.Point(381, 38);
            this.tbxNgonNgu.Name = "tbxNgonNgu";
            this.tbxNgonNgu.Size = new System.Drawing.Size(155, 20);
            this.tbxNgonNgu.TabIndex = 4;
            // 
            // tbxTenNXB
            // 
            this.tbxTenNXB.Enabled = false;
            this.tbxTenNXB.Location = new System.Drawing.Point(107, 156);
            this.tbxTenNXB.Name = "tbxTenNXB";
            this.tbxTenNXB.Size = new System.Drawing.Size(155, 20);
            this.tbxTenNXB.TabIndex = 3;
            // 
            // tbxTenCuonSach
            // 
            this.tbxTenCuonSach.Enabled = false;
            this.tbxTenCuonSach.Location = new System.Drawing.Point(107, 116);
            this.tbxTenCuonSach.Name = "tbxTenCuonSach";
            this.tbxTenCuonSach.Size = new System.Drawing.Size(155, 20);
            this.tbxTenCuonSach.TabIndex = 2;
            // 
            // tbxMaCuonSach
            // 
            this.tbxMaCuonSach.Enabled = false;
            this.tbxMaCuonSach.Location = new System.Drawing.Point(107, 76);
            this.tbxMaCuonSach.Name = "tbxMaCuonSach";
            this.tbxMaCuonSach.Size = new System.Drawing.Size(155, 20);
            this.tbxMaCuonSach.TabIndex = 1;
            // 
            // tbxMaDauSach
            // 
            this.tbxMaDauSach.Enabled = false;
            this.tbxMaDauSach.Location = new System.Drawing.Point(107, 38);
            this.tbxMaDauSach.Name = "tbxMaDauSach";
            this.tbxMaDauSach.Size = new System.Drawing.Size(155, 20);
            this.tbxMaDauSach.TabIndex = 0;
            // 
            // frmTraCuuNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUAN_LY_THU_VIEN.Properties.Resources.hinh_nen_form_phu;
            this.ClientSize = new System.Drawing.Size(1061, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTimKiemNC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLoaiSach);
            this.Controls.Add(this.cbbTacGia);
            this.Controls.Add(this.cbbNgonNgu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuNC";
            this.Text = "Tìm kiếm nâng cao";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbNgonNgu;
        private System.Windows.Forms.ComboBox cbbTacGia;
        private System.Windows.Forms.ComboBox cbbLoaiSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Button btnTimKiemNC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxTenKeSach;
        private System.Windows.Forms.TextBox tbxNamXB;
        private System.Windows.Forms.TextBox tbxTenLoaiSach;
        private System.Windows.Forms.TextBox tbxSoTrang;
        private System.Windows.Forms.TextBox tbxChuyenNganh;
        private System.Windows.Forms.TextBox tbxNgonNgu;
        private System.Windows.Forms.TextBox tbxTenNXB;
        private System.Windows.Forms.TextBox tbxTenCuonSach;
        private System.Windows.Forms.TextBox tbxMaCuonSach;
        private System.Windows.Forms.TextBox tbxMaDauSach;
    }
}