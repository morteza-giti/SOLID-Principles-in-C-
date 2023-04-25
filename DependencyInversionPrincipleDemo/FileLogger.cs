using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleDemo
{
    public class FileLogger:ILogger
    {
        public void Handle(string error)
        {
            Console.WriteLine("FileLogger");
        }
    }
}
