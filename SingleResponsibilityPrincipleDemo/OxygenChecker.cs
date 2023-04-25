using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipleDemo
{
    public class OxygenChecker
    {         
        public bool OxygenLow(OxygenMeter _oxygenMeter)
        {
            return _oxygenMeter.OxygenSaturation <= 75;
        }
    }
}
