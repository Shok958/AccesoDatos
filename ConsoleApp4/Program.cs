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
            var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
                                                            Initial Catalog=Pizzeria;
                                                            Integrated Security=True;
                                                            Connect Timeout=30;
                                                            Encrypt=False;
                                                            TrustServerCertificate=True;
                                                            ApplicationIntent=ReadWrite;
                                                            MultiSubnetFailover=False");
            try
            {
                connection.Open();
            }
            catch(SqlException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name);
            }
            finally {
                //if (connection.State == System.Data.ConnectionState.Open) {
                    //connection.Close();
                //}
                connection.Dispose();
                Console.WriteLine(connection.State);
                Console.ReadLine();
            }
        }
    }
}
