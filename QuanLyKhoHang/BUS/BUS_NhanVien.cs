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
    public class BUS_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();
        public int Insert(NhanVien n)
        {
            return nv.Insert(n);
        }
        public int Update(NhanVien n)
        {
            return nv.Update(n);
        }
        public int Delete(NhanVien n)
        {
            return nv.Delete(n);
        }
        public DataTable Load_BUS(string sql)
        {
            return nv.Load_DAL(sql);
        }
    }
}
