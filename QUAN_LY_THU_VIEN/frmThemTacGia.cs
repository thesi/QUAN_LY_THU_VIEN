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
    public partial class frmThemTacGia : Form
    {
        public frmThemTacGia()
        {
            InitializeComponent();
        }
        //select max(matacgia) from thongtintacgia
        void ShowMaTacGia()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(matacgia) from thongtintacgia";
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
            b = "TG" + f + e;
            tbxMaTacGia.Text = b;
        }
        void ThemMaTacGia()
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            string a = "select max(matacgia) from thongtintacgia";
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
            b = "TG" + f + e;
            SqlCommand cmd1 = new SqlCommand("insert into thongtintacgia(matacgia) values('" + b.ToString() + "')", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
        //insert into thongtintacgia(matacgia) values('" + b.ToString() + "')", Con
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from thongtintacgia where tentacgia = N'" + tbxTenTacGia.Text + "'", Con);
            bool tatkt = false;
            DataSet dataSet1 = new DataSet();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            dar.Fill(dataSet1);
            if (dataSet1.Tables[0].Rows.Count == 0)
                tatkt = true;

            if (tatkt == false)
            {
                MessageBox.Show("Tên Tác Giả đã tồn tại !!!");
            }
            else
            {
                if (tbxTenTacGia.Text == null && tbxDiaChi.Text == null)
                {
                    MessageBox.Show("Nhập đầy đủ thông tin để tiếp tục !!!");
                }
                else
                {
                    ThemMaTacGia();
                    string a = "select max(matacgia) from thongtintacgia";
                    SqlCommand cm = new SqlCommand(a, Con);
                    SqlDataReader reader = cm.ExecuteReader();
                    reader.Read();
                    string b = reader.GetValue(0).ToString();
                    reader.Close();
                    SqlCommand cmd1 = new SqlCommand("update thongtintacgia set Tentacgia = N'" + tbxTenTacGia.Text + "', Diachitacgia = N'" + tbxDiaChi.Text + "' where matacgia = '" + b + "'", Con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Thêm thành công");
                    tbxTenTacGia.Text = null;
                    tbxDiaChi.Text = null;
                    ShowMaTacGia();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemTacGia_Load(object sender, EventArgs e)
        {
            ShowMaTacGia();
        }

    }
}
