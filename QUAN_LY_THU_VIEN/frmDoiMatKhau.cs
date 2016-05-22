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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            lblUserName.Text = frmMain.bientoancuc.bienxy;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select doimatkhau from dangnhap where tendangnhap = '" + lblUserName.Text + "'";
            SqlCommand cmd1 = new SqlCommand(a, Con);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
                if (int.Parse(reader[0].ToString()) == 0)
                {
                    label5.Visible = true;
                }
                else MessageBox.Show("Không tìm thấy dữ liệu");
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

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            Func data = new Func();
            if (data.CheckLoginNhanVien(lblUserName.Text, tbxMKCu.Text))
            {
                if (tbxMKMoi.Text.ToString() == tbxMKMoiXN.Text.ToString())
                {
                    DataSet ds = new DataSet();
                    SqlConnection Con = Conn.GetCon();
                    Con.Open();
                    SqlCommand cmd1 = new SqlCommand("update dangnhap set MatKhau ='" + md5(tbxMKMoi.Text.ToString()) + "', matkhaubandau = '' ,doimatkhau = 1 where tendangnhap = '"+ lblUserName.Text +"' ", Con);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(ds);
                    MessageBox.Show("Đã đổi mật khẩu thành công .");
                    this.Close();
                }
                else
                    MessageBox.Show("Mật khẩu xác nhận không đúng !!!");
            }
            else
                MessageBox.Show("Mật khẩu cũ nhập không đúng !!!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (label5.Visible)
            {
                frmMain obj = (frmMain)this.MdiParent;
                obj.DangXuat();
                this.Close();
            }
            this.Close();
        }
    }
}
