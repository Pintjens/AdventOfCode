using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Coordinats
    {

        private int x;
        public int X
        {
            set
            {
                if (value.GetType().Name != "Int32")
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.x = value;
                }
            }
            get { return this.x; }
        }

        private int y;
        public int Y
        {
            set
            {
                if (value.GetType().Name != "Int32")
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.y = value;
                }
            }
            get { return this.y; }
        }

        public Coordinats(int[] xYPair)
        {
            if (xYPair.Length != 2)
            {
                throw new ArgumentException();
            }
            else
            {
                this.X = xYPair[0];
                this.Y = xYPair[1];
            }
        }
        public Coordinats(int x, int y) : this(new int[] { x, y })
        {

        }

        public override string ToString()
        {
            return $"x = {this.X}, y = {this.Y}";
        }
    }
}
