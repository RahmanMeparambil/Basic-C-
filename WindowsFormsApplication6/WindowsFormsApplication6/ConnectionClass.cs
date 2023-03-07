using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication6
{
    class ConnectionClass
    {
        public static string Con;
        public static SqlConnection sqlconnection = new SqlConnection(Con);

        public static bool OpenConnection()
        {
            try
            {
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.ConnectionString = Con;
                    sqlconnection.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
