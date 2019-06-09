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
    public class BUS_Kho
    {
        DAL_Kho kho = new DAL_Kho();
        public int Insert(Kho h)
        {
            return kho.Insert(h);
        }
        public int Update(Kho h)
        {
            return kho.Update(h);
        }
        public int Delete(Kho h)
        {
            return kho.Delete(h);
        }
        public DataTable Load_BUS(string sql)
        {
            return kho.Load_DAL(sql);
        }
    }
}
