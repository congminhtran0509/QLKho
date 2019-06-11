using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Login:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(TaiKhoan tk)
        {
            if (Load_DAL("select * from Login where UserName='" + tk.Name + "'").Rows.Count > 0) return 2;
            else
            {
                SqlCommand cmd = new SqlCommand("TaoTaiKhoan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@usr", tk.Name));
                cmd.Parameters.Add(new SqlParameter("@psd", tk.Passwd));
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Update(TaiKhoan tk)
        {
            if (Load_DAL("select * from Login where UserName='" + tk.Name + "'").Rows.Count == 0) return 2;
            else
            {
                SqlCommand cmd = new SqlCommand("DoiMatKhau", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@psd", tk.Passwd));
                cmd.Parameters.Add(new SqlParameter("@usr", tk.Name));
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Delete(TaiKhoan tk)
        {
            if (Load_DAL("select * from Login where UserName='" + tk.Name + "'").Rows.Count == 0) return 2;
            else
            {
                SqlCommand cmd = new SqlCommand("XoaTaiKhoan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@usr", tk.Name));
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }
    }
}
