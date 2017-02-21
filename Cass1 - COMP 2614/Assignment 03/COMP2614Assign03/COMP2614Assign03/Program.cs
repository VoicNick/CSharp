using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//adding namespace for StreamReader
using System.IO;

namespace COMP2614Assign03
{
    class Program
    {
        static int Main(string[] args)
        {
            string path;
            StreamReader streamReader = null;

            // verify correct program usage. Must have teh data file name 
            // as an argument. E.g. COMP2614Assign03 data.txt
            if(args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                Console.WriteLine("Missing parameter, data file name. Correct program usage: COMP2614Assign03 data.txt");
                return 1;
            }

            try
            {
                if(File.Exists(path))
                {
                    streamReader = new StreamReader(path);
                    while(streamReader.Peek() > 0)
                    {
                        string currentLine;
                        currentLine = streamReader.ReadLine();
                        string[] dataOnCurrentLine = currentLine.Split('|');

                        //to do validation on the split methiod and result

                        //reading header of the invoice on the curerent line
                        string[] invoiceHeaderData = dataOnCurrentLine[0].Split(':');

                        //reading the additional lines on the invoice form the current line
                        InvoiceDetailLineCollection currentDetailLine;
                        


                        //we start at the secound elemet at index 1, to skip the header processesd before
                        for(int i=1;i<dataOnCurrentLine.Length;i++)
                        {
                            string[] invoiceAdditionalLines = dataOnCurrentLine[i].Split(':');
                            currentDetailLine.
                        }




                    }
                }
            }
            catch
            {

            }

            finally
            {
                if(streamReader!=null)
                {
                    streamReader.Close();
                }
            }

            return 0;
        }
    }
}
