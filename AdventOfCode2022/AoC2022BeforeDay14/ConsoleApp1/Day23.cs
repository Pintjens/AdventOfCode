using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day23
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
            
            List<string> startData = Input.Day23.Full();

            List<string> possitions = new List<string>();
            List<string> proposals = new List<string>();

            int direction = -1;


            for(int i = 0; i < startData.Count; i++)
            {
                for(int j = 0; j < startData[i].Length; j++)
                {
                    if (startData[i][j] == '#')
                    {
                        possitions.Add(i + "," + j);
                    }

                }
            }
            int x;
            int y;

            int stayCount = 0;
            bool finished = false;

            for (int t = 0; !finished; t++)//10 times
            {
                ////Visual debug builder
                //Console.Clear();
                //List<int[]> xyPos = new List<int[]>();

                //foreach (string possition in possitions)
                //{
                //    string[] xYPos = possition.Split(',');
                //    xyPos.Add(new int[] { Convert.ToInt32(xYPos[0]) + 2, Convert.ToInt32(xYPos[1]) + 3 });
                //}

                //for(int xx = 0; xx < startData.Count + 5; xx++)
                //{
                //    for(int yy = 0; yy < 14; yy++)
                //    {
                //        int g;
                //        for (g = 0; g < xyPos.Count; g++)
                //        {
                //            if (xyPos[g][0] == xx && xyPos[g][1] == yy)
                //            {
                //                Console.Write('#');
                //                g = xyPos.Count + 1;
                //            }
                //        }
                //        if(g == xyPos.Count)
                //        {
                //            Console.Write('.');
                //        }
                //    }
                //    Console.WriteLine();

                //}
                //Console.ReadLine();







                proposals.Clear();

                direction = (direction + 1) % 4;

                stayCount = 0;

                foreach (string possition in possitions)
                {
                    string[] xY = possition.Split(',');
                    x = Convert.ToInt32(xY[0]);
                    y = Convert.ToInt32(xY[1]);


                    List<int> option = new List<int>();
                    bool proposed = false;
                    int thisDirection = direction;
                    for (int i = 0; i < 4; i++)
                    {
                        switch (thisDirection)
                        {
                            case 0: // North
                                if (!possitions.Contains($"{x - 1},{y - 1}") && !possitions.Contains($"{x - 1},{y}") && !possitions.Contains($"{x - 1},{y + 1}"))
                                {
                                    option.Add(0);
                                }
                                break;
                            case 1: // South
                                if (!possitions.Contains($"{x + 1},{y - 1}") && !possitions.Contains($"{x + 1},{y}") && !possitions.Contains($"{x + 1},{y + 1}"))
                                {
                                    option.Add(1);
                                }
                                break;
                            case 2: // West
                                if (!possitions.Contains($"{x - 1},{y - 1}") && !possitions.Contains($"{x},{y - 1}") && !possitions.Contains($"{x + 1},{y - 1}"))
                                {
                                    option.Add(2);
                                }
                                break;
                            case 3: // East
                                if (!possitions.Contains($"{x - 1},{y + 1}") && !possitions.Contains($"{x},{y + 1}") && !possitions.Contains($"{x + 1},{y + 1}"))
                                {
                                    option.Add(3);
                                }
                                break;
                        }

                        thisDirection = (thisDirection + 1) % 4;

                    }
                    if(option.Count == 4 || option.Count == 0)
                    {
                        option.Add(4);
                        option[0] = 4;
                    }
                    switch (option[0])
                    {
                        case 0:
                            proposals.Add($"{x - 1},{y}");
                            break;
                        case 1:
                            proposals.Add($"{x + 1},{y}");
                            break;
                        case 2:
                            proposals.Add($"{x},{y - 1}");
                            break;
                        case 3:
                            proposals.Add($"{x},{y + 1}");
                            break;
                        default:
                            stayCount++;
                            proposals.Add(possition);
                            break;

                    }

                }

                ImmutableList<string> ImPos()
                {
                    return possitions.ToImmutableList();
                }

                ImmutableList<string> imPos = ImPos();

                possitions.Clear();


                for (int i = 0; i < imPos.Count; i++)
                {
                    if (proposals.IndexOf(proposals[i]) == proposals.LastIndexOf(proposals[i]))
                    {
                        possitions.Add(proposals[i]);
                    }
                    else
                    {
                        stayCount++;
                        possitions.Add(imPos[i]);
                    }
                }


                if(t == 9)
                {
                    int minX = 9999999;
                    int maxX = -9999999;
                    int minY = minX;
                    int maxY = maxX;

                    foreach (string possition in possitions)
                    {
                        x = Convert.ToInt32(possition.Split(',')[0]);
                        y = Convert.ToInt32(possition.Split(',')[1]);

                        if (x < minX)
                        {
                            minX = x;
                        }
                        if (x > maxX)
                        {
                            maxX = x;
                        }
                        if (y < minY)
                        {
                            minY = y;
                        }
                        if (y > maxY)
                        {
                            maxY = y;
                        }

                    }

                    Console.WriteLine(((((minX - maxX) * -1) + 1) * (((minY - maxY) * -1) + 1)) - possitions.Count);
                }

                if (stayCount == possitions.Count)
                {
                    stayCount = t + 1;
                    finished = true;
                }
                

            }


            Console.WriteLine(stayCount);



            //4033 is to low
            //4034 is the right answer for part 1

            //960 is the right answer for part 2

        }
        public static void Part2()
        {

        }
    }
}
