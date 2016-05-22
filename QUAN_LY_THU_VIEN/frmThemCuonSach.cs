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
    public partial class frmThemCuonSach : Form
    {
        public frmThemCuonSach()
        {
            InitializeComponent();
        }

        void ShowMaCS()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(macuonsach) from thongtincuonsach";
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
            b = "CS" + f + e;
            tbxMaCS.Text = b;
        }
        void ThemMaNN()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(macuonsach) from thongtincuonsach";
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
            b = "CS" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into thongtincuonsach(macuonsach,madausach) values('" + b.ToString() + "','"+tbxMaDS.Text+"')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void tbxMaDS_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = Conn.GetCon();
            string sql = ("select tendausach,matacgia,maisbn from thongtindausach where madausach ='" + tbxMaDS.Text + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                tbxTenDS.Text = dr[0].ToString();
                tbxISBN.Text = dr[2].ToString();
                string a = dr[1].ToString();
                con.Close();
                string sql1 = ("select tentacgia from thongtintacgia where matacgia ='" + a + "'");
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            con.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                tbxTG.Text = dr1[0].ToString();
                con.Close();
            }
            else
            {
                con.Close();
            }

            }
            else
            {
                tbxTenDS.Text = null;
                tbxISBN.Text = null;
                tbxTG.Text = null;
                con.Close();
            }
        }

        private void frmThemCuonSach_Load(object sender, EventArgs e)
        {
            ShowMaCS();
            tbxNgayNhap.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            tbxNNhap.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
                    ThemMaNN();
                    string a = "select max(macuonsach) from thongtincuonsach";
                    SqlCommand cm = new SqlCommand(a, Con);
                    SqlDataReader reader = cm.ExecuteReader();
                    reader.Read();
                    string b = reader.GetValue(0).ToString();
                    reader.Close();
                    SqlCommand cmd1 = new SqlCommand("update thongtincuonsach set ngaynhapsach = '" + tbxNNhap.Text + "' where macuonsach = '" + b + "'", Con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Thêm thành công");
            tbxTenDS.Text = null;
                tbxISBN.Text = null;
                tbxTG.Text = null;
                    ShowMaCS();
                }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
}

