using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    internal class Day20
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
            List<int> startList = Input.Day20.Full();

            List<int> indexList = new List<int>();

            for (int i = 0; i < startList.Count; i++)
            {
                indexList.Add(i);
            }

            int maxIndex = startList.Count -1;

            for (int i = 0; i < maxIndex + 1; i++)
            {

                int currentIndex = indexList.IndexOf(i);

                int value = startList[i];

                int newIndex = (((currentIndex + value) % maxIndex) + maxIndex) % maxIndex;

                indexList.RemoveAt(currentIndex);
                indexList.Insert(newIndex, i);

            }

            int index0 = indexList.IndexOf(startList.IndexOf(0));

            int nr1 = startList[indexList[(index0 + 1000) % (maxIndex+1)]];
            int nr2 = startList[ indexList[(index0 + 2000) % (maxIndex+1)]];
            int nr3 = startList[ indexList[(index0 + 3000) % (maxIndex+1)]];


            Console.WriteLine(nr1 + nr2 + nr3);

            // 3533 is to high
            //-4050 is not right
            
            // 2275 is the right answer
        }
        public static void Part2()
        {

            Console.WriteLine((13 * 25) % 6);
            Console.WriteLine((13 * (25 % 6)) % 6);

            List<int> originalList = Input.Day20.Full();
            List<int> startList = Input.Day20.Full();

            int maxIndex = startList.Count - 1;
            int rawShift = 811589153;


            //base shift 237 
            //int shift = 237;

            // gives the same result as base shift at Micro and Macro
            //int shift = 237 * startList.Count;

            //gives the same result as base shift at Micro and Macro
            //int shift = 237 % maxIndex;

            //int shift = 237562;
            int shift = rawShift % maxIndex;


            for (int i = 0; i < startList.Count; i++)
            {
                //long calculate = ((startList[i] * shift) % (startList.Count - 1));
                //startList[i] = (int)calculate;

                //startList[i] = (startList[i] * ((shift / (startList.Count -1)) - (shift % (startList.Count - 1) ))) + (shift % (startList.Count -1));

                //modulo of basic works for Micro and Macro
                startList[i] = (startList[i] * shift) % (startList.Count - 1);

                //BASIC
                //startList[i] *= shift;
            }

            List<int> indexList = new List<int>();

            for (int i = 0; i < startList.Count; i++)
            {
                indexList.Add(i);
            }

            for(int time = 0; time < 10; time++)
            {
                for (int i = 0; i < maxIndex + 1; i++)
                {

                    int currentIndex = indexList.IndexOf(i);

                    int value = startList[i];

                    int newIndex = (((currentIndex + value) % maxIndex) + maxIndex) % maxIndex;

                    indexList.RemoveAt(currentIndex);
                    indexList.Insert(newIndex, i);

                }


                //foreach (var nr in indexList)
                //{
                //    //Console.Write($"{startList[nr]}, ");
                //    Console.Write((long)originalList[nr] * rawShift + ", ");
                //}
                //Console.WriteLine();
            }

            int index0 = indexList.IndexOf(originalList.IndexOf(0));

            long nr1 = (long)originalList[indexList[(index0 + 1000) % (maxIndex + 1)]]*rawShift;
            long nr2 = (long)originalList[indexList[(index0 + 2000) % (maxIndex + 1)]]*rawShift;
            long nr3 = (long)originalList[indexList[(index0 + 3000) % (maxIndex + 1)]]*rawShift;


            Console.WriteLine(nr1 + nr2 + nr3);

            //4090409331120 is the right answer
        }
    }
}
