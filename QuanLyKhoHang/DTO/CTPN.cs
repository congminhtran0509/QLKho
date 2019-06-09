using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTPN
    {
        string mapn;
        string mahang;
        int soluong;
        float dongia;

        public string MaPN { get { return mapn; } set { mapn = value; } }
        public string MaHang { get { return mahang; } set { mahang = value; } }
        public int SoLuong { get { return soluong; } set { soluong = value; } }
        public float DonGia { get { return dongia; } set { dongia = value; } }

        public CTPN() { }
        public CTPN(string pn, string mh, int sl, float dg)
        {
            MaPN = pn;
            MaHang = mh;
            SoLuong = sl;
            DonGia = dg;
        }
    }
}
