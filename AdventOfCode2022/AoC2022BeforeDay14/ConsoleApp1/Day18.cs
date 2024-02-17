using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day18
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
            int touchingSides = 0;

            List<int[]> data = Input.Day18.Full();

            for (int i = 0; i < data.Count; i++)
            {
                int[] baseBlock = data[i];

                if (true)
                {

                }

                for (int j = i + 1; j < data.Count; j++)
                {
                    int[] otherBlock = data[j];

                    int matchingValues = 0;

                    for(int k = 0; k < 3; k++)
                    {
                        if (baseBlock[k] - otherBlock[k] > 1 || baseBlock[k] - otherBlock[k] < -1)
                        {
                            matchingValues = 0;
                            break;
                        }
                        else if (baseBlock[k] == otherBlock[k])
                        {
                            matchingValues++;
                        }
                    }

                    if (matchingValues == 2)
                    {
                        touchingSides += 2;
                        //one side of each block
                    }
                }
            }

            Console.WriteLine((data.Count * 6) - touchingSides);

        }
        public static void Part2()
        {
            List<int[]> data = Input.Day18.Full();

            int maxX = 0;
            int maxY = 0;
            int maxZ = 0;

            foreach (var block in data)
            {
                if (block[0] > maxX)
                {
                    maxX = block[0];
                }
                if (block[1] > maxY)
                {
                    maxY = block[1];
                }
                if (block[2] > maxZ)
                {
                    maxZ = block[2];
                }
            }

            int surfaceArea = 0;

            List<int[]> steamCloud = new List<int[]> { new int[] { 0, 0, 0, } };


            for (int i = 0; i < steamCloud.Count; i++)
            {
                int[] steamParticle = steamCloud[i];

                List<int[]> touchingBlocks = new List<int[]>();

                for (int j = 0; j < data.Count; j++)
                {
                    int[] block = data[j];

                    int matchingValues = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        if (block[k] - steamParticle[k] > 1 || block[k] - steamParticle[k] < -1)
                        {
                            matchingValues = 0;
                            break;
                        }
                        else if (block[k] == steamParticle[k])
                        {
                            matchingValues++;
                        }
                    }

                    if (matchingValues == 2)
                    {
                        surfaceArea++;

                        touchingBlocks.Add(block);

                    }
                }

                for (int xyz = 0; xyz < 3; xyz++)
                {
                    for(int direction = -1; direction < 2; direction += 2)
                    {
                        int[] newSteamParticle = new int[] { steamParticle[0], steamParticle[1], steamParticle[2] };

                        newSteamParticle[xyz] -= direction;

                        bool add = true;

                        foreach (var block in touchingBlocks)
                        {
                            if (block[0] == newSteamParticle[0] && block[1] == newSteamParticle[1] && block[2] == newSteamParticle[2])
                            {
                                //there is a block there
                                add = false;
                                break;
                            }
                        }
                        if (add)
                        {
                            foreach(var oldParticle in steamCloud)
                            {
                                if (oldParticle[0] == newSteamParticle[0] && oldParticle[1] == newSteamParticle[1] && oldParticle[2] == newSteamParticle[2])
                                {
                                    // already in the cloud
                                    add = false;
                                    break;
                                }
                            }
                        }
                        if (add && (newSteamParticle[0] < -1 || newSteamParticle[0] > maxX+2 || newSteamParticle[1] < -1 || newSteamParticle[1] > maxY +2 || newSteamParticle[2] < -1 || newSteamParticle[2] > maxZ + 2))
                        {
                            // out of bounds
                            add = false;
                        }
                        if (add)
                        {
                            steamCloud.Add(newSteamParticle);
                        }
                    }
                }
            }

            Console.WriteLine(surfaceArea);



            //2453 is to low
            //2458 is the right answer
        }
    }
}
