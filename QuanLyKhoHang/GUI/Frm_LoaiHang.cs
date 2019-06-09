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
    public partial class Frm_LoaiHang : Form
    {
        public Frm_LoaiHang()
        {
            InitializeComponent();
        }

        BUS_LoaiHang lh = new BUS_LoaiHang();
        private void Frm_LoaiHang_Load(object sender, EventArgs e)
        {
            dtgvLoaiHang.DataSource = lh.Load_BUS("select * from LoaiHang");
            txtMaLH.Text = "";
            txtTenLH.Text = "";
        }

        private void dtgvLoaiHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtMaLH.Text = dtgvLoaiHang.Rows[i].Cells[0].Value.ToString();
                txtTenLH.Text = dtgvLoaiHang.Rows[i].Cells[1].Value.ToString();
            }
            catch { MessageBox.Show("Bạn đã click vào ngoài vùng dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            try
            {
                LoaiHang ob = new LoaiHang(txtMaLH.Text, txtTenLH.Text);
                i = lh.Insert(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2)
                s = "Không thể thêm dữ liệu!!\n Mã loại hàng này đã tồn tại!!";
            else if (i == 1)
            {
                s = "Thêm thành công!!";
                Frm_LoaiHang_Load(sender, e);
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
                LoaiHang ob = new LoaiHang(txtMaLH.Text, txtTenLH.Text);
                i = lh.Update(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2)
                s = "Mã loại hàng này không tồn tại!!";
            else if (i == 1) { s = "Sửa thành công!!"; Frm_LoaiHang_Load(sender, e); }
            else s = "Lỗi!! Không thể sửa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            try
            {
                LoaiHang ob = new LoaiHang(txtMaLH.Text, txtTenLH.Text);
                i = lh.Delete(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2) s = "Mã loại hàng này không tồn tại!!";
            else if (i == 3) s = "Không thể xóa do trong hệ thống có mặt hàng thuộc loại hàng này!!";
            else if (i == 1) { s = "Xóa thành công!!"; Frm_LoaiHang_Load(sender, e); }
            else s = "Lỗi!! Không thể xóa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Frm_LoaiHang_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Frm_LoaiHang_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
