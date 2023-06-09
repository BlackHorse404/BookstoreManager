using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace QuanLyNhaSach.DataAccess
{
    public static class DBConfig
    {
        public static string ServerName = "PHAT-MSI";
        public static string DBname = "QL_NHASACH2";
        private static string user = "sa";
        private static string pass = "12345";
        public static string Username { get { return user; } }
        public static string Password { get { return pass; } }
        public static SqlConnection getConnectString()
        {
            string strConn = "Data Source="+ServerName+";Initial Catalog="+DBname+";Integrated Security=True";
            return new SqlConnection(strConn);
        }
    }
}
