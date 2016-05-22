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
    public partial class frmTiepNhanGopY : Form
    {
        public frmTiepNhanGopY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select magopy as 'Mã góp ý', madocgia as'Mã độc giả', email as'Email', tieude as'Tiêu đề', noidung as'Nội dung', (CASE WHEN tiepnhan = 0 THEN N'Chưa tiếp nhận' WHEN tiepnhan = 1 THEN N'Đã tiếp nhận' END) as 'Tiếp nhận'  from gopydocgia", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Con = Conn.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("update gopydocgia set tiepnhan = 1, phanhoi = N'"+ tbxPhanHoi.Text +"' where magopy = '"+ textBox1.Text +"'", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Tiếp nhận thành công !!!");
        }
    }
}
