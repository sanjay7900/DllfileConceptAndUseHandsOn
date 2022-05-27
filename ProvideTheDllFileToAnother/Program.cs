using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptDllFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProvideDllFileForEbill.Ebill.WriteCustomerDetail();
            ProvideDllFileForEbill.Customer.BillReports();
            ProvideDllFileForEbill.Customer.ShowCustomerDetails(1);
            ProvideDllFileForEbill.Customer.ShowCustomerDetails(2);
            ProvideDllFileForEbill.Customer.ShowCustomerDetails(3);
            ProvideDllFileForEbill.Customer.ShowCustomerDetails(4);
            Console.ReadKey();  
        }
    }
}
