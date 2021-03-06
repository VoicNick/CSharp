﻿using System;
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
    /// Class that represents a contact
    /// </summary>
    class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string province;
        private string postalCode;

        //deafult constructor
        public Contact ()
        {
            
        }

        //parameterized constructor
        public Contact (string firstName, string lastName, string address, 
            string city, string province, string postalCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.province = province;
            this.postalCode = postalCode;
            //FirstName = firstName;
            //LastName = lastName;
            //Address = address;
            //City = city;
            //Province = province;
            //PostalCode = postalCode;
        }

        //property methods
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}",FirstName,LastName);
        }
    }
}
