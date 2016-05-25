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
            if (cbbMaDocGia.Text == "")
            {
                MessageBox.Show("Chưa chọn mã đọc giả để mở khóa !!!");
            }
            else
            {
                using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
                {
                    DataRow row = ((DataRowView)cbbMaDocGia.SelectedItem).Row;
                    string madocgia = row[0].ToString();

                    var thongtindocgiaQuery = from thongtindocgia in db.THONGTINDOCGIAs
                                              where thongtindocgia.MADOCGIA == madocgia
                                              select thongtindocgia;
                    if (thongtindocgiaQuery.Any())
                    {
                        THONGTINDOCGIA ttdg = thongtindocgiaQuery.Single();
                        ttdg.TRANGTHAIDOCGIA = 1;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Đã mở khóa thành công.");
                }
            }
            cbbMaDocGia.DataSource = LayDuLieuMaDG();
            cbbMaDocGia.ValueMember = "MaDocGia";
        }

        private void cbbMaDocGia_TextChanged(object sender, EventArgs e)
        {
            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                DataRow row = ((DataRowView)cbbMaDocGia.SelectedItem).Row;
                string madocgia = row[0].ToString();

                var thongtindocgiaQuery = from thongtindocgia in db.THONGTINDOCGIAs
                                          where thongtindocgia.MADOCGIA == madocgia
                                          select thongtindocgia;
                if (thongtindocgiaQuery.Any())
                {
                    THONGTINDOCGIA ttdg = thongtindocgiaQuery.Single();
                    tbxHoTen.Text = ttdg.TENDOCGIA;
                    tbxNgaySinh.Text = ttdg.NGAYSINH.ToString();
                    tbxSDT.Text = ttdg.SODIENTHOAIDOCGIA;
                }
            }
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
