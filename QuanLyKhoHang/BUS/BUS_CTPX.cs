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
    public class BUS_CTPX
    {
        DAL_CTPX ctpx = new DAL_CTPX();
        public int Insert(CTPX h)
        {
            return ctpx.Insert(h);
        }
        public int Update(CTPX h)
        {
            return ctpx.Update(h);
        }
        public int Delete(CTPX h)
        {
            return ctpx.Delete(h);
        }
        public DataTable Load_BUS(string sql)
        {
            return ctpx.Load_DAL(sql);
        }
    }
}
