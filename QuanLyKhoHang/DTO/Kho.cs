using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Kho
    {
        string makho;
        string tenkho;
        string diachi;
        string nvql;
        string dienthoai;

        public string MaKho { get { return makho; } set { makho = value; } }
        public string TenKho { get { return tenkho; } set { tenkho = value; } }
        public string DiaChi { get { return diachi; } set { diachi = value; } }
        public string NVQL { get { return nvql; } set { nvql = value; } }
        public string DT { get { return dienthoai; } set { dienthoai = value; } }

        public Kho() { }
        public Kho(string ma, string ten, string dc, string ql, string dt)
        {
            MaKho = ma;
            TenKho = ten;
            DiaChi = dc;
            NVQL = ql;
            DT = dt;
        }
    }
}
