using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class Frm_TimKiem : Form
    {
        public Frm_TimKiem()
        {
            InitializeComponent();
        }

        BUS_Login login = new BUS_Login();
        private void Frm_TimKiem_Load(object sender, EventArgs e)
        {
            string[] chon1 = new string[11];
            chon1[0] = "Nhân viên";
            chon1[1] = "Loại hàng";
            chon1[2] = "Nhà cung cấp";
            chon1[3] = "Khách hàng";
            chon1[4] = "Kho";
            chon1[5] = "Mặt hàng";
            chon1[6] = "Phiếu nhập";
            chon1[7] = "Phiếu xuất";
            chon1[8] = "Chi tiết phiếu nhập";
            chon1[9] = "Chi tiết phiếu xuất";
            chon1[10] = "Chi tiết mặt hàng";
            foreach (string i in chon1)
                cbxLuaChon.Items.Add(i);
            cbxLuaChon.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int? i = cbxLuaChon.SelectedIndex, k = cbxLuaChon2.SelectedIndex;
            string sql = "";
            if(i==0)
            {
                if (k == 0)
                    sql = "select * from NhanVien where MaNV like '%" + txtNoiDung.Text + "%' or TenNV like N'%"
                        + txtNoiDung.Text + "%' or DiaChi like N'%" + txtNoiDung.Text + "%' or GT like N'%"
                        + txtNoiDung.Text + "%'";
                else if (k == 1)
                    try
                    {
                        sql = "select * from NhanVien where Month(NgaySinh) = " + Convert.ToInt32(txtNoiDung.Text);
                    }
                    catch (Exception ex) { MessageBox.Show("Dữ liệu cần tìm đã nhập không hợp lệ!\n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (k == 2)
                    sql = "select MaKho,NhanVien.* from NhanVien inner join Kho on NhanVien.MaNV=Kho.NVQL";
                else
                    sql = "select * from NhanVien";
            }
            else if (i == 1)
            {
                if (k == 0)
                    sql = "select * from LoaiHang where MaLH like '%" + txtNoiDung.Text + "%' or TenLH like N'%" + txtNoiDung.Text + "%'";
                else
                    sql = "select * from LoaiHang";
            }
            else if (i == 2)
            {
                if (k == 0)
                    sql = "select * from NhaCC where MaNCC like '%" + txtNoiDung.Text + "%' or TenNCC like N'%"
                        + txtNoiDung.Text + "%' or DiaChi like N'%" + txtNoiDung.Text + "%'";
                else
                    sql = "select * from NhaCC";
            }
            else if (i == 3)
            {
                if (k == 0)
                    sql = "select * from KhachHang where MaKH like '%" + txtNoiDung.Text + "%' or TenKH like N'%"
                        + txtNoiDung.Text + "%' or DiaChi like N'%" + txtNoiDung.Text + "%'";
                else
                    sql = "select * from KhachHang";
            }
            else if (i == 4)
            {
                if (k == 0)
                    sql = "select * from Kho where MaKho like '%" + txtNoiDung.Text + "%' or TenKho like N'%"
                        + txtNoiDung.Text + "%' or DiaChi like N'%" + txtNoiDung.Text + "%'";
                else
                    sql = "select * from Kho";
            }
            dtgvKQ.DataSource = login.Load_BUS(sql);
            txtKQ.Text = login.Load_BUS(sql).Rows.Count.ToString();
        }

        private void cbxLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxLuaChon.SelectedIndex;
            cbxLuaChon2.Items.Clear();
            if (i == 0)
            {
                cbxLuaChon2.Items.Add("Mã, Họ tên, Địa chỉ hoặc Giới tính");
                cbxLuaChon2.Items.Add("Tháng sinh");
                cbxLuaChon2.Items.Add("Nhân viên quản lý kho");
            }
            else if (i == 1)
            {
                cbxLuaChon2.Items.Add("Mã hoặc Tên");
            }
            else if (i == 2 || i==3 || i==4)
            {
                cbxLuaChon2.Items.Add("Mã, Tên hoặc Địa chỉ");
            }
            else if (i == 5)
            {
                 cbxLuaChon2.Items.Add("Mã, Tên hoặc Loại hàng");
            }
            else if (i == 6 || i==7)
            {
                cbxLuaChon2.Items.Add("Mã phiếu, Nhân viên, Đối tác hoặc Kho");
                cbxLuaChon2.Items.Add("Ngày, Tháng hoặc Năm");
            }
            else if (i == 8 || i==9)
            {
                cbxLuaChon2.Items.Add("Hàng hóa hoặc Mã phiếu");
            }
            else if (i == 10)
            {
                cbxLuaChon2.Items.Add("Hàng hóa hoặc Kho");
                cbxLuaChon2.Items.Add("Số lượng");
            }
        }

        
    }
}
