using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        // tao chuoi ket noi co so du lieu

        public static SqlConnection connect()
        {

            string str = @"Data Source=DESKTOP-6GG2D7G\DATASSMS;Initial Catalog=QuanLyCungCapNuocSach;Integrated Security=True";
            SqlConnection con = new SqlConnection(str); // khoi tao connect
            return con;
        }
    }

    public class AccessData
    {
        // ham do du lieu vao datable
        public static DataTable getData(string query)
        {
            SqlConnection conn = SqlConnectionData.connect();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(tb);
            conn.Close();
            return tb;
        }

        public static void execQuery(string sql)
        {
            SqlConnection conn = SqlConnectionData.connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }

    }
}
