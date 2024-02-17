using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
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
            char lastChar = '*';
            string input = Inputs.Day1.Full();
            input += input.Last();
            int total = 0;

            foreach(char c in input)
            {
                if (c == lastChar)
                {
                    total += Convert.ToInt32(c.ToString());
                }
                lastChar = c;
            }

            Console.WriteLine(total);

            // 1559 is to high;
            // 1223 is the right answer
        }
        public static void Part2()
        {

            string input = Inputs.Day1.Full();
            int halfWay = input.Length / 2;
            char lastChar;
            int total = 0;

            for(int c = 0; c < input.Length; c++)
            {

                lastChar = input[(c + halfWay) % input.Length];

                if (input[c] == lastChar)
                {
                    total += Convert.ToInt32(input[c].ToString());
                }


            }

            Console.WriteLine(total);

            // 1124 is to low

        }
    }
}
