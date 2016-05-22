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
    public partial class frmCRPhatNopTre : Form
    {
        public frmCRPhatNopTre()
        {
            InitializeComponent();
        }

        private void frmCRPhatNopTre_Load(object sender, EventArgs e)
        {
            Report.crPhatTreSach ttv = new Report.crPhatTreSach();
            ttv.Refresh();
            CRLePhi.ReportSource = ttv;
            CRLePhi.Refresh();
        }
    }
}
