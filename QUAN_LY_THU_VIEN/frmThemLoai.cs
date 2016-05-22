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
    public partial class frmThemLoai : Form
    {
        public frmThemLoai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from thongtinloaisach where maloaiddc = N'" + tbxMaLoai.Text + "'", Con);
            bool tatkt = false;
            DataSet dataSet1 = new DataSet();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            dar.Fill(dataSet1);
            if (dataSet1.Tables[0].Rows.Count == 0)
                tatkt = true;

            if (tatkt == false)
            {
                MessageBox.Show("Mã loại sách đã tồn tại !!!");
            }
            else
                if (tbxTenLoai.Text == null)
                {
                    MessageBox.Show("Nhập đầy đủ thông tin để tiếp tục !!!");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("insert into thongtinloaisach(maloaiddc,tenloaiddc) values ('" + tbxMaLoai.Text + "',N'" + tbxTenLoai.Text + "')", Con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Thêm thành công");
                }
        }
    }
}
