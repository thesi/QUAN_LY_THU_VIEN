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
    public partial class frmThemDauSach : Form
    {
        public frmThemDauSach()
        {
            InitializeComponent();
        }
        public DataTable LayLoai()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select TenLoaiddc from thongtinloaisach ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        public DataTable LayNN()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select TenNgonngu from ngonngu ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        public DataTable LayTG()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select Tentacgia from thongtintacgia ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        public DataTable LayNXB()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select Tennhaxuatban from thongtinnhaxuatban ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }
        public DataTable LayKS()
        {
            SqlConnection Con = Conn.GetCon();
            DataTable dt = new DataTable();
            string sql = "select Tenke from thongtinkesach ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt;
        }

        private void cbxNgonNgu_MouseClick(object sender, MouseEventArgs e)
        {
            cbxNgonNgu.DataSource = LayNN();
            cbxNgonNgu.ValueMember = "TenNgonNgu";
        }

        private void cbxTacGia_MouseClick(object sender, MouseEventArgs e)
        {
            cbxTacGia.DataSource = LayTG();
            cbxTacGia.ValueMember = "TenTacgia";
        }

        private void cbxNXB_MouseClick(object sender, MouseEventArgs e)
        {
            cbxNXB.DataSource = LayNXB();
            cbxNXB.ValueMember = "TenNhaXuatBan";
        }

        private void cbxKeSach_MouseClick(object sender, MouseEventArgs e)
        {
            cbxKeSach.DataSource = LayKS();
            cbxKeSach.ValueMember = "TenKe";
        }
        void ShowMaDS()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(madausach) from thongtindausach";
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
            b = "DS" + f + e;
            tbxMaDS.Text = b;
        }
        void ThemMaDS()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(madausach) from thongtindausach";
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
            b = "DS" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into thongtindausach(madausach,mangonngu,maloaiddc,make,matacgia,manhaxuatban) values('" + b.ToString() + "','" + lblNN.Text + "','" + lblLoai.Text + "','" + lblKS.Text + "','" + lblTG.Text + "','" + lblNXB.Text + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemDauSach_Load(object sender, EventArgs e)
        {
            ShowMaDS();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form a = new frmThemLoai();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form a = new frmThemNgonNgu();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form a = new frmThemTacGia();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form a = new frmThemNXB();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form a = new frmThemKeSach();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from thongtindausach where tendausach = N'" + tbxTenDS.Text + "'", Con);
            bool tatkt = false;
            DataSet dataSet1 = new DataSet();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            dar.Fill(dataSet1);
            if (dataSet1.Tables[0].Rows.Count == 0)
                tatkt = true;

            if (tatkt == false)
            {
                MessageBox.Show("Tên Đầu sách đã tồn tại !!!");
            }
            else
                if (tbxTenDS.Text == null || tbxGiaBia.Text == null || tbxSoTrang.Text == null || tbxMaISBN.Text == null || tbxNamXB.Text == null)
                {
                    MessageBox.Show("Nhập đầy đủ thông tin để tiếp tục !!!");
                }
                else
                {
                    ThemMaDS();
                    string a = "select max(madausach) from thongtindausach";
                    SqlCommand cm = new SqlCommand(a, Con);
                    SqlDataReader reader = cm.ExecuteReader();
                    reader.Read();
                    string b = reader.GetValue(0).ToString();
                    reader.Close();
                    SqlCommand cmd1 = new SqlCommand("update thongtindausach set TenDauSach = N'" + tbxTenDS.Text + "',namxuatban = '" + tbxNamXB.Text + "', sotrang = '" + tbxSoTrang.Text + "', maisbn = '" + tbxMaISBN.Text + "', giabia = '" + tbxGiaBia.Text + "' where madausach = '" + b + "'", Con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Thêm thành công");
                    tbxTenDS.Text = null;
                    ShowMaDS();
                }
        }

        private void cbxLoai_MouseClick(object sender, MouseEventArgs e)
        {
            cbxLoai.DataSource = LayLoai();
            cbxLoai.ValueMember = "TenLoaiDDC";
        }

        
        private void cbxLoai_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select maloaiddc from thongtinloaisach where tenloaiddc =  N'" + cbxLoai.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string b = reader.GetValue(0).ToString();
                lblLoai.Text = b;
                Con.Close();
            }
            else Con.Close();
        }

        private void cbxNgonNgu_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select mangonngu from ngonngu where tenngonngu =  N'" + cbxNgonNgu.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string b = reader.GetValue(0).ToString();
                lblNN.Text = b;
                Con.Close();
            }
            else Con.Close();
        }

        private void cbxTacGia_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select matacgia from thongtintacgia where tentacgia =  N'" + cbxTacGia.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string b = reader.GetValue(0).ToString();
                lblTG.Text = b;
                Con.Close();
            }
            else Con.Close();
        }

        private void cbxNXB_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select manhaxuatban from thongtinnhaxuatban where tennhaxuatban =  N'" + cbxNXB.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string b = reader.GetValue(0).ToString();
                lblNXB.Text = b;
                Con.Close();
            }
            else Con.Close();
        }

        private void cbxKeSach_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select make from thongtinkesach where tenke =  N'" + cbxKeSach.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string b = reader.GetValue(0).ToString();
                lblKS.Text = b;
                Con.Close();
            }
            else Con.Close();
        }


    }
}
