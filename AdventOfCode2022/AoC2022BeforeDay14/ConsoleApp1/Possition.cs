using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Possition
    {
        private int x;
        public int X
        {
            get
            {
                return this.x;
            }
        }
        private int y;
        public int Y
        {
            get
            {
                return this.y;
            }
        }
        public Possition(int[] xy)
        {
            this.x = xy[0];
            this.y = xy[1];
        }
    }
}
