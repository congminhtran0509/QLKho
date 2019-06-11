using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
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
        public int Insert(TaiKhoan tk)
        {
            return login.Insert(tk);
        }
        public int Update(TaiKhoan tk)
        {
            return login.Update(tk);
        }
        public int Delete(TaiKhoan tk)
        {
            return login.Delete(tk);
        }
    }
}
