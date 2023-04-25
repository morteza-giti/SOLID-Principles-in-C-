using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleDemo
{
    class GoldCustomer:Customer
    {
        public override double GetDiscount(double TotalSales)
        {
            return TotalSales - 100;
        }
        public override void Add()
        {
            Console.WriteLine("Gold Customer Added.");
        }
    }
}
