using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QuanLySanPham.Service
{
    public class BaseService
    {
        protected IDbConnection connection;
        public BaseService()
        {
            connection = new SqlConnection(@"Data Source=ADMIN\VANDUYSQL;Initial Catalog=QuanLySanPham;Integrated Security=True");
        }
    }
}
