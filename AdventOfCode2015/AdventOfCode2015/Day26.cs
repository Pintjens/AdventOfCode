using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    internal class Day26
    {
        public static void PartPicker()
        {
            Console.Write("Part? : ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "1":
                    Part1();
                    break;
                case "2":
                    Part2();
                    break;
                default:
                    Console.WriteLine("Not Possible");
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
