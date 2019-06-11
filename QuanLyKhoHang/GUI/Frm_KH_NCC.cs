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
    public partial class Frm_KH_NCC : Form
    {
        public Frm_KH_NCC()
        {
            InitializeComponent();
        }

        BUS_KhachHang kh = new BUS_KhachHang();
        BUS_NhaCC ncc = new BUS_NhaCC();
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (radioBtnKH.Checked)
                dtgvDoiTac.DataSource = kh.Load_BUS("select * from KhachHang");
            else if (radioBtnNCC.Checked)
                dtgvDoiTac.DataSource = ncc.Load_BUS("select * from NhaCC");
            txtMa.Text = "";
            txtTen.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            txtEmail.Text = "";
        }

        private void dtgvDoiTac_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtMa.Text = dtgvDoiTac.Rows[i].Cells[0].Value.ToString();
                txtTen.Text = dtgvDoiTac.Rows[i].Cells[1].Value.ToString();
                txtDC.Text = dtgvDoiTac.Rows[i].Cells[2].Value.ToString();
                txtDT.Text = dtgvDoiTac.Rows[i].Cells[3].Value.ToString();
                txtEmail.Text = dtgvDoiTac.Rows[i].Cells[4].Value.ToString();
            }
            catch { MessageBox.Show("Bạn đã click vào ngoài vùng dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            if (radioBtnKH.Checked)
            {
                try
                {
                    KhachHang ob = new KhachHang(txtMa.Text, txtTen.Text, txtDC.Text, txtDT.Text, txtEmail.Text);
                    i = kh.Insert(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            }
            else if (radioBtnNCC.Checked)
            {
                try
                {
                    NhaCC ob = new NhaCC(txtMa.Text, txtTen.Text, txtDC.Text, txtDT.Text, txtEmail.Text);
                    i = ncc.Insert(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Thêm thành công!!";
                    btnLoad_Click(sender, e);
                    break;
                case 2:
                    s = "Không thể thêm dữ liệu!!\n Mã đối tác này đã tồn tại!!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể thêm dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Frm_KH_NCC_Load(object sender, EventArgs e)
        {
            radioBtnKH.Checked = true;
            btnLoad_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            if (radioBtnKH.Checked)
            {
                try
                {
                    KhachHang ob = new KhachHang(txtMa.Text, txtTen.Text, txtDC.Text, txtDT.Text, txtEmail.Text);
                    i = kh.Update(ob);
                }
                catch {s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            }
            else if (radioBtnNCC.Checked)
            {
                try
                {
                    NhaCC ob = new NhaCC(txtMa.Text, txtTen.Text, txtDC.Text, txtDT.Text, txtEmail.Text);
                    i = ncc.Update(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Sửa thành công!!";
                   btnLoad_Click(sender, e);
                    break;
                case 2:
                    s = "Không thể sửa dữ liệu!!\n Mã đối tác này không tồn tại!!";
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
            if (radioBtnKH.Checked)
            {
                try
                {
                    KhachHang ob = new KhachHang(txtMa.Text, txtTen.Text, txtDC.Text, txtDT.Text, txtEmail.Text);
                    i = kh.Delete(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            }
            else if (radioBtnNCC.Checked)
            {
                try
                {
                    NhaCC ob = new NhaCC(txtMa.Text, txtTen.Text, txtDC.Text, txtDT.Text, txtEmail.Text);
                    i = ncc.Delete(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Xóa thành công!!";
                    btnLoad_Click(sender, e);
                    break;
                case 2:
                    s = "Không thể xóa dữ liệu!!\n Mã đối tác này không tồn tại!!";
                    break;
                case 3:
                    s = "Không thể xóa!!\n Đối tác này tồn tại trong bảng giao dịch!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể xóa dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioBtnKH_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radioBtnKH.Checked) btnLoad_Click(sender, e);
        }

        private void radioBtnNCC_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radioBtnNCC.Checked) btnLoad_Click(sender, e);
        }
    }
}
