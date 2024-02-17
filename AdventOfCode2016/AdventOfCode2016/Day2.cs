using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2016
{
    internal class Day2
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

            string code = "";
            int[,] keyPad = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[] position = new int[] { 1, 1 };

            foreach(string line in Inputs.Day2.Full())
            {
                foreach(char direction in line)
                {
                    switch (direction)
                    {
                        case 'U':
                            if (position[1] > 0)
                            {
                                position[1]--;
                            }
                            break;
                        case 'D':
                            if (position[1] < 2)
                            {
                                position[1]++;
                            }
                            break;
                        case 'L':
                            if (position[0] > 0)
                            {
                                position[0]--;
                            }
                            break;
                        case 'R':
                            if (position[0] < 2)
                            {
                                position[0]++;
                            }
                            break;
                        default:
                            Console.WriteLine("Something went wrong");
                            break;
                    }
                }


                code += keyPad[position[1],position[0]];
            }

            Console.WriteLine(code);



        }
        public static void Part2()
        {

        }
    }
}
