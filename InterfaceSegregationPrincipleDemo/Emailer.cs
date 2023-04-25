using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleDemo
{
    public class Emailer
    {
        public void SendMessage(IEmailable contact, string subject, string body)
        {            
            // Code to send email, using contact's email address and name
        }
    }
}
