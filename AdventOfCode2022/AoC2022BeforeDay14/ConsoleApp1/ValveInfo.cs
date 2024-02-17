using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class ValveInfo
    {
        private int flowrate;
        public int FlowRate
        {
            set
            {
                this.flowrate = value;
            }
            get
            {
                return this.flowrate;
            }
        }
        private List<string> connections;
        public List<string> Connections
        {
            set
            {
                this.connections = value;
            }
            get
            {
                return this.connections;
            }
        }
        public ValveInfo(int flowrate, List<string> connections)
        {
            this.flowrate = flowrate;
            this.connections = connections;
        }
    }
}
