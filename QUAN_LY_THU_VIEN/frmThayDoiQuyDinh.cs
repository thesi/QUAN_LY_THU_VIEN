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
    public partial class frmThayDoiQuyDinh : Form
    {
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
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

        private void cbbTenNhom_MouseClick(object sender, MouseEventArgs e)
        {
            cbbTenNhom.DataSource = LayDuLieu1();
            cbbTenNhom.ValueMember = "TenNhom";
        }

        private void cbbTenNhom_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select lephigiahan,lephicapthe,songaymuontoida,sosachmuontoida,sotienphattremotngay,sotienphatlamhusach,sotienphatlammatsach from quydinh where maquydinh in (select maquydinh from nhomdocgia where tennhom = N'" + cbbTenNhom.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbxGiaHan.Text = reader[0].ToString();
                tbxCapThe.Text = reader[1].ToString();
                tbxNgay.Text = reader[2].ToString();
                tbxSach.Text = reader[3].ToString();
                tbxTre.Text = reader[4].ToString();
                tbxHu.Text = reader[5].ToString();
                tbxMat.Text = reader[6].ToString();
                Con.Close();
            }
            else
            {
                tbxGiaHan.Text = null;
                tbxCapThe.Text = null;
                tbxNgay.Text = null;
                tbxSach.Text = null;
                tbxTre.Text = null;
                tbxHu.Text = null;
                tbxMat.Text = null;
                Con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "update quydinh set lephigiahan = '" + Convert.ToInt32(tbxGiaHan.Text) + "',lephicapthe= '" + Convert.ToInt32(tbxCapThe.Text) + "',songaymuontoida= '" + Convert.ToInt32(tbxNgay.Text) + "',sosachmuontoida= '" + Convert.ToInt32(tbxSach.Text) + "',sotienphattremotngay= '" + Convert.ToInt32(tbxTre.Text) + "',sotienphatlamhusach= '" + Convert.ToInt32(tbxHu.Text) + "',sotienphatlammatsach= '" + Convert.ToInt32(tbxMat.Text) + "' from quydinh where maquydinh in (select maquydinh from nhomdocgia where tennhom = N'" + cbbTenNhom.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            Con.Close();
            MessageBox.Show("Đã hoàn tất cập nhật quy định !!!");
            tbxGiaHan.Text = null;
            tbxCapThe.Text = null;
            tbxNgay.Text = null;
            tbxSach.Text = null;
            tbxTre.Text = null;
            tbxHu.Text = null;
            tbxMat.Text = null;
        }
    }
}
