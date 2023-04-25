using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleDemo
{
    class EmailLogger:ILogger
    {
        public void Handle(string error)
        {
            Console.WriteLine("Email Logger");
        }
    }
}
