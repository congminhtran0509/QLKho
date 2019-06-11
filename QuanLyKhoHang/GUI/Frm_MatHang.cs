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
                Application.Exit();
            }
            if (mh.Load_BUS("select * from LoaiHang").Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu về loại hàng!! Hãy thêm loại hàng vào hệ thống!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
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
            int i = -1; string s = "";
            try
            {
                MatHang ob = new MatHang(txtMaMH.Text, txtTenMH.Text, cbxMaLH.SelectedValue.ToString(), txtDVT.Text);
                i = mh.Insert(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Thêm thành công!!";
                    Frm_MatHang_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể thêm dữ liệu!!\n Mã mặt hàng này đã tồn tại!!";
                    break;
                case 3:
                    s = "Không thể thêm dữ liệu!!\n Hãy chọn tên mặt hàng khác, tên mặt hàng này đã có trong hệ thống!!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể thêm dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            try
            {
                MatHang ob = new MatHang(txtMaMH.Text, txtTenMH.Text, cbxMaLH.SelectedValue.ToString(), txtDVT.Text);
                i = mh.Update(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Sửa thành công!!";
                    Frm_MatHang_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể sửa dữ liệu!!\n Mã mặt hàng này không tồn tại!!";
                    break;
                case 3:
                    s = "Không thể sửa tên mặt hàng!!\n Hãy chọn tên mặt hàng khác, mặt hàng này đã có trong hệ thống!!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể sửa dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            try
            {
                MatHang ob = new MatHang(txtMaMH.Text, txtTenMH.Text, cbxMaLH.SelectedValue.ToString(), txtDVT.Text);
                i = mh.Delete(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Xóa thành công!!";
                    Frm_MatHang_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể xóa dữ liệu!!\n Mã mặt hàng này không tồn tại!!";
                    break;
                case 3:
                    s = "Không thể xóa!! Mặt hàng này tồn tại trong CTPN!";
                    break;
                case 4:
                    s = "Không thể xóa!! Mặt hàng này tồn tại trong CTPX!";
                    break;
                case 5:
                    s = "Không thể xóa!! Mặt hàng này tồn tại trong hệ thống kho!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể xóa dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
