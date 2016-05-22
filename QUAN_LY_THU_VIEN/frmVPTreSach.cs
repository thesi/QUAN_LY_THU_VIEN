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
    public partial class frmVPTreSach : Form
    {
        public frmVPTreSach()
        {
            InitializeComponent();
        }
        private void frmVPTreSach_Load(object sender, EventArgs e)
        {
            tbxNgayNop.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            tbxNNop.Text = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
        }

        void ThemMaNP()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(maphinop) from thongtinnopphi";
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
            b = "NP" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into thongtinnopphi(maphinop) values('" + b.ToString() + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
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
                    string sql3 = ("select SOTIENPHATTREMOTNGAY,songaymuontoida from quydinh where maquydinh in ( select maquydinh from nhomdocgia where tennhom = N'" + tbxTenNhom.Text + "')");
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    con.Open();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    if (dr3.Read())
                    {
                        tbxTre.Text = dr3[0].ToString();
                        string ngaymuontoida = dr3[1].ToString();
                        double ngaymuontd = Convert.ToDouble(ngaymuontoida);
                        con.Close();
                        string sql4 = ("select ngaymuon from phieumuontra where madocgia='" + tbxMaDG.Text + "'");
                        SqlCommand cmd4 = new SqlCommand(sql4, con);
                        con.Open();
                        SqlDataReader dr4 = cmd4.ExecuteReader();
                        if (dr4.Read())
                        {
                            tbxNMuon.Text = dr4[0].ToString();
                            tbxNgayMuon.Text = tbxNMuon.Text.Substring(0, 2) + "/" + tbxNMuon.Text.Substring(3, 2) + "/" + tbxNMuon.Text.Substring(6,4);
                            DateTime ngaymuon = new DateTime(Convert.ToInt32(tbxNMuon.Text.Substring(6, 4)), Convert.ToInt32(tbxNMuon.Text.Substring(3, 2)), Convert.ToInt32(tbxNMuon.Text.Substring(0, 2)));
                            DateTime ngayphaitra = ngaymuon.AddDays(ngaymuontd);
                            tbxNgayPhaiTra.Text = ngayphaitra.Day.ToString() + "/" + ngayphaitra.Month.ToString() + "/" + ngayphaitra.Year.ToString();
                            TimeSpan songaytre = DateTime.Now.Subtract(ngayphaitra);
                            tbxNgayTre.Text = Convert.ToInt32(songaytre.TotalDays).ToString();
                            con.Close();
                        }
                        else
                        {
                            tbxNgayPhaiTra.Text = null;
                            tbxNgayTre.Text = null;
                            tbxNMuon.Text = null;
                            tbxNgayMuon.Text = null;
                            con.Close();
                        }
                    }
                    else
                    {
                        tbxTre.Text = null;
                        con.Close();
                    }
                }
                else
                {
                    tbxTenNhom.Text = null;
                    tbxTenDG.Text = null;
                    con.Close();
                }
            }
        }

        private void tbxNgayTre_TextChanged(object sender, EventArgs e)
        {
            if (tbxTre.Text == null || tbxNgayTre.Text == null)
            {
                MessageBox.Show("Nhập mã độc giả để tính tiền phạt !!!");
            }
            else
            {
                string a = tbxNgayTre.Text;
                if (tbxTre.Text != null && a != "" && tbxTre.Text != "" && a != null)
                {
                   int tien = Convert.ToInt32(tbxTre.Text) * Convert.ToInt32(tbxNgayTre.Text);
                   tbxTien.Text = tien.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxTenDG.Text == null)
            {
                MessageBox.Show("Nhập chính xác mã độc giả !!!");
            }
            else
            {
                SqlConnection Con = Conn.GetCon();
                Con.Open();
                ThemMaNP();
                string a = "select max(maphinop) from thongtinnopphi";
                SqlCommand cm = new SqlCommand(a, Con);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.Read())
                {
                    string b = reader.GetValue(0).ToString();
                    SqlCommand cmd1 = new SqlCommand("update thongtinnopphi set madocgia = '" + tbxMaDG.Text + "', ngaynop = '" + tbxNNop.Text + "', phatnoptre = '" + Convert.ToInt32(tbxTien.Text) + "' where maphinop = '" + b + "'", Con);
                    Con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Nộp phí trễ sách thành công");
                    tbxMaDG.Text = null;
                    tbxTenNhom.Text = null;
                    tbxTenDG.Text = null;
                    tbxTien.Text = null;
                    tbxTre.Text = null;
                    tbxNgayTre.Text = null;
                    frmCRPhatNopTre mkk = new frmCRPhatNopTre();
                    mkk.Show();

                }
                else
                {
                    MessageBox.Show("Nộp phí thất bại !!");
                    Con.Close();
                }
            }
        }
    }
}

   
        
