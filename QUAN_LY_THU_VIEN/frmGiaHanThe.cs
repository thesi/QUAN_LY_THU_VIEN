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
    public partial class frmGiaHanThe : Form
    {
        public frmGiaHanThe()
        {
            InitializeComponent();
        }
        public string Get_Day()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(3, 2);
            return str;
        }
        public string Get_Month()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 2);
            return str;
        }
        public string Get_Year()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(6, 4);
            return str;
        }
        public DataTable LayDuLieuMaDG()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select Madocgia from thongtindocgia ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        private void frmGiaHanThe_Load(object sender, EventArgs e)
        {
            cbbMaDocGia.DataSource = LayDuLieuMaDG();
            cbbMaDocGia.ValueMember = "MaDocGia";
        
        }

        private void cbbMaDocGia_TextChanged(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)cbbMaDocGia.SelectedItem).Row;
            string madocgia = row[0].ToString();

            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                var ngayhethanQuery = from thongtindocgia in db.THONGTINDOCGIAs
                    where thongtindocgia.MADOCGIA == madocgia
                    select thongtindocgia.NGAYHETHAN;

                tbxNgayHetHan.Text = ngayhethanQuery.Single().ToString();
            }
        }

       
        private void cbbNamGiaHan_TextChanged(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)cbbMaDocGia.SelectedItem).Row;
            string madocgia = row[0].ToString();

            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                var lephigiahanQuery = from thongtindocgia in db.THONGTINDOCGIAs join nhomdocgia in db.NHOMDOCGIAs 
                                      on thongtindocgia.MANHOM equals nhomdocgia.MANHOM
                                      join quydinh in db.QUYDINHs on nhomdocgia.MAQUYDINH equals quydinh.MAQUYDINH
                                      where thongtindocgia.MADOCGIA == madocgia
                                      select quydinh.LEPHIGIAHAN;

                
                string b = lephigiahanQuery.Single().ToString();
                int phi = Convert.ToInt32(b) * Convert.ToInt32(cbbNamGiaHan.Text);
                tbxPhi.Text = "" + phi.ToString();
                string str = tbxNgayHetHan.Text.ToString().Trim();
                str = str.Substring(6, 4);
                string day = tbxNgayHetHan.Text.ToString().Trim();
                day = day.Substring(3, 2);
                string month = tbxNgayHetHan.Text.ToString().Trim();
                month = month.Substring(0, 2);
                int year = Convert.ToInt32(str) + Convert.ToInt32(cbbNamGiaHan.Text);
                string hanmoi = month + "-" + day + "-" + year.ToString();
                MessageBox.Show("Thẻ được sử dụng tới : " + hanmoi + " Nhấn gia hạn để tiếp tục ");
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)cbbMaDocGia.SelectedItem).Row;
            string madocgia = row[0].ToString();

            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(maphinop) from ThongTinNopPhi";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            Con.Close();
            string c = "";
            int d = 0;
            string e1 = "";
            string f = "";
            for (int i = 2; i < b.Length; i++)
            {
                c += b[i].ToString();
            }
            d = Convert.ToInt32(c) + 1;
            e1 = Convert.ToString(d);
            for (int j = 0; j < (c.Length - e1.Length); j++)
            {
                f += c[j].ToString();
            }
            b = "NP" + f + e1;

            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                //var thongtinnopphiQuery = from thongtinnopphi in db.THONGTINNOPPHIs
                THONGTINNOPPHI thongtinnopphi = new THONGTINNOPPHI();
                thongtinnopphi.PHIDINHKY = int.Parse(tbxPhi.Text);
                thongtinnopphi.MADOCGIA = madocgia;
                thongtinnopphi.PHICAPTHE = 0;
                thongtinnopphi.PHATNOPTRE = 0;
                thongtinnopphi.PHATHUSACH = 0;
                thongtinnopphi.PHATMATSACH = 0;
                thongtinnopphi.NGAYNOP = DateTime.Now;
                thongtinnopphi.MAPHINOP = b;
                db.THONGTINNOPPHIs.Add(thongtinnopphi);

                db.SaveChanges();

                string str = tbxNgayHetHan.Text.ToString().Trim();
                str = str.Substring(6, 4);
                string day = tbxNgayHetHan.Text.ToString().Trim();
                day = day.Substring(3, 2);
                string month = tbxNgayHetHan.Text.ToString().Trim();
                month = month.Substring(0, 2);
                int year = Convert.ToInt32(str) + Convert.ToInt32(cbbNamGiaHan.Text);
                string hanmoi = month + "-" + day + "-" + year.ToString();

                var ngayhethanQuery = from thongtindocgia in db.THONGTINDOCGIAs
                    where thongtindocgia.MADOCGIA == madocgia
                    select thongtindocgia;
                var ngayhethanObj = ngayhethanQuery.First();
                ngayhethanObj.NGAYHETHAN = DateTime.Parse(hanmoi);
                ngayhethanObj.TRANGTHAIDOCGIA = 1;

                db.SaveChanges();

                MessageBox.Show("Gia hạn thành công .");
                this.Close();
                frmCRGiaHanThe tt = new frmCRGiaHanThe();
                tt.Show();
            }            
        }

        private void cbbMaDocGia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)cbbMaDocGia.SelectedItem).Row;
            string madocgia = row[0].ToString();

            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                var lephigiahanQuery = from thongtindocgia in db.THONGTINDOCGIAs
                                       join nhomdocgia in db.NHOMDOCGIAs on thongtindocgia.MANHOM equals nhomdocgia.MANHOM
                                       join quydinh in db.QUYDINHs on nhomdocgia.MAQUYDINH equals quydinh.MAQUYDINH
                                       where thongtindocgia.MADOCGIA == madocgia
                                       select quydinh.LEPHIGIAHAN;
                int lephigiahan = Convert.ToInt32(lephigiahanQuery.Single().ToString());
                if (cbbNamGiaHan.Text != "")
                    lephigiahan *= Convert.ToInt32(cbbNamGiaHan.Text);
                tbxPhi.Text = "" + lephigiahan.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
