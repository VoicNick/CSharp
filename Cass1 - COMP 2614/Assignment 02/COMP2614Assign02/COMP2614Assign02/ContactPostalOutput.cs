using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment 2 for the Comp2614 class, Summer 2016 term
// Author: Voicu Chirtes
// Version: May 18, 2016

namespace COMP2614Assign02
{
    /// <summary>
    /// Class used to format a contact object to appropriate postal standards
    /// </summary>
    class ContactPostalOutput
    {
        /// <summary>
        /// Method for formatting a contact object to Canadian Postal Standard
        /// </summary>
        /// <param name="contactToFormat">the contact object to format</param>
        /// <returns>the Formatted string</returns>
        public static string FormatToCanadian(Contact contactToFormat)
        {
            string formattedString =
                contactToFormat.FirstName + " " + contactToFormat.LastName + '\n' +
                contactToFormat.Address + '\n' +
                contactToFormat.City + " " + contactToFormat.Province + "  " + 
                contactToFormat.PostalCode + '\n';
            return formattedString;
        }
    }
}
