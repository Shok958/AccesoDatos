using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
                                                            Initial Catalog=Pizzeria;
                                                            Integrated Security=True;
                                                            Connect Timeout=30;
                                                            Encrypt=False;
                                                            TrustServerCertificate=True;
                                                            ApplicationIntent=ReadWrite;
                                                            MultiSubnetFailover=False"))
            {
                SqlParameter id = new SqlParameter("@id", SqlDbType.UniqueIdentifier);
                SqlParameter name = new SqlParameter("@name", SqlDbType.VarChar, 11);
                id.Value = Guid.NewGuid();
                name.Value = "Luis";

                try
                {
                    connection.Open();
                }catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                try
                {
                    SqlCommand query = new SqlCommand(@"INSERT INTO Client (Id, Name) Values (@id, @name)", connection);
                    query.Parameters.Add(id);
                    query.Parameters.Add(name);
                    query.ExecuteNonQuery();
                }catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
            }

            /* using (var person = new Person()) {

             }*/
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
