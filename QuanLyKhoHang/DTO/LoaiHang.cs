using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHang
    {
        string malh;
        string tenlh;

        public string MaLH { get { return malh; } set { malh = value; } }
        public string TenLH { get { return tenlh; } set { tenlh = value; } }

        public LoaiHang() { }
        public LoaiHang(string ma, string ten)
        {
            MaLH = ma;
            TenLH = ten;
        }
    }
}
