using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace COMP2614Assign06
{
    static class ClientRepository
    {
        //SQL connection string
        private static string connString = "Server=tcp:s08.winhost.com;"
                                 + "Database=DB_15202_2614d162;"
                                 + "User ID=DB_15202_2614d162_user;"
                                 + "Password=93nu5#S67;"
                                 + "Integrated Security=False;";

        /// <summary>
        /// Getting a collection of all the clients form the database
        /// </summary>
        /// <returns>All the clients in the database</returns>
        static public ClientCollection GetAllClients()
        {
            ClientCollection clients;

            //creating the connection
            using(SqlConnection conn = new SqlConnection(connString))
            {
                //SQL query
                string query = string.Format("{0} {1} {2}"
                                     , "SELECT *"
                                     , "FROM Client"
                                     , "ORDER BY ClientCode");
                using(SqlCommand cmd = new SqlCommand())
                {
                    //preparing the command
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    //opening SQL connection
                    conn.Open();

                    clients = new ClientCollection();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string clientCode = (string)reader["ClientCode"];
                            string companyName = (string)reader["CompanyName"];
                            string address1 = (string)reader["Address1"];
                            
                            string address2 = null;
                            if(!reader.IsDBNull(3))
                            {
                                address2 = (string)reader["Address2"];
                            }
                            
                            string city = null;
                            if(!reader.IsDBNull(4))
                            {
                                city = (string)reader["City"];
                            }

                            string province = (string)reader["Province"];
                            string postalCode = null;
                            if(!reader.IsDBNull(6))
                            {
                                postalCode = (string)reader["PostalCode"];
                            }
                            decimal yTDSales = (decimal)reader["YTDSales"];
                            bool creditHold = ((byte)reader["CreditHold"]!=0);
                            string notes = null;
                            if(!reader.IsDBNull(9))
                            {
                                notes = (string)reader["Notes"];
                            }

                            clients.Add(new Client
                            {
                                ClientCode = clientCode
                                , CompanyName = companyName
                                , Address1 = address1
                                , Address2 = address2
                                , City = city
                                , Province = province
                                , PostalCode = postalCode
                                , YTDSales = yTDSales
                                , CreditHold = creditHold
                                , Notes = notes
                            });                    
                        }
                    }
                    return clients;
                }
            } 
        }
    }
}
