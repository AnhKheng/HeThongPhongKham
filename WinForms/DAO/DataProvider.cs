using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    internal class DataProvider
    {
        public static string sql = @"
                Data Source = phongkhamdalieu.mssql.somee.com;
                Initial Catalog = phongkhamdalieu;
                User ID = DowNguyen_SQLLogin_1;
                Password = qlphongkham;
                TrustServerCertificate = True; ";
        private static SqlConnection connection;
        public static void MoKetNoi()
        {
            if (connection == null)
            {
                connection = new SqlConnection(sql);
            }
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public static void DongKetNoi()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
		// Thực hiện truy vấn dữ liệu và trả về DataTable 
		public static DataTable TruyVanDuLieu(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                DongKetNoi();
            }
            return dt;
        }
		// Thực hiện câu lệnh INSERT, UPDATE, DELETE
		public static int ThucThiCauLenh(string query, SqlParameter[] parameters = null)
        {
            int result;
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                DongKetNoi();
            }
            return result;
		}
		// Thực hiện truy vấn trả về một giá trị đơn
		public static object TruyVanDon(string query, SqlParameter[] parameters = null)
        {
            object result;
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                result = cmd.ExecuteScalar();
            }
            finally
            {
                DongKetNoi();
            }
            return result;
		}
	}

}
