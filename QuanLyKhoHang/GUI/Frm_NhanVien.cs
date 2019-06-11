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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien nv = new BUS_NhanVien();

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = nv.Load_BUS("select * from NhanVien");
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            da_tiNgaySinh.Text = "";
            txtCMND.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            txtEmail.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            try
            {
                NhanVien ob = new NhanVien(txtMaNV.Text, txtHoTen.Text, da_tiNgaySinh.Value.ToString(), txtCMND.Text,
                radioBtnNam.Checked ? "Nam" : "Nữ", txtDC.Text, txtDT.Text, txtEmail.Text);
                i = nv.Insert(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Thêm thành công!!";
                    Frm_NhanVien_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể thêm dữ liệu!!\n Mã nhân viên này đã tồn tại!!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể thêm dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtMaNV.Text = dtgvNhanVien.Rows[i].Cells[0].Value.ToString();
                txtHoTen.Text = dtgvNhanVien.Rows[i].Cells[1].Value.ToString();
                da_tiNgaySinh.Value = Convert.ToDateTime(dtgvNhanVien.Rows[i].Cells[2].Value);
                txtCMND.Text = dtgvNhanVien.Rows[i].Cells[3].Value.ToString();
                if (dtgvNhanVien.Rows[i].Cells[4].Value.ToString() == "Nam")
                    radioBtnNam.Checked = true;
                else radioBtnNu.Checked = true;
                txtDC.Text = dtgvNhanVien.Rows[i].Cells[5].Value.ToString();
                txtDT.Text = dtgvNhanVien.Rows[i].Cells[6].Value.ToString();
                txtEmail.Text = dtgvNhanVien.Rows[i].Cells[7].Value.ToString();
            }
            catch(Exception ex) { MessageBox.Show("Bạn đã click vào ngoài vùng dữ liệu!\n" + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = -1; string s = "";
            try
            {
                NhanVien ob = new NhanVien(txtMaNV.Text, txtHoTen.Text, da_tiNgaySinh.Value.ToString(), txtCMND.Text,
                radioBtnNam.Checked ? "Nam" : "Nữ", txtDC.Text, txtDT.Text, txtEmail.Text);
                i = nv.Update(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Sửa thành công!!";
                    Frm_NhanVien_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể sửa dữ liệu!!\n Mã nhân viên này không tồn tại!!";
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
                NhanVien ob = new NhanVien(txtMaNV.Text, txtHoTen.Text, da_tiNgaySinh.Value.ToString(), txtCMND.Text,
                radioBtnNam.Checked ? "Nam" : "Nữ", txtDC.Text, txtDT.Text, txtEmail.Text);
                i = nv.Delete(ob);
            }
            catch { s="Dữ liệu đã nhập không phù hợp!\n Mời nhập lại!!"; }
            switch (i)
            {
                case -2:
                    s = "Lỗi kết nối!!";
                    break;
                case 1:
                    s = "Xóa thành công!!";
                    Frm_NhanVien_Load(sender, e);
                    break;
                case 2:
                    s = "Không thể xóa dữ liệu!!\n Mã nhân viên này không tồn tại!!";
                    break;
                case 3:
                    s = "Không thể xóa!!\n Mã NV này tồn tại trong bảng PHIẾU NHẬP!";
                    break;
                case 4:
                    s = "Không thể xóa!!\n Mã NV này tồn tại trong bảng PHIẾU XUẤT!";
                    break;
                case 5:
                    s = "Không thể xóa!!\n Đây là NVQL kho! Hãy đổi NVQL rồi xóa!";
                    break;
                case 0:
                    s = "Lỗi!! Không thể xóa dữ liệu!!";
                    break;
            }
            MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
