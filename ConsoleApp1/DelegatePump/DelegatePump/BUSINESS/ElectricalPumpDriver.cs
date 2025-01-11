using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePump.BUSINESS
{
    public class ElectricPumpDriver: Pump
    {
        public ElectricPumpDriver(int id) : base(id) 
        { 
        
        }
        public string StartPumpRunning() 
        {
            this.status = PumpStatus.ON;
            return "Electric Pump is Running";
        }
        public string StopPumpRunning()
        {
            this.status = PumpStatus.OFF;
            return "Electric Pump is Stopped Running";
        }
    }
}
