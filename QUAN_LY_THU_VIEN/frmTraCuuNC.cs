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
    public partial class frmTraCuuNC : Form
    {
        public frmTraCuuNC()
        {
            InitializeComponent();
        }
        public DataTable LayDuLieuNgonNgu()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select tenngonngu from ngonngu ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        public DataTable LayDuLieuLoaiSach()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select TenLoaiddc from ThongTinloaisach ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        public DataTable LayDuLieuTacGia()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select tentacgia from thongtintacgia ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }


        private void dgvTimKiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTimKiem.Rows[e.RowIndex];


                tbxMaDauSach.Text = row.Cells[0].Value.ToString();
                tbxMaCuonSach.Text = row.Cells[1].Value.ToString();
                tbxTenCuonSach.Text = row.Cells[2].Value.ToString();
                tbxTenNXB.Text = row.Cells[4].Value.ToString();
                tbxNamXB.Text = row.Cells[5].Value.ToString();
                tbxNgonNgu.Text = row.Cells[6].Value.ToString();
                tbxChuyenNganh.Text = row.Cells[7].Value.ToString();
                tbxSoTrang.Text = row.Cells[8].Value.ToString();
                tbxTenLoaiSach.Text = row.Cells[9].Value.ToString();
                tbxTenKeSach.Text = row.Cells[10].Value.ToString();
                SqlConnection Con = Conn.GetCon();
                Con.Open();
                string aa = "select TrangThaiHuy from ThongTinCuonSach where Macuonsach = '" + tbxMaCuonSach.Text.ToString() + "'";
                SqlCommand cmd11 = new SqlCommand(aa, Con);
                SqlDataReader reader1 = cmd11.ExecuteReader();
                reader1.Read();
                string bb = reader1.GetValue(0).ToString();
                reader1.Close();
                if (bb == "1")
                {
                    lblTrangThai.Text = "Đã Hủy.";
                }
                else
                {

                    string a = "select TrangThaiMuon from ThongTinCuonSach where Macuonsach = '" + tbxMaCuonSach.Text.ToString() + "'";
                    SqlCommand cmd1 = new SqlCommand(a, Con);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    reader.Read();
                    string b = reader.GetValue(0).ToString();
                    if (b == "0")
                    {
                        lblTrangThai.Text = "Còn Sách.";
                    }
                    else
                        lblTrangThai.Text = "Đã mượn.";
                    reader.Close();
                    //dgvTenTacGia.DataSource = ds1.Tables[0];       
                }
            }
            catch { MessageBox.Show("Click đúng Vị trí !"); }
        
            }

        private void cbbNgonNgu_Click(object sender, EventArgs e)
        {
            cbbNgonNgu.DataSource = LayDuLieuNgonNgu();
            cbbNgonNgu.ValueMember = "TenNgonNgu";
        
        }

        private void cbbLoaiSach_Click(object sender, EventArgs e)
        {
            cbbLoaiSach.DataSource = LayDuLieuLoaiSach();
            cbbLoaiSach.ValueMember = "TenLoaiddc";
        
        }

        private void cbbTacGia_Click(object sender, EventArgs e)
        {
            cbbTacGia.DataSource = LayDuLieuTacGia();
            cbbTacGia.ValueMember = "TenTacGia";
        
        }

        private void cbbNgonNgu_TextChanged(object sender, EventArgs e)
        {
                    
        }

        private void btnTimKiemNC_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string sql = @" select  distinct
                                                    thongtindausach.madausach as 'Mã Đầu Sách' ,
                                                    thongtincuonsach.macuonsach as 'Mã Cuốn Sách',
                                                    thongtindausach.tendausach as 'Tên Đầu Sách',
                                                    thongtindausach.MAISBN as 'Mã ISBN',
                                                    thongtinnhaxuatban.tennhaxuatban as 'Tên Nhà Xuất Bản',
                                                    thongtindausach.namxuatban as 'Năm Xuất Bản',
                                                    ngonngu.tenngonngu as 'Ngôn Ngữ',
                                                    thongtintacgia.tentacgia as 'Tác Giả',
                                                    thongtindausach.sotrang as 'Số Trang',
                                                    thongtinloaisach.tenloaiddc as 'Tên Loại Sách',
                                                    thongtinkesach.tenke as 'Tên Kệ Sách' 
                                                    from
                                                    thongtindausach,thongtincuonsach,ngonngu,thongtinkesach,thongtinloaisach,thongtinnhaxuatban,thongtintacgia
                                                    where
                                                    thongtincuonsach.madausach = thongtindausach.madausach
                                                    and thongtindausach.mangonngu = ngonngu.mangonngu
                                                    and thongtindausach.manhaxuatban = thongtinnhaxuatban.manhaxuatban
                                                    and thongtindausach.maloaiddc = thongtinloaisach.maloaiddc
                                                    and thongtindausach.make = thongtinkesach.make
                                                    and thongtindausach.matacgia = thongtintacgia.matacgia"; 
                                                    
            if (cbbNgonNgu.Text != "")
            {
                sql += " and ngonngu.tenngonngu = N'" + cbbNgonNgu.Text.ToString() + "'";
            }
            if (cbbLoaiSach.Text != "")
            {
                sql += " and THongTinLoaiSach.tenloaiddc =N'" + cbbLoaiSach.Text.ToString() + "'";
            }
            if (cbbTacGia.Text != "")
            {
                sql += " and ThongTinTacGia.tentacgia =N'" + cbbTacGia.Text.ToString() + "'";
            }

            SqlCommand cmd1 = new SqlCommand(sql, Con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dgvTimKiem.DataSource = ds1.Tables[0]; 
        }
    }
}
