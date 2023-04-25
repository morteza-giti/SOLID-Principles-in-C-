﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipleDemo
{
    public class TransferManager
    {
        public ITransferSource Source { get; set; }

        public ITransferDestination Destination { get; set; }

        public decimal Value { get; set; }

        public void Transfer()
        {
            Source.RemoveFunds(Value);
            Destination.AddFunds(Value);
        }
    }
}
