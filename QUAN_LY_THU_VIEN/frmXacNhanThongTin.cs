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
    public partial class frmXacNhanThongTin : Form
    {
        public frmXacNhanThongTin()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            SqlConnection con = Conn.GetCon();
            string sql = ("select tendocgia,manhom,ngaysinh,gioitinh,socmnd from thongtindocgia where madocgia ='" + tbxMaDG.Text + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbxTenDG.Text = dr[0].ToString();
                tbxMaNhom.Text = dr[1].ToString();
                string manhom = dr[1].ToString();
                tbxNSinh.Text = dr[2].ToString();
                if (dr[3].ToString() == "1") tbxGioiTinh.Text = "Nam";
                else tbxGioiTinh.Text = "Nữ";
                tbxCMND.Text = dr[4].ToString();
                string ma = tbxMaDG.Text;
                string link = "C:\\HinhAnh\\" + ma + ".jpg";
                pbxHinh.Image = Image.FromFile(link);
                tbxNgaySinh.Text = tbxNSinh.Text.Substring(3, 2) + "/" + tbxNSinh.Text.Substring(0, 2) + "/" + tbxNSinh.Text.Substring(6, 4);
                con.Close();
                string sql1 = ("select tennhom from nhomdocgia where manhom ='" + manhom + "'");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                con.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                    tbxTenNhom.Text = dr1[0].ToString();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã độc giã này !!!");
                groupBox1.Visible = false;
            }
        }
    }
}
