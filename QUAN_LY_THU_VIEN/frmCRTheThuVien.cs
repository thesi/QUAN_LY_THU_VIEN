using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUAN_LY_THU_VIEN
{
    public partial class frmCRTheThuVien : Form
    {
        public frmCRTheThuVien()
        {
            InitializeComponent();
        }
        public class BienMaDocGia
        {
            public static string MaDocGia;
        }
        private void frmTheThuVien_Load(object sender, EventArgs e)
        {
            tbxMaDocGia.Text = BienMaDocGia.MaDocGia;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            SqlCommand cmd = new SqlCommand(@"SELECT * from view_thethuvien where madocgia = '" + tbxMaDocGia.Text + "'", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            Report.crTheThuVien ttv = new Report.crTheThuVien();
            ttv.SetDataSource(ds.Tables[0]);
            ttv.Refresh();
            CRTheThuVien.ReportSource = ttv;
            CRTheThuVien.Refresh();
        }

    }
}
