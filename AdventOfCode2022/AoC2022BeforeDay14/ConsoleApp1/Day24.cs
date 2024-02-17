using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day24 // Blizzards
    {
        public static void Main()
        {
            Console.Write("Part ? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Part1();
            }
            else if (choice == "2")
            {
                Part2();
            }
            else
            {
                Console.WriteLine("Not possible..");
                Main();
            }
        }
        public static void Part1()
        {
            string[] data = Input.Day24.Full();
            int mapWidth = data[0].Length;

            List<int[]> start = new List<int[]>();
            start.Add(new int[] { 0, 1 });

            ImmutableList<int[]> possitions = start.ToImmutableList<int[]>(); 

            List<int[]> LB = new List<int[]>();
            List<int[]> RB = new List<int[]>();
            List<int[]> UB = new List<int[]>();
            List<int[]> DB = new List<int[]>();

            //Collect data


            for(int i = 1; i < data.Length -1; i++)
            {
                for(int j = 1; j < data[i].Length -1; j++)
                {
                    switch (data[i][j])
                    {
                        case '<':
                            LB.Add(new int[] { i, j-1 });
                            break;
                        case '>':
                            RB.Add(new int[] { i, j-1 });
                            break;
                        case '^':
                            UB.Add(new int[] { i-1, j });
                            break;
                        case 'v':
                            DB.Add(new int[] { i-1, j });
                            break;
                        default:
                            // no blizzard
                            break;
                    }
                }
            }



            // Initiate map
            char[][] map = new char[data.Length][];
            for(int m = 0; m < map.Length; m++)
            {
                map[m] = new char[mapWidth];
                map[m][0] = '#';
                map[m][mapWidth - 1] = '#';
            }
            for(int n = 0; n < mapWidth; n++)
            {
                map[0][n] = '#';
                map[map.Length - 1][n] = '#';
            }
            map[0][1] = 'Z';
            map[map.Length - 1][mapWidth - 2] = 'X';

            int part = 1;
            char goal = 'X';

            bool running = true;
            int time = 0;
            do
            {
                time++;

                // Rebuild map
                for (int m = 1; m < map.Length-1; m++)
                {
                    for(int n = 1; n < mapWidth - 1; n++)
                    {
                        map[m][n] = '.';
                    }
                }

                int innerWidth = mapWidth - 2;
                int innerHight = map.Length - 2;
                foreach (var p in LB)
                {
                    int y = (((p[1] - time) % innerWidth) + innerWidth) % innerWidth;

                    map[p[0]][y + 1] = '*';
                }
                foreach (var p in RB)
                {
                    map[p[0]][((p[1] + time) % innerWidth) + 1] = '*';
                }
                foreach (var p in UB)
                {
                    int x = (((p[0] - time) % innerHight) + innerHight) % innerHight;

                    map[x + 1][p[1]] = '*';
                }
                foreach (var p in DB)
                {
                    map[((p[0] + time) % innerHight) + 1][p[1]] = '*';
                }




                //foreach (var line in map)
                //{
                //    foreach (var point in line)
                //    {
                //        Console.Write(point);
                //    }
                //    Console.WriteLine();
                //}

                //Console.WriteLine();

                List<int[]> newPossitions = new List<int[]>();

                foreach (var possition in possitions)
                {

                    //stay
                    if (map[possition[0]][possition[1]] != '*')
                    {
                        newPossitions.Add(new int[] { possition[0], possition[1] });
                    }
                    //try down
                    if (possition[0] != map.Length - 1)
                    {
                        if (map[possition[0] + 1][possition[1]] == goal)
                        {
                            if (part == 2)
                            {
                                running = false;
                            }

                            Console.WriteLine($"Part {part}: " + time);
                            part++;

                            newPossitions.Clear();
                            newPossitions.Add(new int[] { possition[0] + 1, possition[1] });
                            goal = 'Z';

                            break;
                        }
                        else if (map[possition[0] + 1][possition[1]] != '*' && map[possition[0] + 1][possition[1]] != '#')
                        {

                            newPossitions.Add(new int[] { possition[0] + 1, possition[1] });
                        }
                    }

                    //try up
                    if (possition[0] != 0)
                    {
                        if (map[possition[0] - 1][possition[1]] == goal)
                        {
                            Console.WriteLine($"Back at start: " + time);

                            newPossitions.Clear();
                            newPossitions.Add(new int[] { possition[0] - 1, possition[1] });
                            goal = 'X';

                            break;
                        }
                        else if (!(possition[0] < 2))
                        {
                            if (map[possition[0] - 1][possition[1]] != '*' && map[possition[0] - 1][possition[1]] != '#')
                            {
                                newPossitions.Add(new int[] { possition[0] - 1, possition[1] });
                            }
                        }
                    }


                    //try left
                    if (possition[1] != 1)
                    {
                        if (map[possition[0]][possition[1] - 1] != '*' && map[possition[0]][possition[1] - 1] != '#')
                        {
                            newPossitions.Add(new int[] { possition[0], possition[1] - 1 });
                        }
                    }

                    //try tight
                    if (possition[1] != mapWidth - 2)
                    {
                        if (map[possition[0]][possition[1] + 1] != '*' && map[possition[0]][possition[1] + 1] != '#')
                        {
                            newPossitions.Add(new int[] { possition[0], possition[1] + 1 });
                        }
                    }
                }

                static ImmutableList<int[]> CleanList(List<int[]> newPossitions)
                {
                    bool dbl = false;
                    List<int[]> cleanList = new List<int[]>();
                    foreach(var possition in newPossitions)
                    {
                        dbl = false;
                        foreach(var clean in cleanList)
                        {
                            if (clean[0] == possition[0] && clean[1] == possition[1])
                            {
                                dbl = true;
                                break;
                            }
                        }
                        if (!dbl)
                        {
                            cleanList.Add(new int[] { possition[0], possition[1] });
                        }
                    }
                    return cleanList.ToImmutableList<int[]>();
                }

                possitions = CleanList(newPossitions);

            } while (running);

            //311 is the right answer for part 1;
        }
        public static void Part2()
        {

        }
    }
}
