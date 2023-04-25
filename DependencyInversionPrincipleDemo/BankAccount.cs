using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleDemo
{
    public interface ITransferSource
    {
        void RemoveFunds(decimal value);
    }

    public interface ITransferDestination
    {
        void AddFunds(decimal value);
    }
    public class BankAccount : ITransferDestination,ITransferSource
    {
        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }

        public void AddFunds(decimal value)
        {
            Balance += value;
        }

        public void RemoveFunds(decimal value)
        {
            Balance -= value;
        }
    }
}
