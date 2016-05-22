namespace QUAN_LY_THU_VIEN
{
    partial class frmCRTheThuVien
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
            this.CRTheThuVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbxMaDocGia = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CRTheThuVien
            // 
            this.CRTheThuVien.ActiveViewIndex = -1;
            this.CRTheThuVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRTheThuVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRTheThuVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRTheThuVien.Location = new System.Drawing.Point(0, 0);
            this.CRTheThuVien.Name = "CRTheThuVien";
            this.CRTheThuVien.Size = new System.Drawing.Size(725, 506);
            this.CRTheThuVien.TabIndex = 0;
            // 
            // tbxMaDocGia
            // 
            this.tbxMaDocGia.Enabled = false;
            this.tbxMaDocGia.Location = new System.Drawing.Point(95, 65);
            this.tbxMaDocGia.Name = "tbxMaDocGia";
            this.tbxMaDocGia.Size = new System.Drawing.Size(100, 20);
            this.tbxMaDocGia.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(58, 134);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Độc Giả";
            // 
            // frmCRTheThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxMaDocGia);
            this.Controls.Add(this.CRTheThuVien);
            this.Name = "frmCRTheThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTheThuVien";
            this.Load += new System.EventHandler(this.frmTheThuVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRTheThuVien;
        private System.Windows.Forms.TextBox tbxMaDocGia;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;


    }
}