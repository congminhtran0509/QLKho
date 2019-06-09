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
    public class BUS_CTMH
    {
        DAL_CTMH ctmh = new DAL_CTMH();
        public int Insert(CTMH h)
        {
            return ctmh.Insert(h);
        }
        public int Update(CTMH h)
        {
            return ctmh.Update(h);
        }
        public int Delete(CTMH h)
        {
            return ctmh.Delete(h);
        }
        public DataTable Load_BUS(string sql)
        {
            return ctmh.Load_DAL(sql);
        }
    }
}
