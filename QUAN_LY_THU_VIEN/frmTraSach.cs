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
    public partial class frmTraSach : Form
    {
        public frmTraSach()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = Conn.GetCon();
            string sql = ("select maphieu,ngaymuon from phieumuontra where madocgia='" + tbxMaDG.Text + "' and tinhtrang = 0");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbxMaPhieu.Text = dr[0].ToString();
                tbxNMuon.Text = dr[1].ToString();
                string a = dr[1].ToString();
                con.Close();
                tbxNgayMuon.Text = tbxNMuon.Text.Substring(0, 2) + "/" + tbxNMuon.Text.Substring(3, 2) + "/" + tbxNMuon.Text.Substring(6, 4);
                label8.Visible = false;
                string sql3 = ("select songaymuontoida from quydinh where maquydinh in ( select maquydinh from nhomdocgia where manhom in (select manhom from thongtindocgia where madocgia = '" + tbxMaDG.Text + "'))");
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    con.Open();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    if (dr3.Read())
                    {
                        string ngaymuontoida = dr3[0].ToString();
                        double ngaymuontd = Convert.ToDouble(ngaymuontoida);
                        DateTime ngaymuon = new DateTime(Convert.ToInt32(tbxNMuon.Text.Substring(6, 4)), Convert.ToInt32(tbxNMuon.Text.Substring(3, 2)), Convert.ToInt32(tbxNMuon.Text.Substring(0, 2)));
                        DateTime ngayphaitra = ngaymuon.AddDays(ngaymuontd);
                        tbxNgayPhaiTra.Text = ngayphaitra.Day.ToString() + "/" + ngayphaitra.Month.ToString() + "/" + ngayphaitra.Year.ToString();
                    }
                    else
                    {
                        tbxNgayPhaiTra = null;
                        con.Close();
                    }
                tbxNgayTra.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                tbxNTra.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
                btnDanhSach.Enabled = true;
            }
            else
            {
                tbxMaPhieu.Text = null;
                tbxNgayMuon.Text = null;
                tbxNgayPhaiTra.Text = null;
                tbxNgayTra.Text = null;
                btnDanhSach.Enabled = false;
                con.Close();
            }
            
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conn.GetCon();
            string sql = ("select macuonsach from thongtinsachmuon where maphieu='" + tbxMaPhieu.Text + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbxMaSach.Items.Add(dr[0]);
            }
            con.Close();
            for (int i = 0; i < lbxMaSach.Items.Count; i++)
            {
                string sql1 = ("select tendausach from thongtindausach where madausach in ( select madausach from thongtincuonsach where macuonsach ='" + lbxMaSach.Items[i].ToString() + "')");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                con.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    lbxDanhSach.Items.Add(lbxMaSach.Items[i].ToString() + " - " + dr1[0]);
                }
                con.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbxMaDG.Text = null;
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conn.GetCon();
            string sql = ("update phieumuontra set ngaytra = '" + tbxNTra.Text + "', tinhtrang = 1 where maphieu = '" + tbxMaPhieu.Text + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
                con.Close();
                for (int i = 0; i < lbxMaSach.Items.Count; i++)
                {
                    
                    string sql3 = ("update thongtincuonsach set trangthaimuon = 0 where macuonsach = '" + lbxMaSach.Items[i].ToString() + "'");
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    con.Open();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    con.Close();
                }
                MessageBox.Show("Trả sách thành công !!!");
                tbxMaDG.Text = null;
        }
    }
}
