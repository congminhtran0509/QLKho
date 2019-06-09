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
    public class DAL_CTMH : DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(CTMH ctmh)
        {
            if (Load_DAL("select * from Kho where MaKho='" + ctmh.MaKho + "'").Rows.Count == 0) return 3;
            else if (Load_DAL("select * from MatHang where MaHang='" + ctmh.MaHang + "'").Rows.Count == 0) return 4;
            else if (Load_DAL("select * from CTMH where MaKho='" + ctmh.MaKho + "' and MaHang='" + ctmh.MaHang + "'").Rows.Count > 0) return 2;
            else if (ctmh.SoLuong < 0) return 5;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Insert_CTMH", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", ctmh.MaHang));
                    cmd.Parameters.Add(new SqlParameter("@kho", ctmh.MaKho));
                    cmd.Parameters.Add(new SqlParameter("@sl", ctmh.SoLuong));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                catch
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    return 0;
                }
        }

        public int Update(CTMH ctmh)
        {
            if (Load_DAL("select * from CTMH where MaKho='" + ctmh.MaKho + "' and MaHang='" + ctmh.MaHang + "'").Rows.Count == 0) return 2;
            else if (ctmh.SoLuong < 0) return 3;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Update_CTMH", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sl", ctmh.SoLuong));
                    cmd.Parameters.Add(new SqlParameter("@ma", ctmh.MaHang));
                    cmd.Parameters.Add(new SqlParameter("@kho", ctmh.MaKho));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                catch
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    return 0;
                }
        }

        public int Delete(CTMH ctmh)
        {
            if (Load_DAL("select * from CTMH where MaKho='" + ctmh.MaKho + "' and MaHang='" + ctmh.MaHang + "'").Rows.Count == 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Delete_CTMH", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", ctmh.MaHang));
                    cmd.Parameters.Add(new SqlParameter("@kho", ctmh.MaKho));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 1;
                }
                catch
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    return 0;
                }
        }
    }
}
