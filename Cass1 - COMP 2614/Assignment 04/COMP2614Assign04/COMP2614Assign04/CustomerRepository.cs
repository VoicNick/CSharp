using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace COMP2614Assign04
{
    static class CustomerRepository
    {
        private static string dbConnectionString =
            "Server=tcp:s08.winhost.com;" +
            "Database=DB_15202_2614d162;" +
            "User ID=DB_15202_2614d162_user;" +
            "Password=93nu5#S67;" +
            "Integrated Security=False;";

        /// <summary>
        /// Get a list of all unique provinces in the db
        /// </summary>
        /// <returns>a list of all unique provinces in the db</returns>
        public static List<string> GetAllUniqueProvinces()
        {
            List<string> allUniqueProvinces = new List<string>();

            //creating the DB connection
            using (SqlConnection connectionToDB = new SqlConnection(dbConnectionString))
            {
                //querying all distingct provinces
                string query = string.Format("{0} {1}",
                    "SELECT DISTINCT Province",
                    "FROM Customer");
                using (SqlCommand dbCommand = new SqlCommand(query,connectionToDB))
                {
                    connectionToDB.Open();

                    //read the data
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string province = null;
                            if(!reader.IsDBNull(0))
                            {
                                province = (string)reader[0];
                            }
                            allUniqueProvinces.Add(province);
                        }
                    }
                }
            }
            return allUniqueProvinces;
        }

        /// <summary>
        /// Gets all customers in a certain province. 
        /// </summary>
        /// <param name="provinceFilter">The province code (e.g. ON, BC). Use ALL for all provinces</param>
        /// <returns></returns>
        public static CustomerCollection GetCustomersByProvince(string provinceFilter)
        {
            CustomerCollection customers = new CustomerCollection();

            //creating the DB connection
            using (SqlConnection connectionToDB = new SqlConnection(dbConnectionString))
            {
                //querying all distingct provinces
                string query = string.Format("{0} {1} {2}",
                    "SELECT CompanyName, Address, City, Province, PostalCode, CreditHold",
                    "FROM Customer",
                    provinceFilter.ToUpper() == "ALL" ? "" : "WHERE Province = @province");

                using (SqlCommand dbCommand = new SqlCommand(query, connectionToDB))
                {
                    dbCommand.Parameters.AddWithValue("@province", provinceFilter);
                    connectionToDB.Open();

                    //read the data
                    using (SqlDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string companyName = (string)reader[0];
                            string address = null;
                            if(!reader.IsDBNull(1))
                            {
                                address = (string)reader[1];
                            }
                            string city = null;
                            if(!reader.IsDBNull(2))
                            {
                                city = (string)reader[2];
                            }
                            string province = null;
                            if(!reader.IsDBNull(3))
                            {
                                province = (string)reader[3];
                            }

                            string postalCode = null;
                            if (!reader.IsDBNull(4))
                            {
                                postalCode = (string)reader[4];
                            }
                            
                            bool creditHold = false;
                            if (!reader.IsDBNull(5))
                            {
                                creditHold = ((byte)reader[5] != 0);
                            }

                            Customer customer = new Customer
                                                {
                                                    CompanyName = companyName,
                                                    Address = address,
                                                    City = city,
                                                    Province = province,
                                                    PostalCode = postalCode,
                                                    CreditHold = creditHold
                                                };
                            customers.Add(customer);
                        }
                    }
                }
            }


            return customers;
        }
    }
}
