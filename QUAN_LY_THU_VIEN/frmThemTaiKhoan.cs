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
    public partial class frmThemTaiKhoan : Form
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
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
        private void btnCapTK_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from DangNhap where tendangnhap = '"+ tbxTenDangNhap.Text +"'", Con);
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
                string mk = TaoMK(6);
                string a = "select max(mataikhoan) from DangNhap";
                SqlCommand cm = new SqlCommand(a, Con);
                SqlDataReader reader = cm.ExecuteReader();
                reader.Read();
                string b = reader.GetValue(0).ToString();
                reader.Close();
                string c = "select max(madocgia) from thongtindocgia";
                SqlCommand cm1 = new SqlCommand(c, Con);
                SqlDataReader reader1 = cm1.ExecuteReader();
                reader1.Read();
                string d = reader1.GetValue(0).ToString();
                reader1.Close();
                SqlCommand cmd1 = new SqlCommand("update ThongTinDOcGia set MaTaiKhoan = '" + b + "' where madocgia = '" + d + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlCommand cmd2 = new SqlCommand("update Dangnhap set TenDangNhap = '" + tbxTenDangNhap.Text + "', matkhau = '" + md5(mk) + "',matkhaubandau = '" + mk + "', QuyenTruyCap = 4 where mataikhoan = (select max(mataikhoan) from dangnhap)", Con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(ds);
                MessageBox.Show("Hoàn Tất.");
                this.Close();
                frmCRMatKhau mkk = new frmCRMatKhau();
                mkk.Show();
            
                frmCRPhiCapThe tt= new frmCRPhiCapThe();
                tt.Show();
            }
            
        }
    }
}
