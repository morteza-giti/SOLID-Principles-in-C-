using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleDemo
{
    public interface IDiscount
    {
        double GetDiscount(double TotalSales);
    }
}
