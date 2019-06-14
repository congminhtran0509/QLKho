using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        public static string username="";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NhanVien f = new Frm_NhanVien();
            f.Show();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LoaiHang f = new Frm_LoaiHang();
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KH_NCC f = new Frm_KH_NCC();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KH_NCC f = new Frm_KH_NCC();
            f.Show();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Kho f = new Frm_Kho();
            f.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MatHang f = new Frm_MatHang();
            f.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PN_PX f = new Frm_PN_PX();
            f.Show();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PN_PX f = new Frm_PN_PX();
            f.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
                e.Cancel = true;
        }

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CTPN_CTPX f = new Frm_CTPN_CTPX();
            f.Show();
        }

        private void chiTiếtPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CTPN_CTPX f = new Frm_CTPN_CTPX();
            f.Show();
        }

        private void chiTiếtMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CTMH f = new Frm_CTMH();
            f.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = username;
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TimKiem f = new Frm_TimKiem();
            f.Show();
        }

        private void inBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BaoCao f = new Frm_BaoCao();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
