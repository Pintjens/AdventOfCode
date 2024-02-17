using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day19 // Mining Robots
    {

        // ideal track
        //1: 1
        //2: 3
        //3: 6
        //4: 10
        //5: 15
        //6: 21
        //7: 28
        //8: 36
        //9: 45
        //10: 55
        //11: 66
        //12: 78
        //13: 91
        //14: 105
        //15: 120
        //16: 136
        //17: 153
        //18: 171
        //19: 190
        //20: 210
        //21: 231
        //22: 253
        //23: 276
        //24: 300

        // BP1 needs 48-2 ore and 168-7 obs for that



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

            int geodes = 0;
            int geodeBots = 1;
            int time = 0;
            int ore = 46;
            int obsidean = 161;

            void PrintStatus()
            {
                Console.WriteLine();
                Console.WriteLine($"Time: {time}");
                Console.WriteLine($"OreBot: \t Ore: {ore}");
                Console.WriteLine($"ClyBot: ");
                Console.WriteLine($"ObsBot: \t Obs: {obsidean}");
                Console.WriteLine($"GeoBot: {geodeBots}\t Geo: {geodes}");
            }

            PrintStatus();
            for (time = 0; time < 24;)
            {

                // you know exactly how mutch a robot wil produce for the rest of the time from the moent it leaves the factory, so you dont actually need to track how many you have


                geodes += geodeBots;
                if (ore >= 2 && obsidean >= 7)
                {
                    ore -= 2;
                    obsidean -= 7;
                    geodeBots++;
                }

                else
                {

                }







                time++;
                PrintStatus();
            }
        }
        public static void Part2()
        {

        }
    }
}
