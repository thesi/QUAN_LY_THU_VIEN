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
    public partial class frmCRPhatMatSach : Form
    {
        public frmCRPhatMatSach()
        {
            InitializeComponent();
        }

        private void frmCRPhatMatSach_Load(object sender, EventArgs e)
        {
            Report.crPhatMatSach ttv = new Report.crPhatMatSach();
            ttv.Refresh();
            CRLePhi.ReportSource = ttv;
            CRLePhi.Refresh();
        }
    }
}
