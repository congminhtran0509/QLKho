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
            else if (i == 5)
            {
                if (k == 0)
                    sql = "select distinct MatHang.*,TenLH from MatHang inner join LoaiHang on MatHang.MaLH=LoaiHang.MaLH where MaHang like '%" 
                        + txtNoiDung.Text + "%' or TenHang like N'%" + txtNoiDung.Text + "%' or MatHang.MaLH like '%" + txtNoiDung.Text 
                        + "%' or TenLH like N'%"+txtNoiDung.Text+"%'";
                else
                    sql = "select * from MatHang";
            }
            else if (i == 6)
            {
                if (k == 0)
                    sql = "select distinct PhieuNhap.*,TenNV,TenNCC,TenKho from PhieuNhap inner join NhanVien on PhieuNhap.MaNV=NhanVien.MaNV " +
                        "inner join NhaCC on PhieuNhap.MaNCC=NhaCC.MaNCC inner join Kho on Kho.MaKho=PhieuNhap.MaKho where PhieuNhap.MaPN like '%"
                        + txtNoiDung.Text + "%' or PhieuNhap.MaNV like '%" + txtNoiDung.Text + "%' or TenNV like N'%" + txtNoiDung.Text
                        + "%' or PhieuNhap.MaNCC like '%" + txtNoiDung.Text + "%' or TenNCC like N'%" + txtNoiDung.Text + "%' or PhieuNhap.MaKho like '%"
                        + txtNoiDung.Text + "%' or TenKho like N'%" + txtNoiDung.Text + "%' order by NgayNhap desc";
                else if (k == 1)
                    try
                    {
                        sql = "select * from PhieuNhap where Month(NgayNhap) = Convert(int,Left('" + txtNoiDung.Text + "',2)) " +
                            " and year(NgayNhap)=Convert(int,right(rtrim('" + txtNoiDung.Text +"'),4)) order by NgayNhap asc";
                    }
                    catch (Exception ex) { MessageBox.Show("Dữ liệu cần tìm đã nhập không hợp lệ!\n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (k == 2)
                    try
                    {
                        sql = "select * from PhieuNhap where NgayNhap = '" + Convert.ToDateTime(txtNoiDung.Text) + "'";
                    }
                    catch (Exception ex) { MessageBox.Show("Dữ liệu cần tìm đã nhập không hợp lệ!\n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                    sql = "select * from PhieuNhap order by NgayNhap desc";
            }
            else if (i == 7)
            {
                if (k == 0)
                    sql = "select distinct PhieuXuat.*,TenNV,TenKH,TenKho from PhieuXuat inner join NhanVien on PhieuXuat.MaNV=NhanVien.MaNV " +
                        "inner join KhachHang on PhieuXuat.MaKH=KhachHang.MaKH inner join Kho on Kho.MaKho=PhieuXuat.MaKho where PhieuXuat.MaPX like '%"
                        + txtNoiDung.Text + "%' or PhieuXuat.MaNV like '%" + txtNoiDung.Text + "%' or TenNV like N'%" + txtNoiDung.Text
                        + "%' or PhieuXuat.MaKH like '%" + txtNoiDung.Text + "%' or TenKH like N'%" + txtNoiDung.Text + "%' or PhieuXuat.MaKho like '%"
                        + txtNoiDung.Text + "%' or TenKho like N'%" + txtNoiDung.Text + "%'  order by NgayXuat desc";
                else if (k == 1)
                    try
                    {
                        sql = "select * from PhieuXuat where Month(NgayXuat) = Convert(int,Left('" + txtNoiDung.Text + "',2)) " +
                            " and year(NgayXuat)=Convert(int,right(rtrim('" + txtNoiDung.Text + "'),4)) order by NgayXuat asc";
                    }
                    catch (Exception ex) { MessageBox.Show("Dữ liệu cần tìm đã nhập không hợp lệ!\n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (k == 2)
                    try
                    {
                        sql = "select * from PhieuXuat where NgayXuat = '" + Convert.ToDateTime(txtNoiDung.Text) + "'";
                    }
                    catch (Exception ex) { MessageBox.Show("Dữ liệu cần tìm đã nhập không hợp lệ!\n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                    sql = "select * from PhieuXuat order by NgayXuat desc";
            }
            else if (i == 8)
            {
                if (k == 0)
                    sql = "select distinct CTPN.*,TenHang from MatHang inner join CTPN on MatHang.MaHang=CTPN.MaHang inner join PhieuNhap " +
                        " on PhieuNhap.MaPN=CTPN.MaPN where CTPN.MaPN like '%" + txtNoiDung.Text + "%' or CTPN.MaHang like '%"
                        + txtNoiDung.Text + "%' or TenHang like N'%" + txtNoiDung.Text + "%'";
                else
                    sql = "select * from CTPN";
            }
            else if (i == 9)
            {
                if (k == 0)
                    sql = "select distinct CTPX.*,TenHang from MatHang inner join CTPX on MatHang.MaHang=CTPX.MaHang inner join PhieuXuat " +
                        " on PhieuXuat.MaPX=CTPX.MaPX where CTPX.MaPX like '%" + txtNoiDung.Text + "%' or CTPX.MaHang like '%"
                        + txtNoiDung.Text + "%' or TenHang like N'%" + txtNoiDung.Text + "%'";
                else
                    sql = "select * from CTPX";
            }
            else if (i == 10)
            {
                if (k == 0)
                    sql = "select distinct CTMH.*,TenHang,TenKho,TenLH from MatHang inner join CTMH on MatHang.MaHang=CTMH.MaHang inner join Kho " +
                        " on Kho.MaKho=CTMH.MaKho inner join LoaiHang on MatHang.MaLH=loaiHang.MaLH where CTMH.MaKho like '%" + txtNoiDung.Text 
                        + "%' or CTMH.MaHang like '%" + txtNoiDung.Text + "%' or TenHang like N'%" + txtNoiDung.Text + "%' or TenKho like N'%" 
                        + txtNoiDung.Text + "%' or MatHang.MaLH like '%" + txtNoiDung.Text + "%' or TenLH like N'%" + txtNoiDung.Text + "%'";
                else if (k == 1)
                    try
                    {
                        sql = "select * from CTMH where SoLuong < " + Convert.ToInt32(txtNoiDung.Text);
                    }
                    catch (Exception ex) { MessageBox.Show("Dữ liệu cần tìm đã nhập không hợp lệ!\n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                    sql = "select * from CTMH";
            }
            dtgvKQ.DataSource = login.Load_BUS(sql);
            txtKQ.Text = login.Load_BUS(sql).Rows.Count.ToString();
            MessageBox.Show("Hoàn thành tìm kiếm!\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cbxLuaChon2.Items.Add("Tháng (MM/YYYY)");
                cbxLuaChon2.Items.Add("Ngày (MM/DD/YYYY)");
            }
            else if (i == 8 || i==9)
            {
                cbxLuaChon2.Items.Add("Hàng hóa hoặc Mã phiếu");
            }
            else if (i == 10)
            {
                cbxLuaChon2.Items.Add("Hàng hóa hoặc Kho hoặc Loại hàng");
                cbxLuaChon2.Items.Add("Số lượng < x");
            }
        }

        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
