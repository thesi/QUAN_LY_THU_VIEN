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
    public partial class frmTruyVet : Form
    {
        public frmTruyVet()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = Conn.GetCon();
                string qr = "Select distinct ttdg.MADOCGIA, ttdg.TENDOCGIA, ttdg.NGAYSINH,pmt.MAPHIEU,pmt.NGAYMUON,pmt.NGAYTRA,ttcs.MACUONSACH,ttds.TENDAUSACH From (((THONGTINDOCGIA ttdg inner join PHIEUMUONTRA pmt on ttdg.MADOCGIA = pmt.MADOCGIA) Inner Join THONGTINSACHMUON ttsm on ttsm.MAPHIEU = pmt.MAPHIEU) Inner Join THONGTINCUONSACH ttcs on ttcs.MACUONSACH = ttsm.MACUONSACH) Inner Join THONGTINDAUSACH ttds on ttds.MADAUSACH = ttcs.MADAUSACH Where ttdg.MADOCGIA = '"+ tbxMaDG.Text +"'";
                SqlCommand cmd5 = new SqlCommand(qr, Con);
                SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                DataSet ds5 = new DataSet();
                da5.Fill(ds5);
                dataGridView1.DataSource = ds5.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
