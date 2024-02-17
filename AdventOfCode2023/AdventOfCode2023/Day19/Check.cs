using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19
{
    internal class Check
    {
        // x<2355:R,
        // x = reference
        // < = comparer
        // 2355 = value
        // R = doNext

        public char reference;
        public char comparer;
        public int value;
        public string doNext;
    }
}
