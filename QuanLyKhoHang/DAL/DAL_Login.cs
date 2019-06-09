using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_Login:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }
    }
}
