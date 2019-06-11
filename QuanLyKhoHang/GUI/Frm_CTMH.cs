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
            try
            {
                cbxMaKho.DisplayMember = "TenKho";
                cbxMaKho.ValueMember = "MaKho";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!! Ứng dụng sẽ dừng, Mời bạn quay lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (ctmh.Load_BUS("select * from Kho").Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu về kho!! Hãy thêm kho vào hệ thống!","Thông tin",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }
            if (ctmh.Load_BUS("select * from MatHang").Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu về mặt hàng!! Hãy thêm các mặt hàng vào hệ thống!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
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
            int i = -1; string s = "";
            try {
                CTMH ob = new CTMH(cbxMaKho.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text));
                i = ctmh.Insert(ob);
            }
            catch { s = "Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Thêm thành công!!";
                    Frm_CTMH_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể thêm dữ liệu!!\n Chi tiết mặt hàng này đã tồn tại!!";
                    break;
                case 3:
                    s = "Không thể thêm dữ liệu!!\n Giá trị số lượng không hợp lệ!!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể sửa dữ liệu!!";
                    break;
            }
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
            int i = -1; string s = "";
            try
            {
                CTMH ob = new CTMH(cbxMaKho.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text));
                i = ctmh.Update(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Sửa thành công!!";
                    Frm_CTMH_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể sửa dữ liệu!!\n Chi tiết mặt hàng này không tồn tại!!";
                    break;
                case 3:
                    s = "Không thể sửa dữ liệu!!\n Giá trị số lượng không hợp lệ!!";
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
                CTMH ob = new CTMH(cbxMaKho.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text));
                i = ctmh.Delete(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Xóa thành công!!";
                    Frm_CTMH_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể xóa dữ liệu!!\n Chi tiết mặt hàng này không tồn tại!!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể sửa dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
