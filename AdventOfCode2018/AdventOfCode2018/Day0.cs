using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018
{
    internal class Day0
    {
        public static void PartPicker()
        {
            Console.Write("Part? : ");
            string part = Console.ReadLine();

            switch (part)
            {
                case "1":
                    Part1();
                    break;
                case "2":
                    Part2();
                    break;
                default:
                    Console.WriteLine("Not Possible..");
                    PartPicker();
                    break;
            }
        }
        public static void Part1()
        {

        }
        public static void Part2()
        {

        }
    }
}
