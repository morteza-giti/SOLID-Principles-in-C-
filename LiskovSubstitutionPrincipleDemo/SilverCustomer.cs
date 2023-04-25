using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleDemo
{
    class SilverCustomer : Customer
    {
        public override double GetDiscount(double TotalSales)
        {
            return TotalSales - 50;
        }
        public override void Add()
        {
            Console.WriteLine("Silver Customer Added.");
        }
    }
}
