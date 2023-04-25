using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleDemo
{
    class CustomerWithDelete : IDatabaseDelete
    {
        public void Delete()
        {
            Console.WriteLine("Customer Deleted");
        }

        public void Add()
        {
           Customer obj = new Customer();
           obj.Add();
        }
    }
}
