using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class CamelHand : IComparable<CamelHand>
    {

        public string hand = "";

        public int bid;


        public int CompareTo(CamelHand? other)
        {
             return other.hand.CompareTo(this.hand);
        }
    }
}
