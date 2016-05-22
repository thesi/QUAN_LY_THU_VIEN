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
    public partial class frmCRThongKe : Form
    {
        public frmCRThongKe()
        {
            InitializeComponent();
        }

        private void frmCRThongKe_Load(object sender, EventArgs e)
        {
            Report.crThongKe ttv = new Report.crThongKe();
            ttv.Refresh();
            CRThongKe.ReportSource = ttv;
            CRThongKe.Refresh();
        }
    }
}
