using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinForms_PhongKham.DAO
{
    internal class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                "Data Source = phongkhamdalieu.mssql.somee.com;" +
                "Initial Catalog = phongkhamdalieu;" +
                "User ID = DowNguyen_SQLLogin_1;" +
                "Password = qlphongkham;" +
                "TrustServerCertificate = True; "
            );
        }
    }
}
