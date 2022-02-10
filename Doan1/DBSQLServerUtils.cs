using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Doan1
{
    class DBSQLServerUtils
    {
        
        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            //Data Source = DESKTOP - JKE89KN\SQLEXPRESS; Initial Catalog = QLxe; Integrated Security = True
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
