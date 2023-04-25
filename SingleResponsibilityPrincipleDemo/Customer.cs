using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipleDemo
{
    public class Customer
    {
        Logger _logger = new Logger();
        public void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                _logger.LogEvent(ex);
            }
        }  
    }
}
