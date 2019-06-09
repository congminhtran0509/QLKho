using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Login
    {
        DAL_Login login = new DAL_Login();
        public DataTable Load_BUS(string sql)
        {
            return login.Load_DAL(sql);
        }
    }
}
