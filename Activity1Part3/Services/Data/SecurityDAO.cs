using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Activity1Part3.Services.Data
{
    public class SecurityDAO
    {
        //connect to the database 
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool FinByUser(UserModel user)
        {
            //start by assuming that nothing is found in the query 
            bool success = false;

            // write sql expression 
            string queryString = "SELECT * FROM dbo.Users WHERE USERNAME = @userName AND PASSWORD = @Password"; 

            //create and open the connetion to the database inside a using block
            //This ensures that all resources are closed properly when the query is done.

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                // associate @username with the user.username
                command.Parameters.Add("@userName", System.Data.SqlDbType.VarChar, 50).Value = user.userName;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

                //open the database and run the comman
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return success;
        }
    }
}
