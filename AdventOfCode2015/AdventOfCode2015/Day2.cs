using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    internal class Day2
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
            long totalSizeNeded = 0;
            
            foreach(string packet in Inputs.Day2.Full())
            {
                string[] packetSplit = packet.Split('x');
                int l = Convert.ToInt32(packetSplit[0]);
                int w = Convert.ToInt32(packetSplit[1]);
                int h = Convert.ToInt32(packetSplit[2]);

                int sorter;

                if(l > w)
                {
                    sorter = w;
                    w = l;
                    l = sorter;
                }
                if(w > h)
                {
                    sorter = h;
                    h = w;
                    w = sorter;
                }

                int packedSize = (3 * (l * w)) + (2 * (l * h)) + (2 * (w * h));
                totalSizeNeded += packedSize;


            }
            Console.WriteLine(totalSizeNeded);
        }
        public static void Part2()
        {
            long totalSizeNeded = 0;

            foreach (string packet in Inputs.Day2.Full())
            {
                string[] packetSplit = packet.Split('x');
                int l = Convert.ToInt32(packetSplit[0]);
                int w = Convert.ToInt32(packetSplit[1]);
                int h = Convert.ToInt32(packetSplit[2]);

                int sorter;

                if (l > w)
                {
                    sorter = w;
                    w = l;
                    l = sorter;
                }
                if (w > h)
                {
                    sorter = h;
                    h = w;
                    w = sorter;
                }

                int ribbonSize = (2*l + 2*w) + l*w*h;
                totalSizeNeded += ribbonSize;


            }
            Console.WriteLine(totalSizeNeded);
        }
    }
}
