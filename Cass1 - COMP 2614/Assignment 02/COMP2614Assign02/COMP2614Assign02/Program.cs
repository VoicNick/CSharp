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
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, address, city, province, postalCode;

            Console.WriteLine("Contact Information");
            Console.WriteLine("------------------------------");
            Console.Write("Firstname:   ");
            firstName = Console.ReadLine();
            Console.Write("Lastname:    ");
            lastName = Console.ReadLine();
            Console.Write("Address:     ");
            address = Console.ReadLine();
            Console.Write("City:        ");
            city = Console.ReadLine();
            Console.Write("Province:    ");
            province = Console.ReadLine();
            Console.Write("Postal Code: ");
            postalCode = Console.ReadLine();

            //creating contact1, empty object
            Contact contact1 = new Contact();

            //populating contact1
            contact1.FirstName = firstName;
            contact1.LastName = lastName;
            contact1.Address = address;
            contact1.City = city;
            contact1.Province = province;
            contact1.PostalCode = postalCode;

            //creating contact2, using a parameterized constructor
            Contact contact2 = new Contact(firstName, lastName, address,
                city, province, postalCode);

            // creating contact3, using Object Initializer syntax
            Contact contact3 = new Contact { FirstName = firstName, LastName = lastName,
            Address=address, City=city, PostalCode = postalCode, Province = province};

            //adding the three contacts to an array
            Contact[] contacts = new Contact[3] { contact1, contact2, contact3 };

            //printing the array of contacts
            Console.WriteLine("\nContacts");
            Console.WriteLine("------------------------------");
            foreach(Contact currentContact in contacts)
            {
                Console.WriteLine("{0} \n",ContactPostalOutput.FormatToCanadian(currentContact));
            }

            Console.ReadLine();
        }
    }
}
