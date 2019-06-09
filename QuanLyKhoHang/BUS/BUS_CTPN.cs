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
    public class BUS_CTPN
    {
        DAL_CTPN ctpn = new DAL_CTPN();
        public int Insert(CTPN h)
        {
            return ctpn.Insert(h);
        }
        public int Update(CTPN h)
        {
            return ctpn.Update(h);
        }
        public int Delete(CTPN h)
        {
            return ctpn.Delete(h);
        }
        public DataTable Load_BUS(string sql)
        {
            return ctpn.Load_DAL(sql);
        }
    }
}
