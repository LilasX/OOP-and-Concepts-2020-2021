using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePump.BUSINESS
{
    public enum PumpStatus { ON , OFF }
    public class Pump
    {
        protected int id;
        protected PumpStatus status;

        public PumpStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Pump(int id) {
            this.id = id;
            this.status = PumpStatus.OFF;
        }
    }
}
