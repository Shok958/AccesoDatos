using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection("conexion");
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                if (connection.State == System.Data.ConnectionState.Open) {
                    connection.Close();
                }
                connection.Dispose();
            }
        }
    }
}
