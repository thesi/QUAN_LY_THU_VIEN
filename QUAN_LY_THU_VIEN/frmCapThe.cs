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
    public partial class frmCapThe : Form
    {
        public frmCapThe()
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ThemMaDocGia()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(madocgia) from ThongtinDOcGia";
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
            b = "DG" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into ThongTinDocGia(MaDocGia,Manhom) values('" + b.ToString() + "','NH000001')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
        public DataTable LayDuLieu1()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select TenNhom from NhomDocGia ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        void ThemMaTaiKhoan()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(mataikhoan) from DangNhap";
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
            b = "TK" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into DangNhap(MaTaiKhoan) values('" + b.ToString() + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
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
        
        private void btnCapThe_Click(object sender, EventArgs e)
        {
            if (tbxHoTen.Text == "" || tbxSDT.Text == "" || tbxDiaChi.Text == "" || tbxNoiCongTac.Text == "" || cbbTDHV.Text == "" || tbxCMND.Text == "" || tbxNgaySinh.Text == "" )
            {
                MessageBox.Show("Chưa nhập đủ thông tin !!!");
            }
            else
            {
                SqlConnection Con = Conn.GetCon();
                Con.Open();
                ThemMaDocGia();
                int GioiTinh = 0;
                if (rbtnNam.Checked)
                {
                    GioiTinh = 1;
                }
                else
                    GioiTinh = 0;
                string ngaydk = "";
                 ngaydk = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
                int NamHH = Convert.ToInt32(DateTime.Now.Year) + 1;
                string ngayhh = "";
                ngayhh = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + NamHH.ToString();
                string aa = "select manhom from nhomdocgia where tennhom = N'"+ cbbChonNhom.Text.ToString() +"'";
                SqlCommand cmddd = new SqlCommand(aa, Con);
                SqlDataReader reader1 = cmddd.ExecuteReader();
                reader1.Read();
                string bb = reader1.GetValue(0).ToString();
                reader1.Close();
                SqlCommand cmd = new SqlCommand("update ThongTinDOcGia set TenDocGia = N'" + tbxHoTen.Text + "', TrinhDoHOcVan = N'" + cbbTDHV.Text.ToString()+ "', SoDienThoaiDocGia = '" + Convert.ToInt32(tbxSDT.Text) + "', NoiCongTac = '" + tbxNoiCongTac.Text.ToString() + "', nghenghiep = '" + tbxNgheNghiep.Text.ToString() + "',  DiaChiDocGia = N'" + tbxDiaChi.Text + "',SoCMND = '" + Convert.ToInt32(tbxCMND.Text) + "',  GioiTinh = '" + GioiTinh + "',  NgayDangKy = '" + ngaydk + "', NgayHetHan = '" + ngayhh + "', NgaySinh = '" + tbxNgaySinh.Text.ToString() + "', trangthaidocgia = 1, manhom = '"+ bb.ToString() +"' where MaDocGia = (select Max(MaDocGia) from ThongTinDocGia)", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ThemMaNopPhi();
                string a = "select lephicapthe from quydinh where maquydinh in(select maquydinh from nhomdocgia where tennhom = N'"+cbbChonNhom.Text.ToString()+"')";
                SqlCommand cmdd = new SqlCommand(a, Con);
                SqlDataReader reader = cmdd.ExecuteReader();
                reader.Read();
                string b = reader.GetValue(0).ToString();
                reader.Close();
                string a1 = "select max(maphinop) from thongtinnopphi";
                SqlCommand cmdd1 = new SqlCommand(a1, Con);
                SqlDataReader reader11 = cmdd1.ExecuteReader();
                reader11.Read();
                string b1 = reader11.GetValue(0).ToString();
                reader11.Close();
                SqlCommand cmd1 = new SqlCommand(@"update thongtinnopphi set MaDocGia = (select max(Madocgia)
                        from thongtindocgia), phicapthe = '" + Convert.ToInt32(lblPhiNhom.Text) + "',PHIDINHKY = '"+ Convert.ToInt32(b) +"', ngaynop = '"+ ngaydk +"', phatnoptre = 0, phatmatsach = 0, phathusach = 0 where maphinop ='" + b1 + "' ", Con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                ThemMaTaiKhoan();
                Form x = new frmThemTaiKhoan();
                x.Show();
              //  MessageBox.Show("Thêm thành công");
        
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            tbxNgaySinh.Text = dtpNgaySinh.Value.Month + "/" + dtpNgaySinh.Value.Day + "/" + dtpNgaySinh.Value.Year;
        }

        private void cbbChonNhom_MouseClick(object sender, MouseEventArgs e)
        {
            cbbChonNhom.DataSource = LayDuLieu1();
            cbbChonNhom.ValueMember = "TenNhom";
        
        }

        private void cbbChonNhom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbChonNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                var lephicaptheQuery = from quydinh in db.QUYDINHs
                    join nhomdocgia in db.NHOMDOCGIAs on quydinh.MAQUYDINH equals nhomdocgia.MAQUYDINH 
                    select  quydinh.LEPHICAPTHE;
                if (lephicaptheQuery.Any())
                {
                    lblPhiNhom.Text = lephicaptheQuery.First().ToString();
                }
                else lblPhiNhom.Text = "0";
            }
        }
    }
}
