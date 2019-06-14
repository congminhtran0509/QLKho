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
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class Frm_BaoCao : Form
    {
        public Frm_BaoCao()
        {
            InitializeComponent();
        }
        BUS_Login login = new BUS_Login();
        private void Frm_BaoCao_Load(object sender, EventArgs e)
        {
            cbxLuaChon.Items.Add("PHIẾU XUẤT");
            cbxLuaChon.Items.Add("PHIẾU NHẬP");
            cbxLuaChon.Items.Add("CHI TIẾT PHIẾU XUẤT");
            cbxLuaChon.Items.Add("CHI TIẾT PHIẾU NHẬP");
            cbxLuaChon.Items.Add("HÀNG HÓA TỒN KHO");
            cbxLuaChon.SelectedIndex = 0;
            rabtnKhong.Checked = true;
        }

        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxLuaChon.SelectedIndex;
            cbxLuaChon2.Items.Clear();
            if (i == 0)
            {
                cbxLuaChon2.Items.Add("KHO");
                cbxLuaChon2.Items.Add("NHÂN VIÊN");
                cbxLuaChon2.Items.Add("KHÁCH HÀNG");
            }
            else if (i == 1)
            {
                cbxLuaChon2.Items.Add("KHO");
                cbxLuaChon2.Items.Add("NHÂN VIÊN");
                cbxLuaChon2.Items.Add("NHÀ CUNG CẤP");
            }
            else if (i == 2)
            {
                cbxLuaChon2.Items.Add("KHO");
                cbxLuaChon2.Items.Add("PHIẾU XUẤT");
                cbxLuaChon2.Items.Add("MẶT HÀNG");
            }
            else if (i == 3)
            {
                cbxLuaChon2.Items.Add("KHO");
                cbxLuaChon2.Items.Add("PHIẾU NHẬP");
                cbxLuaChon2.Items.Add("MẶT HÀNG");
            }
            else if (i == 4)
            {
                cbxLuaChon2.Items.Add("KHO");
                cbxLuaChon2.Items.Add("MẶT HÀNG");
                cbxLuaChon2.Items.Add("LOẠI HÀNG");
            }
            try { cbxLuaChon2.SelectedIndex = 0; } catch { }
        }

        private void cbxLuaChon2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? i = cbxLuaChon.SelectedIndex, k = cbxLuaChon2.SelectedIndex;
            if (i == 0)
            {
                if (k == 0)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaKho,TenKho from Kho");
                    cbxGiaTri.DisplayMember = "TenKho";
                    cbxGiaTri.ValueMember = "MaKho";
                }
                else if (k == 1)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaNV,TenNV from NhanVien");
                    cbxGiaTri.DisplayMember = "TenNV";
                    cbxGiaTri.ValueMember = "MaNV";
                }
                else if (k == 2)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaKH,TenKH from KhachHang");
                    cbxGiaTri.DisplayMember = "TenKH";
                    cbxGiaTri.ValueMember = "MaKH";
                }
            }
            else if (i == 1)
            {
                if (k == 0)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaKho,TenKho from Kho");
                    cbxGiaTri.DisplayMember = "TenKho";
                    cbxGiaTri.ValueMember = "MaKho";
                }
                else if (k == 1)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaNV,TenNV from NhanVien");
                    cbxGiaTri.DisplayMember = "TenNV";
                    cbxGiaTri.ValueMember = "MaNV";
                }
                else if (k == 2)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaNCC,TenNCC from NhaCC");
                    cbxGiaTri.DisplayMember = "TenNCC";
                    cbxGiaTri.ValueMember = "MaNCC";
                }
            }
            else if (i == 2)
            {
                if (k == 0)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaKho,TenKho from Kho");
                    cbxGiaTri.DisplayMember = "TenKho";
                    cbxGiaTri.ValueMember = "MaKho";
                }
                else if (k == 1)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaPX from PhieuXuat");
                    cbxGiaTri.DisplayMember = "MaPX";
                    cbxGiaTri.ValueMember = "MaPX";
                }
                else if (k == 2)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaHang,TenHang from MatHang");
                    cbxGiaTri.DisplayMember = "TenHang";
                    cbxGiaTri.ValueMember = "MaHang";
                }
            }
            else if (i == 3)
            {
                if (k == 0)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaKho,TenKho from Kho");
                    cbxGiaTri.DisplayMember = "TenKho";
                    cbxGiaTri.ValueMember = "MaKho";
                }
                else if (k == 1)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaPN from PhieuNhap");
                    cbxGiaTri.DisplayMember = "MaPN";
                    cbxGiaTri.ValueMember = "MaPN";
                }
                else if (k == 2)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaHang,TenHang from MatHang");
                    cbxGiaTri.DisplayMember = "TenHang";
                    cbxGiaTri.ValueMember = "MaHang";
                }
            }
            else if (i == 4)
            {
                if (k == 0)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaKho,TenKho from Kho");
                    cbxGiaTri.DisplayMember = "TenKho";
                    cbxGiaTri.ValueMember = "MaKho";
                }
                else if (k == 1)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaHang,TenHang from MatHang");
                    cbxGiaTri.DisplayMember = "TenHang";
                    cbxGiaTri.ValueMember = "MaHang";
                }
                else if (k == 2)
                {
                    cbxGiaTri.DataSource = login.Load_BUS("select MaLH,TenLH from LoaiHang");
                    cbxGiaTri.DisplayMember = "TenLH";
                    cbxGiaTri.ValueMember = "MaLH";
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cbxGiaTri.SelectedValue == null)
            {
                MessageBox.Show("Lỗi kết nối hoặc giá trị đã chọn không hợp lệ, hãy kiểm tra lại!! ");
            }
            else
            {
                int? i = cbxLuaChon.SelectedIndex, k = cbxLuaChon2.SelectedIndex;
                string sql = "", dc = @"";
                DataTable dt = new DataTable();
                if (i == 0)
                {
                    if (k == 0)
                        sql = "select * from PhieuXuat where MaKho='" + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 1)
                        sql = "select * from PhieuXuat where MaNV='" + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 2)
                        sql = "select * from PhieuXuat where MaKH='" + cbxGiaTri.SelectedValue.ToString() + "'";
                    else
                        sql = "select * from PhieuXuat";
                    dc = @"..\..\rptBaoCaoPX.rdlc";
                }
                else if (i == 1)
                {
                    if (k == 0)
                        sql = "select * from PhieuNhap where MaKho='" + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 1)
                        sql = "select * from PhieuNhap where MaNV='" + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 2)
                        sql = "select * from PhieuNhap where MaNCC='" + cbxGiaTri.SelectedValue.ToString() + "'";
                    else
                        sql = "select * from PhieuNhap";
                    dc = @"..\..\rptBaoCaoPN.rdlc";
                }
                else if (i == 2)
                {
                    if (k == 0)
                        sql = "select CTPX.* from CTPX inner join PhieuXuat on CTPX.MaPX=PhieuXuat.MaPX where MaKho='"
                            + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 1)
                        sql = "select CTPX.* from CTPX inner join PhieuXuat on CTPX.MaPX=PhieuXuat.MaPX where CTPX.MaPX='" 
                            + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 2)
                        sql = "select CTPX.* from CTPX inner join PhieuXuat on CTPX.MaPX=PhieuXuat.MaPX where CTPX.MaHang='" 
                            + cbxGiaTri.SelectedValue.ToString() + "'";
                    else
                        sql = "select CTPX.* from CTPX inner join PhieuXuat on CTPX.MaPX=PhieuXuat.MaPX";
                    dc = @"..\..\rptBaoCaoCTPX.rdlc";
                }
                else if (i == 3)
                {
                    if (k == 0)
                        sql = "select CTPN.* from CTPN inner join PhieuNhap on CTPN.MaPN=PhieuNhap.MaPN where MaKho='"
                            + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 1)
                        sql = "select CTPN.* from CTPN inner join PhieuNhap on CTPN.MaPN=PhieuNhap.MaPN where CTPN.MaPN='" 
                            + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 2)
                        sql = "select CTPN.* from CTPN inner join PhieuNhap on CTPN.MaPN=PhieuNhap.MaPN where CTPN.MaHang='" 
                            + cbxGiaTri.SelectedValue.ToString() + "'";
                    else
                        sql = "select CTPN.* from CTPN inner join PhieuNhap on CTPN.MaPN=PhieuNhap.MaPN";
                    dc = @"..\..\rptBaoCaoCTPN.rdlc";
                }
                else if (i == 4)
                {
                    if (k == 0)
                        sql = "select CTMH.MaKho,CTMH.MaHang,MaLH,SoLuong from CTMH inner join Kho on CTMH.MaKho=Kho.MaKho " +
                            "inner join MatHang on CTMH.MaHang=MatHang.MaHang where CTMH.MaKho='" + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 1)
                        sql = "select CTMH.MaKho,CTMH.MaHang,MaLH,SoLuong from CTMH inner join MatHang on CTMH.MaHang=MatHang.MaHang " +
                            "where CTMH.MaHang='" + cbxGiaTri.SelectedValue.ToString() + "'";
                    else if (k == 2)
                        sql = "select CTMH.MaKho,CTMH.MaHang,MaLH,SoLuong from CTMH inner join MatHang on CTMH.MaHang=MatHang.MaHang " +
                            "where MatHang.MaLH='" + cbxGiaTri.SelectedValue.ToString() + "'";
                    else
                        sql = "select CTMH.MaKho,CTMH.MaHang,MaLH,SoLuong from CTMH inner join MatHang on CTMH.MaHang=MatHang.MaHang";
                    dc = @"..\..\rptBaoCaoTonKho.rdlc";
                }
                if (rabtnNgay.Checked)
                {
                    string str = "";
                    if (i == 0 || i == 2)
                        str = "NgayXuat='"+Convert.ToDateTime(dtpkerNgay.Value)+"'";
                    else if (i == 1 || i == 3)
                        str = "NgayNhap='" + Convert.ToDateTime(dtpkerNgay.Value) + "'";
                    if (k == 0 || k == 1 || k == 2)
                        sql +=  " and " + str;
                    else
                        sql += " where " + str;
                }
                else if (rabtnThang.Checked)
                {
                    string str = "";
                    if (i == 0 || i == 2)
                        try { str = "Month(NgayXuat)=" + Convert.ToInt32(txtThangQuy.Text) + " and year(NgayXuat)=" + Convert.ToInt32(txtNam.Text); }
                        catch { MessageBox.Show("Lỗi kết nối hoặc giá trị đã chọn không hợp lệ, hãy kiểm tra lại!! "); }
                    else if (i == 1 || i == 3)
                        try { str = "Month(NgayNhap)=" + Convert.ToInt32(txtThangQuy.Text) + " and year(NgayNhap)=" + Convert.ToInt32(txtNam.Text); }
                        catch { MessageBox.Show("Lỗi kết nối hoặc giá trị đã chọn không hợp lệ, hãy kiểm tra lại!! "); }
                    if (k == 0 || k == 1 || k == 2)
                        sql += " and " + str;
                    else
                        sql += " where " + str;
                }
                else if (rabtnQuy.Checked)
                {
                    string str = "";
                    if (i == 0 || i == 2)
                        try { str = "Datepart(q,NgayXuat)=" + Convert.ToInt32(txtThangQuy.Text) + " and year(NgayXuat)=" + Convert.ToInt32(txtNam.Text); }
                        catch { MessageBox.Show("Lỗi kết nối hoặc giá trị đã chọn không hợp lệ, hãy kiểm tra lại!! "); }
                    else if (i == 1 || i == 3)
                        try { str = "Datepart(q,NgayNhap)=" + Convert.ToInt32(txtThangQuy.Text) + " and year(NgayNhap)=" + Convert.ToInt32(txtNam.Text); }
                        catch { MessageBox.Show("Lỗi kết nối hoặc giá trị đã chọn không hợp lệ, hãy kiểm tra lại!! "); }
                    if (k == 0 || k == 1 || k == 2)
                        sql += " and " + str;
                    else
                        sql += " where " + str;
                }
                dt = login.Load_BUS(sql);
                string s = "";
                if (dt.Rows.Count > 0)
                {
                    rptverNX.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    rptverNX.LocalReport.ReportPath = dc;
                    ReportParameter param = new ReportParameter("param", cbxLuaChon.GetItemText(cbxLuaChon.SelectedItem) 
                        + " " + cbxGiaTri.SelectedValue.ToString() + " (" + cbxGiaTri.GetItemText(cbxGiaTri.SelectedItem) + ")");
                    rptverNX.LocalReport.SetParameters(param);
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "BaoCao";
                    rds.Value = dt;
                    rptverNX.LocalReport.DataSources.Clear();
                    rptverNX.LocalReport.DataSources.Add(rds);
                    rptverNX.RefreshReport();
                    s = "Hoàn thành thống kê!!";
                }
                else s = "Không có dữ liệu!!";
                    MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtThangQuy_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
