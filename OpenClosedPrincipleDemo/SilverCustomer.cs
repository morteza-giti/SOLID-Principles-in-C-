using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo
{
    class SilverCustomer:Customer
    {
        public override double GetDiscount(double TotalSales)
        {
            return TotalSales - 50;
        }
    }
}
