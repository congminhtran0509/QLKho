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
                MessageBox.Show("Lỗi kết nối!! Ứng dụng sẽ dừng, Mời bạn quay lại sau!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(0);
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
            int i = 0; string s = "";
            try
            {
                Kho ob = new Kho(txtMaKho.Text, txtTenKho.Text, txtDC.Text, cbxMaNV.SelectedValue.ToString(), txtDT.Text);
                i = kho.Insert(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2)
                s = "Không thể thêm dữ liệu!!\n Mã kho này đã tồn tại!!";
            else if (i == 1)
            {
                s = "Thêm thành công!!";
                Frm_Kho_Load(sender, e);
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
                Kho ob = new Kho(txtMaKho.Text, txtTenKho.Text, txtDC.Text, cbxMaNV.SelectedValue.ToString(), txtDT.Text);
                i = kho.Update(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2)
                s = "Mã kho này không tồn tại!!";
            else if (i == 1) { s = "Sửa thành công!!"; Frm_Kho_Load(sender, e); }
            else s = "Lỗi!! Không thể sửa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0; string s = "";
            try
            {
                Kho ob = new Kho(txtMaKho.Text, txtTenKho.Text, txtDC.Text, cbxMaNV.SelectedValue.ToString(), txtDT.Text);
                i = kho.Delete(ob);
            }
            catch { MessageBox.Show("Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (i == 2) s = "Mã kho này không tồn tại!!";
            if (i == 3) s = "Không thể xóa dữ liệu! Mã kho này có ràng buộc nhập hàng hóa!";
            if (i == 4) s = "Không thể xóa dữ liệu! Mã kho này có ràng buộc xuất hàng hóa!";
            if (i == 5) s = "Không thể xóa dữ liệu! Kho này có chứa hàng hóa!";
            else if (i == 1) { s = "Xóa thành công!!"; Frm_Kho_Load(sender, e); }
            else s = "Lỗi!! Không thể xóa dữ liệu!!";
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
