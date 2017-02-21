using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer.Common;

namespace DataLayer.DataAccess
{
    public class ClientRepository
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
        public static ClientCollection GetAllClients()
        {
            ClientCollection clients;

            //creating the connection
            using(SqlConnection conn = new SqlConnection(connString))
            {
                //SQL query
                string query = string.Format("{0} {1} {2}"
                                     , "SELECT *"
                                     , "FROM Client884836"
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
        } // end GetAllClients() method

        /// <summary>
        /// Updates a client in the database
        /// </summary>
        /// <param name="client">the client to update</param>
        /// <returns>number of rows affected as returend by the SQL query</returns>
        public static int UpdateClient(Client client)
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                //Client884836
                string query = string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}"
                                , "UPDATE Client884836"
                                , "SET CompanyName = @companyName"
                                , ", Address1 = @address1"
                                , ", Address2 = @address2"
                                , ", City = @city"
                                , ", Province = @province"
                                , ", PostalCode = @postalCode"
                                , ", YTDSales = @yTDSales"
                                , ", CreditHold = @creditHold"
                                , ", Notes = @notes"
                                , "WHERE ClientCode = @clientCode");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    if (client.CompanyName != null)
                    {
                        cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@companyName", DBNull.Value);
                    }

                    if (client.Address1 != null)
                    {
                        cmd.Parameters.AddWithValue("@address1", client.Address1);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address1", DBNull.Value);
                    }

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    if (client.Province != null)
                    {
                        cmd.Parameters.AddWithValue("@province", client.Province);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@province", DBNull.Value);
                    }

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@yTDSales", client.YTDSales);

                    byte creditHold = (client.CreditHold ? (byte)1 : (byte)0);
                    cmd.Parameters.AddWithValue("@creditHold", creditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }//end UpdateClient(client) method

        /// <summary>
        /// Adds a client to the database
        /// </summary>
        /// <param name="client">the client to add</param>
        /// <returns>SQL result of number of rows affected</returns>
        public static int AddClient(Client client)
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                // sql query
                string query = string.Format ("{0} {1} {2} {3} {4}"
                                , "INSERT INTO Client884836"
                                , "(ClientCode, CompanyName, Address1, Address2, City"
                                , ", Province, PostalCode, YTDSales, CreditHold, Notes)"
                                , "VALUES (@clientCode, @companyName, @address1, @address2, @city"
                                , ", @province, @postalCode, @yTDSales, @creditHold, @notes)");

                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    if (client.ClientCode != null)
                    {
                        cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@clientCode", DBNull.Value);
                    }
                    if (client.CompanyName != null)
                    {
                        cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@companyName", DBNull.Value);
                    }

                    if (client.Address1 != null)
                    {
                        cmd.Parameters.AddWithValue("@address1", client.Address1);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address1", DBNull.Value);
                    }

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    if (client.Province != null)
                    {
                        cmd.Parameters.AddWithValue("@province", client.Province);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@province", DBNull.Value);
                    }

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@yTDSales", client.YTDSales);

                    byte creditHold = (client.CreditHold ? (byte)1 : (byte)0);
                    cmd.Parameters.AddWithValue("@creditHold", creditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }//end AddClient(client) method

        /// <summary>
        /// Deletes a client from the database
        /// </summary>
        /// <param name="client">the client to delete</param>
        /// <returns>SQL result of number of rows affected</returns>
        public static int DeleteClient(Client client)
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                //SQL query
                string query = string.Format("{0} {1}"
                                , "DELETE Client884836"
                                , "WHERE ClientCode = @clientCode");

                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("clientCode", client.ClientCode);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
