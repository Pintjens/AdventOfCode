using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventOfCode.GetValue;

namespace AdventOfCode.Day15
{
    public class Sensor
    {
        private static List<Sensor> allSensors = new List<Sensor>();
        public static ImmutableList<Sensor> AllSensors
        {
            get
            {
                return allSensors.ToImmutableList();
            }
        }
        public int X { get; }
        public int Y { get; }

        private Possition pos;
        public Possition Pos
        {
            get
            {
                return pos;
            }
        }

        public int Range;

        public Sensor(int[,] data)
        {
            X = data[0, 0];
            Y = data[0, 1];
            this.pos = new Possition(new int[] { data[0, 0], data[0, 1] });
            Range = ManhattanDistance(X, Y, data[1, 0], data[1, 1]);

            allSensors.Add(this);
        }
    }
}
