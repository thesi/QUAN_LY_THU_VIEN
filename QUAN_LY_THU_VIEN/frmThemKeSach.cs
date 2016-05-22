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
    public partial class frmThemKeSach : Form
    {
        public frmThemKeSach()
        {
            InitializeComponent();
        }


        void ShowMaKS()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(make) from thongtinkesach";
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
            b = "KS" + f + e;
            tbxMaKS.Text = b;
        }
        void ThemMaKS()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(make) from thongtinkesach";
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
            b = "KS" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into thongtinkesach(make) values('" + b.ToString() + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }


        private void frmThemKeSach_Load_1(object sender, EventArgs e)
        {
            ShowMaKS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from thongtinkesach where tenke = N'" + tbxTenKS.Text + "'", Con);
            bool tatkt = false;
            DataSet dataSet1 = new DataSet();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            dar.Fill(dataSet1);
            if (dataSet1.Tables[0].Rows.Count == 0)
                tatkt = true;

            if (tatkt == false)
            {
                MessageBox.Show("Tên Kệ sách đã tồn tại !!!");
            }
            else
                if (tbxTenKS.Text == null)
                {
                    MessageBox.Show("Nhập đầy đủ thông tin để tiếp tục !!!");
                }
                else
                {
                    ThemMaKS();
                    string a = "select max(make) from thongtinkesach";
                    SqlCommand cm = new SqlCommand(a, Con);
                    SqlDataReader reader = cm.ExecuteReader();
                    reader.Read();
                    string b = reader.GetValue(0).ToString();
                    reader.Close();
                    SqlCommand cmd1 = new SqlCommand("update thongtinkesach set Tenke = N'" + tbxTenKS.Text + "' where make = '" + b + "'", Con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Thêm thành công");
                    tbxTenKS.Text = null;
                    ShowMaKS();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
