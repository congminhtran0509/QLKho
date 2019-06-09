using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTMH
    {
        string makho;
        string mahang;
        int soluong;

        public string MaKho { get { return makho; } set { makho = value; } }
        public string MaHang { get { return mahang; } set { mahang = value; } }
        public int SoLuong { get { return soluong; } set { soluong = value; } }

        public CTMH() { }
        public CTMH(string kh, string mh, int sl)
        {
            MaKho = kh;
            MaHang = mh;
            SoLuong = sl;
        }
    }
}
