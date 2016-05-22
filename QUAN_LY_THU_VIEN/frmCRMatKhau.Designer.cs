namespace QUAN_LY_THU_VIEN
{
    partial class frmCRMatKhau
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
            this.CRMatKhau = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRMatKhau
            // 
            this.CRMatKhau.ActiveViewIndex = -1;
            this.CRMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRMatKhau.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRMatKhau.Location = new System.Drawing.Point(0, 0);
            this.CRMatKhau.Name = "CRMatKhau";
            this.CRMatKhau.Size = new System.Drawing.Size(284, 262);
            this.CRMatKhau.TabIndex = 0;
            // 
            // frmCRMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CRMatKhau);
            this.Name = "frmCRMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCRMatKhau";
            this.Load += new System.EventHandler(this.frmCRMatKhau_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRMatKhau;
    }
}