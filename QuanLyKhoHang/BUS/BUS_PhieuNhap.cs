using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhieuNhap
    {
        DAL_PhieuNhap pn = new DAL_PhieuNhap();
        public int Insert(PhieuNhap h)
        {
            return pn.Insert(h);
        }
        public int Update(PhieuNhap h)
        {
            return pn.Update(h);
        }
        public int Delete(PhieuNhap h)
        {
            return pn.Delete(h);
        }
        public DataTable Load_BUS(string sql)
        {
            return pn.Load_DAL(sql);
        }
    }
}
