using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUAN_LY_THU_VIEN
{
    public partial class frmCRPhiCapThe : Form
    {
        public frmCRPhiCapThe()
        {
            InitializeComponent();
        }
        
        private void frmPhiCapThe_Load(object sender, EventArgs e)
        {
            Report.crPhiCapThe ttv = new Report.crPhiCapThe();
            ttv.Refresh();
            CRLePhi.ReportSource = ttv;
            CRLePhi.Refresh();
        }
    }
}
