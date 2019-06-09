using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        string mapn;
        string manv;
        string ngaynhap;
        string mancc;
        string makho;

        public string MaPN { get { return mapn; } set { mapn = value; } }
        public string MaNV { get { return manv; } set { manv = value; } }
        public string NgayNhap { get { return ngaynhap; } set { ngaynhap = value; } }
        public string MaNCC { get { return mancc; } set { mancc = value; } }
        public string MaKho { get { return makho; } set { makho = value; } }

        public PhieuNhap() { }
        public PhieuNhap(string pn, string nv, string nn, string ncc, string kho)
        {
            MaPN = pn;
            MaNV = nv;
            NgayNhap = nn;
            MaNCC = ncc;
            MaKho = kho;
        }
    }
}
