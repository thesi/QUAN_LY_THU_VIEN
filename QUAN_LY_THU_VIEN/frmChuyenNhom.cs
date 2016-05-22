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
    public partial class frmChuyenNhom : Form
    {
        public frmChuyenNhom()
        {
            InitializeComponent();
        }
        public DataTable LayDuLieuMaDG()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select Madocgia from thongtindocgia ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        public DataTable LayDuLieuNhom()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select tennhom from nhomdocgia where manhom <> any (select manhom from thongtindocgia where madocgia = '"+ cbbMaDocGia.Text +"')";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        private void frmChuyenNhom_Load(object sender, EventArgs e)
        {
            cbbMaDocGia.DataSource = LayDuLieuMaDG();
            cbbMaDocGia.ValueMember = "MaDocGia";
        
        }

        private void cbbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbMaDocGia_TextChanged(object sender, EventArgs e)
        {
           
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = @"select
                                nhomdocgia.tennhom, thongtindocgia.tendocgia,thongtindocgia.ngaysinh, thongtindocgia.sodienthoaidocgia 
                         from nhomdocgia,thongtindocgia
                        where nhomdocgia.manhom = thongtindocgia.manhom 
                              and thongtindocgia.madocgia = '"+ cbbMaDocGia.Text +"'";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            string nhom = "";
            string ten = "";
            string ngaysinh = "";
            string sdt = "";
            while (reader.Read())
            {
                nhom = reader.GetValue(0).ToString();
                ten = reader.GetValue(1).ToString();
                ngaysinh = reader.GetValue(2).ToString();
                sdt = reader.GetValue(3).ToString();
            }
            
            reader.Close();
            Con.Close();
            tbxTenNhom.Text = "" + nhom;
            tbxHoTen.Text = "" + ten;
            tbxNgaySinh.Text = "" + ngaysinh;
            tbxSDT.Text = "" + sdt;

            cbbTenNhomChuyen.Enabled = true;
        }

        private void cbbMaDocGia_MouseClick(object sender, MouseEventArgs e)
        {
            
           
        }

        private void cbbTenNhomChuyen_MouseClick(object sender, MouseEventArgs e)
        {
            cbbTenNhomChuyen.DataSource = LayDuLieuNhom();
            cbbTenNhomChuyen.ValueMember = "TenNhom";
        }

        private void btnChuyenNhom_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select manhom from nhomdocgia where tennhom =N'"+cbbTenNhomChuyen.Text.ToString()+"'";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            reader.Close();
            
            SqlCommand cmd1 = new SqlCommand("update thongtindocgia set Manhom = '"+ b +"' where madocgia = '"+ cbbMaDocGia.Text.ToString() +"' ", Con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            MessageBox.Show("Đã chuyển thành công.");
            this.Close();
        }

        private void cbbMaDocGia_MouseLeave(object sender, EventArgs e)
        {

          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
