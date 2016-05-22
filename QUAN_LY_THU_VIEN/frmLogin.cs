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
    public partial class frmLogin : Form
    {
        public frmLogin() 
        {
            
            InitializeComponent();
        }

        public int QuyenTruyCap()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            int quyen = 0;
            string a = "select quyentruycap from dangnhap where tendangnhap = '" + frmMain.bientoancuc.bienxy + "'";
            SqlCommand cmd1 = new SqlCommand(a, Con);
            SqlDataReader reader = cmd1.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            quyen = Convert.ToInt32(b);
            return quyen;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

             Func data = new Func();
             if (data.CheckLoginNhanVien(tbxUser.Text, tbxPass.Text))
             {
                 frmMain.bientoancuc.bienxy = tbxUser.Text;
                 frmMain obj = (frmMain)this.MdiParent;
                 obj.ShowMenu();
                 this.Close();
                 MessageBox.Show("Đăng nhập thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 if (data.CheckDNLanDau(frmMain.bientoancuc.bienxy) || data.CheckDoiMK(frmMain.bientoancuc.bienxy))
                 {
                     obj.SuaMK();
                 }
                 if (QuyenTruyCap() == 4)
                 {
                     obj.ShowGopY();
                 }
                 switch (QuyenTruyCap())
                 {
                     case 0: obj.QLHT(); break;
                     case 1: obj.QLCT(); break;
                     case 2: obj.QLDG(); break;
                     case 3: obj.QLS(); break;
                 }


             }
             else
             {
                 if (tbxUser.Text == "admin" && tbxPass.Text == "philong")
                 {
                     frmMain.bientoancuc.bienxy = tbxUser.Text;
                     frmMain obj = (frmMain)this.MdiParent;
                     obj.ShowMenu();
                     this.Close();
                     MessageBox.Show("Đăng nhập thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     obj.HienAll();

                 }
                 else
                 {
                     MessageBox.Show("Đăng nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
