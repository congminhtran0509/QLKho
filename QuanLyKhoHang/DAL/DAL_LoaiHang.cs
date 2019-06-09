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
    public class DAL_LoaiHang:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(LoaiHang lh)
        {
            if (Load_DAL("select * from LoaiHang where MaLH='" + lh.MaLH + "'").Rows.Count > 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Insert_LoaiHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@malh", lh.MaLH));
                    cmd.Parameters.Add(new SqlParameter("@tenlh", lh.TenLH));
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

        public int Update(LoaiHang lh)
        {
            if (Load_DAL("select * from LoaiHang where MaLH='" + lh.MaLH + "'").Rows.Count == 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Update_LoaiHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@tenlh", lh.TenLH));
                    cmd.Parameters.Add(new SqlParameter("@malh", lh.MaLH));
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

        public int Delete(LoaiHang lh)
        {
            if (Load_DAL("select * from LoaiHang where MaLH ='" + lh.MaLH + "'").Rows.Count == 0) return 2;
            else
            {
                if (Load_DAL("select * from MatHang where MaLH ='" + lh.MaLH + "'").Rows.Count > 0) return 3;
                else
                    try
                    {
                        if (con.State != ConnectionState.Open) con.Open();
                        SqlCommand cmd = new SqlCommand("Delete_LoaiHang", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@malh", lh.MaLH));
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
}
