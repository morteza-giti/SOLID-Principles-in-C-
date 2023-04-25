using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDiscount> _customerCollection = new List<IDiscount>();
            _customerCollection.Add(new GoldCustomer());
            _customerCollection.Add(new SilverCustomer());
            _customerCollection.Add(new BronzeCustomer());
            _customerCollection.Add(new Lead());
            foreach (IDiscount cust in _customerCollection)
            {
                Console.WriteLine(cust.GetDiscount(200));               
            }
            Console.ReadKey();
        }
    }
}
