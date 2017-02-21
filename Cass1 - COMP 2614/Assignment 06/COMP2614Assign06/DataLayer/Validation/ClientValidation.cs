using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Common;
using DataLayer.DataAccess;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DataLayer.Validation
{
    /// <summary>
    /// Class that handles data validation. The link between the application and the data layer.
    /// It validates the business rules and uses the repository class to 
    /// get the data.
    /// </summary>
    public class ClientValidation
    {
        /// <summary>
        /// a private list of current errors
        /// </summary>
        private static ErrorList errorList;

        /// <summary>
        /// a public list of current errors
        /// </summary>
        public static ErrorList ErrorList
        {
            get { return errorList; ; }
        }

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
                //MessageBox.Show(errorList.ErrorMessages);
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
        /// <returns>weather the client is valid or not</returns>
        private static bool validate(Client client)
        {
            bool valid = true;
            errorList.Clear();
            
            //business rules to validate a client object

            string regExFiveUpperAlphaChar = @"^[A-Z]{5}$";

            //ClientCode must be five upper case alpha characters
            if ((String.IsNullOrEmpty(client.ClientCode)) || (!Regex.IsMatch(client.ClientCode,regExFiveUpperAlphaChar)))
            {
                valid = false;
                errorList.Add("Error: The Client Code must be exactly five UpperCase alpha characters.");
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

            string regExCdnPostalCode = @"^[A-Z]\d[A-Z] \d[A-Z]\d$";

            if ((String.IsNullOrEmpty(client.PostalCode))||(!Regex.IsMatch(client.PostalCode, regExCdnPostalCode)))
            {
                valid = false;
                errorList.Add("Error: Postal Code Format is Incorrect.");
            }     

            if(client.YTDSales<0)
            {
                valid = false;
                errorList.Add("Error: YTDSales can not be less than zero.");
            }
            return valid;
        }//end validate method
    }
}
