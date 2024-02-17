using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day12
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
            string[] hightMap = { "abcccccccccccccccccaaaaaaaaccccccacccaaccccccccccccccccccaaaaaaaaaacccccccccccccccccccccccccccccccaaaaaaccccccccccccccccccccccccccccccccccaaaaa", "abccccccccccccccccccaaaaacccccccaaaaaaacccccccccccaaccaaaaaaaaaaaaaccccccccccccccccccccccccccccccccaaaaacccccccccccccccccccccccccccccccccaaaaaa", "abccccccccccccaaccccaaaaaacccccccaaaaaaaaccccccacaaaccaaaaaaaaaaaaaaaccccccccccccccccccaaacccccccaaaaaaaccccccccccccccccaaaccccccccccccccaaaaaa", "abccccccccacccaaccccaaaaaacccccccaaaaaaaaaccccaaaaaaaaacaaaaaaaaaaaaacccccccccccccccccccaacccccccaaaaaaaacccccccccccccccaaaccccccccccccccaccaaa", "abaacccccaaaaaaaccccaaaccacccccccaaaaaaaaaccccaaaaaaaaccccaaaaaaaaaaaccccccccccccccccaacaaaaaccccaaaaaaaacccccccccccccccaaacccccccccccccccccaaa", "abaaccccccaaaaaaaacccccccccccccccaaaaaaaaccccccaaaaaacccccaaaacaaaaccccccccccccccccccaaaaaaaaccccccaaacaccccccccccccccccaaakccaaaccccccccccccaa", "abaaacccccaaaaaaaaaccccccccccccccaaaaaaacccccccaaaaaccccccaaaccaaaaccccccccccccaacacccaaaaaccccccccaaacccccccccccccacacckkkkkkkaacccccccccccccc", "abaaacccccaaaaaaaaaccccccccccccccaccaaaaaccccccaaaaaacccccaaacaaaccccccccccccccaaaaccccaaaaacccccccccccccccccccccccaaaakkkkkkkkkacccaaaccaccccc", "abacacccccaaaaaaaccccccccccccccccccccaaaaaaaccccccaaccccccaaaaaaaaccccccccccccaaaaacccaaacaacccccccccccccccccccccccaajkkkkppkkkkccccaaaaaaccccc", "abacccccccaaaaaaacccccccccccccccccccaaaaaaaaccccccccccccccccaaaaaaccccccccccccaaaaaacccaacccccccccccccccccccccccccccjjkkooppppkllccccaaaaaccccc", "abccccccccaccaaaccccccccccccccccccccaaaaaaaacccccccccccccccccaaaaaccccccccccccacaaaacccccccccccccccccccccccccccccjjjjjjoooppppklllcacaaaaaccccc", "abcccaacccccccaaacccccccccccccccccccaaaaaaacccccccccccccccccaaaaacccccccccccccccaacaccccccccccccccccccccccccccjjjjjjjjoooopuppplllcccccaaaacccc", "abcccaacccccccccccccccccaaacccccccccccaaaaaaccccccaaaaacccccaaaaaccccccccccccaaacaaacccccaaaccccccccccccccccijjjjjjjjooouuuuuppllllcccccaaacccc", "abaaaaaaaaccccccccccccccaaaaccccccccccaacaaaccccccaaaaaccccccccccccccccccccccaaaaaaacccccaaacacccccccccccccciijjoooooooouuuuuppplllllccccaccccc", "abaaaaaaaaccccccccccccccaaaaccccccccccaacccccccccaaaaaacccccccccccccccccccccccaaaaaacccaaaaaaaacccccccccccciiiqqooooooouuuxuuuppplllllccccccccc", "abccaaaaccccccccccccccccaaaccccccccccccccccccccccaaaaaacccccccccccccccccccccccaaaaaaaccaaaaaaaacccccccccccciiiqqqqtttuuuuxxxuupppqqllllmccccccc", "abcaaaaacccaaaccccccccccccccccccccccccaccccccccccaaaaaacccccccccccccccccccccaaaaaaaaaaccaaaaaaccccccccccccciiiqqqtttttuuuxxxuuvpqqqqmmmmccccccc", "abcaacaaaccaaacaaccccccccccccccccccccaaaacaaaccccccaacccaaaaacccccccccccccccaaaaaaaaaacccaaaaacccaaaccccccciiiqqttttxxxxxxxyuvvvvqqqqmmmmcccccc", "abcacccaaccaaaaaaccccccccccccccccccccaaaaaaaacccccccccccaaaaacccccccccccccccaaacaaacccccaaaaaaccaaaacccccaaiiiqqtttxxxxxxxxyyvvvvvvqqqmmmdddccc", "abcccccccaaaaaaaccccccccccccccccccccccaaaaaaaaacccccccccaaaaaaccccccccccccccccccaaaccccccaacccccaaaacccaaaaiiiqqqttxxxxxxxyyyyyyvvvqqqmmmdddccc", "SbccccccccaaaaaccccccccaacaaccccccccaaaaaaaaaaccccccccccaaaaaaccccccccccccaaacccaaccccccccccccccaaaacccaaaaaiiiqqtttxxxxEzzyyyyvvvvqqqmmmdddccc", "abaccccccccaaaaacccccccaaaaacccccccaaaaaaaaaaaccccccccccaaaaaaccccccccccaaaaaacccccccccccccccccccccccccaaaaaiiiqqqtttxxxyyyyyyvvvvqqqmmmdddcccc", "abaacccccccaacaaaccccccaaaaaacccccccaaaaaaaaaaccccccccccccaaacccccccccccaaaaaaccccccccccccccccccccccccccaaaahhhqqqqttxxyyyyyyvvvvqqqmmmddddcccc", "abaccccccccaaccccccccccaaaaaacccaacaaccaaaaaaaaaccccccccccccccccccccccccaaaaaaccccccccccccccccccccccccccaaaachhhqqtttxwyyyyyywvrqqqmmmmdddccccc", "abaaaccccccccccccccccccaaaaaacccaaaaaccaaaaacaaaccccccccccccccccccccccccaaaaaccccaaaaccccaaaccccccccccccccccchhhppttwwwywwyyywwrrrnmmmdddcccccc", "abaaaccccccccccccccccccccaaaccccaaaaaacaaaaaaaaaccccccccaaacccccccccccccaaaaaccccaaaaccccaaaccccccccccccccccchhpppsswwwwwwwwywwrrrnnndddccccccc", "abaaacccccccccccccccccccccccccccaaaaaacccaaaaaacccccccccaaaaacccccaacccccccccccccaaaacaaaaaaaaccccccccccccccchhpppsswwwwsswwwwwrrrnneeddccccccc", "abaccccccccaaaacccccccccccccccccaaaaaaccccaaaaaaaacccccaaaaaaccaacaaacccccccccccccaaccaaaaaaaaccccccccccccccchhpppssssssssrwwwwrrrnneeecaaccccc", "abaccccccccaaaacccccccccccccccccccaaaccccaaaaaaaaacccccaaaaaaccaaaaaccccccccccccccccccccaaaaacccccccccccccccchhpppssssssssrrrwrrrnnneeeaaaccccc", "abcccccccccaaaacccccccccccccccccccccccccaaaaaaaaaaccccccaaaaacccaaaaaacccccccccccccccccaaaaaacccccccccccccccchhpppppsssooorrrrrrrnnneeeaaaccccc", "abcccccccccaaaccccccccccccccccccccccccccaaacaaacccccccccaacaacaaaaaaaacccccccccccccccccaaaaaacaaccccccccccccchhhppppppoooooorrrrnnneeeaaaaacccc", "abccccccccccccccccccccccccccccccccccccccccccaaaccaaaacccccccccaaaaacaaccccaacccccccccacaaaaaacaaccccccccccccchhhgpppppoooooooonnnnneeeaaaaacccc", "abcccccccaacccccccccccccccccccccccccccccccccaaacaaaaaccccccccccacaaaccccccaacccccccccaacaaaaaaaaaaacccccaaccccgggggggggggfooooonnneeeeaaaaacccc", "abcccccccaaacaaccccccccccccaacccccccccccccccccccaaaaaaccccaacccccaaacccaaaaaaaaccccccaaaaacaaaaaaaaccccaaacccccggggggggggfffooonneeeecaaacccccc", "abcccccccaaaaaaccccaacccccaaacccccccccccccccccccaaaaaaccccaaaccccccccccaaaaaaaacccccccaaaaaccaaaaccccaaaaaaaacccggggggggfffffffffeeeecaaccccccc", "abcccccaaaaaaaccaaaaacaaaaaaacccccccccccccccccccaaaaacccccaaaacccaaccccccaaaacccccccaaaaaaaacaaaaacccaaaaaaaaccccccccccaaaffffffffecccccccccccc", "abcaaacaaaaaaacccaaaaaaaaaaaaaaaccccccccccccccccccaaacccccaaaacaaaacaacccaaaaaccccccaaaaaaaaaaaaaaccccaaaaaacccccccccccaaacaafffffccccccccccaaa", "abaaaacccaaaaaaccaaaaacaaaaaaaaaccccccccccccaaacccccccccccaaaaaaaaacaaccaaacaacccccccccaacccaaccaaccccaaaaaaccccccccccaaaaccaaacccccccccccccaaa", "abaaaacccaacaaacaaaaacccaaaaaaacccccccccccccaaaacccccccccaaaaaaaaaaaaaccaacccacccccccccaacccccccccccccaaaaaaccccccccccaaacccccccccccccccccccaaa", "abcaaacccaacccccccaaaccaaaaaacccccccccccccccaaaaccccccaaaaaaaaaaaaaaaaaaccccccccccccccccccccccccccccccaaccaaccccccccccaaaccccccccccccccccaaaaaa", "abcccccccccccccccccccccaaaaaaaccccccccccccccaaacccccccaaaaaaaaaaaaaaaaaacccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccaaaaaa" };


            List<int[]> positions = new List<int[]> { new int[2] };


            // find strat position
            positions[0][0] = 20;
            positions[0][1] = 0;

            int[] destination = new int[2];
            bool endReached = false;
            int steps = 0;

            while (!endReached)
            {
                int positionsOccupide = positions.Count;


                for (int i = 0; i < positionsOccupide; i++)
                {

                    int startRow = positions[i][0];
                    int startCol = positions[i][1];

                    // left
                    if (startCol > 0)
                    {
                        destination = new int[2];
                        destination[0] = startRow;
                        destination[1] = startCol - 1;
                        if (CheckPosition(startRow, startCol, destination[0], destination[1], hightMap)[0] == true)
                        {
                            positions.Add(destination);
                            endReached = CheckPosition(startRow, startCol, destination[0], destination[1], hightMap)[1];
                        }
                    }


                    // right
                    if (startCol < hightMap[0].Length - 1)
                    {
                        destination = new int[2];
                        destination[0] = startRow;
                        destination[1] = startCol + 1;
                        if (CheckPosition(startRow, startCol, destination[0], destination[1], hightMap)[0] == true && !endReached)
                        {
                            positions.Add(destination);
                            endReached = CheckPosition(startRow, startCol, destination[0], destination[1], hightMap)[1];
                        }
                    }


                    // up
                    if (startRow > 0)
                    {
                        destination = new int[2];
                        destination[0] = startRow - 1;
                        destination[1] = startCol;
                        if (CheckPosition(startRow, startCol, destination[0], destination[1], hightMap)[0] == true && !endReached)
                        {
                            positions.Add(destination);
                            endReached = CheckPosition(startRow, startCol, destination[0], destination[1], hightMap)[1];
                        }
                    }


                    // down
                    if (startRow < hightMap.GetLength(0) - 1)
                    {
                        destination = new int[2];
                        destination[0] = startRow + 1;
                        destination[1] = startCol;
                        if (CheckPosition(startRow, startCol, destination[0], destination[1], hightMap)[0] == true && !endReached)
                        {
                            positions.Add(destination);
                            endReached = CheckPosition(startRow, startCol, destination[0], destination[1], hightMap)[1];
                        }
                    }



                    string hightMapRow = hightMap[startRow];
                    string firstPart = hightMapRow.Substring(0, startCol);
                    string secndPart = hightMapRow.Substring(startCol + 1);
                    hightMapRow = firstPart + 'X' + secndPart;

                    hightMap[startRow] = hightMapRow;



                }
                Console.Clear();
                foreach (string mapRow in hightMap)
                {
                    Console.WriteLine(mapRow);
                }
                Console.ReadLine();

                steps++;
                for (int i = positionsOccupide - 1; i >= 0; i--)
                {
                    positions.RemoveAt(i);
                }


            }
            Console.WriteLine(steps);

            // its 462




        }
        public static bool[] CheckPosition(int startRow, int startCol, int destanationRow, int destinationCol, string[] hightMap)
        {
            bool endReached = false;
            bool exesible = false;

            char startValue = hightMap[startRow][startCol];
            char destinationValue = hightMap[destanationRow][destinationCol];

            if (destinationValue != 'X')
            {
                if (startValue == 'z' && destinationValue == 'E')
                {
                    endReached = true;
                    exesible = true;
                }
                else
                {
                    if (startValue == 'S')
                    {
                        startValue = ('a');
                    }
                    if ((destinationValue - startValue) <= 1)
                    {
                        exesible = true;
                    }
                }
            }

            bool[] returnAr = { exesible, endReached };
            return returnAr;
        }
        public static void Part2()
        {
            string[] hightMap = { "abcccccccccccccccccaaaaaaaaccccccacccaaccccccccccccccccccaaaaaaaaaacccccccccccccccccccccccccccccccaaaaaaccccccccccccccccccccccccccccccccccaaaaa", "abccccccccccccccccccaaaaacccccccaaaaaaacccccccccccaaccaaaaaaaaaaaaaccccccccccccccccccccccccccccccccaaaaacccccccccccccccccccccccccccccccccaaaaaa", "abccccccccccccaaccccaaaaaacccccccaaaaaaaaccccccacaaaccaaaaaaaaaaaaaaaccccccccccccccccccaaacccccccaaaaaaaccccccccccccccccaaaccccccccccccccaaaaaa", "abccccccccacccaaccccaaaaaacccccccaaaaaaaaaccccaaaaaaaaacaaaaaaaaaaaaacccccccccccccccccccaacccccccaaaaaaaacccccccccccccccaaaccccccccccccccaccaaa", "abaacccccaaaaaaaccccaaaccacccccccaaaaaaaaaccccaaaaaaaaccccaaaaaaaaaaaccccccccccccccccaacaaaaaccccaaaaaaaacccccccccccccccaaacccccccccccccccccaaa", "abaaccccccaaaaaaaacccccccccccccccaaaaaaaaccccccaaaaaacccccaaaacaaaaccccccccccccccccccaaaaaaaaccccccaaacaccccccccccccccccaaakccaaaccccccccccccaa", "abaaacccccaaaaaaaaaccccccccccccccaaaaaaacccccccaaaaaccccccaaaccaaaaccccccccccccaacacccaaaaaccccccccaaacccccccccccccacacckkkkkkkaacccccccccccccc", "abaaacccccaaaaaaaaaccccccccccccccaccaaaaaccccccaaaaaacccccaaacaaaccccccccccccccaaaaccccaaaaacccccccccccccccccccccccaaaakkkkkkkkkacccaaaccaccccc", "abacacccccaaaaaaaccccccccccccccccccccaaaaaaaccccccaaccccccaaaaaaaaccccccccccccaaaaacccaaacaacccccccccccccccccccccccaajkkkkppkkkkccccaaaaaaccccc", "abacccccccaaaaaaacccccccccccccccccccaaaaaaaaccccccccccccccccaaaaaaccccccccccccaaaaaacccaacccccccccccccccccccccccccccjjkkooppppkllccccaaaaaccccc", "abccccccccaccaaaccccccccccccccccccccaaaaaaaacccccccccccccccccaaaaaccccccccccccacaaaacccccccccccccccccccccccccccccjjjjjjoooppppklllcacaaaaaccccc", "abcccaacccccccaaacccccccccccccccccccaaaaaaacccccccccccccccccaaaaacccccccccccccccaacaccccccccccccccccccccccccccjjjjjjjjoooopuppplllcccccaaaacccc", "abcccaacccccccccccccccccaaacccccccccccaaaaaaccccccaaaaacccccaaaaaccccccccccccaaacaaacccccaaaccccccccccccccccijjjjjjjjooouuuuuppllllcccccaaacccc", "abaaaaaaaaccccccccccccccaaaaccccccccccaacaaaccccccaaaaaccccccccccccccccccccccaaaaaaacccccaaacacccccccccccccciijjoooooooouuuuuppplllllccccaccccc", "abaaaaaaaaccccccccccccccaaaaccccccccccaacccccccccaaaaaacccccccccccccccccccccccaaaaaacccaaaaaaaacccccccccccciiiqqooooooouuuxuuuppplllllccccccccc", "abccaaaaccccccccccccccccaaaccccccccccccccccccccccaaaaaacccccccccccccccccccccccaaaaaaaccaaaaaaaacccccccccccciiiqqqqtttuuuuxxxuupppqqllllmccccccc", "abcaaaaacccaaaccccccccccccccccccccccccaccccccccccaaaaaacccccccccccccccccccccaaaaaaaaaaccaaaaaaccccccccccccciiiqqqtttttuuuxxxuuvpqqqqmmmmccccccc", "abcaacaaaccaaacaaccccccccccccccccccccaaaacaaaccccccaacccaaaaacccccccccccccccaaaaaaaaaacccaaaaacccaaaccccccciiiqqttttxxxxxxxyuvvvvqqqqmmmmcccccc", "abcacccaaccaaaaaaccccccccccccccccccccaaaaaaaacccccccccccaaaaacccccccccccccccaaacaaacccccaaaaaaccaaaacccccaaiiiqqtttxxxxxxxxyyvvvvvvqqqmmmdddccc", "abcccccccaaaaaaaccccccccccccccccccccccaaaaaaaaacccccccccaaaaaaccccccccccccccccccaaaccccccaacccccaaaacccaaaaiiiqqqttxxxxxxxyyyyyyvvvqqqmmmdddccc", "SbccccccccaaaaaccccccccaacaaccccccccaaaaaaaaaaccccccccccaaaaaaccccccccccccaaacccaaccccccccccccccaaaacccaaaaaiiiqqtttxxxxEzzyyyyvvvvqqqmmmdddccc", "abaccccccccaaaaacccccccaaaaacccccccaaaaaaaaaaaccccccccccaaaaaaccccccccccaaaaaacccccccccccccccccccccccccaaaaaiiiqqqtttxxxyyyyyyvvvvqqqmmmdddcccc", "abaacccccccaacaaaccccccaaaaaacccccccaaaaaaaaaaccccccccccccaaacccccccccccaaaaaaccccccccccccccccccccccccccaaaahhhqqqqttxxyyyyyyvvvvqqqmmmddddcccc", "abaccccccccaaccccccccccaaaaaacccaacaaccaaaaaaaaaccccccccccccccccccccccccaaaaaaccccccccccccccccccccccccccaaaachhhqqtttxwyyyyyywvrqqqmmmmdddccccc", "abaaaccccccccccccccccccaaaaaacccaaaaaccaaaaacaaaccccccccccccccccccccccccaaaaaccccaaaaccccaaaccccccccccccccccchhhppttwwwywwyyywwrrrnmmmdddcccccc", "abaaaccccccccccccccccccccaaaccccaaaaaacaaaaaaaaaccccccccaaacccccccccccccaaaaaccccaaaaccccaaaccccccccccccccccchhpppsswwwwwwwwywwrrrnnndddccccccc", "abaaacccccccccccccccccccccccccccaaaaaacccaaaaaacccccccccaaaaacccccaacccccccccccccaaaacaaaaaaaaccccccccccccccchhpppsswwwwsswwwwwrrrnneeddccccccc", "abaccccccccaaaacccccccccccccccccaaaaaaccccaaaaaaaacccccaaaaaaccaacaaacccccccccccccaaccaaaaaaaaccccccccccccccchhpppssssssssrwwwwrrrnneeecaaccccc", "abaccccccccaaaacccccccccccccccccccaaaccccaaaaaaaaacccccaaaaaaccaaaaaccccccccccccccccccccaaaaacccccccccccccccchhpppssssssssrrrwrrrnnneeeaaaccccc", "abcccccccccaaaacccccccccccccccccccccccccaaaaaaaaaaccccccaaaaacccaaaaaacccccccccccccccccaaaaaacccccccccccccccchhpppppsssooorrrrrrrnnneeeaaaccccc", "abcccccccccaaaccccccccccccccccccccccccccaaacaaacccccccccaacaacaaaaaaaacccccccccccccccccaaaaaacaaccccccccccccchhhppppppoooooorrrrnnneeeaaaaacccc", "abccccccccccccccccccccccccccccccccccccccccccaaaccaaaacccccccccaaaaacaaccccaacccccccccacaaaaaacaaccccccccccccchhhgpppppoooooooonnnnneeeaaaaacccc", "abcccccccaacccccccccccccccccccccccccccccccccaaacaaaaaccccccccccacaaaccccccaacccccccccaacaaaaaaaaaaacccccaaccccgggggggggggfooooonnneeeeaaaaacccc", "abcccccccaaacaaccccccccccccaacccccccccccccccccccaaaaaaccccaacccccaaacccaaaaaaaaccccccaaaaacaaaaaaaaccccaaacccccggggggggggfffooonneeeecaaacccccc", "abcccccccaaaaaaccccaacccccaaacccccccccccccccccccaaaaaaccccaaaccccccccccaaaaaaaacccccccaaaaaccaaaaccccaaaaaaaacccggggggggfffffffffeeeecaaccccccc", "abcccccaaaaaaaccaaaaacaaaaaaacccccccccccccccccccaaaaacccccaaaacccaaccccccaaaacccccccaaaaaaaacaaaaacccaaaaaaaaccccccccccaaaffffffffecccccccccccc", "abcaaacaaaaaaacccaaaaaaaaaaaaaaaccccccccccccccccccaaacccccaaaacaaaacaacccaaaaaccccccaaaaaaaaaaaaaaccccaaaaaacccccccccccaaacaafffffccccccccccaaa", "abaaaacccaaaaaaccaaaaacaaaaaaaaaccccccccccccaaacccccccccccaaaaaaaaacaaccaaacaacccccccccaacccaaccaaccccaaaaaaccccccccccaaaaccaaacccccccccccccaaa", "abaaaacccaacaaacaaaaacccaaaaaaacccccccccccccaaaacccccccccaaaaaaaaaaaaaccaacccacccccccccaacccccccccccccaaaaaaccccccccccaaacccccccccccccccccccaaa", "abcaaacccaacccccccaaaccaaaaaacccccccccccccccaaaaccccccaaaaaaaaaaaaaaaaaaccccccccccccccccccccccccccccccaaccaaccccccccccaaaccccccccccccccccaaaaaa", "abcccccccccccccccccccccaaaaaaaccccccccccccccaaacccccccaaaaaaaaaaaaaaaaaacccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccaaaaaa" };


            List<int[]> positions = new List<int[]> { new int[2] };


            // find start position
            positions[0][0] = 20;
            positions[0][1] = 120;

            int[] destination = new int[2];
            bool endReached = false;
            int steps = 0;


            while (!endReached)
            {
                int positionsOccupide = positions.Count;


                for (int i = 0; i < positionsOccupide; i++)
                {

                    int startRow = positions[i][0];
                    int startCol = positions[i][1];

                    // left
                    if (startCol > 0)
                    {
                        destination = new int[2];
                        destination[0] = startRow;
                        destination[1] = startCol - 1;
                        if (CheckPositionReverse(startRow, startCol, destination[0], destination[1], hightMap)[0] && !endReached)
                        {
                            positions.Add(destination);
                            endReached = CheckPositionReverse(startRow, startCol, destination[0], destination[1], hightMap)[1];
                        }
                    }


                    // right
                    if (startCol < hightMap[0].Length - 1)
                    {
                        destination = new int[2];
                        destination[0] = startRow;
                        destination[1] = startCol + 1;
                        if (CheckPositionReverse(startRow, startCol, destination[0], destination[1], hightMap)[0] && !endReached)
                        {
                            positions.Add(destination);
                            endReached = CheckPositionReverse(startRow, startCol, destination[0], destination[1], hightMap)[1];
                        }
                    }


                    // up
                    if (startRow > 0)
                    {
                        destination = new int[2];
                        destination[0] = startRow - 1;
                        destination[1] = startCol;
                        if (CheckPositionReverse(startRow, startCol, destination[0], destination[1], hightMap)[0] == true && !endReached)
                        {
                            positions.Add(destination);
                            endReached = CheckPositionReverse(startRow, startCol, destination[0], destination[1], hightMap)[1];
                        }
                    }


                    // down
                    if (startRow < hightMap.GetLength(0) - 1)
                    {
                        destination = new int[2];
                        destination[0] = startRow + 1;
                        destination[1] = startCol;
                        if (CheckPositionReverse(startRow, startCol, destination[0], destination[1], hightMap)[0] == true && !endReached)
                        {
                            positions.Add(destination);
                            endReached = CheckPositionReverse(startRow, startCol, destination[0], destination[1], hightMap)[1];
                        }
                    }



                    string hightMapRow = hightMap[startRow];
                    string firstPart = hightMapRow.Substring(0, startCol);
                    string secndPart = hightMapRow.Substring(startCol + 1);
                    hightMapRow = firstPart + 'X' + secndPart;













                    hightMap[startRow] = hightMapRow;



                }
                Console.ReadLine();
                Console.Clear();
                foreach (string mapRow in hightMap)
                {
                    Console.WriteLine(mapRow);
                }



                steps++;
                for (int i = positionsOccupide - 1; i >= 0; i--)
                {
                    positions.RemoveAt(i);
                }


            }
            Console.WriteLine(steps);

            // its 451



        }
        public static bool[] CheckPositionReverse(int startRow, int startCol, int destanationRow, int destinationCol, string[] hightMap)
        {
            bool endReached = false;
            bool exesible = false;

            char startValue = hightMap[startRow][startCol];
            char destinationValue = hightMap[destanationRow][destinationCol];
            if (startValue == 'E')
            {
                startValue = 'z';
            }
            if (destinationValue != 'X')
            {
                if ((startValue - destinationValue) == 0 || startValue - destinationValue == 1 || startValue - destinationValue == -1 || startValue - destinationValue == -2

                    )
                {
                    exesible = true;
                    if (destinationValue == 'a')
                    {
                        endReached = true;
                    }
                }
            }


            bool[] returnAr = { exesible, endReached };
            return returnAr;
        }
    }
}
