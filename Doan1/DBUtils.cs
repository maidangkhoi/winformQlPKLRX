using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Doan1
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"LAPTOP-4IQPV792";
            string database = "QLxe2";
            string username = "sa";
            string password = "123";
            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
