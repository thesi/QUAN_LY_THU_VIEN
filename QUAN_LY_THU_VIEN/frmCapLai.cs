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
    public partial class frmCapLai : Form
    {

        public frmCapLai()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using (QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities())
            {
                var ttdgQuery = from ttdg in db.THONGTINDOCGIAs where ttdg.MADOCGIA == tbxMaDG.Text select ttdg;
                if (ttdgQuery.Any())
                {
                    THONGTINDOCGIA objThongtindocgia = ttdgQuery.Single();
                    tbxTenDG.Text = objThongtindocgia.TENDOCGIA;
                    tbxMaNhom.Text = objThongtindocgia.MANHOM;
                    string manhom = objThongtindocgia.MANHOM;
                    tbxNSinh.Text = objThongtindocgia.NGAYSINH.ToString();
                    if (objThongtindocgia.GIOITINH.ToString() == "1")
                        tbxGioiTinh.Text = "Nam";
                    else
                        tbxGioiTinh.Text = "Nu";
                    tbxCMND.Text = objThongtindocgia.SOCMND.ToString();
                    string ma = tbxMaDG.Text;
                    string link = ".\\HinhAnh\\nguoidung.jpg";
                    pbxHinh.Image = Image.FromFile(link);
                    tbxNgaySinh.Text = tbxNSinh.Text.Substring(3, 2) + "/" + tbxNSinh.Text.Substring(0, 2) + "/" +
                                       tbxNSinh.Text.Substring(6, 4);

                    var tennhomQuery = from nhom in db.NHOMDOCGIAs where nhom.MANHOM == manhom select nhom.TENNHOM;
                    tbxTenNhom.Text = tennhomQuery.Single().ToString();
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã độc giã này !!!");
                }
            }
        }

        private void btnCapLai_Click(object sender, EventArgs e)
        {
            frmCRTheThuVien.BienMaDocGia.MaDocGia = tbxMaDG.Text;
            frmCRTheThuVien thetv = new frmCRTheThuVien();
            thetv.Show();
        }
    }
}
