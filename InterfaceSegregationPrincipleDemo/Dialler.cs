using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleDemo
{
    public class Dialler
    {
        public void MakeCall(IDialable contact)
        {            
            // Code to dial telephone number of contact
        }
    }
}
