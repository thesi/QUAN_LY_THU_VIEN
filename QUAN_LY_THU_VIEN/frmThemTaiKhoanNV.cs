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
    public partial class frmThemTaiKhoanNV : Form
    {
        public frmThemTaiKhoanNV()
        {
            InitializeComponent();
        }

        private void btnCapTK_Click(object sender, EventArgs e)
        {
            cbbQuyen.SelectedIndex = 0;
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
                string a = "select max(mataikhoan) from DangNhap";
                SqlCommand cm = new SqlCommand(a, Con);
                SqlDataReader reader = cm.ExecuteReader();
                reader.Read();
                string b = reader.GetValue(0).ToString();
                reader.Close();
                string c = "select max(manhanvien) from nhanvien";
                SqlCommand cm1 = new SqlCommand(c, Con);
                SqlDataReader reader1 = cm1.ExecuteReader();
                reader1.Read();
                string d = reader1.GetValue(0).ToString();
                reader1.Close();
                SqlCommand cmd1 = new SqlCommand("update nhanvien set MaTaiKhoan = '" + b + "' where manhanvien = '" + d + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlCommand cmd2 = new SqlCommand("update Dangnhap set TenDangNhap = '" + tbxTenDangNhap.Text + "', MatKhau = '" + tbxMatKhau.Text + "', QuyenTruyCap = '"+ cbbQuyen.SelectedIndex +"' where mataikhoan = (select max(mataikhoan) from dangnhap)", Con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(ds);
                MessageBox.Show("Hoàn Tất.");
                this.Close();
               
            }
            
        }
    }
}
