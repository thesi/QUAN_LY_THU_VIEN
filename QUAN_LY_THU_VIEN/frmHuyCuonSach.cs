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
    public partial class frmHuyCuonSach : Form
    {
        public frmHuyCuonSach()
        {
            InitializeComponent();
        }

        private void tbxMaCS_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = Conn.GetCon();
            string sql = ("select tendausach,maisbn,madausach from thongtindausach where madausach = any(select madausach from thongtincuonsach where macuonsach ='" + tbxMaCS.Text + "')");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbxTenDS.Text = dr[0].ToString();
                tbxISBN.Text = dr[1].ToString();
                string a = dr[2].ToString();
                con.Close();
                string sql1 = ("select tentacgia from thongtintacgia where matacgia = any(select matacgia from thongtindausach where madausach  ='" + a + "')");
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            con.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                tbxTenTG.Text = dr1[0].ToString();
                con.Close();
            }
            else
            {
                tbxTenTG.Text = null;
                con.Close();
            }
            }
            else
            {
                tbxTenDS.Text = null;
                tbxISBN.Text = null;
                tbxTenTG.Text = null;
                con.Close();
            }
        }

        private void frmHuyCuonSach_Load(object sender, EventArgs e)
        {
            tbxNgayHuy.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            tbxNHuy.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy cuốn sách này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                SqlConnection Con = Conn.GetCon();
                SqlCommand cmd1 = new SqlCommand("select tranthaihuy from thongtincuonsach where Macuonsach = '" + tbxMaCS.Text + "'", Con);
                Con.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    if (dr1[0].ToString() == "0")
                    {
                        Con.Close();
                        SqlCommand cmd = new SqlCommand("update thongtincuonsach set trangthaihuy = 1 where Macuonsach = '" + tbxMaCS.Text + "'", Con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        MessageBox.Show("Đã hủy cuốn sách thành công !!!");
                    }
                    else
                    {
                        MessageBox.Show("Cuốn sách này đã được hủy !!!");

                    }
                }
                else Con.Close();
            }
        }
    }
}
