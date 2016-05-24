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
    public partial class frmGopYDocGia : Form
    {
        public frmGopYDocGia()
        {
            InitializeComponent();
        }

        private void frmGopYDocGia_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmMain.bientoancuc.bienxy;

            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                var thongtindocgiaQuery = from thongtindocgia in db.THONGTINDOCGIAs
                    join dangnhap in db.DANGNHAPs on thongtindocgia.MATAIKHOAN equals dangnhap.MATAIKHOAN
                    where dangnhap.TENDANGNHAP == lblUser.Text
                    select new {thongtindocgia.TENDOCGIA, thongtindocgia.MADOCGIA};
                var obj = thongtindocgiaQuery.Single();

                lblMaDocGia.Text = obj.MADOCGIA;
                lblTenDocGia.Text = obj.TENDOCGIA;
            }

            
/*            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = @"select thongtindocgia.madocgia, thongtindocgia.TenDocGia from ThongTinDocGia, DangNhap
                        where thongtindocgia.mataikhoan = dangnhap.mataikhoan and dangnhap.tendangnhap = '" + lblUser.Text.ToString() + "'";
            SqlCommand cmd1 = new SqlCommand(a, Con);
            SqlDataReader reader = cmd1.ExecuteReader();
            string b = "";
            string d = "";
            while (reader.Read())
            {
                b = reader.GetValue(0).ToString();
                d = reader.GetValue(1).ToString();
            }
            Con.Close();
            lblMaDocGia.Text = b.ToString();
            lblTenDocGia.Text = d.ToString();*/
        }
        string ThemMaGopY()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(maGOPY) from GOPYDOCGIA";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            Con.Close();
            string c = "";
            int d;
            string e = "";
            string f = "";
            for (int i = 2; i < b.Length; i++)
            {
                c += b[i].ToString();
            }
            d = Convert.ToInt32(c) + 1;
            e = Convert.ToString(d);
            for (int j = 0; j < (c.Length - e.Length); j++)
            {
                f += c[j].ToString();
            }
            b = "GY" + f + e;
            return b;
        }
        private void btnGopY_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            ThemMaGopY();
            SqlCommand cmd = new SqlCommand("update GopYDocGia set MaDocGia = '"+ lblMaDocGia.Text +"', NoiDung = '"+ tbxGopY.Text +"', tieude = '"+ tbxTieuDe.Text+"', email = '"+ tbxEmail.Text +"' where magopy = (select max(magopy) from gopydocgia)", Con);
            
            DataSet dataSet1 = new DataSet();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            dar.Fill(dataSet1);
            MessageBox.Show("Đã gửi thành công. Cám ơn Độc Giả đã quan tâm.");
            this.Close();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
