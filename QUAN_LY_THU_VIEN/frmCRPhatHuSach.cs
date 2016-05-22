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
    public partial class frmCRPhatHuSach : Form
    {
        public frmCRPhatHuSach()
        {
            InitializeComponent();
        }

        private void frmCRPhatHuSach_Load(object sender, EventArgs e)
        {
            Report.crPhatHuSach ttv = new Report.crPhatHuSach();
            ttv.Refresh();
            CRLePhi.ReportSource = ttv;
            CRLePhi.Refresh();
        }
    }
}
