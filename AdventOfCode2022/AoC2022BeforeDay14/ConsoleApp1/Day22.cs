using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day22
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

            string[] mapData = Input.Day22.Full.Map();
            string instructions = Input.Day22.Full.Instructions();

            int maxLength = 0;

            foreach(string line in mapData)
            {
                if(line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            for(int i = 0; i < mapData.Length; i++)
            {
                mapData[i] += new String(' ', maxLength - mapData[i].Length);
            }


            int[] startPoint = new int[2];
            startPoint[0] = 0;
            startPoint[1] = mapData[0].IndexOf('.');


            int instructionIndex = 0;



            int[] lastPosition = new int[2];
            int direction = 0;
            //0 = right
            //1 = down
            //2 = left
            //3 = up


            while (instructionIndex < instructions.Length)
            {
                string distanceString = "";
                char turn = 'O';
                bool findingStep = true;

                while (findingStep && instructionIndex < instructions.Length)
                {

                    char instructionPart = instructions[instructionIndex];

                    if (instructionPart == 'R' || instructionPart == 'L')
                    {
                        turn = instructionPart;
                        findingStep = false;
                    }
                    else
                    {
                        distanceString += instructionPart;
                    }
                    instructionIndex++;
                }

                int distance = Convert.ToInt32(distanceString);


                int row = lastPosition[0];
                int col = lastPosition[1];
                char ahead;


                if (direction % 2 == 0)
                {
                    int move = -1;
                    if (direction == 0)
                    {
                        move = 1;
                    }

                    for (int step = 1; step <= distance; step++)
                    {
                        try
                        {
                            col += move;
                            ahead = mapData[row][col];
                        }
                        catch
                        {
                            if (direction == 0)
                            {
                                col = 0;
                            }
                            else
                            {
                                col = mapData[row].Length - 1;
                            }

                            ahead = mapData[row][col];
                        }

                        if (ahead == '#')
                        {
                            step = distance;
                        }
                        else if (ahead == ' ')
                        {
                            step--;
                        }
                        else
                        {
                            lastPosition[1] = col;
                        }
                    }
                }
                else
                {
                    int move = -1;
                    if (direction == 1)
                    {
                        move = 1;
                    }

                    for (int step = 1; step <= distance; step++)
                    {
                        try
                        {
                            row += move;
                            ahead = mapData[row][col];
                        }
                        catch
                        {
                            if (direction == 1)
                            {
                                row = 0;
                            }
                            else
                            {
                                row = mapData.Length - 1;
                            }

                            ahead = mapData[row][col];
                        }

                        if (ahead == '#')
                        {
                            step = distance;
                        }
                        else if (ahead == ' ')
                        {
                            step--;
                        }
                        else
                        {
                            lastPosition[0] = row;
                        }
                    }
                }




                Console.WriteLine();



                if(instructionIndex < instructions.Length)
                {
                    if (turn == 'R')
                    {
                        direction = (direction + 1) % 4;
                    }
                    else
                    {
                        direction = (direction - 1) % 4;
                        if (direction == -1)
                        {
                            direction = 3;
                        }
                    }
                }

            }

            Console.WriteLine(((lastPosition[0]+1) * 1000) + (4 * (lastPosition[1]+1)) + direction);




            //95358 is the right answer

        }
        public static void Part2()
        {   //                                          turn
            // A1   UP 199[50-99] => [150-199]0     RI  +1
            //      LE [150-199]149 => 0[50-99]     DO  -1
            // A2   RI [155-199]50 => 149[50-99]    UP  -1
            //      DO 150[50-99] => [150-199]49    LE  +1

            // B1   UP 199[100-149] => 199[0-49]    UP  +0
            //      DO 0[0-49] => 0[100-149]        DO  +0
            // B2   UP 99[0-49] => [50-99]50        RI  +1
            //      LE [50-99]49 => [0-49]100       DO  -1
            // B3   RI [50-99]100 => 49[100-149]    UP  -1
            //      DO 50[100-149] => [50-99]99     LE  +1

            // C1.1 LE [0-49]49 => [149-100]0       RI  +2
            //   .2 LE [100-149]149 => [49-0]50     RI  +2
            // C2.1 RI [100-149]100 => [49-0]149    LE  +2
            //   .2 RI [0-49]0 => [149-100]99       LE  +2



            string[] mapData = Input.Day22.Full.Map();
            string instructions = Input.Day22.Full.Instructions();
            //instructions = "250R200R250L250L300L50";

            int maxLength = 0;

            foreach (string line in mapData)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            for (int i = 0; i < mapData.Length; i++)
            {
                mapData[i] += new String(' ', maxLength - mapData[i].Length);
            }


            int[] startPoint = new int[2];
            startPoint[0] = 0;
            startPoint[1] = mapData[0].IndexOf('.');


            int instructionIndex = 0;

            //startPoint[0] = 25;
            //startPoint[1] = 75;

            int[] lastPosition = new int[] { startPoint[0], startPoint[1] };



            int direction = 0;
            //0 = right
            //1 = down
            //2 = left
            //3 = up


            while (instructionIndex < instructions.Length)
            {
                string distanceString = "";
                char turn = 'O';
                bool findingStep = true;

                while (findingStep && instructionIndex < instructions.Length)
                {

                    char instructionPart = instructions[instructionIndex];

                    if (instructionPart == 'R' || instructionPart == 'L')
                    {
                        turn = instructionPart;
                        findingStep = false;
                    }
                    else
                    {
                        distanceString += instructionPart;
                    }
                    instructionIndex++;


                }

                int distance = Convert.ToInt32(distanceString);


                int row = lastPosition[0];
                int col = lastPosition[1];
                char ahead;


                for (int step = 0; step < distance; step++)
                {


                    switch (direction)
                    {
                        case 0:
                            col++;
                            if (col == maxLength)
                            {
                                col = 0;
                            }
                            break;
                        case 1:
                            row++;
                            if (row == mapData.Length)
                            {
                                row = 0;
                            }
                            break;
                        case 2:
                            col--;
                            if (col == -1)
                            {
                                col = maxLength - 1;
                            }
                            break;
                        case 3:
                            row--;
                            if (row == -1)
                            {
                                row = mapData.Length - 1;
                            }
                            break;
                        default:
                            Console.WriteLine("something's wrong");
                            break;
                    }


                    ahead = mapData[row][col];
                    int dC = 0; // direction correction

                    switch (ahead)
                    {
                        case '#':
                            step = distance;
                            break;
                        case ' ':
                            //                                          turn
                            // A1   UP 199[50-99] => [150-199]0     RI  +1
                            if (row == 199 && col >= 50 && col <= 99)
                            {
                                row = col + 100;
                                col = 0;
                                dC = 1;
                            }
                            //      LE [150-199]149 => 0[50-99]     DO  -1
                            else if (col == 149 && row >= 150 && row <= 199)
                            {
                                col = row - 100;
                                row = 0;
                                dC = 3;
                            }
                            // A2   RI [150-199]50 => 149[50-99]    UP  -1
                            else if (col == 50 && row >= 150 && row <= 199)
                            {
                                col = row - 100;
                                row = 149;
                                dC = 3;
                            }
                            //      DO 150[50-99] => [150-199]49    LE  +1
                            else if (row == 150 && col >= 50 && col <= 99)
                            {
                                row = col + 100;
                                col = 49;
                                dC = 1;
                            }
                            // B1   UP 199[100-149] => 199[0-49]    UP  +0
                            else if (row == 199 && col >= 100 && col <= 149)
                            {
                                col = col - 100;
                                row = 199;
                            }
                            //      DO 0[0-49] => 0[100-149]        DO  +0
                            else if (row == 0 && col <= 49)
                            {
                                col += 100;
                            }
                            // B2   UP 99[0-49] => [50-99]50        RI  +1
                            else if (row == 99 && col <= 49)
                            {
                                row = col + 50;
                                col = 50;
                                dC = 1;
                            }
                            //      LE [50-99]49 => 100[0-49]       DO  -1
                            else if (col == 49 && row >= 50 && row <= 99)
                            {
                                col = row - 50;
                                row = 100;
                                dC = 3;
                            }
                            // B3   RI [50-99]100 => 49[100-149]    UP  -1
                            else if (col == 100 && row >= 50 && row <= 99)
                            {
                                col = row + 50;
                                row = 49;
                                dC = 3;
                            }
                            //      DO 50[100-149] => [50-99]99     LE  +1
                            else if (row == 50 && col >= 100 && col <= 149)
                            {
                                row = col - 50;
                                col = 99;
                                dC = 1;
                            }
                            // C1.1 LE [0-49]49 => [149-100]0       RI  +2
                            else if (col == 49 && row <= 49)
                            {
                                row = 149 - row;
                                col = 0;
                                dC = 2;
                            }
                            //   .2 LE [100-149]149 => [49-0]50     RI  +2
                            else if (col == 149 && row >= 100 && row <= 149)
                            {
                                row = 149 - row;
                                col = 50;
                                dC = 2;
                            }
                            // C2.1 RI [100-149]100 => [49-0]149    LE  +2
                            else if (col == 100 && row >= 100 && row <= 149)
                            {
                                row = 149 - row;
                                col = 149;
                                dC = 2;
                            }
                            //   .2 RI [0-49]0 => [149-100]99       LE  +2
                            else if (col == 0 && row <= 49)
                            {
                                row = 149 - row;
                                col = 99;
                                dC = 2;
                            }
                            else
                            {
                                Console.WriteLine("Something's wrong 2");
                            }

                            ahead = mapData[row][col];

                            if (ahead == '#')
                            {
                                step = distance;
                            }
                            else
                            {
                                lastPosition[0] = row;
                                lastPosition[1] = col;

                                direction = (direction + dC) % 4;
                            }
                            break;

                        default:
                            lastPosition[0] = row;
                            lastPosition[1] = col;
                            break;
                    }

                }

                //Console.Clear();
                //for (int i = 0; i < mapData.Length; i++)
                //{
                //    for (int j = 0; j < mapData[i].Length; j++)
                //    {
                //        if (i == lastPosition[0] && j == lastPosition[1])
                //        {
                //            Console.BackgroundColor = ConsoleColor.Red;
                //            if (direction == 0)
                //            {
                //                Console.Write(">");
                //            }
                //            else if (direction == 1)
                //            {
                //                Console.Write("V");
                //            }
                //            else if (direction == 2)
                //            {
                //                Console.Write("<");
                //            }
                //            else if (direction == 3)
                //            {
                //                Console.Write("A");
                //            }
                //            Console.ResetColor();

                //        }
                //        else
                //        {
                //            Console.Write(mapData[i][j]);
                //        }
                //    }
                //    Console.WriteLine();

                //}
                //Console.ReadLine();



                if (instructionIndex < instructions.Length)
                {
                    if (turn == 'R')
                    {
                        direction = (direction + 1) % 4;
                    }
                    else
                    {
                        direction = (direction - 1) % 4;
                        if (direction == -1)
                        {
                            direction = 3;
                        }
                    }
                }




            }

            Console.WriteLine(((lastPosition[0] + 1) * 1000) + (4 * (lastPosition[1] + 1)) + direction);


            // 40581 is to low
            // 144361 is the right answer (only typos messed it up -.- )
        }
    }
}
