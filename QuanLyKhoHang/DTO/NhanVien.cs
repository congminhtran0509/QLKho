using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        string manv;
        string hoten;
        string ngaysinh;
        string cmnd;
        string gioitinh;
        string diachi;
        string dienthoai;
        string email;

        public string MaNV { get { return manv; } set { manv = value; } }
        public string HoTen { get { return hoten; } set { hoten = value; } }
        public string NgaySinh { get { return ngaysinh; } set { ngaysinh = value; } }
        public string GT { get { return gioitinh; } set { gioitinh = value; } }
        public string CMND { get { return cmnd; } set { cmnd = value; } }
        public string DiaChi { get { return diachi; } set { diachi = value; } }
        public string DT { get { return dienthoai; } set { dienthoai = value; } }
        public string Email { get { return email; } set { email = value; } }

        public NhanVien() { }
        public NhanVien(string mnv, string ht, string ns, string cmt, string gt, string dc, string dt, string em)
        {
            MaNV = mnv;
            HoTen = ht;
            NgaySinh = ns;
            CMND = cmt;
            GT = gt;
            DiaChi = dc;
            DT = dt;
            Email = em;
        }
    }
}
