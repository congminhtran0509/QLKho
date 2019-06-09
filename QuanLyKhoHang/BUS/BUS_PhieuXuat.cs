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
    public class BUS_PhieuXuat
    {
        DAL_PhieuXuat px = new DAL_PhieuXuat();
        public int Insert(PhieuXuat h)
        {
            return px.Insert(h);
        }
        public int Update(PhieuXuat h)
        {
            return px.Update(h);
        }
        public int Delete(PhieuXuat h)
        {
            return px.Delete(h);
        }
        public DataTable Load_BUS(string sql)
        {
            return px.Load_DAL(sql);
        }
    }
}
