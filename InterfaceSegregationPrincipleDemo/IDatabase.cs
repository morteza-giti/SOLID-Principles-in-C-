using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleDemo
{
    public interface IDatabase
    {
        void Add();
    }

    public interface IDatabaseDelete : IDatabase
    {
        void Delete();
    }
}
