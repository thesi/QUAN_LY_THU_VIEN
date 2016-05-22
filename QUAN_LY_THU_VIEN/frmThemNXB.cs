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
    public partial class frmThemNXB : Form
    {
        public frmThemNXB()
        {
            InitializeComponent();
        }

        void ShowMaNXB()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(manhaxuatban) from thongtinnhaxuatban";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            Con.Close();
            string c = "";
            int d;
            string e = "";
            string f = "";
            for (int i = 3; i < b.Length; i++)
            {
                c += b[i].ToString();
            }
            d = Convert.ToInt32(c) + 1;
            e = Convert.ToString(d);
            for (int j = 0; j < (c.Length - e.Length); j++)
            {
                f += c[j].ToString();
            }
            b = "NXB" + f + e;
            tbxMaNXB.Text = b;
        }
        void ThemMaNXB()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(manhaxuatban) from thongtinnhaxuatban";
            SqlCommand cmd = new SqlCommand(a, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string b = reader.GetValue(0).ToString();
            Con.Close();
            string c = "";
            int d;
            string e = "";
            string f = "";
            for (int i = 3; i < b.Length; i++)
            {
                c += b[i].ToString();
            }
            d = Convert.ToInt32(c) + 1;
            e = Convert.ToString(d);
            for (int j = 0; j < (c.Length - e.Length); j++)
            {
                f += c[j].ToString();
            }
            b = "NXB" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into thongtinnhaxuatban(MaNhaXuatBan) values('" + b.ToString() + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from thongtinnhaxuatban where tennhaxuatban = N'" + tbxTenNXB.Text + "'", Con);
            bool tatkt = false;
            DataSet dataSet1 = new DataSet();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            dar.Fill(dataSet1);
            if (dataSet1.Tables[0].Rows.Count == 0)
                tatkt = true;

            if (tatkt == false)
            {
                MessageBox.Show("Tên Nhà Xuất Bản đã tồn tại !!!");
            }
            else
            {
                if (tbxTenNXB.Text == null && tbxDiaChi.Text == null)
                {
                    MessageBox.Show("Nhập đầy đủ thông tin để tiếp tục !!!");
                }
                else
                {
                    ThemMaNXB();
                    string a = "select max(manhaxuatban) from thongtinnhaxuatban";
                    SqlCommand cm = new SqlCommand(a, Con);
                    SqlDataReader reader = cm.ExecuteReader();
                    reader.Read();
                    string b = reader.GetValue(0).ToString();
                    reader.Close();
                    SqlCommand cmd1 = new SqlCommand("update thongtinnhaxuatban set TenNhaXuatBan = N'" + tbxTenNXB.Text + "', Diachinhaxuatban = N'" + tbxDiaChi.Text + "' where manhaxuatban = '" + b + "'", Con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Thêm thành công");
                    tbxTenNXB.Text = null;
                    tbxDiaChi.Text = null;
                    ShowMaNXB();
                }
            }
        }

        private void frmThemNXB_Load(object sender, EventArgs e)
        {
            ShowMaNXB();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
