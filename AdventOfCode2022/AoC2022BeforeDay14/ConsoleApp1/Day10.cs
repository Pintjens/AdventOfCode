using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day10
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
            string[,] input = { { "addx", "1" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "5" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "-1" }, { "addx", "5" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "5" }, { "noop", "noop" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "6" }, { "addx", "-4" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "5" }, { "noop", "noop" }, { "addx", "-32" }, { "addx", "35" }, { "addx", "5" }, { "addx", "-31" }, { "addx", "7" }, { "addx", "-13" }, { "addx", "2" }, { "addx", "2" }, { "addx", "5" }, { "addx", "6" }, { "addx", "-5" }, { "addx", "2" }, { "addx", "5" }, { "addx", "2" }, { "addx", "2" }, { "addx", "-17" }, { "addx", "18" }, { "addx", "5" }, { "addx", "2" }, { "addx", "-30" }, { "addx", "31" }, { "addx", "2" }, { "addx", "2" }, { "addx", "-32" }, { "addx", "-1" }, { "addx", "10" }, { "addx", "-8" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "6" }, { "addx", "16" }, { "noop", "noop" }, { "addx", "-11" }, { "addx", "3" }, { "addx", "-2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "6" }, { "noop", "noop" }, { "addx", "-2" }, { "noop", "noop" }, { "addx", "7" }, { "addx", "3" }, { "addx", "-2" }, { "addx", "4" }, { "addx", "-20" }, { "noop", "noop" }, { "addx", "-14" }, { "addx", "-2" }, { "addx", "6" }, { "addx", "2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "-1" }, { "addx", "4" }, { "noop", "noop" }, { "addx", "5" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "3" }, { "addx", "-2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "4" }, { "noop", "noop" }, { "addx", "5" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "-24" }, { "addx", "-15" }, { "addx", "17" }, { "addx", "-10" }, { "addx", "2" }, { "addx", "-5" }, { "addx", "6" }, { "noop", "noop" }, { "addx", "3" }, { "addx", "2" }, { "addx", "2" }, { "noop", "noop" }, { "addx", "3" }, { "addx", "2" }, { "addx", "5" }, { "addx", "-2" }, { "addx", "3" }, { "addx", "2" }, { "addx", "2" }, { "addx", "5" }, { "addx", "2" }, { "addx", "-18" }, { "addx", "-19" }, { "noop", "noop" }, { "addx", "1" }, { "addx", "2" }, { "addx", "5" }, { "addx", "3" }, { "noop", "noop" }, { "noop", "noop" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "5" }, { "addx", "2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "-8" }, { "addx", "11" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "5" }, { "addx", "2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "-34" }, { "noop", "noop" } };
            //string[,] input = {{"addx","1"},{"noop","noop"},{"addx","2"},{"addx","5"},{"addx","3"},{"noop","noop"},{"addx"," - 1"},{"addx","5"},{"noop","noop"},{"noop","noop"},{"addx","5"},{"noop","noop"},{"addx","3"},{"noop","noop"},{"addx","6"},{"addx"," - 4"},{"noop","noop"},{"noop","noop"},{"addx","5"},{"noop","noop"},{"addx"," - 32"},{"addx","35"},{"addx","5"},{"addx"," - 31"},{"addx","7"},{"addx"," - 13"},{"addx","2"},{"addx","2"},{"addx","5"},{"addx","6"},{"addx"," - 5"},{"addx","2"},{"addx","5"},{"addx","2"},{"addx","2"},{"addx"," - 17"},{"addx","18"},{"addx","5"},{"addx","2"},{"addx"," - 30"},{"addx","31"},{"addx","2"},{"addx","2"},{"addx"," - 32"},{"addx"," - 1"},{"addx","10"},{"addx"," - 8"},{"noop","noop"},{"noop","noop"},{"addx","6"},{"addx","16"},{"noop","noop"},{"addx"," - 11"},{"addx","3"},{"addx"," - 2"},{"addx","3"},{"noop","noop"},{"addx","6"},{"noop","noop"},{"addx"," - 2"},{"noop","noop"},{"addx","7"},{"addx","3"},{"addx"," - 2"},{"addx","4"},{"addx"," - 20"},{"noop","noop"},{"addx"," - 14"},{"addx"," - 2"},{"addx","6"},{"addx","2"},{"addx","3"},{"noop","noop"},{"addx","2"},{"addx"," - 1"},{"addx","4"},{"noop","noop"},{"addx","5"},{"noop","noop"},{"addx","2"},{"addx","3"},{"addx"," - 2"},{"addx","3"},{"noop","noop"},{"addx","4"},{"noop","noop"},{"addx","5"},{"noop","noop"},{"addx","2"},{"addx"," - 24"},{"addx"," - 15"},{"addx","17"},{"addx"," - 10"},{"addx","2"},{"addx"," - 5"},{"addx","6"},{"noop","noop"},{"addx","3"},{"addx","2"},{"addx","2"},{"noop","noop"},{"addx","3"},{"addx","2"},{"addx","5"},{"addx"," - 2"},{"addx","3"},{"addx","2"},{"addx","2"},{"addx","5"},{"addx","2"},{"addx"," - 18"},{"addx"," - 19"},{"noop","noop"},{"addx","1"},{"addx","2"},{"addx","5"},{"addx","3"},{"noop","noop"},{"noop","noop"},{"noop","noop"},{"noop","noop"},{"addx","2"},{"addx","5"},{"addx","2"},{"addx","3"},{"noop","noop"},{"addx"," - 8"},{"addx","11"},{"noop","noop"},{"noop","noop"},{"addx","2"},{"addx","5"},{"addx","2"},{"addx","3"},{"noop","noop"},{"addx"," - 34"},{"noop","noop"}};
            //string[,] input = { { "noop", "noop" }, { "addx", "3" }, { "addx", "-5" } };
            int X = 1;
            int cycle = 1;
            int signal20 = 0;
            int signal60 = 0;
            int signal100 = 0;
            int signal140 = 0;
            int signal180 = 0;
            int signal220 = 0;
            int signalSum = 0;

            int totalCommands = input.GetLength(0);

            for (int i = 0; i < totalCommands; i++)
            {

                if (input[i, 0] == "noop")
                {
                    if (cycle == 20)
                    {
                        signal20 = 20 * X;
                    }
                    else if (cycle == 60)
                    {
                        signal60 = 60 * X;
                    }
                    else if (cycle == 100)
                    {
                        signal100 = 100 * X;
                    }
                    else if (cycle == 140)
                    {
                        signal140 = 140 * X;
                    }
                    else if (cycle == 180)
                    {
                        signal180 = 180 * X;
                    }
                    else if (cycle == 220)
                    {
                        signal220 = 220 * X;
                    }
                    cycle++;
                }
                else
                {
                    if (cycle == 20)
                    {
                        signal20 = 20 * X;
                    }
                    else if (cycle == 60)
                    {
                        signal60 = 60 * X;
                    }
                    else if (cycle == 100)
                    {
                        signal100 = 100 * X;
                    }
                    else if (cycle == 140)
                    {
                        signal140 = 140 * X;
                    }
                    else if (cycle == 180)
                    {
                        signal180 = 180 * X;
                    }
                    else if (cycle == 220)
                    {
                        signal220 = 220 * X;
                    }
                    cycle++;
                    if (cycle == 20)
                    {
                        signal20 = 20 * X;
                    }
                    else if (cycle == 60)
                    {
                        signal60 = 60 * X;
                    }
                    else if (cycle == 100)
                    {
                        signal100 = 100 * X;
                    }
                    else if (cycle == 140)
                    {
                        signal140 = 140 * X;
                    }
                    else if (cycle == 180)
                    {
                        signal180 = 180 * X;
                    }
                    else if (cycle == 220)
                    {
                        signal220 = 220 * X;
                    }
                    X += Convert.ToInt32(input[i, 1]);
                    cycle++;


                }
                signalSum = signal20 + signal60 + signal100 + signal140 + signal180 + signal220;
            }


            Console.WriteLine(signalSum);
            // its 13820
        }
        public static void Part2()
        {
            string[,] input = { { "addx", "1" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "5" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "-1" }, { "addx", "5" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "5" }, { "noop", "noop" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "6" }, { "addx", "-4" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "5" }, { "noop", "noop" }, { "addx", "-32" }, { "addx", "35" }, { "addx", "5" }, { "addx", "-31" }, { "addx", "7" }, { "addx", "-13" }, { "addx", "2" }, { "addx", "2" }, { "addx", "5" }, { "addx", "6" }, { "addx", "-5" }, { "addx", "2" }, { "addx", "5" }, { "addx", "2" }, { "addx", "2" }, { "addx", "-17" }, { "addx", "18" }, { "addx", "5" }, { "addx", "2" }, { "addx", "-30" }, { "addx", "31" }, { "addx", "2" }, { "addx", "2" }, { "addx", "-32" }, { "addx", "-1" }, { "addx", "10" }, { "addx", "-8" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "6" }, { "addx", "16" }, { "noop", "noop" }, { "addx", "-11" }, { "addx", "3" }, { "addx", "-2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "6" }, { "noop", "noop" }, { "addx", "-2" }, { "noop", "noop" }, { "addx", "7" }, { "addx", "3" }, { "addx", "-2" }, { "addx", "4" }, { "addx", "-20" }, { "noop", "noop" }, { "addx", "-14" }, { "addx", "-2" }, { "addx", "6" }, { "addx", "2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "-1" }, { "addx", "4" }, { "noop", "noop" }, { "addx", "5" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "3" }, { "addx", "-2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "4" }, { "noop", "noop" }, { "addx", "5" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "-24" }, { "addx", "-15" }, { "addx", "17" }, { "addx", "-10" }, { "addx", "2" }, { "addx", "-5" }, { "addx", "6" }, { "noop", "noop" }, { "addx", "3" }, { "addx", "2" }, { "addx", "2" }, { "noop", "noop" }, { "addx", "3" }, { "addx", "2" }, { "addx", "5" }, { "addx", "-2" }, { "addx", "3" }, { "addx", "2" }, { "addx", "2" }, { "addx", "5" }, { "addx", "2" }, { "addx", "-18" }, { "addx", "-19" }, { "noop", "noop" }, { "addx", "1" }, { "addx", "2" }, { "addx", "5" }, { "addx", "3" }, { "noop", "noop" }, { "noop", "noop" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "5" }, { "addx", "2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "-8" }, { "addx", "11" }, { "noop", "noop" }, { "noop", "noop" }, { "addx", "2" }, { "addx", "5" }, { "addx", "2" }, { "addx", "3" }, { "noop", "noop" }, { "addx", "-34" }, { "noop", "noop" } };

            List<char> firstLineOutput = new List<char>();
            List<char> scendLineOutput = new List<char>();
            List<char> therdLineOutput = new List<char>();
            List<char> fourtLineOutput = new List<char>();
            List<char> fifthLineOutput = new List<char>();
            List<char> sixthLineOutput = new List<char>();



            int X = 1;
            int cycle = 0;

            int totalCommands = input.GetLength(0);

            for (int i = 0; i < totalCommands; i++)
            {
                char[] spritePosition = { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' };
                if (X > -2 && X < 39)
                {
                    spritePosition[X + 1] = '#';
                }
                if (X > -1 && X < 40)
                {
                    spritePosition[X] = '#';
                }
                if (X > 0 && X < 41)
                {
                    spritePosition[X - 1] = '#';
                }




                if (input[i, 0] == "noop")
                {
                    if (cycle <= 39)
                    {
                        firstLineOutput.Add(spritePosition[cycle]);
                    }
                    else if (cycle <= 79)
                    {
                        scendLineOutput.Add(spritePosition[cycle - 40]);
                    }
                    else if (cycle <= 119)
                    {
                        therdLineOutput.Add(spritePosition[cycle - 80]);
                    }
                    else if (cycle <= 159)
                    {
                        fourtLineOutput.Add(spritePosition[cycle - 120]);
                    }
                    else if (cycle <= 199)
                    {
                        fifthLineOutput.Add(spritePosition[cycle - 160]);
                    }
                    else if (cycle <= 239)
                    {
                        sixthLineOutput.Add(spritePosition[cycle - 200]);
                    }
                    cycle++;
                }
                else
                {
                    if (cycle <= 39)
                    {
                        firstLineOutput.Add(spritePosition[cycle]);
                    }
                    else if (cycle <= 79)
                    {
                        scendLineOutput.Add(spritePosition[cycle - 40]);
                    }
                    else if (cycle <= 119)
                    {
                        therdLineOutput.Add(spritePosition[cycle - 80]);
                    }
                    else if (cycle <= 159)
                    {
                        fourtLineOutput.Add(spritePosition[cycle - 120]);
                    }
                    else if (cycle <= 199)
                    {
                        fifthLineOutput.Add(spritePosition[cycle - 160]);
                    }
                    else if (cycle <= 240)
                    {
                        sixthLineOutput.Add(spritePosition[cycle - 200]);
                    }
                    cycle++;


                    if (cycle <= 39)
                    {
                        firstLineOutput.Add(spritePosition[cycle]);
                    }
                    else if (cycle <= 79)
                    {
                        scendLineOutput.Add(spritePosition[cycle - 40]);
                    }
                    else if (cycle <= 119)
                    {
                        therdLineOutput.Add(spritePosition[cycle - 80]);
                    }
                    else if (cycle <= 159)
                    {
                        fourtLineOutput.Add(spritePosition[cycle - 120]);
                    }
                    else if (cycle <= 199)
                    {
                        fifthLineOutput.Add(spritePosition[cycle - 160]);
                    }
                    else if (cycle <= 239)
                    {
                        sixthLineOutput.Add(spritePosition[cycle - 200]);
                    }

                    X += Convert.ToInt32(input[i, 1]);
                    cycle++;


                }

            }

            Printers.PrintCharList(firstLineOutput);
            Printers.PrintCharList(scendLineOutput);
            Printers.PrintCharList(therdLineOutput);
            Printers.PrintCharList(fourtLineOutput);
            Printers.PrintCharList(fifthLineOutput);
            Printers.PrintCharList(sixthLineOutput);

            // its ZKGRKGRK
        }
    }
}
