using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        public SqlDataAdapter da;
        public DataTable dt;
        public SqlCommand cmd;
        SqlConnection conn;
        public SqlConnection LayKetNoi()
        {
            string sql = "Data Source=DESKTOP-VL6AKQP\\SQLEXPRESS02;Initial Catalog=QLKS;Integrated Security=True";
            return new SqlConnection(sql);
        }
        // hàm lấy bảng động của store
        public DataTable LayBang(string sql)
        {
            DataTable dt = null;
            try
            {
                conn = LayKetNoi();
                conn.Open();
                dt = new DataTable();
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi rồi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

    }
}
