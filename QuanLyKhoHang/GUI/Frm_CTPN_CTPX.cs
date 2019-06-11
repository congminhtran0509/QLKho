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
    public partial class Frm_CTPN_CTPX : Form
    {
        public Frm_CTPN_CTPX()
        {
            InitializeComponent();
        }
        BUS_CTPN ctpn = new BUS_CTPN();
        BUS_CTPX ctpx = new BUS_CTPX();
        private void Frm_CTPN_CTPX_Load(object sender, EventArgs e)
        {
            radioBtnCTPN.Checked = true;
            btnLoad_Click(sender, e);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cbxMaMH.DataSource = ctpn.Load_BUS("select * from MatHang");
            try
            {
                cbxMaMH.DisplayMember = "TenHang";
                cbxMaMH.ValueMember = "MaHang";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!! Ứng dụng sẽ dừng, Mời bạn quay lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (ctpn.Load_BUS("select * from MatHang").Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu về mặt hàng!! Hãy thêm mặt hàng vào hệ thống!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                if (radioBtnCTPN.Checked)
                {
                    if (ctpn.Load_BUS("select * from PhieuNhap").Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu về phiếu nhập!! Hãy thêm phiếu nhập vào hệ thống!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    cbxMaPNX.DataSource = ctpn.Load_BUS("select * from PhieuNhap");
                    cbxMaPNX.DisplayMember = "MaPN";
                    cbxMaPNX.ValueMember = "MaPN";
                    dtgvPhieuNX.DataSource = ctpn.Load_BUS("select * from PhieuNhap");
                    dtgvCTPNX.DataSource = ctpn.Load_BUS("select * from CTPN");
                }
                else if (radioBtnCTPX.Checked)
                {
                    if (ctpx.Load_BUS("select * from PhieuXuat").Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu về phiếu xuất!! Hãy thêm phiếu xuất vào hệ thống!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    cbxMaPNX.DataSource = ctpx.Load_BUS("select * from PhieuXuat");
                    cbxMaPNX.DisplayMember = "MaPX";
                    cbxMaPNX.ValueMember = "MaPX";
                    dtgvPhieuNX.DataSource = ctpx.Load_BUS("select * from PhieuXuat");
                    dtgvCTPNX.DataSource = ctpx.Load_BUS("select * from CTPX");
                }
            cbxMaPNX.Text = "";
            cbxMaMH.Text = "";
            txtSL.Text="";
            txtDG.Text = "";
        }

        private void radioBtnCTPN_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radioBtnCTPN.Checked) btnLoad_Click(sender, e);
        }

        private void radioBtnCTPX_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radioBtnCTPX.Checked) btnLoad_Click(sender, e);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgvCTPNX_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            if (radioBtnCTPN.Checked)
            {
                try
                {
                    CTPN ob = new CTPN(cbxMaPNX.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text), Convert.ToSingle(txtDG.Text));
                    i = ctpn.Insert(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
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
                        s = "Không thể thêm dữ liệu!!\n chi tiết phiếu nhập này đã tồn tại!!";
                        break;
                    case 3:
                        s = "Không thể thêm dữ liệu!!\n Giá trị số lượng hay đơn giá không hợp lệ!!";
                        break;
                    case 0:
                        s = "Lỗi!! Không thể thêm dữ liệu!!";
                        break;
                }
            }
            else if (radioBtnCTPX.Checked)
            {
                try
                {
                    CTPX ob = new CTPX(cbxMaPNX.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text), Convert.ToSingle(txtDG.Text));
                    i = ctpx.Insert(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
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
                        s = "Không thể thêm dữ liệu!!\n chi tiết phiếu xuất này đã tồn tại!!";
                        break;
                    case 3:
                        s = "Không thể thêm dữ liệu!!\n Giá trị số lượng hay đơn giá không hợp lệ!!";
                        break;
                    case 4:
                        s = "Không thể thêm dữ liệu!!\n Trong kho không có mặt hàng đang cần!!\n Vui lòng lấy tại kho khác!";
                        break;
                    case 5:
                        s = "Không thể thêm dữ liệu!!\n Số lượng hàng cần có trong kho không đủ!!";
                        break;
                    case 0:
                        s = "Lỗi!! Không thể thêm dữ liệu!!";
                        break;
                }
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvCTPNX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvCTPNX_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                cbxMaPNX.SelectedValue = dtgvCTPNX.Rows[i].Cells[0].Value.ToString();
                cbxMaMH.SelectedValue = dtgvCTPNX.Rows[i].Cells[1].Value.ToString();
                txtSL.Text = dtgvCTPNX.Rows[i].Cells[2].Value.ToString();
                txtDG.Text = dtgvCTPNX.Rows[i].Cells[3].Value.ToString();
            }
            catch { MessageBox.Show("Bạn đã click vào ngoài vùng dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            if (radioBtnCTPN.Checked)
            {
                try
                {
                    CTPN ob = new CTPN(cbxMaPNX.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text), Convert.ToSingle(txtDG.Text));
                    i = ctpn.Update(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
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
                        s = "Không thể sửa dữ liệu!!\n Mã phiếu nhập này không tồn tại!!";
                        break;
                    case 3:
                        s = "Không thể sửa dữ liệu!!\n Giá trị số lượng hay đơn giá không hợp lệ!!";
                        break;
                    case 0:
                        s = "Lỗi!! Không thể sửa dữ liệu!!";
                        break;
                }
            }
            else if (radioBtnCTPX.Checked)
            {
                try
                {
                    CTPX ob = new CTPX(cbxMaPNX.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text), Convert.ToSingle(txtDG.Text));
                    i = ctpx.Update(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
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
                        s = "Không thể sửa dữ liệu!!\n Mã phiếu xuất này không tồn tại!!";
                        break;
                    case 3:
                        s = "Không thể sửa dữ liệu!!\n Giá trị số lượng hay đơn giá không hợp lệ!!";
                        break;
                    case 4:
                        s = "Không thể sửa dữ liệu!!\n Số lượng hàng cần có trong kho không đủ!!";
                        break;
                    case 0:
                        s = "Lỗi!! Không thể sửa dữ liệu!!";
                        break;
                }
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            if (radioBtnCTPN.Checked)
            {
                try
                {
                    CTPN ob = new CTPN(cbxMaPNX.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text), Convert.ToSingle(txtDG.Text));
                    i = ctpn.Delete(ob);
                }
                catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            }
            else if (radioBtnCTPX.Checked)
            {
                try
                {
                    CTPX ob = new CTPX(cbxMaPNX.SelectedValue.ToString(), cbxMaMH.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text), Convert.ToSingle(txtDG.Text));
                    i = ctpx.Delete(ob);
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
                    s = "Không thể xóa dữ liệu!!\n Chi tiết phiếu này không tồn tại!!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể xóa dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvPhieuNX_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string bind = dtgvPhieuNX.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (radioBtnCTPN.Checked)
                    dtgvCTPNX.DataSource = ctpn.Load_BUS("select * from CTPN where MaPN = '" + bind + "'");
                else if (radioBtnCTPX.Checked)
                    dtgvCTPNX.DataSource = ctpx.Load_BUS("select * from CTPX where MaPX = '" + bind + "'");
            }
            catch { MessageBox.Show("Bạn đã click vào ngoài vùng dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
