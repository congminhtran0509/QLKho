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
    public partial class Frm_PN_PX : Form
    {
        public Frm_PN_PX()
        {
            InitializeComponent();
        }

        BUS_PhieuNhap pn = new BUS_PhieuNhap();
        BUS_PhieuXuat px = new BUS_PhieuXuat();
        private void Frm_PN_PX_Load(object sender, EventArgs e)
        {
            radioBtnPN.Checked = true;
            btnLoad_Click(sender,e);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cbxMaNV.DataSource = pn.Load_BUS("select * from NhanVien");
            try
            {
                cbxMaNV.DisplayMember = "TenNV";
                cbxMaNV.ValueMember = "MaNV";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!! Ứng dụng sẽ dừng, Mời bạn quay lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            cbxMaKho.DataSource = pn.Load_BUS("select * from Kho");
            cbxMaKho.DisplayMember = "TenKho";
            cbxMaKho.ValueMember = "MaKho";
            if (radioBtnPN.Checked)
            {
                cbxMaDoiTac.DataSource = pn.Load_BUS("select * from NhaCC");
                cbxMaDoiTac.DisplayMember = "TenNCC";
                cbxMaDoiTac.ValueMember = "MaNCC";
                dtgvPhieuNX.DataSource = pn.Load_BUS("select * from PhieuNhap");
            }
            else if (radioBtnPX.Checked)
            {
                cbxMaDoiTac.DataSource = pn.Load_BUS("select * from KhachHang");
                cbxMaDoiTac.DisplayMember = "TenKH";
                cbxMaDoiTac.ValueMember = "MaKH";
                dtgvPhieuNX.DataSource = px.Load_BUS("select * from PhieuXuat");
            }
            txtMa.Text = "";
            cbxMaNV.Text = "";
            da_tiNgayNX.Value = DateTime.Now;
            cbxMaDoiTac.Text = "";
            cbxMaKho.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            if (radioBtnPN.Checked)
            {
                try
                {
                    PhieuNhap ob = new PhieuNhap(txtMa.Text, cbxMaNV.SelectedValue.ToString(), da_tiNgayNX.Value.ToString(), cbxMaDoiTac.SelectedValue.ToString(), cbxMaKho.SelectedValue.ToString());
                    i = pn.Insert(ob);
                }
                catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (radioBtnPX.Checked)
            {
                try
                {
                    PhieuXuat ob = new PhieuXuat(txtMa.Text, cbxMaNV.SelectedValue.ToString(), da_tiNgayNX.Value.ToString(), cbxMaDoiTac.SelectedValue.ToString(), cbxMaKho.SelectedValue.ToString());
                    i = px.Insert(ob);
                }
                catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            if (i == 2) s = "Không thể thêm dữ liệu!!\n Mã phiếu này đã tồn tại!!";
            else if (i == 1) { s = "Thêm thành công!!"; btnLoad_Click(sender, e); }
            else
                s = "Lỗi!! Không thể thêm dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            if (radioBtnPN.Checked)
            {
                try
                {
                    PhieuNhap ob = new PhieuNhap(txtMa.Text, cbxMaNV.SelectedValue.ToString(), da_tiNgayNX.Value.ToString(), cbxMaDoiTac.SelectedValue.ToString(), cbxMaKho.SelectedValue.ToString());
                    i = pn.Update(ob);
                }
                catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (radioBtnPX.Checked)
            {
                try
                {
                    PhieuXuat ob = new PhieuXuat(txtMa.Text, cbxMaNV.SelectedValue.ToString(), da_tiNgayNX.Value.ToString(), cbxMaDoiTac.SelectedValue.ToString(), cbxMaKho.SelectedValue.ToString());
                    i = px.Update(ob);
                }
                catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            if (i == 2) s = "Mã phiếu này không tồn tại!!";
            else if (i == 1) { s = "Sửa thành công!!"; btnLoad_Click(sender, e); }
            else s = "Lỗi!! Không thể sửa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            if (radioBtnPN.Checked)
            {
                try
                {
                    PhieuNhap ob = new PhieuNhap(txtMa.Text, cbxMaNV.SelectedValue.ToString(), da_tiNgayNX.Value.ToString(), cbxMaDoiTac.SelectedValue.ToString(), cbxMaKho.SelectedValue.ToString());
                    i = pn.Delete(ob);
                }
                catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (radioBtnPX.Checked)
            {
                try
                {
                    PhieuXuat ob = new PhieuXuat(txtMa.Text, cbxMaNV.SelectedValue.ToString(), da_tiNgayNX.Value.ToString(), cbxMaDoiTac.SelectedValue.ToString(), cbxMaKho.SelectedValue.ToString());
                    i = px.Delete(ob);
                }
                catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            if (i == 2) s = "Mã phiếu này không tồn tại!!";
            else if (i == 3) s = "Không thể xóa do mã phiếu này có giao dịch các mặt hàng!!";
            else if (i == 1) { s = "Xóa thành công!!"; btnLoad_Click(sender, e); }
            else s = "Lỗi!! Không thể xóa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvPhieuNX_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtMa.Text = dtgvPhieuNX.Rows[i].Cells[0].Value.ToString();
                cbxMaNV.SelectedValue = dtgvPhieuNX.Rows[i].Cells[1].Value.ToString();
                da_tiNgayNX.Value= Convert.ToDateTime(dtgvPhieuNX.Rows[i].Cells[2].Value.ToString());
                cbxMaDoiTac.SelectedValue= dtgvPhieuNX.Rows[i].Cells[3].Value.ToString();
                cbxMaKho.SelectedValue = dtgvPhieuNX.Rows[i].Cells[4].Value.ToString();
            }
            catch { MessageBox.Show("Bạn đã click vào ngoài vùng dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void radioBtnPX_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radioBtnPX.Checked) btnLoad_Click(sender, e);
        }

        private void radioBtnPN_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radioBtnPN.Checked) btnLoad_Click(sender, e);
        }
    }
}
