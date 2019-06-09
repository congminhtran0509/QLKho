using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class Frm_MatHang : Form
    {
        public Frm_MatHang()
        {
            InitializeComponent();
        }
        BUS_MatHang mh = new BUS_MatHang();
        private void Frm_MatHang_Load(object sender, EventArgs e)
        {
            cbxMaLH.DataSource = mh.Load_BUS("select * from LoaiHang");
            try
            {
                cbxMaLH.DisplayMember = "TenLH";
                cbxMaLH.ValueMember = "MaLH";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!! Ứng dụng sẽ dừng, Mời bạn quay lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            dtgvMatHang.DataSource = mh.Load_BUS("select * from MatHang");
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtDVT.Text = "";
            cbxMaLH.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgvMatHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtMaMH.Text = dtgvMatHang.Rows[i].Cells[0].Value.ToString();
                txtTenMH.Text = dtgvMatHang.Rows[i].Cells[1].Value.ToString();
                cbxMaLH.SelectedValue = dtgvMatHang.Rows[i].Cells[2].Value.ToString();
                txtDVT.Text = dtgvMatHang.Rows[i].Cells[3].Value.ToString();
            }
            catch { MessageBox.Show("Bạn đã click vào ngoài vùng dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            try
            {
                MatHang ob = new MatHang(txtMaMH.Text, txtTenMH.Text, cbxMaLH.SelectedValue.ToString(), txtDVT.Text);
                i = mh.Insert(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2)
                s = "Không thể thêm dữ liệu!!\n Mã mặt hàng này đã tồn tại!!";
            else if (i == 1)
            {
                s = "Thêm thành công!!";
                Frm_MatHang_Load(sender, e);
            }
            else
                s = "Lỗi!! Không thể thêm dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            try
            {
                MatHang ob = new MatHang(txtMaMH.Text, txtTenMH.Text, cbxMaLH.SelectedValue.ToString(), txtDVT.Text);
                i = mh.Update(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2)
                s = "Mã mặt hàng này không tồn tại!!";
            else if (i == 1) { s = "Sửa thành công!!"; Frm_MatHang_Load(sender, e); }
            else s = "Lỗi!! Không thể sửa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            try
            {
                MatHang ob = new MatHang(txtMaMH.Text, txtTenMH.Text, cbxMaLH.SelectedValue.ToString(), txtDVT.Text);
                i = mh.Delete(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2) s = "Mã mặt hàng này không tồn tại!!";
            if (i == 3) s = "Không thể xóa!! Mặt hàng này tồn tại trong CTPN!!";
            if (i == 4) s = "Không thể xóa!! Mặt hàng này tồn tại trong CTPX!!";
            else if (i == 1) { s = "Xóa thành công!!"; Frm_MatHang_Load(sender, e); }
            else s = "Lỗi!! Không thể xóa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
