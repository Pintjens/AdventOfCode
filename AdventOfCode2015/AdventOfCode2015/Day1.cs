using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    internal class Day1
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
            int floor = 0;

            foreach(char move in Inputs.Day1.GPT())
            {
                if(move == '(')
                {
                    floor++;
                }
                else
                {
                    floor--;
                }
            }
            Console.WriteLine(floor);




        }
        public static void Part2()
        {
            int floor = 0;
            int charCount = 0;

            foreach (char move in Inputs.Day1.Full())
            {
                charCount++;
                if (move == '(')
                {
                    floor++;
                }
                else
                {
                    floor--;
                }
                if (floor == -1)
                {
                    break;
                }
            }

            Console.WriteLine(charCount);

        }
    }

}
