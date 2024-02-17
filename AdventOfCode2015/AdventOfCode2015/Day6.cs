using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    internal class Day6
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
            Dictionary<int, Dictionary<int, int>> lights = new Dictionary<int, Dictionary<int, int>>();

            int x;
            int y;

            for(y = 0; y < 1000; y++)
            {
                lights[y] = new Dictionary<int, int>();
                for(x = 0; x < 1000; x++)
                {
                    lights[y][x] = -1;
                }
            }

            int fromX;
            int fromY;
            int toX;
            int toY;


            foreach (var instruction in Inputs.Day6.Full())
            {
                string[] instructionSplit = instruction.Split(' ');
                if (instructionSplit[0] == "toggle")
                {
                    fromX = Convert.ToInt32(instructionSplit[1].Split(',')[0]);
                    fromY = Convert.ToInt32(instructionSplit[1].Split(',')[1]); ;
                    toX = Convert.ToInt32(instructionSplit[3].Split(',')[0]); ;
                    toY = Convert.ToInt32(instructionSplit[3].Split(',')[1]); ;

                    for (y = fromY; y <= toY; y++)
                    {
                        for (x = fromX; x <= toX; x++)
                        {
                            lights[y][x] *= -1;
                        }
                    }
                }
                else
                {
                    fromX = Convert.ToInt32(instructionSplit[2].Split(',')[0]);
                    fromY = Convert.ToInt32(instructionSplit[2].Split(',')[1]); ;
                    toX = Convert.ToInt32(instructionSplit[4].Split(',')[0]); ;
                    toY = Convert.ToInt32(instructionSplit[4].Split(',')[1]); ;

                    int setTo = -1; // If its off

                    if (instructionSplit[1] == "on")
                    {
                        setTo = 1;
                    }

                    for(y = fromY; y <= toY; y++)
                    {
                        for(x = fromX; x <= toX; x++)
                        {
                            lights[y][x] = setTo;
                        }
                    }
                }
            }

            int onCount = 0;
            for (y = 0; y < 1000; y++)
            {
                for (x = 0; x < 1000; x++)
                {
                    if (lights[y][x] == 1)
                    {
                        onCount++;
                    }
                }
            }

            Console.WriteLine(onCount);

        }
        public static void Part2()
        {
            Dictionary<int, Dictionary<int, int>> lights = new Dictionary<int, Dictionary<int, int>>();

            int x;
            int y;

            for (y = 0; y < 1000; y++)
            {
                lights[y] = new Dictionary<int, int>();
                for (x = 0; x < 1000; x++)
                {
                    lights[y][x] = 0;
                }
            }

            int fromX;
            int fromY;
            int toX;
            int toY;


            foreach (var instruction in Inputs.Day6.Full())
            {
                string[] instructionSplit = instruction.Split(' ');
                if (instructionSplit[0] == "toggle")
                {
                    fromX = Convert.ToInt32(instructionSplit[1].Split(',')[0]);
                    fromY = Convert.ToInt32(instructionSplit[1].Split(',')[1]); ;
                    toX = Convert.ToInt32(instructionSplit[3].Split(',')[0]); ;
                    toY = Convert.ToInt32(instructionSplit[3].Split(',')[1]); ;

                    for (y = fromY; y <= toY; y++)
                    {
                        for (x = fromX; x <= toX; x++)
                        {
                            lights[y][x] +=2;
                        }
                    }
                }
                else
                {
                    fromX = Convert.ToInt32(instructionSplit[2].Split(',')[0]);
                    fromY = Convert.ToInt32(instructionSplit[2].Split(',')[1]); ;
                    toX = Convert.ToInt32(instructionSplit[4].Split(',')[0]); ;
                    toY = Convert.ToInt32(instructionSplit[4].Split(',')[1]); ;

                    int setTo = -1; // If its off

                    if (instructionSplit[1] == "on")
                    {
                        setTo = 1;
                    }

                    for (y = fromY; y <= toY; y++)
                    {
                        for (x = fromX; x <= toX; x++)
                        {
                            lights[y][x] += setTo;
                            if (lights[y][x] < 0) // -.-'
                            {
                                lights[y][x] = 0;
                            }
                        }
                    }
                }
            }

            long brightness = 0;
            for (y = 0; y < 1000; y++)
            {
                for (x = 0; x < 1000; x++)
                {
                    brightness += lights[y][x];
                }
            }

            Console.WriteLine(brightness);

            // 14190930 is to low

            // 14687245 is the right answer
        }
    }
}
