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
            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                DataRow row = ((DataRowView) cbbMaDocGia.SelectedItem).Row;
                String madocgia = row[0].ToString();
                var chuyennhomQuery = from nhomdocgia in db.NHOMDOCGIAs
                    join thongtindocgia in db.THONGTINDOCGIAs
                        on nhomdocgia.MANHOM equals thongtindocgia.MANHOM
                    where thongtindocgia.MADOCGIA == madocgia
                                      select new
                    {
                        nhomdocgia.TENNHOM, thongtindocgia.TENDOCGIA, thongtindocgia.NGAYSINH, thongtindocgia.SODIENTHOAIDOCGIA
                    };
                var obj = chuyennhomQuery.Single();
                   
                tbxTenNhom.Text = obj.TENNHOM;
                tbxHoTen.Text = obj.TENDOCGIA;
                tbxNgaySinh.Text = obj.NGAYSINH.ToString();
                tbxSDT.Text = obj.SODIENTHOAIDOCGIA;
            }
            cbbTenNhomChuyen.Enabled = true;
        }

        private void cbbTenNhomChuyen_MouseClick(object sender, MouseEventArgs e)
        {
            cbbTenNhomChuyen.DataSource = LayDuLieuNhom();
            cbbTenNhomChuyen.ValueMember = "TenNhom";
        }

        private void btnChuyenNhom_Click(object sender, EventArgs e)
        {
            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                var manhomQuery = from nhomdocgia in db.NHOMDOCGIAs
                    where nhomdocgia.TENNHOM == cbbTenNhomChuyen.Text
                    select nhomdocgia.MANHOM;
                string manhom = manhomQuery.Single();

                var thongtindocgiaQuery = from thongtindocgia in db.THONGTINDOCGIAs
                    where thongtindocgia.MADOCGIA == cbbMaDocGia.Text
                    select thongtindocgia;
                THONGTINDOCGIA ttdgCapnhat = thongtindocgiaQuery.Single();
                ttdgCapnhat.MANHOM = manhom;
                db.SaveChanges();
            }

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
