using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTPX
    {
        string mapx;
        string mahang;
        int soluong;
        float dongia;

        public string MaPX { get { return mapx; } set { mapx = value; } }
        public string MaHang { get { return mahang; } set { mahang = value; } }
        public int SoLuong { get { return soluong; } set { soluong = value; } }
        public float DonGia { get { return dongia; } set { dongia = value; } }

        public CTPX(string px, string mh, int sl, float dg)
        {
            MaPX = px;
            MaHang = mh;
            SoLuong = sl;
            DonGia = dg;
        }
    }
}
