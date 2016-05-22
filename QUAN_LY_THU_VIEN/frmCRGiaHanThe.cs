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
    public partial class frmCRGiaHanThe : Form
    {
        public frmCRGiaHanThe()
        {
            InitializeComponent();
        }

        private void frmCRGiaHanThe_Load(object sender, EventArgs e)
        {
            
            Report.crPhiGiaHanThe ttv = new Report.crPhiGiaHanThe();
            ttv.Refresh();
            CRLePhi.ReportSource = ttv;
            CRLePhi.Refresh();
        }
    }
}
