using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018
{
    internal class Day1
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
            int total = 0;

            foreach(string number in Inputs.Day1.Full())
            {
                total += Convert.ToInt32(number);
            }

            Console.WriteLine(total);
        }
        public static void Part2()
        {

            int total = 0;
            List<int> previous = new List<int>();
            bool found = false;

            for (int i = 0; !found; i++)
            {
                total += Convert.ToInt32(Inputs.Day1.Full()[i % Inputs.Day1.Full().Length]);

                if (previous.Contains(total))
                {
                    Console.WriteLine(total);
                    found = true;
                    break;
                }

                previous.Add(total);
            }


        }
    }
}
