using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    internal class Day3
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
            int minX = 0;
            int maxX = 0;
            int minY = 0;
            int maxY = 0;

            foreach (char direction in Inputs.Day3.Full())
            {
                switch (direction)
                {
                    case '<':
                        minX++;
                        break;
                    case '>':
                        maxX++;
                        break;
                    case '^':
                        minY++;
                        break;
                    default:
                        maxY++;
                        break;
                }
            }

            int[] start = new int[] {minX+1, minY+1};

            Dictionary<int, Dictionary<int, bool>> grid = new Dictionary<int, Dictionary<int, bool>>();

            int x;
            int y;

            for(y = 0; y < minY + maxY; y++)
            {
                grid.Add(y, new Dictionary<int, bool>());

                for(x = 0; x < minX + maxX + 2; x++)
                { 
                    grid[y].Add(x, false);
                }
            }

            x = start[0];
            y = start[1];

            grid[y][x] = true; // start position

            foreach (char direction in Inputs.Day3.Full())
            {
                switch (direction)
                {
                    case '<':
                        x--;
                        break;
                    case '>':
                        x++;
                        break;
                    case '^':
                        y--;
                        break;
                    default:
                        y++;
                        break;
                }

                grid[y][x] = true;

            }


            int count = 0;

            for(int i = 0; i < grid.Count; i++)
            {
                foreach(var j in grid[i])
                {
                    if(j.Value == true)
                    {
                        count++;
                    }
                }
            }


            Console.WriteLine(count);



        }
        public static void Part2()
        {

            int minX = 0;
            int maxX = 0;
            int minY = 0;
            int maxY = 0;

            foreach (char direction in Inputs.Day3.Full())
            {
                switch (direction)
                {
                    case '<':
                        minX++;
                        break;
                    case '>':
                        maxX++;
                        break;
                    case '^':
                        minY++;
                        break;
                    default:
                        maxY++;
                        break;
                }
            }

            int[] start = new int[] { minX + 1, minY + 1 };

            Dictionary<int, Dictionary<int, bool>> grid = new Dictionary<int, Dictionary<int, bool>>();

            int x;
            int y;

            for (y = 0; y < minY + maxY; y++)
            {
                grid.Add(y, new Dictionary<int, bool>());

                for (x = 0; x < minX + maxX + 2; x++)
                {
                    grid[y].Add(x, false);
                }
            }

            int xS = start[0];
            int yS = start[1];

            int xR = start[0];
            int yR = start[1];

            grid[yS][xS] = true; // start position


            for (int i = 0; i < Inputs.Day3.Full().Length; i++)
            {
                char dS = Inputs.Day3.Full()[i];
                switch (dS)
                {
                    case '<':
                        xS--;
                        break;
                    case '>':
                        xS++;
                        break;
                    case '^':
                        yS--;
                        break;
                    default:
                        yS++;
                        break;
                }

                i++;
                char dR = Inputs.Day3.Full()[i];
                switch (dR)
                {
                    case '<':
                        xR--;
                        break;
                    case '>':
                        xR++;
                        break;
                    case '^':
                        yR--;
                        break;
                    default:
                        yR++;
                        break;
                }

                grid[yS][xS] = true;
                grid[yR][xR] = true;
            }


            int count = 0;

            for (int i = 0; i < grid.Count; i++)
            {
                foreach (var j in grid[i])
                {
                    if (j.Value == true)
                    {
                        count++;
                    }
                }
            }


            Console.WriteLine(count);

            // 2362 is to high

        }
    }
}
