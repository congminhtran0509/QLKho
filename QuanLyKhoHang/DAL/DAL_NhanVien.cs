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
    public class DAL_NhanVien:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(NhanVien nv)
        {
            if (Load_DAL("select * from NhanVien where MaNV = '" + nv.MaNV + "'").Rows.Count > 0) return 2;
            else
            {
                string sql = "exec Insert_NV @manv , @ht , @ns , @cmnd , @gt , @dc , @dt , @email";
                SqlCommand cmd = new SqlCommand(sql, con);
                object[] param = { nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CMND, nv.GT, nv.DiaChi, nv.DT, nv.Email };
                int i = 0;
                string[] lstParam = sql.Split(' ');
                foreach (string item in lstParam)
                   if (item.Contains('@'))
                   {
                       if (i == 2) cmd.Parameters.AddWithValue(item, Convert.ToDateTime(param[i]));
                       else cmd.Parameters.AddWithValue(item, param[i]);
                       i++;
                   }
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Update(NhanVien nv)
        {
            string sql = "select * from NhanVien where MaNV = '" + nv.MaNV + "'";
            if (Load_DAL(sql).Rows.Count == 0) return 2;
            else
                {
                    SqlCommand cmd = new SqlCommand("Update_NV", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ht", nv.HoTen));
                    cmd.Parameters.Add(new SqlParameter("@ns", Convert.ToDateTime(nv.NgaySinh)));
                    cmd.Parameters.Add(new SqlParameter("@cmnd", nv.CMND));
                    cmd.Parameters.Add(new SqlParameter("@gt", nv.GT));
                    cmd.Parameters.Add(new SqlParameter("@dc", nv.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@dt", nv.DT));
                    cmd.Parameters.Add(new SqlParameter("@email", nv.Email));
                    cmd.Parameters.Add(new SqlParameter("@manv", nv.MaNV));
                    try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                    try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Delete(NhanVien nv)
        {
            if (Load_DAL("select * from NhanVien where MaNV = '" + nv.MaNV + "'").Rows.Count == 0) return 2;
            else if (Load_DAL("select * from PhieuNhap where MaNV = '" + nv.MaNV + "'").Rows.Count > 0) return 3;
            else if (Load_DAL("select * from PhieuXuat where MaNV = '" + nv.MaNV + "'").Rows.Count > 0) return 4;
            else if (Load_DAL("select * from Kho where NVQL = '" + nv.MaNV + "'").Rows.Count > 0) return 5;
            else {
                SqlCommand cmd = new SqlCommand("Delete_NV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manv", nv.MaNV));
                try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        } 
    }
}
