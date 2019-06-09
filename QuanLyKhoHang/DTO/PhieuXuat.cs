using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuat
    {
        string mapx;
        string manv;
        string ngayxuat;
        string makh;
        string makho;

        public string MaPX { get { return mapx; } set { mapx = value; } }
        public string MaNV { get { return manv; } set { manv = value; } }
        public string NgayXuat { get { return ngayxuat; } set { ngayxuat = value; } }
        public string MaKH { get { return makh; } set { makh = value; } }
        public string MaKho { get { return makho; } set { makho = value; } }

        public PhieuXuat() { }
        public PhieuXuat(string px, string nv, string nx, string kh, string kho)
        {
            MaPX = px;
            MaNV = nv;
            NgayXuat = nx;
            MaKH = kh;
            MaKho = kho;
        }
    }
}
