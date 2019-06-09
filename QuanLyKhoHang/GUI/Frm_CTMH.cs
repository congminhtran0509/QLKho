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
    public partial class Frm_CTMH : Form
    {
        public Frm_CTMH()
        {
            InitializeComponent();
        }
        BUS_CTMH ctmh = new BUS_CTMH();
        private void Frm_CTMH_Load(object sender, EventArgs e)
        {
            cbxMaKho.DataSource = ctmh.Load_BUS("select * from Kho");
            cbxMaKho.DisplayMember = "TenKho";
            cbxMaKho.ValueMember = "MaKho";
            cbxMaMH.DataSource = ctmh.Load_BUS("select * from MatHang");
            cbxMaMH.DisplayMember = "TenHang";
            cbxMaMH.ValueMember = "MaHang";
            dtgvCTMH.DataSource = ctmh.Load_BUS("select * from CTMH");
            cbxMaKho.Text = "";
            cbxMaMH.Text = "";
            txtSL.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            try {
                CTMH ob = new CTMH(cbxMaKho.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text));
                i = ctmh.Insert(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2) s = "Không thể thêm dữ liệu!!\n Chi tiết mặt hàng này đã tồn tại!!";
            else if (i == 3) s = "Mã kho này không tồn tại!!";
            else if (i == 4) s = "Mặt hàng này không tồn tại!!";
            else if (i == 5) s = "Giá trị số lượng không hợp lệ!!";
            else if (i == 1)
            {
                s = "Thêm thành công!!";
                Frm_CTMH_Load(sender, e);
            }
            else
                s = "Lỗi!! Không thể thêm dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgvCTMH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                cbxMaKho.SelectedValue = dtgvCTMH.Rows[i].Cells[1].Value.ToString();
                cbxMaMH.SelectedValue = dtgvCTMH.Rows[i].Cells[0].Value.ToString();
                txtSL.Text = dtgvCTMH.Rows[i].Cells[2].Value.ToString();
            }
            catch { MessageBox.Show("Bạn đã click vào ngoài vùng dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            try
            {
                CTMH ob = new CTMH(cbxMaKho.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text));
                i = ctmh.Update(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2) s = "Không thể sửa!!\n Chi tiết mặt hàng này không tồn tại!!";
            else if (i == 3) s = "Giá trị số lượng không hợp lệ!!";
            else if (i == 1)
            {
                s = "Sửa thành công!!";
                Frm_CTMH_Load(sender, e);
            }
            else
                s = "Lỗi!! Không thể sửa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            try
            {
                CTMH ob = new CTMH(cbxMaKho.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text));
                i = ctmh.Delete(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2) s = "Không thể xóa!!\n Chi tiết mặt hàng này không tồn tại!!";
            else if (i == 1)
            {
                s = "Xóa thành công!!";
                Frm_CTMH_Load(sender, e);
            }
            else
                s = "Lỗi!! Không thể xóa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
