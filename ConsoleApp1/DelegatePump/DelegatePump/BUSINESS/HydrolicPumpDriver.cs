using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePump.BUSINESS
{
    public class HydrolicPumpDriver:Pump
    {
        public HydrolicPumpDriver(int id) : base(id) 
        { 
        
        }
        public string TurnON() {
            this.status = PumpStatus.ON;
            return "Hydrolic Pump is turned ON";
        }
        public string TurnOFF()
        {
            this.status = PumpStatus.OFF;
            return "Hydrolic Pump is turned OFF";
        }
    }
}
