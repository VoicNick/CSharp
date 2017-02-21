using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Common;
using DataLayer.DataAccess;

namespace DataLayer.Validation
{
    public class ClientValidation
    {
        private static ErrorList errorList;

        static ClientValidation()
        {
            errorList = new ErrorList();
        }

        /// <summary>
        /// Getting a collection of all the clients form the database
        /// </summary>
        /// <returns>All the clients in the database</returns>
        public static ClientCollection GetAllClients()
        {
            return ClientRepository.GetAllClients();
        }

        /// <summary>
        /// Updates a client in the database
        /// </summary>
        /// <param name="client">the client to update</param>
        /// <returns>number of rows affected as returend by the SQL query</returns>
        public static int UpdateClient(Client client)
        {
            if(validate(client))
            {
                return ClientRepository.UpdateClient(client);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Deletes a client from the database
        /// </summary>
        /// <param name="client">the client to delete</param>
        /// <returns>SQL result of number of rows affected</returns>
        public static int DeleteClient(Client client)
        {
            if (validate(client))
            {
                return ClientRepository.DeleteClient(client);
            }
            else
            { 
                return 0; 
            }
        }

        /// <summary>
        /// Validates and adds a client to the database
        /// </summary>
        /// <param name="client">the client to add</param>
        /// <returns>SQL result of number of rows affected</returns>
        public static int AddClient(Client client)
        {
            if(existingClientCode(client.ClientCode))
            {
                bool existing = true;
            }

            if(validate(client))
            {
                return ClientRepository.AddClient(client);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Validation method for a client object
        /// </summary>
        /// <param name="client">the client to validate</param>
        /// <returns>wether the client is valid or not</returns>
        private static bool validate(Client client)
        {
            bool valid = true;
            errorList.Clear();
            
            //business rules to validate a client object
            
            if ((String.IsNullOrEmpty(client.ClientCode))||(client.ClientCode.Length!=5))
            {
                valid = false;
                errorList.Add("Error: The Client Code must be exactlly five alpha characters.");
            }

            if(String.IsNullOrEmpty(client.CompanyName))
            {
                valid = false;
                errorList.Add("Error: The Company Name can not be empty.");
            }

            if(String.IsNullOrEmpty(client.Address1))
            {
                valid = false;
                errorList.Add("Error: The Address1 can not be empty.");
            }

            if(String.IsNullOrEmpty(client.Province))
            {
                valid = false;
                errorList.Add("Error: The Province can not be empty.");
            }

            if(client.YTDSales<0)
            {
                valid = false;
                errorList.Add("Error: YTDSales can not be less than zero.");
            }

            return valid;
        }//end validate method

        /// <summary>
        /// Verifies if a string is already present in database as a ClientCode
        /// </summary>
        /// <param name="clientCodeToCheck">the client code to check</param>
        /// <returns>wether the client code already exists in the database</returns>
        public static bool existingClientCode(string clientCodeToCheck)
        {
            bool existing = false;

            ClientCollection allClients = ClientRepository.GetAllClients();

            var match = allClients.Where(x => x.ClientCode.Contains(clientCodeToCheck));

            if(match.Any())
            {
                existing = true;
            }
            

            return existing;
        }

        public static ErrorList ErrorList
        {
            get { return errorList; ; }
        }
    }
}
