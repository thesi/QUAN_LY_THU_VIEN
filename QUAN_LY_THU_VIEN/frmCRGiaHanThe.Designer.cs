namespace QUAN_LY_THU_VIEN
{
    partial class frmCRGiaHanThe
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
            this.CRLePhi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRLePhi
            // 
            this.CRLePhi.ActiveViewIndex = -1;
            this.CRLePhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRLePhi.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRLePhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRLePhi.Location = new System.Drawing.Point(0, 0);
            this.CRLePhi.Name = "CRLePhi";
            this.CRLePhi.Size = new System.Drawing.Size(284, 262);
            this.CRLePhi.TabIndex = 0;
            // 
            // frmCRGiaHanThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CRLePhi);
            this.Name = "frmCRGiaHanThe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCRGiaHanThe";
            this.Load += new System.EventHandler(this.frmCRGiaHanThe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRLePhi;
    }
}