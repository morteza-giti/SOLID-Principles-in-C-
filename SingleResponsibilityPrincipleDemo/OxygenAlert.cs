using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipleDemo
{
    public class OxygenAlert
    {
        public void ShowLowOxygenAlert(OxygenMeter _oxygenMeter)
        {
            Console.WriteLine("Oxygen low ({0:F1}%)", _oxygenMeter.OxygenSaturation);
        }
    }
}
