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
    public partial class Frm_Kho : Form
    {
        public Frm_Kho()
        {
            InitializeComponent();
        }
        BUS_Kho kho = new BUS_Kho();
        private void Frm_Kho_Load(object sender, EventArgs e)
        {
            try {
                cbxMaNV.DataSource = kho.Load_BUS("Select MaNV,TenNV from NhanVien");
                cbxMaNV.DisplayMember = "TenNV";
                cbxMaNV.ValueMember = "MaNV";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối, hãy kiểm tra lại kết nối!!\n Ứng dụng sẽ dừng, Mời bạn quay lại sau!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
            if (kho.Load_BUS("select * from NhanVien").Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu về nhân viên!! Hãy thêm nhân viên vào hệ thống!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            dtgvKho.DataSource = kho.Load_BUS("select * from Kho");
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtDC.Text = "";
            cbxMaNV.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgvKho_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtMaKho.Text = dtgvKho.Rows[i].Cells[0].Value.ToString();
                txtTenKho.Text = dtgvKho.Rows[i].Cells[1].Value.ToString();
                txtDC.Text = dtgvKho.Rows[i].Cells[2].Value.ToString();
                cbxMaNV.SelectedValue = dtgvKho.Rows[i].Cells[3].Value.ToString();
                txtDT.Text = dtgvKho.Rows[i].Cells[4].Value.ToString();
            }
            catch { MessageBox.Show("Bạn đã click vào ngoài vùng dữ liệu!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            try
            {
                Kho ob = new Kho(txtMaKho.Text, txtTenKho.Text, txtDC.Text, cbxMaNV.SelectedValue.ToString(), txtDT.Text);
                if(kho.Load_BUS("Select * from Kho where NVQL='" + cbxMaNV.SelectedValue.ToString() + "'").Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("NVQL bạn chọn là NVQL của kho khác,\n Bạn vẫn muốn để NV này quản lý kho này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) i = kho.Insert(ob);
                    else s = "Đã hủy bỏ hành động thêm này!";
                }
                else i = kho.Insert(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Thêm thành công!!";
                    Frm_Kho_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể thêm dữ liệu!!\n Mã kho này đã tồn tại!!";
                    break;
                case 3:
                    s = "Không thể thêm dữ liệu!!\n Hãy chọn tên kho khác, Tên kho này đã tồn tại trong hệ thống!!";
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
                Kho ob = new Kho(txtMaKho.Text, txtTenKho.Text, txtDC.Text, cbxMaNV.SelectedValue.ToString(), txtDT.Text);
                if (kho.Load_BUS("Select * from Kho where NVQL='" + cbxMaNV.SelectedValue.ToString() + "' and MaKho <> '"+txtMaKho.Text+"'").Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("NVQL bạn chọn là NVQL của kho khác,\n Bạn vẫn muốn để NV này quản lý kho này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) i = kho.Update(ob);
                    else s = "Đã hủy bỏ hành động sửa này!";
                }
                else i = kho.Update(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Sửa thành công!!";
                    Frm_Kho_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể sửa dữ liệu!!\n Mã kho này không tồn tại!!";
                    break;
                case 3:
                    s = "Không thể sửa dữ liệu!!\n Hãy chọn tên kho khác, Tên kho này đã có trong hệ thống!!";
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
                Kho ob = new Kho(txtMaKho.Text, txtTenKho.Text, txtDC.Text, cbxMaNV.SelectedValue.ToString(), txtDT.Text);
                i = kho.Delete(ob);
            }
            catch {s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Xóa thành công!!"; Frm_Kho_Load(sender, e);
                    break;
                case 2:
                    s = "Mã kho này không tồn tại!!";
                    break;
                case 3:
                    s = "Không thể xóa dữ liệu! Mã kho này có ràng buộc nhập hàng hóa!";
                    break;
                case 4:
                    s = "Không thể xóa dữ liệu! Mã kho này có ràng buộc xuất hàng hóa!";
                    break;
                case 5:
                    s = "Không thể xóa dữ liệu! Kho này có chứa hàng hóa!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể xóa dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
