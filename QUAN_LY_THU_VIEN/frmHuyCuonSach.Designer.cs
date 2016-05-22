namespace QUAN_LY_THU_VIEN
{
    partial class frmHuyCuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHuyCuonSach));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMaCS = new System.Windows.Forms.TextBox();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNgayHuy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTenTG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTenDS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNHuy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(201, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hủy sách";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã cuốn sách";
            // 
            // tbxMaCS
            // 
            this.tbxMaCS.Location = new System.Drawing.Point(124, 46);
            this.tbxMaCS.Name = "tbxMaCS";
            this.tbxMaCS.Size = new System.Drawing.Size(100, 20);
            this.tbxMaCS.TabIndex = 2;
            this.tbxMaCS.TextChanged += new System.EventHandler(this.tbxMaCS_TextChanged);
            // 
            // tbxISBN
            // 
            this.tbxISBN.Enabled = false;
            this.tbxISBN.Location = new System.Drawing.Point(124, 182);
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(100, 20);
            this.tbxISBN.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã ISBN";
            // 
            // tbxNgayHuy
            // 
            this.tbxNgayHuy.Enabled = false;
            this.tbxNgayHuy.Location = new System.Drawing.Point(124, 228);
            this.tbxNgayHuy.Name = "tbxNgayHuy";
            this.tbxNgayHuy.Size = new System.Drawing.Size(100, 20);
            this.tbxNgayHuy.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày hủy";
            // 
            // tbxTenTG
            // 
            this.tbxTenTG.Enabled = false;
            this.tbxTenTG.Location = new System.Drawing.Point(124, 134);
            this.tbxTenTG.Name = "tbxTenTG";
            this.tbxTenTG.Size = new System.Drawing.Size(100, 20);
            this.tbxTenTG.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tác giả";
            // 
            // tbxTenDS
            // 
            this.tbxTenDS.Enabled = false;
            this.tbxTenDS.Location = new System.Drawing.Point(124, 90);
            this.tbxTenDS.Name = "tbxTenDS";
            this.tbxTenDS.Size = new System.Drawing.Size(100, 20);
            this.tbxTenDS.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên đầu sách";
            // 
            // button2
            // 
            this.button2.Image = global::QUAN_LY_THU_VIEN.Properties.Resources._1364801780_button_cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(308, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thoát";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hủy cuốn sách";
            // 
            // tbxNHuy
            // 
            this.tbxNHuy.Location = new System.Drawing.Point(37, 282);
            this.tbxNHuy.Name = "tbxNHuy";
            this.tbxNHuy.Size = new System.Drawing.Size(100, 20);
            this.tbxNHuy.TabIndex = 13;
            this.tbxNHuy.Visible = false;
            // 
            // frmHuyCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 349);
            this.Controls.Add(this.tbxNHuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxTenDS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxTenTG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNgayHuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMaCS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHuyCuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hủy cuốn sách";
            this.Load += new System.EventHandler(this.frmHuyCuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMaCS;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNgayHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTenTG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTenDS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNHuy;
    }
}