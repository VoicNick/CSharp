using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Validation
{
    /// <summary>
    /// Class for the error messages
    /// </summary>
    public class ErrorList : List<string>
    {
        /// <summary>
        /// The list of error messages as one multiline string
        /// </summary>
        public string ErrorMessages
        {
            get
            {
                string errors = string.Empty;
                foreach(string s in this)
                {
                    errors += s + "\n";
                }
                return errors;
            }
        }
    }
}
