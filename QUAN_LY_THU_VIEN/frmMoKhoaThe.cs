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
    public partial class frmMoKhoaThe : Form
    {
        public frmMoKhoaThe()
        {
            InitializeComponent();
        }
        public DataTable LayDuLieuMaDG()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select Madocgia from thongtindocgia where trangthaidocgia = 0 ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        private void frmMoKhoaThe_Load(object sender, EventArgs e)
        {
            cbbMaDocGia.DataSource = LayDuLieuMaDG();
            cbbMaDocGia.ValueMember = "MaDocGia";
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd1 = new SqlCommand("update thongtindocgia set trangthaidocgia = '1' where madocgia = '"+ cbbMaDocGia.Text.ToString() +"' ", Con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            MessageBox.Show("Đã mở khóa thành công.");
            this.Close();
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

        private void cbbMaDocGia_Click(object sender, EventArgs e)
        {
            if (cbbMaDocGia.Text == "")
            {
                MessageBox.Show("Hiện tại không có thẻ nào bị khóa !");

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
