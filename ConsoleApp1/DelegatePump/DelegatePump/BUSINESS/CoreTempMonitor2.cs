using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePump.BUSINESS
{
    public delegate string StartPumpCall();

    public class CoreTempMonitor2
    {
        private List<StartPumpCall> listPumpDelegates;
        
        public CoreTempMonitor2() {
            this.listPumpDelegates = new List<StartPumpCall>();
        }
        public void Add( StartPumpCall pumpDelegate)
        {
            this.listPumpDelegates.Add(pumpDelegate);
        }
        public string switchOnAllPumps()
        {
            string result = "";
            string pumpResult = "";

            foreach (StartPumpCall obj in this.listPumpDelegates)
            {
                //pumpResult = obj.Invoke();
                pumpResult = obj();
                result += pumpResult + "\r\n";
            }
            return result;
        }
    }
}
