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
    public partial class frmThemNgonNgu : Form
    {
        public frmThemNgonNgu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemNgonNgu_Load(object sender, EventArgs e)
        {
            ShowMaNN();
        }

        void ShowMaNN()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(mangonngu) from NgonNgu";
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
            b = "NN" + f + e;
            tbxMaNN.Text = b;
        }
        void ThemMaNN()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(mangonngu) from NgonNgu";
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
            b = "NN" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into NgonNgu(mangonngu) values('" + b.ToString() + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from NgonNgu where tenngonngu = N'" + tbxTenNN.Text + "'", Con);
            bool tatkt = false;
            DataSet dataSet1 = new DataSet();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            dar.Fill(dataSet1);
            if (dataSet1.Tables[0].Rows.Count == 0)
                tatkt = true;

            if (tatkt == false)
            {
                MessageBox.Show("Tên Ngôn Ngữ đã tồn tại !!!");
            }
            else
                if (tbxTenNN.Text == null)
                {
                    MessageBox.Show("Nhập đầy đủ thông tin để tiếp tục !!!");
                }
                else
            {
                ThemMaNN();
                string a = "select max(mangonngu) from NgonNgu";
                SqlCommand cm = new SqlCommand(a, Con);
                SqlDataReader reader = cm.ExecuteReader();
                reader.Read();
                string b = reader.GetValue(0).ToString();
                reader.Close();
                SqlCommand cmd1 = new SqlCommand("update NgonNgu set TenNgonNgu = N'" + tbxTenNN.Text + "' where mangonngu = '" + b + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Thêm thành công");
                tbxTenNN.Text = null;
                ShowMaNN();
            }
        }
    }
}
