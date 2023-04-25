using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleDemo
{
    public interface ILogger
    {
        private void Handle(string error);
    }
}
