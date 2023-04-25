using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase customer = new Customer();
            IDatabaseDelete newCustomer=new CustomerWithDelete();

            customer.Add();            
            newCustomer.Delete();
            newCustomer.Add();
            Console.ReadKey();

            Dialler d=new Dialler();
            d.MakeCall(new Contact());
            d.MakeCall(new Engineer());
        }
    }
}
