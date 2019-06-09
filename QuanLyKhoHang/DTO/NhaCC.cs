using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCC
    {
        string mancc;
        string tenncc;
        string diachi;
        string dienthoai;
        string email;

        public string MaNCC { get { return mancc; } set { mancc = value; } }
        public string TenNCC { get { return tenncc; } set { tenncc = value; } }
        public string DiaChi { get { return diachi; } set { diachi = value; } }
        public string DT { get { return dienthoai; } set { dienthoai = value; } }
        public string Email { get { return email; } set { email = value; } }

        public NhaCC() { }
        public NhaCC(string ma, string ten, string dc, string dt, string e)
        {
            MaNCC = ma;
            TenNCC = ten;
            DiaChi = dc;
            DT = dt;
            Email = e;
        }
    }
}
