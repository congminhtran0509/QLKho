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
    public class BUS_MatHang
    {
        DAL_MatHang mh = new DAL_MatHang();
        public int Insert(MatHang h)
        {
            return mh.Insert(h);
        }
        public int Update(MatHang h)
        {
            return mh.Update(h);
        }
        public int Delete(MatHang h)
        {
            return mh.Delete(h);
        }
        public DataTable Load_BUS(string sql)
        {
            return mh.Load_DAL(sql);
        }
    }
}
