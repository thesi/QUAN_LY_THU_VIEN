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
    public partial class frmLapPhieuMuon : Form
    {
        public frmLapPhieuMuon()
        {
            InitializeComponent();
        }

        public DataTable LayDuLieu1()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select Macuonsach from thongtincuonsach where madausach = '"+ tbxMaDS.Text +"' and trangthaimuon = 0 and trangthaihuy = 0 ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }

        void ThemMaPM()
        {

            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(MAPHIEU) from phieumuontra ";
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
            b = "PM" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into phieumuontra(maphieu,madocgia,manhanvien) values('" + b.ToString() + "','" + tbxMaDG.Text + "','" + label11.Text + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);

        }

        void ShowMaPM()
        {

            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(MAPHIEU) from phieumuontra ";
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
            tbxMaPhieu.Text = "PM" + f + e;            
        }

        private void tbxMaDG_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = Conn.GetCon();
            string sql = ("select tendocgia from thongtindocgia where madocgia='" + tbxMaDG.Text + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbxTenDG.Text = dr[0].ToString();
                con.Close();
                string sql2 = ("select tennhom from nhomdocgia where manhom in ( select manhom from thongtindocgia where madocgia ='" + tbxMaDG.Text + "')");
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                con.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    tbxTenNhom.Text = dr2[0].ToString();
                    con.Close();
                    string sql3 = ("select SOSACHMUONTOIDA,songaymuontoida from quydinh where maquydinh in ( select maquydinh from nhomdocgia where tennhom = N'" + tbxTenNhom.Text + "')");
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    con.Open();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    if (dr3.Read())
                    {
                        tbxSoSach.Text = dr3[0].ToString();
                        string a = dr3[1].ToString();
                        double b = Convert.ToDouble(a);
                        con.Close();
                        DateTime ngaytra = DateTime.Now.AddDays(b);
                        tbxNgayPhaiTra.Text = ngaytra.Day.ToString() + "/" + ngaytra.Month.ToString() + "/" + ngaytra.Year.ToString();
                    }
                    else
                    {
                        con.Close();
                        tbxSoSach.Text = null;
                        tbxNgayPhaiTra = null;
                    }
                }
                else
                {
                    con.Close();
                    tbxTenNhom.Text = null;
                }
               
            }
            else
            {
                tbxTenDG.Text = null;
                tbxTenNhom.Text = null;
                tbxSoSach.Text = null;
                con.Close();
            }
            string sql1 = ("select tinhtrang from phieumuontra where madocgia = '"+tbxMaDG.Text+"'");
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            con.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                if (dr1[0].ToString() == "0")
                {
                    con.Close();
                    label8.Visible = true;
                    btnMuon.Enabled = false;
                }
                else
                {
                    con.Close();
                    label8.Visible = false;
                    btnMuon.Enabled = true;
                    
                }
            }
            else
            {
                label8.Visible = false;
                btnMuon.Enabled = true;
            }

        }

        private void tbxMaDS_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = Conn.GetCon();
            string sql = ("select tendausach from thongtindausach where madausach = '" + tbxMaDS.Text + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbxTenCS.Text = dr[0].ToString();
                cbbMaCS.DataSource = LayDuLieu1();
                cbbMaCS.ValueMember = "MaCuonSach";
                if (cbbMaCS.SelectedValue == null)
                {
                    MessageBox.Show("Đầu sách không còn sách để mượn !!");
                    btnMuon.Enabled = false;
                }
                btnMuon.Enabled = true;
                con.Close();
            }
            else
            {
                tbxTenCS.Text = null;
                con.Close();
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbxSoSach.Text != null && lbxMaSM.Items.Count > int.Parse(tbxSoSach.Text))
            {
                MessageBox.Show("Không được mượn quá số sách quy định !!!");
            }
            else
            {
                bool coroi = false;
                for (int a = 0; a < lbxTenSM.Items.Count; a++)
                {
                    if (lbxTenSM.Items[a].ToString() == tbxTenCS.Text) coroi = true;
                }
                if (coroi == false && tbxTenCS.Text != null)
                {
                    lbxTenSM.Items.Add(tbxTenCS.Text);
                    lbxMaSM.Items.Add(cbbMaCS.SelectedValue);
                }
                if (coroi) MessageBox.Show("Sách đã mượn rồi !!!");
                if (tbxTenCS.Text == null) MessageBox.Show("Kiểm tra lại mã sách chưa đúng !!!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {

            SqlConnection con = Conn.GetCon();
            string sql = ("select manhanvien from nhanvien where mataikhoan in (select mataikhoan from dangnhap where tendangnhap ='" + label10.Text + "')");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label11.Text = dr[0].ToString();
            }
            else label11.Text = null;
            con.Close();
            if (tbxMaDG.Text == null || tbxMaDS.Text == null || label11.Text == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để tiếp tục !!");
            }
            else
            {
                ThemMaPM();
                string sql1 = ("update phieumuontra set ngaymuon = '"+ tbxNMuon.Text +"' where maphieu = '" + tbxMaPhieu.Text + "'");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                con.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                con.Close();

                for (int i = 0; i < lbxMaSM.Items.Count; i++)
                    {
                        string sql2 = ("insert into thongtinsachmuon(maphieu,macuonsach) values('" + tbxMaPhieu.Text + "','" + lbxMaSM.Items[i].ToString() + "')");
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        con.Open();
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        con.Close();
                        string sql3 = ("update thongtincuonsach set trangthaimuon = 1 where macuonsach = '" + lbxMaSM.Items[i].ToString() + "'");
                        SqlCommand cmd3 = new SqlCommand(sql3, con);
                        con.Open();
                        SqlDataReader dr3 = cmd3.ExecuteReader();
                        con.Close();
                    }
               MessageBox.Show("Thành công !!!");
            }

        }

        private void frmLapPhieuMuon_Load(object sender, EventArgs e)
        {

            label10.Text = frmMain.bientoancuc.bienxy;
            ShowMaPM();
            tbxNgayMuon.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            tbxNMuon.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lbxMaSM.Items.Clear();
            lbxTenSM.Items.Clear();
            tbxMaDS.Text = null;
            tbxMaDG.Text = null;

        }
    }


}
