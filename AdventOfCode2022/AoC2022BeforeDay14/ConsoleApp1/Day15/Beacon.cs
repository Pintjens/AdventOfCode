using System.Collections.Generic;
using System.Collections.Immutable;
using static AdventOfCode.Possition;

namespace AdventOfCode.Day15
{
    public class Beacon
    {
        private static List<Beacon> allBeacons = new List<Beacon>();
        public static ImmutableList<Beacon> AllBeacons
        {
            get
            {
                return allBeacons.ToImmutableList();
            }
        }
        private Possition pos;
        public Possition Pos
        {
            get
            {
                return pos;
            }
        }
        public Beacon(int[] possition)
        {
            pos = new Possition(possition);

            allBeacons.Add(this);
        }
    }

}
