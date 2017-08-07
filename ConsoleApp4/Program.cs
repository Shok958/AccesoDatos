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

           /* using (var person = new Person()) {

            }*/

            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
                                                            Initial Catalog=Pizzeria;
                                                            Integrated Security=True;
                                                            Connect Timeout=30;
                                                            Encrypt=False;
                                                            TrustServerCertificate=True;
                                                            ApplicationIntent=ReadWrite;
                                                            MultiSubnetFailover=False"))
            {
                connection.Open();
                SqlCommand query = new SqlCommand(@"INSERT INTO Client (id,Name) Values (1,'Pepe')", connection);
                query.ExecuteNonQuery();
            }

           
            /* try
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
             }*/

        }
    }

    class Person:IDisposable {

        public int Id { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
