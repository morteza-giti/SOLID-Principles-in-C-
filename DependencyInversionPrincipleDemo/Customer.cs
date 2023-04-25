using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleDemo
{
    public class Customer
    {
        private ILogger obj;

        public Customer(ILogger ilogger)
        {
            obj = ilogger;
        }
        public virtual void Add(int i)
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {               
                obj.Handle(ex.ToString());
            }
        }
    }
}
