﻿using System;
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
            string str = @"Data Source=DESKTOP-6GG2D7G\DATASSMS;Initial Catalog=QuanLYSinhVIen;Integrated Security=True";
            SqlConnection con = new SqlConnection(str); // khoi tao connect
            return con;
        }
    }

    public class AccessData
    {
        public static string checkLoginDTO(account acc)
        {
            string user = null;

            // ham connect toi co so du lieu
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_logic", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", acc.User_name);
            cmd.Parameters.AddWithValue("@pass", acc.Password);
            // neu kiem tra quyen thi them 1 cai param o day

            cmd.Connection = conn;
            SqlDataReader reader= cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Username or password is incorrect.";
            }

            return user;
        }
    }
}
