using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=FLLXOA737G4K4BX\SQLEXPRESS01;Initial Catalog=QuanLyKhoHang_TTNN;Integrated Security=True");
        public DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql,con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            try { da.Fill(dt); }
            catch { }
            dt.AcceptChanges();
            return dt;
        }
    }
}
