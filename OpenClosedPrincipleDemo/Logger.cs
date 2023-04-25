using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class PrinterLogger : ILogger
    {
        public void Log(string message)
        {
           //Write data to printer
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            //Write data to database
        }
    }
    public class Logger
    {
        private ILogger _ilogger;

        public Logger(ILogger ilogger)
        {
            _ilogger = ilogger;
        }
        public void Log(string message)
        {
            _ilogger.Log(message);
        }
    }
}
