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
    public class DAL_NhaCC:DBConnect
    {
        public DataTable Load_DAL(string sql)
        {
            return Load(sql);
        }

        public int Insert(NhaCC ncc)
        {
            if (Load_DAL("select * from NhaCC where MaNCC='"+ncc.MaNCC+"'").Rows.Count > 0) return 2;
            else
                {
                    SqlCommand cmd = new SqlCommand("Insert_NCC", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", ncc.MaNCC));
                    cmd.Parameters.Add(new SqlParameter("@ten", ncc.TenNCC));
                    cmd.Parameters.Add(new SqlParameter("@dc", ncc.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@dt", ncc.DT));
                    cmd.Parameters.Add(new SqlParameter("@email", ncc.Email));
                    try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                    try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Update(NhaCC ncc)
        {
            if (Load_DAL("select * from NhaCC where MaNCC='" + ncc.MaNCC + "'").Rows.Count == 0) return 2;
            else
                {
                    SqlCommand cmd = new SqlCommand("Update_NCC", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ten", ncc.TenNCC));
                    cmd.Parameters.Add(new SqlParameter("@dc", ncc.DiaChi));
                    cmd.Parameters.Add(new SqlParameter("@dt", ncc.DT));
                    cmd.Parameters.Add(new SqlParameter("@email", ncc.Email));
                    cmd.Parameters.Add(new SqlParameter("@ma", ncc.MaNCC));
                    try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                    try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }

        public int Delete(NhaCC ncc)
        {
            if (Load_DAL("select * from NhaCC where MaNCC='" + ncc.MaNCC + "'").Rows.Count == 0) return 2;
            else if(Load_DAL("select * from PhieuNhap where MaNCC='" + ncc.MaNCC + "'").Rows.Count > 0) return 3;
            else
                {
                    SqlCommand cmd = new SqlCommand("Delete_NCC", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", ncc.MaNCC));
                    try { if (con.State != ConnectionState.Open) con.Open(); } catch { return -2; }
                    try { cmd.ExecuteNonQuery(); return 1; } catch { return 0; } finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
        }
    }
}
