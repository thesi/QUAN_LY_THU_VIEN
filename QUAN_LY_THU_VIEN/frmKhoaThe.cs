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
    public partial class frmKhoaThe : Form
    {
        public frmKhoaThe()
        {
            InitializeComponent();
        }
        public DataTable LayDuLieuMaDG()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select MaDocGia from ThongTinDocGia where TrangThaiDocGia = 1";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }

        private void cbbMaDocGia_MouseClick(object sender, MouseEventArgs e)
        {
            cbbMaDocGia.DataSource = LayDuLieuMaDG();
            cbbMaDocGia.ValueMember = "MaDocGia";
        }

        private void btnChuyenNhom_Click(object sender, EventArgs e)
        {
            if (cbbMaDocGia.Text == "")
            {
                MessageBox.Show("Chưa chọn mã đọc giả để khóa !!!");
            }
            else
            {
                SqlConnection Con = Conn.GetCon();
                DataSet ds = new DataSet();
                SqlCommand cmd2 = new SqlCommand("update ThongTinDocGia set TrangThaiDocGia = 0 where madocgia = '"+ cbbMaDocGia.Text.ToString() +"'", Con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(ds);
                MessageBox.Show("Đã khóa tài khoản của đọc giả : " + cbbMaDocGia.Text.ToString());
            }
        }

        private void cbbMaDocGia_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = @"select
                               thongtindocgia.tendocgia,thongtindocgia.ngaysinh, thongtindocgia.sodienthoaidocgia 
                         from
                                thongtindocgia
                        where 
                              thongtindocgia.madocgia = '" + cbbMaDocGia.Text + "'";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();

            string ten = "";
            string ngaysinh = "";
            string sdt = "";
            while (reader.Read())
            {
                ten = reader.GetValue(0).ToString();
                ngaysinh = reader.GetValue(1).ToString();
                sdt = reader.GetValue(2).ToString();
            }

            reader.Close();
            Con.Close();

            tbxHoTen.Text = "" + ten;
            tbxNgaySinh.Text = "" + ngaysinh;
            tbxSDT.Text = "" + sdt;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
