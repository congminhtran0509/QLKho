using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        string makh;
        string tenkh;
        string diachi;
        string dienthoai;
        string email;

        public string MaKH { get { return makh; } set { makh = value; } }
        public string TenKH { get { return tenkh; } set { tenkh = value; } }
        public string DiaChi { get { return diachi; } set { diachi = value; } }
        public string DT { get { return dienthoai; } set { dienthoai = value; } }
        public string Email { get { return email; } set { email = value; } }

        public KhachHang() { }
        public KhachHang(string ma, string ten, string dc, string dt, string e)
        {
            MaKH = ma;
            TenKH = ten;
            DiaChi = dc;
            DT = dt;
            Email = e;
        }
    }
}
