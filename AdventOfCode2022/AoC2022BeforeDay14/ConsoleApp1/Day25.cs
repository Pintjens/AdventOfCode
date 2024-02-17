using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day25
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


            List<List<int>> data = new List<List<int>>();

            int longestLine = 0;
            foreach (var line in Input.Day25.Full())
            {
                if (line.Length > longestLine)
                {
                    longestLine = line.Length;
                }
                List<int> lineList = new List<int>();
                for (int i = line.Length - 1; i > -1; i--)
                {
                    int addInt = 0;
                    switch (line[i])
                    {
                        case '-':
                            addInt = -1;
                            break;
                        case '=':
                            addInt = -2;
                            break;
                        default:
                            addInt = line[i] - 48;
                            break;
                    }
                    lineList.Add(addInt);
                }
                data.Add(lineList);
            }

            int[] combinedData = new int[longestLine];

            foreach (var line in data)
            {
                for (int i = 0; i < line.Count; i++)
                {
                    combinedData[i] += line[i];
                }
            }

            double total = 0;
            for (int i = 0; i < combinedData.Length; i++)
            {
                total += combinedData[i] * (Math.Pow(5, i));
            }

            Console.WriteLine(total);


            //Convert to SNAFU
            string snafu = "";


            int snafuLength;
            bool lengthFound = false;
            for (snafuLength = 0; !lengthFound; snafuLength++)
            {
                if ((Math.Pow(5, snafuLength) / 2 - 1) >= total)
                {
                    break;
                }
            }

            char[] snafuChars = new char[snafuLength];
            for(int i = 0; i < snafuChars.Length; i++)
            {
                snafuChars[i] = '0';
            }

            double rest = total;
            bool found = false;
            do
            {
                found = false;
                for (int index = 0; !found; index++)
                {
                    double top = (Math.Pow(5, index + 1) - 1) / 2;
                    if (rest > 0)
                    {
                        if (top >= rest)
                        {
                            if(top - (Math.Pow(5,index)) >= rest){
                                snafuChars[index] = '1';
                                rest -= Math.Pow(5, index);
                                break;
                            }
                            snafuChars[index] = '2';
                            rest -= Math.Pow(5, index) * 2;
                            break;
                        }
                    }
                    else
                    {
                        if (top >= rest * -1)
                        {
                            if (top - (Math.Pow(5, index)) >= rest * -1)
                            {
                                snafuChars[index] = '-';
                                rest += Math.Pow(5, index);
                                break;
                            }
                            snafuChars[index] = '=';
                            rest += Math.Pow(5, index) * 2;
                            break;
                        }
                    }
                }

            } while (rest != 0);

            for(int i = snafuChars.Length; i > 0; i--)
            {
                snafu += snafuChars[i - 1];
            }

            Console.WriteLine(snafu);



            // 2=20---01==222=0=0-2 is the right answer
        }
        public static void Part2()
        {

        }
    }
}
