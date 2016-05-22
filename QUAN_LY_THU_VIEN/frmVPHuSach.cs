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
    public partial class frmVPHuSach : Form
    {
        public frmVPHuSach()
        {
            InitializeComponent();
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
                    string sql3 = ("select SOTIENPHATLAMHUSACH from quydinh where maquydinh in ( select maquydinh from nhomdocgia where tennhom = N'" + tbxTenNhom.Text + "')");
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    con.Open();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    if (dr3.Read())
                    {
                        tbxHu.Text = dr3[0].ToString();
                        con.Close();
                    }
                    else
                    {
                        tbxHu.Text = null;
                        con.Close();
                    }
                }
            }
        }

        private void frmVPHuSach_Load(object sender, EventArgs e)
        {
            tbxNgayNop.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            tbxNNop.Text = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxMaCS_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = Conn.GetCon();
            string sql = ("select giabia from thongtindausach where madausach in (select madausach from thongtincuonsach where macuonsach ='" + tbxMaCS.Text + "')");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbxGiaBia.Text = dr[0].ToString();
                con.Close();
            }
                
                    else
                    {
                        tbxGiaBia.Text = null;
                        con.Close();
                    }
                
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxTenDG.Text == null || tbxTien.Text == null || tbxTenDG.Text ==  "" || tbxTien.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin để nộp phạt !!!");
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
                    SqlCommand cmd1 = new SqlCommand("update thongtinnopphi set madocgia = '" + tbxMaDG.Text + "', ngaynop = '" + tbxNNop.Text + "', phathusach = '" + Convert.ToInt32(tbxTien.Text) + "' where maphinop = '" + b + "'", Con);
                    Con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Nộp phí hư sách thành công");
                    tbxMaDG.Text = null;
                    tbxTenNhom.Text = null;
                    tbxTenDG.Text = null;
                    tbxMaCS.Text = null;
                    tbxGiaBia.Text = null;
                    tbxTien.Text = null;
                    tbxHu.Text = null;
                    frmCRPhatHuSach mkk = new frmCRPhatHuSach();
                    mkk.Show();

                }
                else
                {
                    MessageBox.Show("Nộp phí thất bại !!");
                    Con.Close();
                }
            }
        }

        private void tbxHu_TextChanged(object sender, EventArgs e)
        {
            if (tbxHu.Text == null || tbxGiaBia.Text == null || tbxHu.Text == "" || tbxGiaBia.Text == "")
            {
            }
            else
            {
                int tien = Convert.ToInt32(tbxHu.Text) + Convert.ToInt32(tbxGiaBia.Text);
                tbxTien.Text = tien.ToString();
            }
        }

        private void tbxGiaBia_TextChanged(object sender, EventArgs e)
        {
            if (tbxHu.Text == null || tbxGiaBia.Text == null || tbxHu.Text == "" || tbxGiaBia.Text == "")
            {
                
            }
            else
            {
                int tien = Convert.ToInt32(tbxHu.Text) + Convert.ToInt32(tbxGiaBia.Text);
                tbxTien.Text = tien.ToString();
            }
        }
    }
}
