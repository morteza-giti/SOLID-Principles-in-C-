using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleDemo
{
    public class DatabaseLogger:ILogger
    {
        public void Handle(string error)
        {
            Console.WriteLine("DatabaseLogger");
        }
    }
}
