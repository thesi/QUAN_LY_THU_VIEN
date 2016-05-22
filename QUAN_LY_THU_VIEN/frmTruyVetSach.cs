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
    public partial class frmTruyVetSach : Form
    {
        public frmTruyVetSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = Conn.GetCon();
                string qr = "Select a.tendausach as 'Tên đầu sách', b.ngaynhapsach as 'Ngày nhập sách', b.ngayhuysach as 'Ngày hủy sách', (CASE WHEN b.trangthaimuon = '0' THEN N'Chưa được mượn' WHEN b.trangthaimuon = '1' THEN N'Đã mượn' END) as 'Trạng thái mượn',(CASE WHEN b.trangthaihuy = '0' THEN N'Chưa được hủy' WHEN b.trangthaihuy = '1' THEN N'Đã hủy' END) as 'Trạng thái hủy' from thongtindausach a, thongtincuonsach b where a.madausach = b.madausach and b.macuonsach = '" + tbxMaCS.Text + "'";
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
