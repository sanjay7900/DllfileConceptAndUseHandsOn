using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProvideDllFileForEbill
{
    public class Ebill
    {
        private static string CustomerName;
        private static int CustomerId;
        private static int NoOfUnit;
        private static int CostPerUnit = 7;
        private static int total;
        public static void WriteCustomerDetail()
        {
            FileStream fileStream = new FileStream(@"D:\aspdotnet\CSharpOPPsRepo\ProvideTheDllFileToAnother\CustomerBillDetails.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
        storeOneMore:
            Console.Write("Enter The Customer id :");
            CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ENter the Customer Name");
            CustomerName = Console.ReadLine();
            Console.WriteLine(" Enter the NUmber Of Unit :");
            NoOfUnit = Convert.ToInt32(Console.ReadLine());
            total = NoOfUnit * CostPerUnit;
            writer.WriteLine(CustomerId + "," + CustomerName + "," + NoOfUnit + "," + CostPerUnit + "," + total);
            Console.WriteLine("Do you Want to  More to Store if Yes ? Enter The 1: ");
            int check = Convert.ToInt32(Console.ReadLine());
            if (check == 1)
            {
                goto storeOneMore;
            }
            writer.Dispose();
            writer.Close();
            fileStream.Close();




        }
    }
}
