using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    class ConsolePrinter
    {
        /// <summary>
        /// Prints the customer collection including CompanyName, City, Province, PostalCode and Credit Hold
        /// </summary>
        /// <param name="customers"></param>
        public static void PrintCustomerCollectionOption1(CustomerCollection customers)
        {
            Console.WriteLine("{0,-36}{1,-17}{2,-6}{3,-8}{4,-4}",
                "CompanyName", "City", "Prov", "Postal", "Hold");
            Console.WriteLine(new string('-', 71));

            foreach(Customer currentCustomer in customers)
            {
                Console.WriteLine("{0,-36}{1,-17}{2,-6}{3,-8}{4,-4}",
                    currentCustomer.CompanyName,
                    currentCustomer.City,
                    currentCustomer.Province,
                    currentCustomer.PostalCode,
                    currentCustomer.CreditHold ? "Y":"N");
            }
        }

        /// <summary>
        /// Prints the province options
        /// </summary>
        /// <param name="filterOptions">the list of province codes</param>
        public static void PrintProvinceOptions(List<string> filterOptions)
        {
            Console.WriteLine("Select province filter:");

            for (int i = 0; i < filterOptions.Count; i++)
            {
                Console.WriteLine("{0,9}: {1}", i + 1, filterOptions[i]);
            }
        }
    }
}
