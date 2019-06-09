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
    public class BUS_LoaiHang
    {
        DAL_LoaiHang lh = new DAL_LoaiHang();
        public int Insert(LoaiHang h)
        {
            return lh.Insert(h);
        }
        public int Update(LoaiHang h)
        {
            return lh.Update(h);
        }
        public int Delete(LoaiHang h)
        {
            return lh.Delete(h);
        }
        public DataTable Load_BUS(string sql)
        {
            return lh.Load_DAL(sql);
        }
    }
}
