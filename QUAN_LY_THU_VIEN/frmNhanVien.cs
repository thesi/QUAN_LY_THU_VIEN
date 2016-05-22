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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HideAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region
        public void HideAll()
        {
            gbxThemNV.Hide();
            gbxTimNV.Hide();
            gbxTTNV.Hide();
        }
        public void ClearGbxThemNV()
        {
            tbxThemHT.Clear();
            cbbThemBP.Text =null;
            tbxThemSDT.Clear();
            tbxThemDC.Clear();
            tbxThemNS.Clear();
            tbxThemNVL.Clear();
            tbxThemCMND.Clear();
        }
        public void ClearGbxSuaNV()
        {
            tbxSuaHT.Clear();
            cbbSuaBP.Text = null;
            tbxSuaSDT.Clear();
            tbxSuaDC.Clear();
            tbxSuaNS.Clear();
            tbxSuaNVL.Clear();
            tbxSuaCMND.Clear();
        }
        void ThemMaTK()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(mataikhoan) from DangNhap";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            Con.Close();
            string c = "";
            int d = 0;
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
            SqlCommand cmd1 = new SqlCommand("insert into DangNhap(MaTaiKhoan) values('" + b.ToString() + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        void ThemMaNV()
        {

            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(manhanvien) from NhanVien";
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
            b = "NV" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into NhanVien(manhanvien,mabophan) values('" + b.ToString() + "','BP000001')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);

        }

        public void ThemNV()
        {
            SqlConnection Con = Conn.GetCon();
            if (cbbThemBP.SelectedIndex == 0)
            {
                ThemMaNV();
                SqlCommand cmd1 = new SqlCommand("update NHANVIEN set tennhanvien = N'" + tbxThemHT.Text + "', mabophan = 'BP000001', CMND = '" + tbxThemCMND.Text + "', sodienthoainhanvien = '" + tbxThemSDT.Text + "', NgaySinh =' " + tbxThemNS.Text.ToString() + "', diachinhanvien = N'" + tbxThemDC.Text + "',NgayVaoLam = '" + tbxThemNVL.Text.ToString() + "' WHERE manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da2.Fill(ds);
                if (rbtThemNam.Checked)
                {
                    SqlCommand cmd2 = new SqlCommand("update NhanVien set gioitinh = 1 where manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
                    da3.Fill(ds);
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("update NhanVien set gioitinh = 0 where manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
                    da3.Fill(ds);
                }
            }
            else
            {
                if (cbbThemBP.SelectedIndex == 1)
                {
                    ThemMaNV();
                    SqlCommand cmd1 = new SqlCommand("update NHANVIEN set tennhanvien = N'" + tbxThemHT.Text + "', mabophan = 'BP000002', CMND = '" + tbxThemCMND.Text + "', sodienthoainhanvien = '" + tbxThemSDT.Text + "', NgaySinh =' " + tbxThemNS.Text.ToString() + "', diachinhanvien = N'" + tbxThemDC.Text + "',NgayVaoLam = '" + tbxThemNVL.Text.ToString() + "' WHERE manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    da2.Fill(ds);
                    if (rbtThemNam.Checked)
                    {
                        SqlCommand cmd2 = new SqlCommand("update NhanVien set gioitinh = 1 where manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                        SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
                        da3.Fill(ds);
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("update NhanVien set gioitinh = 0 where manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                        SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
                        da3.Fill(ds);
                    }
                }
                else
                {
                    if (cbbThemBP.SelectedIndex == 2)
                    {
                        ThemMaNV();
                        SqlCommand cmd1 = new SqlCommand("update NHANVIEN set tennhanvien = N'" + tbxThemHT.Text + "', mabophan = 'BP000003', CMND = '" + tbxThemCMND.Text + "', sodienthoainhanvien = '" + tbxThemSDT.Text + "', NgaySinh =' " + tbxThemNS.Text.ToString() + "', diachinhanvien = N'" + tbxThemDC.Text + "',NgayVaoLam = '" + tbxThemNVL.Text.ToString() + "' WHERE manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                        SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
                        DataSet ds = new DataSet();
                        da2.Fill(ds);
                        if (rbtThemNam.Checked)
                        {
                            SqlCommand cmd2 = new SqlCommand("update NhanVien set gioitinh = 1 where manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                            SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
                            da3.Fill(ds);
                        }
                        else
                        {
                            SqlCommand cmd2 = new SqlCommand("update NhanVien set gioitinh = 0 where manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                            SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
                            da3.Fill(ds);
                        }
                    }
                    else
                    {
                        if (cbbThemBP.SelectedIndex == 3)
                        {
                            ThemMaNV();
                            SqlCommand cmd1 = new SqlCommand("update NHANVIEN set tennhanvien = N'" + tbxThemHT.Text + "', mabophan = 'BP000004', CMND = '" + tbxThemCMND.Text + "', sodienthoainhanvien = '" + tbxThemSDT.Text + "', NgaySinh =' " + tbxThemNS.Text.ToString() + "', diachinhanvien = N'" + tbxThemDC.Text + "',NgayVaoLam = '" + tbxThemNVL.Text.ToString() + "' WHERE manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                            SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
                            DataSet ds = new DataSet();
                            da2.Fill(ds);
                            if (rbtThemNam.Checked)
                            {
                                SqlCommand cmd2 = new SqlCommand("update NhanVien set gioitinh = 1 where manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                                SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
                                da3.Fill(ds);
                            }
                            else
                            {
                                SqlCommand cmd2 = new SqlCommand("update NhanVien set gioitinh = 0 where manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
                                SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
                                da3.Fill(ds);
                            }
                        }
                    }
                }
            }
            ThemMaTK();
            DataSet ds1 = new DataSet();
            SqlCommand cmd11 = new SqlCommand("update NhanVien set mataikhoan = (select max(mataikhoan) from dangnhap ) where manhanvien = (select max(manhanvien) from nhanvien ) ", Con);
            SqlDataAdapter da11 = new SqlDataAdapter(cmd11);
            da11.Fill(ds1);
            Form captaikhoan = new frmThemTaiKhoanNV();
            captaikhoan.Show();
        }


        public void DanhSachNV()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select manhanvien as 'Mã nhân viên', tennhanvien as'Tên nhân viên', (CASE WHEN mabophan ='BP000001' THEN N'Bộ Phận Cấp Thẻ' WHEN mabophan ='BP000002' THEN N'Bộ Phận Phục Vụ ĐG' WHEN mabophan ='BP000003' THEN N'Bộ Phận QL Sách'  WHEN mabophan ='BP000004' THEN N'Bộ Phận QL Hệ Thống' END) as 'Tên bộ phận', (CASE WHEN gioiTinh ='1' THEN N'Nam' ELSE N'Nữ' END) as 'Giới tính', mataikhoan as 'Mã tài khoản', cmnd as 'Số CMND', ngaysinh as 'Ngày sinh', diachinhanvien as 'Địa chỉ', sodienthoainhanvien as 'Số điện thoại', ngayvaolam as 'Ngày vào làm'  from NHANVIEN ", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvDanhSach.DataSource = ds.Tables[0];
            //Con.Close();
        }

        #endregion

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            HideAll();
            dgvDanhSach.Visible = true;
            DanhSachNV();
            gbxTTNV.Show();
        }

        private void dgvDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HideAll();
            gbxTTNV.Show();
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDanhSach.Rows[e.RowIndex];
            lbMaNV.Text = row.Cells[0].Value.ToString();
            tbxSuaHT.Text = row.Cells[1].Value.ToString();
            switch (row.Cells[2].Value.ToString())
            {
                case "Bộ Phận Cấp Thẻ": cbbSuaBP.SelectedIndex = 0; break;
                case "Bộ Phận Phục Vụ ĐG": cbbSuaBP.SelectedIndex = 1; break;
                case "Bộ Phận QL Sách": cbbSuaBP.SelectedIndex = 2; break;
                case "Bộ Phận QL Hệ Thống": cbbSuaBP.SelectedIndex = 3; break;
            }
            switch (row.Cells[3].Value.ToString())
            {
                case "Nam": rbtSuaNam.Checked = true; break;
                case "Nữ": rbtSuaNu.Checked = true; break;
            }
            tbxSuaMTK.Text = row.Cells[4].Value.ToString();
            tbxSuaCMND.Text = row.Cells[5].Value.ToString();
            tbxSShowNS.Text = row.Cells[6].Value.ToString().Substring(0, 10);
            tbxSuaNS.Text = tbxSShowNS.Text.Substring(3, 2)+ "/" + tbxSShowNS.Text.Substring(0, 2) + "/" + tbxSShowNS.Text.Substring(6, 4);
            tbxSuaDC.Text = row.Cells[7].Value.ToString();
            tbxSuaSDT.Text = row.Cells[8].Value.ToString();
            tbxSShowNVL.Text = row.Cells[9].Value.ToString().Substring(0, 10);
            tbxSuaNVL.Text = tbxSShowNVL.Text.Substring(3, 2) + "/" + tbxSShowNVL.Text.Substring(0, 2) + "/" + tbxSShowNVL.Text.Substring(6, 4);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            DataSet ds = new DataSet();
            if (tbxSuaHT.Text == "" && tbxSuaCMND.Text == "" && tbxSuaDC.Text == "" && tbxSuaSDT.Text == "" && tbxSuaSDT.Text == "" && tbxSuaSDT.Text == "" && tbxSuaNVL.Text == "" && tbxSuaSDT.Text == "" && tbxSuaNVL.Text == "" && tbxSuaNS.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin !!!");
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("Update NhanVien set NgaySinh = '" + tbxSuaNS.Text.ToString() + "', NgayVaoLam = '" + tbxSuaNVL.Text.ToString() + "', tennhanvien =N'" + tbxSuaHT.Text + "',CMND ='" + Convert.ToString(tbxSuaCMND.Text.ToString()) + "',mataikhoan = '" + tbxSuaMTK.Text.ToString() + "',diachinhanvien =N'" + tbxSuaDC.Text + "',sodienthoainhanvien = '" + Convert.ToString(tbxSuaSDT.Text.ToString()) + "' where manhanvien = '" + lbMaNV.Text + "'", Con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(ds);
                if (rbtSuaNam.Checked)
                {
                    SqlCommand cmd7 = new SqlCommand("Update NHANVIEN set gioitinh = 1 where manhanvien = '" + lbMaNV.Text + "'", Con);
                    SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
                    da7.Fill(ds);
                }
                else
                {
                    SqlCommand cmd8 = new SqlCommand("Update NHANVIEN set gioitinh = 0 where manhanvien = '" + lbMaNV.Text + "'", Con);
                    SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
                    da8.Fill(ds);
                }

                switch (cbbSuaBP.SelectedIndex)
                {
                    case 0:
                        SqlCommand cmd9 = new SqlCommand("Update NHANVIEN set mabophan = 'BP000001' where manhanvien = '" + lbMaNV.Text + "'", Con);
                        SqlDataAdapter da9 = new SqlDataAdapter(cmd9);
                        da9.Fill(ds);
                        break;
                    case 1:
                        SqlCommand cmd10 = new SqlCommand("Update NHANVIEN set mabophan = 'BP000002' where manhanvien = '" + lbMaNV.Text + "'", Con);
                        SqlDataAdapter da10 = new SqlDataAdapter(cmd10);
                        da10.Fill(ds);
                        break;
                    case 2:
                        SqlCommand cmd11 = new SqlCommand("Update NHANVIEN set mabophan = 'BP000003' where manhanvien = '" + lbMaNV.Text + "'", Con);
                        SqlDataAdapter da11 = new SqlDataAdapter(cmd11);
                        da11.Fill(ds);
                        break;
                    case 3:
                        SqlCommand cmd12 = new SqlCommand("Update NHANVIEN set mabophan ='BP000004' where manhanvien = '" + lbMaNV.Text + "'", Con);
                        SqlDataAdapter da12 = new SqlDataAdapter(cmd12);
                        da12.Fill(ds);
                        break;
                }
                MessageBox.Show("Thay đổi thành công !!!");
            }
                DanhSachNV();
                ClearGbxSuaNV();
            }
    

        private void dtpSuaNS_ValueChanged(object sender, EventArgs e)
        {
            tbxSShowNS.Text = dtpSuaNS.Value.Day + "/" + dtpSuaNS.Value.Month + "/" + dtpSuaNS.Value.Year;
            tbxSuaNS.Text = dtpSuaNS.Value.Month + "/" + dtpSuaNS.Value.Day + "/" + dtpSuaNS.Value.Year;
        }

        private void dtpSuaNVL_ValueChanged(object sender, EventArgs e)
        {
            tbxSuaNVL.Text = dtpSuaNVL.Value.Month + "/" + dtpSuaNVL.Value.Day + "/" + dtpSuaNVL.Value.Year;
            tbxSShowNVL.Text = dtpSuaNS.Value.Day + "/" + dtpSuaNS.Value.Month + "/" + dtpSuaNS.Value.Year;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa nhân viên sẽ xóa dữ liệu liên quan đến nhân viên này !!!  Bạn có muốn xóa nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                SqlConnection Con = Conn.GetCon();
                SqlCommand cmd = new SqlCommand("update ChiTietPhieuMuonTra set Manhanvien = null where Manhanvien = '" + lbMaNV.Text + "'", Con);
                SqlCommand cmd1 = new SqlCommand("delete from NhanVien where Manhanvien = '" + lbMaNV.Text + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                da1.Fill(ds);
                MessageBox.Show("Đã xóa nhân viên thành công !!!");
                DanhSachNV();

            }
            else
                MessageBox.Show("Đã hủy thao tác .");
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            HideAll();
            ClearGbxThemNV();
            gbxThemNV.Location = gbxTTNV.Location;
            gbxThemNV.Show();
            cbbThemBP.SelectedIndex = 0;
            rbtThemNam.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbxThemHT.Text == "" || tbxThemDC.Text == "" || tbxThemSDT.Text == "" || tbxThemNS.Text == "" || tbxThemNVL.Text == "" || tbxThemCMND.Text == "" || tbxThemCMND.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin !!!");
            }
            else
            {
                ThemNV();
                ClearGbxThemNV();
                DanhSachNV();
            }
        }

        private void dtpThemNS_ValueChanged(object sender, EventArgs e)
        {
            tbxThemNS.Text = dtpThemNS.Value.Month + "/" + dtpThemNS.Value.Day + "/" + dtpThemNS.Value.Year;
            tbxTThemNS.Text = dtpThemNS.Value.Day + "/" + dtpThemNS.Value.Month + "/" + dtpThemNS.Value.Year;
        }

        private void dtbThemNVL_ValueChanged(object sender, EventArgs e)
        {
            tbxThemNVL.Text = dtpThemNVL.Value.Month + "/" + dtpThemNVL.Value.Day + "/" + dtpThemNVL.Value.Year;
            tbxTThemNVL.Text = dtpThemNS.Value.Day + "/" + dtpThemNS.Value.Month + "/" + dtpThemNS.Value.Year;
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbSearch.SelectedIndex)
            {
                case 0:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập Mã NV :";
                    break;
                case 1:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập tên NV :";
                    break;
                case 2:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập Mã Bộ Phận :";
                    break;
                case 3:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập Mã Tài Khoản :";
                    break;
                case 4:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập CMND :";
                    break;
                case 5:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập Ngày Sinh :";
                    break;
                case 6:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập Giới Tính :";
                    break;
                case 7:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập Số ĐT :";
                    break;
                case 8:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập Địa Chỉ :";
                    break;
                case 9:
                    tbxSearch.Enabled = true;
                    lbSearch.Text = "Nhập Ngày Vào Làm :";
                    break;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "select manhanvien as 'Mã nhân viên', tennhanvien as'Tên nhân viên', (CASE WHEN mabophan ='BP000001' THEN N'Bộ Phận Cấp Thẻ' WHEN mabophan ='BP000002' THEN N'Bộ Phận Phục Vụ ĐG' WHEN mabophan ='BP000003' THEN N'Bộ Phận QL Sách'  WHEN mabophan ='BP000004' THEN N'Bộ Phận QL Hệ Thống' END) as 'Tên bộ phận', (CASE WHEN gioiTinh ='1' THEN N'Nam' ELSE N'Nữ' END) as 'Giới tính', mataikhoan as 'Mã tài khoản', cmnd as 'Số CMND', ngaysinh as 'Ngày sinh', diachinhanvien as 'Địa chỉ', sodienthoainhanvien as 'Số điện thoại', ngayvaolam as 'Ngày vào làm'  from NHANVIEN ";
            SqlConnection Con = Conn.GetCon();
            switch (cbbSearch.SelectedIndex)
            {
                case 0:
                    sql += " where manhanvien = '" + tbxSearch.Text.ToString() + "' ";
                    break;
                case 1:
                    sql += " where tennhanvien = '" + tbxSearch.Text.ToString() + "' ";
                    break;
                case 2:
                    sql += " where mabophan = '" + tbxSearch.Text.ToString() + "' ";
                    break;
                case 3:
                    sql += " where mataikhoan = '" + tbxSearch.Text.ToString() + "' ";
                    break;
                case 4:
                    sql += " where cmnd = '" + Convert.ToInt32(tbxSearch.Text.ToString()) + "' ";
                    break;
                case 5:
                    sql += " where ngaysinh = '" + tbxSearch.Text.ToString() + "' ";
                    break;
                case 6:
                    if (tbxSearch.Text.ToString() == "Nam")
                    {
                        sql += " where gioitinh = '1' ";
                    }
                    else
                        sql += " where gioitinh = '0' ";
                    break;
                case 7:
                    sql += " where sodienthoainhanvien = '" + Convert.ToInt32(tbxSearch.Text.ToString()) + "' ";
                    break;
                case 8:
                    sql += " where diachi = '" + tbxSearch.Text.ToString() + "' ";
                    break;
                case 9:
                    sql += " where ngayvaolam = '" + tbxSearch.Text + "' ";
                    break;
            }

            SqlCommand cmd5 = new SqlCommand(sql, Con);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            dgvDanhSach.DataSource = ds5.Tables[0];
            if (dgvDanhSach.RowCount == 1)
                MessageBox.Show("Không tìm thấy !!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAll();
            gbxTimNV.Location = gbxTTNV.Location;
            gbxTimNV.Show();
            DanhSachNV();
        }

    }
}
