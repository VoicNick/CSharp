using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment 4 for the Comp2614 class, Summer 2016 term
// Author: Voicu Chirtes
// Version: June 15, 2016
namespace COMP2614Assign04
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of string that will hold all provence codes
            //that exist in the DB
            List<string> filterOptions = CustomerRepository.GetAllUniqueProvinces();

            //adding an ALL option to the list
            filterOptions.Add("ALL");
            ConsolePrinter.PrintProvinceOptions(filterOptions);

            int selectedOption;
            //read and try to parse to int the selected option     
            //validating if the selected option is a number and within limits
            //options are 1 to Count
            bool validSelection = Int32.TryParse(Console.ReadLine(), out selectedOption);
            validSelection = validSelection & (selectedOption > 0 & selectedOption <= filterOptions.Count);

            if(!validSelection)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }
            //list is 0 based, so substracting 1
            Console.WriteLine("Customer listing for {0}\n", filterOptions[--selectedOption]);
            ConsolePrinter.PrintCustomerCollectionOption1(CustomerRepository.GetCustomersByProvince(filterOptions[selectedOption]));
            return;
        }
    }
}
