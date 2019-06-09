using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatHang
    {
        string mahang;
        string tenhang;
        string malh;
        string dvt;

        public string MaHang { get { return mahang; } set { mahang = value; } }
        public string TenHang { get { return tenhang; } set { tenhang = value; } }
        public string MaLH { get { return malh; } set { malh = value; } }
        public string DVT { get { return dvt; } set { dvt = value; } }

        public MatHang() { }
        public MatHang(string ma, string ten, string ml, string dv)
        {
            MaHang = ma;
            TenHang = ten;
            MaLH = ml;
            DVT = dv;
        }
    }
}
