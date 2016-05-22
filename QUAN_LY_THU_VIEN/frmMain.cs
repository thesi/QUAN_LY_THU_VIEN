using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUAN_LY_THU_VIEN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void ShowMenu()
        {
            thôngTinToolStripMenuItem.Visible = true;
            label1.Visible = true;
            linkLabel1.Visible = true;
            lblUser.Text = bientoancuc.bienxy;
            đăngNhậpToolStripMenuItem.Visible = false;
        }
        public void HidenMenu()
        {
            linkLabel1.Visible = false;
            thôngTinToolStripMenuItem.Visible = false;
            lblUser.Visible = true;
            label1.Visible = false;
            lblUser.Text = "Vui lòng đăng nhập";
            đăngNhậpToolStripMenuItem.Visible = true;
            bộPhậnCấpThẻToolStripMenuItem.Visible = false;
            bộPhậnPhụcVụĐọcGiảToolStripMenuItem.Visible = false;
            bộPhậnQuảnLýSáchToolStripMenuItem.Visible = false;
            quảnLýHệThốngToolStripMenuItem.Visible = false;
        }
        public void ShowGopY()
        {
            gópÝCủaĐộcGiảToolStripMenuItem.Visible = true;
        }
        public void HideGopY()
        {
            gópÝCủaĐộcGiảToolStripMenuItem.Visible = false;
        }

        public void DangXuat()
        {
            HidenMenu();
            bientoancuc.bienxy = "";
            linkLabel1.Visible = false;
            HideGopY();
        }
        public void QLDG()
        {
            bộPhậnPhụcVụĐọcGiảToolStripMenuItem.Visible = true;
        }
        public void QLS()
        {
            bộPhậnQuảnLýSáchToolStripMenuItem.Visible = true;

        }
        public void QLCT()
        {
            bộPhậnCấpThẻToolStripMenuItem.Visible = true;
        }

        public void QLHT()
        {
            quảnLýHệThốngToolStripMenuItem.Visible = true;
 
        }

        public void HienAll()
        {
            bộPhậnCấpThẻToolStripMenuItem.Visible = true;
            bộPhậnPhụcVụĐọcGiảToolStripMenuItem.Visible = true;
            bộPhậnQuảnLýSáchToolStripMenuItem.Visible = true;
            quảnLýHệThốngToolStripMenuItem.Visible = true;
 
        }
        public void SuaMK()
        {
            Form f1 = new frmDoiMatKhau();
            f1.MdiParent = this;
            f1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cấpMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new frmCapThe();
            form1.MdiParent = this;
            form1.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form log = new frmLogin();
            log.MdiParent = this;
            log.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tk = new frmTaiKhoan();
            tk.MdiParent = this;
            tk.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nv = new frmNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void chuyểnNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cn = new frmChuyenNhom();
            cn.MdiParent = this;
            cn.Show();
        }

        private void khóaThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kt = new frmKhoaThe();
            kt.MdiParent = this;
            kt.Show();

        }

        private void giaHạnThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gh = new frmGiaHanThe();
            gh.MdiParent = this;
            gh.Show();
        }
        public class bientoancuc
        {
            public static string bienxy;
        }
        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tt = new frmThongTinTaiKhoan();
            tt.MdiParent = this;
            tt.Show();
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            HidenMenu();
            bientoancuc.bienxy = "";
        }

        private void mởKhóaThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mk = new frmMoKhoaThe();
            mk.MdiParent = this;
            mk.Show();
        }

        private void cơBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cb = new frmTraCuuCB();
            cb.MdiParent = this;
            cb.Show();
       }

        private void nângCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nc = new frmTraCuuNC();
            nc.MdiParent = this;
            nc.Show();
        }

        private void thêmNgônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new frmThemNgonNgu();
            f1.MdiParent = this;
            f1.Show();
        }

        private void thêmNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new frmThemNXB();
            f2.MdiParent = this;
            f2.Show();
        }

        private void thêmNgônNgữToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form nn = new frmThemNgonNgu();
            nn.MdiParent = this;
            nn.Show();
        }

        private void thêmNhàXuấtBảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form nxb = new frmThemNXB();
            nxb.MdiParent = this;
            nxb.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidenMenu();
            bientoancuc.bienxy = "";
            linkLabel1.Visible = false;
            HideGopY();
        }

        private void quảnLýMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form phieu = new frmLapPhieuMuon();
            phieu.MdiParent = this;
            phieu.Show();
        }

        private void gópÝCủaĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGopYDocGia GY = new frmGopYDocGia();
            GY.MdiParent = this;
            GY.Show();
        }

        private void quảnLýTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraSach TS = new frmTraSach();
            TS.MdiParent = this;
            TS.Show();
        }

        private void quảnLýMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapPhieuMuon a = new frmLapPhieuMuon();
            a.MdiParent = this;
            a.Show();
        }

        private void quảnLýTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraSach a = new frmTraSach();
            a.MdiParent = this;
            a.Show();
        }

        private void tiếpNhậnGópÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiepNhanGopY a = new frmTiepNhanGopY();
            a.MdiParent = this;
            a.Show();
        }

        private void xácNhậnThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXacNhanThongTin a = new frmXacNhanThongTin();
            a.MdiParent = this;
            a.Show();
        }

        private void thêmThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemLoai a = new frmThemLoai();
            a.MdiParent = this;
            a.Show();
        }

        private void thêmNhàXuấtBảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThemNXB a = new frmThemNXB();
            a.MdiParent = this;
            a.Show();
        }

        private void thêmKệSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemKeSach a = new frmThemKeSach();
            a.MdiParent = this;
            a.Show();
        }

        private void thêmTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemTacGia a = new frmThemTacGia();
            a.MdiParent = this;
            a.Show();
        }

        private void thêmĐầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemDauSach a = new frmThemDauSach();
            a.MdiParent = this;
            a.Show();
        }

        private void thêmCuốnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemCuonSach a = new frmThemCuonSach();
            a.MdiParent = this;
            a.Show();
        }

        private void hủyCuốnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuyCuonSach a = new frmHuyCuonSach();
            a.MdiParent = this;
            a.Show();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh a = new frmThayDoiQuyDinh();
            a.MdiParent = this;
            a.Show();
        }

        private void vPTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVPTreSach a = new frmVPTreSach();
            a.MdiParent = this;
            a.Show();
        }

        private void vPLàmHưSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVPHuSach a = new frmVPHuSach();
            a.MdiParent = this;
            a.Show();
        }

        private void vPLàmMấtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVPMatSach a = new frmVPMatSach();
            a.MdiParent = this;
            a.Show();
        }

        private void thêmNgônNgữToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThemNgonNgu a = new frmThemNgonNgu();
            a.MdiParent = this;
            a.Show();
        }

        private void cấpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapLai a = new frmCapLai();
            a.MdiParent = this;
            a.Show();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinPhanMem a = new frmThongTinPhanMem();
            a.MdiParent = this;
            a.Show();
        }

        private void sửaThôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuaThongTinDS a = new frmSuaThongTinDS();
            a.MdiParent = this;
            a.Show();

        }

        private void lậpBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRThongKe a = new frmCRThongKe();
            a.MdiParent = this;
            a.Show();
        }

        private void truyVếtBạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTruyVet a = new frmTruyVet();
            a.MdiParent = this;
            a.Show();
        }

        private void truyVếtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTruyVetSach a = new frmTruyVetSach();
            a.MdiParent = this;
            a.Show();
        }
    }
}
