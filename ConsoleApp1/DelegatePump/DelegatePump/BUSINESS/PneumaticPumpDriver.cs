using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePump.BUSINESS
{
    public class PneumaticPumpDriver:Pump
    {
        public PneumaticPumpDriver(int id): base(id) 
        { 
        
        }
        public string SwitchOn() {
            this.status = PumpStatus.ON;
            return "Pneumatic Pump is switched ON";
        }
        public string SwitchOff()
        {
            this.status = PumpStatus.OFF;
            return "Pneumatic Pump is switched OFF";
        }
    }
}
