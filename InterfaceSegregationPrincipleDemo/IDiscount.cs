using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleDemo
{
    public interface IDiscount
    {
        double GetDiscount(double TotalSales);
    }
}
