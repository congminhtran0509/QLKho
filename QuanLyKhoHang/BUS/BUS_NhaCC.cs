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
    public class BUS_NhaCC
    {
        DAL_NhaCC ncc = new DAL_NhaCC();
        public int Insert(NhaCC cc)
        {
            return ncc.Insert(cc);
        }
        public int Update(NhaCC cc)
        {
            return ncc.Update(cc);
        }
        public int Delete(NhaCC cc)
        {
            return ncc.Delete(cc);
        }
        public DataTable Load_BUS(string sql)
        {
            return ncc.Load_DAL(sql);
        }
    }
}
