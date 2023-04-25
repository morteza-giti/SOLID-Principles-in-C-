using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo
{
    public class Customer
    {
        public int CustomerType { get; set; }

        public virtual double GetDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
}
