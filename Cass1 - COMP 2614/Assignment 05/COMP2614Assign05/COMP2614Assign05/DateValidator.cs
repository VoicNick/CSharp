using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    /// <summary>
    /// Class used for date validation
    /// </summary>
    class DateValidator
    {
        /// <summary>
        /// validate the date
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="month">month</param>
        /// <param name="day">day</param>
        /// <returns>if the date is valid</returns>
        public static bool Validate(string year, string month, string day)
        {
            int yearInt, monthInt, dayInt;

            //testing valid numbers
            bool valid = Int32.TryParse(year, out yearInt) &
                Int32.TryParse(month, out monthInt) &
                Int32.TryParse(day, out dayInt);

            //testing year and month for ranges, and day for positive value
            valid = valid & (yearInt >= 1900 & yearInt <= 9999) &
                (monthInt <= 12 & monthInt > 0) &
                (dayInt > 0);


            //if we are good so far, test the upper limit on the day
            if (valid)
            {
                if (monthInt == 2) //february
                {
                    valid = (dayInt <= 28); // could improve for leap years
                }
                else
                {
                    if(monthInt <= 7)
                    {
                        //Jan to Jul, except Feb: even months have 30 days, odd ones have 31
                        valid = (monthInt % 2 == 0) ? (dayInt <= 30) : (dayInt <= 31);
                    }
                    else
                    {
                        //Aug to Dec: even months have 31 days, odd ones have 30
                        valid = (monthInt % 2 == 1) ? (dayInt <= 30) : (dayInt <= 31);
                    }
                }
            }
            return valid;
        }   
    }
}
