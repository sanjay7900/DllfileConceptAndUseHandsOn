using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProvideDllFileForEbill
{
    public class Customer
    {
        public static void ShowCustomerDetails(int coustomerId)
        {
            Console.WriteLine();
            FileStream fs = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\ProvideTheDllFileToAnother\CustomerBillDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Customer Id" + "\t" + "Customer Name\t" + " Number Of Unit\t " + "Cost Per Unit\t" + " Total Ammount\t");

            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line != "")
                {
                    string[] lines = line.Split(',');
                    if (Convert.ToInt32(lines[0]) == coustomerId)
                    {
                        for(int i = 0; i < lines.Length; i++)
                        {
                            Console.Write(lines[i] + "\t");
                        }
                    }

                }
                Console.WriteLine();


            }
            sr.Dispose();
            sr.Close();
            fs.Close();



        }
        public static void BillReports()
        {
            FileStream fs = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\ProvideTheDllFileToAnother\CustomerBillDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Customer Id" + "\t" + "Customer Name\t" + " Number Of Unit\t " + "Cost Per Unit\t" + " Total Ammount\t");

            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line != "")
                {
                    string[] lines = line.Split(',');

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.Write(lines[i] + "\t");
                    }


                }
                Console.WriteLine();

            }
            sr.Dispose();
            sr.Close();
            fs.Close();


        }
    }
}
