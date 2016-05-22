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
            str = str.Substring(0, 2);
            return str;
        }
        public string Get_Month()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(3, 2);
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
           /* SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a2 = "select NGAYHETHANQD from thongtindocgia where madocgia = '" + cbbMaDocGia.Text.ToString() + "'";
            SqlCommand cmd2 = new SqlCommand(a2, Con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();
            string b2 = reader2.GetValue(1).ToString();
            reader2.Close();
            Con.Close();
            tbxNgayHetHan.Text = "" + b2;
            */
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select ngayhethan from thongtindocgia where madocgia = all( select madocgia from thongtindocgia where madocgia = '"+ cbbMaDocGia.Text.ToString() +"')";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            reader.Close();
            
            tbxNgayHetHan.Text = "" + b;

            
            Con.Close();
            
        }

       
        private void cbbNamGiaHan_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select lephigiahan from quydinh where maquydinh = all( select maquydinh from nhomdocgia where manhom = all (select manhom from thongtindocgia where madocgia = '" + cbbMaDocGia.Text.ToString() + "'))";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            int phi = Convert.ToInt32(b) * Convert.ToInt32(cbbNamGiaHan.Text);
            tbxPhi.Text =""+ phi.ToString();
            string str = tbxNgayHetHan.Text.ToString().Trim();
            str = str.Substring(6, 4);
            string day = tbxNgayHetHan.Text.ToString().Trim();
            day = day.Substring (0, 2);
            string month = tbxNgayHetHan.Text.ToString().Trim();
            month = month.Substring(3, 2);
            int year = Convert.ToInt32(str) + Convert.ToInt32(cbbNamGiaHan.Text);
            string hanmoi = month+"-"+day+"-" + year.ToString(); 
            MessageBox.Show("Thẻ được sử dụng tới : "+hanmoi +" Nhấn gia hạn để tiếp tục ");
        }
        void ThemMaNopPhi()
        {
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
            b = "NP" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into thongtinnopphi(maphinop) values('" + b.ToString() + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            ThemMaNopPhi();
            string a = "select mataikhoan from thongtindocgia where madocgia = '" + cbbMaDocGia.Text.ToString() + "'";
            SqlCommand cm = new SqlCommand(a, Con);
            SqlDataReader reader = cm.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            reader.Close();
            string ngaydk = Get_Month() + "-" + Get_Day() + "-" + Get_Year();
            SqlCommand cmd = new SqlCommand("update ThongTinnopphi set phidinhky = '"+ tbxPhi.Text +"', madocgia ='"+ cbbMaDocGia.Text +"', phicapthe = 0, phatnoptre = 0, phathusach = 0, phatmatsach = 0, ngaynop = '"+ ngaydk +"'", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);    
            DataSet ds = new DataSet();
            da.Fill(ds);
            string str = tbxNgayHetHan.Text.ToString().Trim();
            str = str.Substring(6, 4);
            string day = tbxNgayHetHan.Text.ToString().Trim();
            day = day.Substring(0, 2);
            string month = tbxNgayHetHan.Text.ToString().Trim();
            month = month.Substring(3, 2);
            int year = Convert.ToInt32(str) + Convert.ToInt32(cbbNamGiaHan.Text);
            string hanmoi = month + "-" + day + "-" + year.ToString(); 
            SqlCommand cmd1 = new SqlCommand("update ThongTinDOcGia set ngayhethan = '" + hanmoi + "', trangthaidocgia = 1 where madocgia = '"+ cbbMaDocGia.Text.ToString() +"'", Con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            MessageBox.Show("Gia hạn thành công .");
            this.Close();
            frmCRGiaHanThe tt = new frmCRGiaHanThe();
            tt.Show();
            
        }

        private void cbbMaDocGia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            if (cbbNamGiaHan.Text != "")
            {
                string aa = "select lephigiahan from quydinh where maquydinh in ( select maquydinh from nhomdocgia where manhom in (select manhom from thongtindocgia where madocgia = '" + cbbMaDocGia.Text.ToString() + "'))";

                SqlCommand cmd1 = new SqlCommand(aa, Con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                reader1.Read();
                string bb = reader1.GetValue(0).ToString();

                int phi = Convert.ToInt32(bb) * Convert.ToInt32(cbbNamGiaHan.Text);
                tbxPhi.Text = "" + phi.ToString();

            }
            else
            {
                string aa = "select lephigiahan from quydinh where maquydinh in ( select maquydinh from nhomdocgia where manhom in (select manhom from thongtindocgia where madocgia = '" + cbbMaDocGia.Text.ToString() + "'))";

                SqlCommand cmd1 = new SqlCommand(aa, Con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                reader1.Read();
                string bb = reader1.GetValue(0).ToString();
                tbxPhi.Text = "" + bb.ToString();

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
