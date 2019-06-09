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
    public class DAL_Kho:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(Kho kho)
        {
            if (Load_DAL("select * from Kho where MaKho='" + kho.MaKho + "'").Rows.Count > 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Insert_Kho", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", kho.MaKho));
                    cmd.Parameters.Add(new SqlParameter("@ten", kho.TenKho));
                    cmd.Parameters.Add(new SqlParameter("@dc", kho.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@nvql", kho.NVQL));
                    cmd.Parameters.Add(new SqlParameter("@dt", kho.DT));
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

        public int Update(Kho kho)
        {
            if (Load_DAL("select * from Kho where MaKho='" + kho.MaKho + "'").Rows.Count == 0) return 2;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Update_Kho", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ten", kho.TenKho));
                    cmd.Parameters.Add(new SqlParameter("@dc", kho.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@nvql", kho.NVQL));
                    cmd.Parameters.Add(new SqlParameter("@dt", kho.DT));
                    cmd.Parameters.Add(new SqlParameter("@ma", kho.MaKho));
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

        public int Delete(Kho kho)
        {
            if (Load_DAL("select * from Kho where MaKho='" + kho.MaKho + "'").Rows.Count == 0) return 2;
            else if (Load_DAL("select * from PhieuNhap where MaKho='" + kho.MaKho + "'").Rows.Count > 0) return 3;
            else if (Load_DAL("select * from PhieuXuat where MaKho='" + kho.MaKho + "'").Rows.Count > 0) return 4;
            else if (Load_DAL("select * from CTMH where MaKho='" + kho.MaKho + "'").Rows.Count > 0) return 5;
            else
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    SqlCommand cmd = new SqlCommand("Delete_Kho", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", kho.MaKho));
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
