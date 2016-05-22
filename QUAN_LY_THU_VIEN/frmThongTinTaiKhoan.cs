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
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
            label1.Text = frmMain.bientoancuc.bienxy;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int QuyenTruyCap()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            int quyen = 0;
            string a = "select quyentruycap from dangnhap where tendangnhap = '" + label1.Text.ToString() + "'";
            SqlCommand cmd1 = new SqlCommand(a, Con);
            SqlDataReader reader = cmd1.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            quyen = Convert.ToInt32(b);
            return quyen;
        }
        public void ThongTinDocGia()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
           
          
            if (QuyenTruyCap() == 4 )
            {
                SqlCommand cmd = new SqlCommand("select * from ThongTinDocGia where MaTaiKhoan = any(select Mataikhoan from dangnhap where tendangnhap = '" + label1.Text.ToString() + "' )", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                string ma = ds.Rows[0][0].ToString();
                string link = "C:\\HinhAnh\\"+ma+".jpg";
                pictureBox1.Image = Image.FromFile(link);
                tbxHoTen.Text = ds.Rows[0][2].ToString();
                if (ds.Rows[0][3].ToString() == "1")
                {
                    tbxGioiTinh.Text = "Nam";
                }
                else
                    if (ds.Rows[0][3].ToString() == "0")
                    {
                        tbxGioiTinh.Text = "Nữ";
                    }

                tbxNgaySinh.Text = ds.Rows[0][4].ToString();
                tbxTrinhDo.Text = ds.Rows[0][5].ToString();
                tbxCMND.Text = ds.Rows[0][6].ToString();
                tbxNgheNghiep.Text = ds.Rows[0][7].ToString();
                tbxNoiCongTac.Text = ds.Rows[0][8].ToString();
                tbxSDT.Text = ds.Rows[0][9].ToString();
                tbxDiaChi.Text = ds.Rows[0][10].ToString();
                tbxNDK.Text = ds.Rows[0][11].ToString();
                tbxNHH.Text = ds.Rows[0][12].ToString();
                lblMaNhom.Text = ds.Rows[0][1].ToString();

                string a = "select tennhom from NhomDocGia where MaNhom = '" + lblMaNhom.Text.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(a, Con);
                SqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                string b = reader.GetValue(0).ToString();
                tbxNhom.Text = b;

                lblBoPhan.Visible = false;
                
                lblTrinhDo.Visible = true;
                tbxTrinhDo.Visible = true;
                lblNDK.Visible = true;
                tbxNDK.Visible = true;
                lblNHH.Visible = true;
                tbxNHH.Visible = true;
               
                lblNgheNghiep.Visible = true;
                tbxNgheNghiep.Visible = true;
                
                lblNoiCongTac.Visible = true;
                tbxNoiCongTac.Visible = true;
                lblThuocNhom.Visible = true;
                tbxNhom.Visible = true;
            }
            else
            {
                if (QuyenTruyCap() == 1 || QuyenTruyCap() == 0 || QuyenTruyCap() == 2 || QuyenTruyCap() == 3)
                {
                    SqlCommand cmd = new SqlCommand("select * from NhanVien where MaTaiKhoan = any(select Mataikhoan from dangnhap where tendangnhap = '" + label1.Text.ToString() + "')", Con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    string ma = ds.Rows[0][0].ToString();
                    string link = "C:\\HinhAnh\\" + ma + ".jpg";
                    pictureBox1.Image = Image.FromFile(link);
                    tbxHoTen.Text = ds.Rows[0][2].ToString();
                    if (ds.Rows[0][6].ToString() == "1")
                    {
                        tbxGioiTinh.Text = "Nam";
                    }
                    else
                        if (ds.Rows[0][6].ToString() == "0")
                        {
                            tbxGioiTinh.Text = "Nữ";
                        }
                    tbxSDT.Text = ds.Rows[0][3].ToString();
                    tbxDiaChi.Text = ds.Rows[0][4].ToString();
                    tbxNgaySinh.Text = ds.Rows[0][7].ToString();
                    tbxCMND.Text = ds.Rows[0][8].ToString();
                    lblMaNhom.Text = ds.Rows[0][1].ToString();

                    string a = "select tenbophan from Bophan where MaBoPhan = '" + lblMaNhom.Text.ToString() + "'";
                    SqlCommand cmd1 = new SqlCommand(a, Con);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    reader.Read();
                    string b = reader.GetValue(0).ToString();
                    lblBoPhan.Text = b;

                    lblBoPhan.Visible = true;
                    
                    lblTrinhDo.Visible = false;
                    tbxTrinhDo.Visible = false;
                    lblNDK.Visible = false;
                    tbxNDK.Visible = false;
                    lblNHH.Visible = false;
                    tbxNHH.Visible = false;
                    
                    lblNgheNghiep.Visible = false;
                    tbxNgheNghiep.Visible = false;
                    
                    lblNoiCongTac.Visible = false;
                    tbxNoiCongTac.Visible = false;
                    lblThuocNhom.Visible = false;
                    tbxNhom.Visible = false;
                }
            }
        }

        private void frmThongTinDocGia_Load(object sender, EventArgs e)
        {
            ThongTinDocGia();
        }

        private void blMaNhom_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
           DataSet ds2 = new DataSet();
           if (QuyenTruyCap() == 4)
           {
               
                       SqlCommand cmd1 = new SqlCommand("update thongtindocgia set NoiCongTac =N'" + tbxNoiCongTac.Text.ToString() + "' where Mataikhoan = any (select mataikhoan from dangnhap where tendangnhap = '"+ label1.Text.ToString() +"')", Con);
                       SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                       da1.Fill(ds2);
                   
                   
                       SqlCommand cmd2 = new SqlCommand("update thongtindocgia set DIaChiDocGia =N'" + tbxDiaChi.Text.ToString() + "'where Mataikhoan = any (select mataikhoan from dangnhap where tendangnhap = '"+ label1.Text.ToString() +"')", Con);
                       SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                       da2.Fill(ds2);
                   
                       SqlCommand cmd3 = new SqlCommand("update thongtindocgia set NgheNghiep =N'" + tbxNgheNghiep.Text.ToString() + "'where Mataikhoan = any (select mataikhoan from dangnhap where tendangnhap = '"+ label1.Text.ToString() +"')", Con);
                       SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                       da3.Fill(ds2);
                       SqlCommand cmd4 = new SqlCommand("update thongtindocgia set SoDienThoaiDocGia = '" + tbxSDT.Text.ToString() + "'where Mataikhoan = any (select mataikhoan from dangnhap where tendangnhap = '"+ label1.Text.ToString() +"')", Con);
                       SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                       da4.Fill(ds2);
                       SqlCommand cmd5 = new SqlCommand("update thongtindocgia set TrinhDoHocVan =N'" + tbxTrinhDo.Text.ToString() + "'where Mataikhoan = any (select mataikhoan from dangnhap where tendangnhap = '"+ label1.Text.ToString() +"')", Con);
                       SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                       da5.Fill(ds2);
                       MessageBox.Show("Thay đổi thông tin thành công.");
                   ThongTinDocGia();
               
           }
           else
               
               { 
                 
                       SqlCommand cmd2 = new SqlCommand("update NhanVien set DiaChiNhanVien =N'" + tbxDiaChi.Text.ToString() + "'where Mataikhoan = any (select mataikhoan from dangnhap where tendangnhap = '"+ label1.Text.ToString() +"')", Con);
                       SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                       da2.Fill(ds2);
                  
                   
                  
                       SqlCommand cmd4 = new SqlCommand("update thongtindocgia set SoDienThoaiDocGia = '" + tbxSDT.Text.ToString() + "'where Mataikhoan = any (select mataikhoan from dangnhap where tendangnhap = '"+ label1.Text.ToString() +"')", Con);
                       SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                       da4.Fill(ds2);
                       MessageBox.Show("Thay đổi thông tin thành công.");
                   
                   ThongTinDocGia();
               
               
               }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Form tt = new frmDoiMatKhau();
            tt.Show();
        }
        
    }
}
