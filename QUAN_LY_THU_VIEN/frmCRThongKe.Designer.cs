namespace QUAN_LY_THU_VIEN
{
    partial class frmCRThongKe
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
            this.CRThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRThongKe
            // 
            this.CRThongKe.ActiveViewIndex = -1;
            this.CRThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRThongKe.Location = new System.Drawing.Point(0, 0);
            this.CRThongKe.Name = "CRThongKe";
            this.CRThongKe.Size = new System.Drawing.Size(596, 450);
            this.CRThongKe.TabIndex = 0;
            // 
            // frmCRThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.CRThongKe);
            this.Name = "frmCRThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCRThongKe";
            this.Load += new System.EventHandler(this.frmCRThongKe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRThongKe;
    }
}