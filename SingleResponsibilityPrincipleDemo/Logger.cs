using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipleDemo
{
    public class Logger
    {
        public void LogEvent(Exception ex)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
        }
    }
}
