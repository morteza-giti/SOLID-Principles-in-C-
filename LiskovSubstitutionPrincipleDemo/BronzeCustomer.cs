using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleDemo
{
    class BronzeCustomer : Customer
    {
        public override double GetDiscount(double TotalSales)
        {
            return TotalSales - 30;
        }
        public override void Add()
        {
            Console.WriteLine("Bronze Customer Added.");
        }
    }
}
