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
    public class BUS_KhachHang
    {
        DAL_KhachHang kh = new DAL_KhachHang();
        public int Insert(KhachHang k)
        {
            return kh.Insert(k);
        }
        public int Update(KhachHang k)
        {
            return kh.Update(k);
        }
        public int Delete(KhachHang k)
        {
            return kh.Delete(k);
        }
        public DataTable Load_BUS(string sql)
        {
            return kh.Load_DAL(sql);
        }
    }
}
