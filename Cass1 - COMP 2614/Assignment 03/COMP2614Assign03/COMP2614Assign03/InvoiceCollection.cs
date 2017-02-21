using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>
    /// A class to model a list of invoices.
    /// </summary>
    class InvoiceCollection : List<Invoice>
    {
        /// <summary>
        /// Print the whole invoice collection to the screen
        /// </summary>
        public void PrintInvoiceCollection()
        {
            foreach(Invoice currentInvoice in this)
            {
                currentInvoice.PrintInvoice();
            }
        }
    }
}
