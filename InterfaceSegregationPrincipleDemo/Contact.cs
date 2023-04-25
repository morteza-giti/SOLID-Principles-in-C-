using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleDemo
{
    public interface IEmailable
    {
        string Name { get; set; }
        string EmailAddress { get; set; }
    }

    public interface IDialable
    {
        string Telephone { get; set; }
    }
    public class Contact : IDialable,IEmailable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
    }
}
