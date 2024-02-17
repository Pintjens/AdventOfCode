using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    internal class Day5
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
            int goodStrings = 0;
            string vowels = "aeiou";

            foreach (string thisString in Inputs.Day5.Full())
            {
                if(thisString.Contains("ab") || thisString.Contains("cd") || thisString.Contains("pq") || thisString.Contains("xy"))
                {
                    // Naughty string
                    // Check next
                }
                else
                {
                    char lastC = '-';
                    int vowelCount = 0;
                    bool inARow = false;
                    for (int c = 0; c < thisString.Length; c++)
                    {
                        if (!inARow)
                        {
                            if(thisString[c] == lastC)
                            {
                                inARow = true;
                            }
                            lastC = thisString[c];
                        }
                        if(vowelCount < 3 && vowels.Contains(thisString[c])){
                            vowelCount++;
                        }

                        if (vowelCount >= 3 && inARow)
                        {
                            goodStrings++;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(goodStrings);

        }
        public static void Part2()
        {
            int goodStrings = 0;

            foreach (string thisStringBase in Inputs.Day5.Full())
            {
                string thisString = "+-" + thisStringBase;
                char lastC = '%';
                bool repeatLetter = false;
                bool repeatDuo = false;
                for (int c = 1; c < thisString.Length; c++)
                {
                    if (!repeatLetter)
                    {
                        if (thisString[c] == lastC)
                        {
                            repeatLetter = true;
                        }
                        lastC = thisString[c-1];
                    }
                    if (!repeatDuo && thisString.Substring(c + 1).Contains(thisString.Substring(c-1,2)))
                    {
                        repeatDuo = true;
                    }

                    if (repeatLetter && repeatDuo)
                    {
                        goodStrings++;
                        break;
                    }
                }

            }

            Console.WriteLine(goodStrings);
        }
    }
}
