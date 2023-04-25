using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleDemo
{
    public class Customer : IDatabase, IDiscount
    {
        public int CustomerType { get; set; }

        public virtual double GetDiscount(double TotalSales)
        {
            return TotalSales;
        }
        public virtual void Add()
        {
            Console.WriteLine("Added");
        }
    }
}
