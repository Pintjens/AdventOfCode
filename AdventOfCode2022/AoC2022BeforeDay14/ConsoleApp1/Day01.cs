using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day01
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
        { //See VSC TypeScript
            int[] puzzelInputNrAr = { };

            int richestElf = 0;
            int biggestCache = 0;

            int sndRishestElf = 0;
            int sndBiggestCache = 0;

            int trdRishestElf = 0;
            int trdBiggestCache = 0;

            for (int i = 0; i < puzzelInputNrAr.Length; i++)
            {

                int sum = 0;

                //for (int j = 0; j < puzzelInputNrAr[i].Length; j++) 
                {
                    //sum += puzzelInputNrAr[i][j];
                }

                if (sum > biggestCache)
                {
                    biggestCache = sum;
                    richestElf = i + 1;
                }
                else if (sum > sndBiggestCache)
                {
                    sndBiggestCache = sum;
                    sndRishestElf = i + 1;
                }
                else if (sum > trdBiggestCache)
                {
                    trdBiggestCache = sum;
                    trdRishestElf = i + 1;
                }
            }

            int combinedTotal = biggestCache + sndBiggestCache + trdBiggestCache;

            Console.WriteLine($"The elf that holds the most calories is elf number ${richestElf}, this elf holds ${biggestCache} calories in total");
            Console.WriteLine($"The elf that holds the second most calories is elf number ${sndRishestElf}, this elf holds ${sndBiggestCache} calories in total");
            Console.WriteLine($"The elf that holds the therth most calories is elf number ${trdRishestElf}, this elf holds {trdBiggestCache} calories in total");
            Console.WriteLine($"Together they holde a combined total of {combinedTotal} calories");
        }
        public static void Part2()
        {

        }
    }
}
