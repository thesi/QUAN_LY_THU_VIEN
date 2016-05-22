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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            HideAll();
        }

        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }

        public void DanhSachTK()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select MATAIKHOAN as 'Mã Tài Khoản', TENDANGNHAP as'Tên truy cập', (CASE WHEN QUYENTRUYCAP = '0'THEN N'Quản lý hệ thống' WHEN QUYENTRUYCAP = '1'THEN N'Quản lý thẻ' WHEN QUYENTRUYCAP = '2' THEN N'Quản lý độc giả' WHEN QUYENTRUYCAP = '3' THEN N'Quản lý sách' WHEN QUYENTRUYCAP = '4'THEN N'Độc giả' END) as 'Quyền' from DANGNHAP", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvDanhSach.DataSource = ds.Tables[0];
            //Con.Close();
        }
        // Hàm xử lý
            #region
       
        public void HideAll()
        {
            gbxThemTK.Hide();
            gbxTimKiem.Hide();
            gbxTTTK.Hide();
        }
        public void ClearGbxThemTK()
        {
            ShowMaTK();
            tbxTTenDN.Clear();
            cbbTQuyen.Text = null;
        }
        public void ClearGbxSuaTK()
        {
            tbxSuaMK.Text = null;
            tbxSuaTen.Text = null;
            cbbSQuyen.Text = null;
        }
        void ShowMaTK()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(MATAIKHOAN) from DANGNHAP";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            Con.Close();
            string c = "";
            int d;
            string e = "";
            string f = "";
            for (int i = 2; i < b.Length; i++)
            {
                c += b[i].ToString();
            }
            d = Convert.ToInt32(c) + 1;
            e = Convert.ToString(d);
            for (int j = 0; j < (c.Length - e.Length); j++)
            {
                f += c[j].ToString();
            }
            b = "TK" + f + e;
            tbxTMaTK.Text = b;
 
        }
        void ThemMaTK()
        {

            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(MATAIKHOAN) from DANGNHAP";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            Con.Close();
            string c = "";
            int d;
            string e = "";
            string f = "";
            for (int i = 2; i < b.Length; i++)
            {
                c += b[i].ToString();
            }
            d = Convert.ToInt32(c) + 1;
            e = Convert.ToString(d);
            for (int j = 0; j < (c.Length - e.Length); j++)
            {
                f += c[j].ToString();
            }
            b = "TK" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into DANGNHAP(MATAIKHOAN) values('" + b.ToString() + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);

        }


        public void ThemTK()
        {
            SqlConnection Con = Conn.GetCon();
            ThemMaTK();
            string pass = TaoMK(6);
                SqlCommand cmd1 = new SqlCommand("update DANGNHAP set TENDANGNHAP = N'" + tbxTTenDN.Text + "',matkhau ='"+ md5(pass) + "', QUYENTRUYCAP = '" + cbbTQuyen.SelectedIndex + "' WHERE MATAIKHOAN = (select max(MATAIKHOAN) from DANGNHAP) ", Con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                //da1.Fill(ds);
                da2.Fill(ds);
                MessageBox.Show(String.Format("Thành công !! Mật khẩu của tài khoản là: {0}",  pass));
                if (dgvDanhSach.Visible == true)
                { 
                    DanhSachTK();
                }
        }

        public string TaoMK(int length)
        {
            string valid = "abcdefghijklmnopqrstuvwxyz1234567890";
            string res = "";
            Random rnd = new Random();
            while (0 < length--)
                res += valid[rnd.Next(valid.Length)];
            return res;
        }

        #endregion





        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            HideAll();
            dgvDanhSach.Visible = true;
            DanhSachTK();
            gbxTTTK.Show();
        }

        private void dgvDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HideAll();
            gbxTTTK.Show();
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDanhSach.Rows[e.RowIndex];
            lbMaTK.Text = row.Cells[0].Value.ToString();
            tbxSuaTen.Text = row.Cells[1].Value.ToString();
            tbxSuaMK.Text = "********";
            switch (row.Cells[2].Value.ToString())
            {
                case "Quản lý hệ thống": cbbSQuyen.SelectedIndex = 0; break;
                case "Quản lý thẻ": cbbSQuyen.SelectedIndex = 1; break;
                case "Quản lý độc giả": cbbSQuyen.SelectedIndex = 2;break;
                case "Quản lý sách": cbbSQuyen.SelectedIndex = 3;break;
                case "Độc giả": cbbSQuyen.SelectedIndex = 4;break;

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            DataSet ds = new DataSet();
            
                if (tbxSuaTen.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên đăng nhập để thay đổi !!!");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("Update DANGNHAP set TENDANGNHAP =N'" + tbxSuaTen.Text + "', Quyentruycap = '"+ cbbSQuyen.SelectedIndex +"' where MATAIKHOAN = '" + lbMaTK.Text + "'", Con);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(ds);
                }
            DanhSachTK();
            ClearGbxSuaTK();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            
            HideAll();
            ClearGbxThemTK();
            gbxThemTK.Location = gbxTTTK.Location;
            gbxThemTK.Show();
            ShowMaTK();
            cbbTQuyen.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from DANGNHAP where TENDANGNHAP = N'" + tbxTTenDN.Text + "'", Con);
            bool tatkt = false;
            DataSet dataSet1 = new DataSet();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            dar.Fill(dataSet1);
            if (dataSet1.Tables[0].Rows.Count == 0)
                tatkt = true;

            if (tatkt == false)
            {
                MessageBox.Show("Tên Đăng nhập đã tồn tại !!!");
            }
            else
            {
                if (tbxTTenDN.Text == "" )
                {
                    MessageBox.Show("Chưa nhập đủ thông tin !!!");
                }
                else
                {
                    ThemTK();
                    ClearGbxThemTK();
                    gbxThemTK.Enabled = true;
                    DanhSachTK();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Xóa tài khoản sẽ xóa dữ liệu liên quan đến tài khoản này !!!  Bạn có muốn xóa tài khoản không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                SqlConnection Con = Conn.GetCon();
                SqlCommand cmd = new SqlCommand("update ThongTinDocGia set Mataikhoan = null where Mataikhoan = '" + lbMaTK.Text + "'", Con);
                SqlCommand cmd1 = new SqlCommand("update NhanVien set Mataikhoan = null where Mataikhoan = '" + lbMaTK.Text + "'", Con);
                SqlCommand cmd2 = new SqlCommand("delete from DangNhap where Mataikhoan = '" + lbMaTK.Text + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                da.Fill(ds);
                da1.Fill(ds);
                da2.Fill(ds);
                MessageBox.Show("Đã xóa tài khoản thành công !!!");
                DanhSachTK();

            }
            else
                MessageBox.Show("Đã hủy thao tác .");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            HideAll();
            gbxTimKiem.Location = gbxTTTK.Location;
            gbxTimKiem.Show();
            cbbTimQuyen.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            string sql = "select MATAIKHOAN as 'Mã Tài Khoản', TENDANGNHAP as'Tên truy cập', (CASE WHEN QUYENTRUYCAP = '0' THEN N'Quản lý hệ thống' WHEN QUYENTRUYCAP = '1' THEN N'Quản lý thẻ' WHEN QUYENTRUYCAP = '2' THEN N'Quản lý độc giả' WHEN QUYENTRUYCAP = '3' THEN N'Quản lý sách' WHEN QUYENTRUYCAP = '4'THEN N'Độc giả' END)  as 'Quyền' from DangNhap where tendangnhap like '%"+tbxTimTen.Text+"%' and quyentruycap = '"+Convert.ToInt32(cbbTimQuyen.SelectedIndex.ToString())+"' ";
            SqlCommand cmd5 = new SqlCommand(sql, Con);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            dgvDanhSach.DataSource = ds5.Tables[0];
            dgvDanhSach.Visible = true;
            if (dgvDanhSach.RowCount == 0)
                MessageBox.Show("Không tìm thấy !!!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mk = TaoMK(6);
            SqlConnection Con = Conn.GetCon();
            DataSet ds = new DataSet();
            SqlCommand cmd1 = new SqlCommand("Update DANGNHAP set doimatkhau = 0, solandn = 0 ,matkhau = '" + md5(mk) + "',matkhaubandau = '" + mk + "'  where MATAIKHOAN = '" + lbMaTK.Text + "'", Con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(ds);
            MessageBox.Show(String.Format("Thành công !! Mật khẩu mới của tài khoản là: {0}", mk));
            DanhSachTK();
            ClearGbxSuaTK();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        




              

    }
}
