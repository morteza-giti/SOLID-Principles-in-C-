using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo
{
    class BronzeCustomer:Customer
    {
        public override double GetDiscount(double TotalSales)
        {
            return TotalSales - 30;
        }
    }
}
