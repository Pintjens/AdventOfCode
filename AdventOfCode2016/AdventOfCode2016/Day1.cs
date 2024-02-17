using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2016
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
            string[] directions = Inputs.Day1.Full().Split(", ");

            //start at 0,0
            int[] possition = new int[] { 0, 0 };
            int heading = 0;
            // 0 = North
            // 1 = East
            // 2 = South
            // 3 = West



            foreach (var direction in directions)
            {
                if (direction[0] == 'R')
                {
                    heading = (heading + 1) % 4;
                }
                else
                {
                    heading = (heading + 3) % 4;
                }

                int distance = Convert.ToInt32(direction.Substring(1));

                switch (heading)
                {
                    case 0:
                        possition[1] -= distance;
                        break;
                    case 1:
                        possition[0] += distance;
                        break;
                    case 2:
                        possition[1] += distance;
                        break;
                    case 3:
                        possition[0] -= distance;
                        break;
                    default:
                        Console.WriteLine("Something went wrong 1");
                        break;
                }
            }




            for(int i = 0; i < possition.Length; i++)
            {
                if (possition[i] < 0)
                {
                    possition[i] *= -1;
                }
            }
            Console.WriteLine(possition[0] + possition[1]);


        }
        public static void Part2()
        {
            string[] directions = Inputs.Day1.Full().Split(", ");

            //start at 0,0
            int[] possition = new int[] { 0, 0 };
            int heading = 0;
            // 0 = North
            // 1 = East
            // 2 = South
            // 3 = West

            List<int[]> visited = new List<int[]>();

            bool found = false;
            foreach (var direction in directions)
            {
                if (direction[0] == 'R')
                {
                    heading = (heading + 1) % 4;
                }
                else
                {
                    heading = (heading + 3) % 4;
                }

                int distance = Convert.ToInt32(direction.Substring(1));

                for(int d = 0; d < distance; d++)
                {

                    visited.Add(new int[] { possition[0], possition[1] });

                    switch (heading)
                    {
                        case 0:
                            possition[1]--;
                            break;
                        case 1:
                            possition[0]++;
                            break;
                        case 2:
                            possition[1]++;
                            break;
                        case 3:
                            possition[0]--;
                            break;
                        default:
                            Console.WriteLine("Something went wrong 1");
                            break;
                    }


                    foreach (var visit in visited)
                    {
                        if (visit[0] == possition[0] && visit[1] == possition[1])
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        break;
                    }

                }


                if (found)
                {
                    break;
                }



            }

            for (int i = 0; i < possition.Length; i++)
            {
                if (possition[i] < 0)
                {
                    possition[i] *= -1;
                }
            }


            Console.WriteLine(possition[0] + possition[1]);

            // 251 is to high
        }
    }
}
