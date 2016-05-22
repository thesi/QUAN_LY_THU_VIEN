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
    public partial class frmCRMatKhau : Form
    {
        public frmCRMatKhau()
        {
            InitializeComponent();
        }

        private void frmCRMatKhau_Load(object sender, EventArgs e)
        {
            Report.crMatKhau ttv = new Report.crMatKhau();
            ttv.Refresh();
            CRMatKhau.ReportSource = ttv;
            CRMatKhau.Refresh();
        }
    }
}
