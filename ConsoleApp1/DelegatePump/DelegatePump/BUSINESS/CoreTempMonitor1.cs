using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePump.BUSINESS
{
    public class CoreTempMonitor1
    {
        private List<Pump> listPumps;

        public CoreTempMonitor1()
        {
            listPumps = new List<Pump>();
        }

        public void Add(Pump pump)
        {
            this.listPumps.Add(pump);
        }

        public string switchOnAllPumps()
        {
            string result = "";
            string pumpResult = "";

            foreach (Pump obj in this.listPumps)
            {
                
                if (obj is ElectricPumpDriver)
                {
                    pumpResult= ((ElectricPumpDriver)obj).StartPumpRunning();
                    result += pumpResult+"\r\n";
                }
                //-----------------------------------------------
                if (obj is HydrolicPumpDriver)
                {
                    pumpResult = (obj as HydrolicPumpDriver).TurnON();
                    result += pumpResult + "\r\n";
                }
                //-----------------------------------------------
                if (obj is PneumaticPumpDriver)
                {
                    pumpResult = ((PneumaticPumpDriver)obj).SwitchOn();
                    result += pumpResult + "\r\n";
                }
            }
            return result;
        }
    }
}
