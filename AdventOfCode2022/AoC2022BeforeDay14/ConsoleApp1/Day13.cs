using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day13 // Order List Int Arrays
    {
        public static void Main()
        {
            Console.Write("Part ? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Part1Try3();
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
        public static void Part1Try1()
        {
            List<string[]> data = Input.Day13.MicroBare();

            int total = 0;

            for (int i = 0; i < data.Count; i++)
            {
                string left = data[i][0];
                string right = data[i][1];

                bool checking = true;

                int index = 0;
                while (checking)
                {

                    char lc;
                    char rc;

                    try
                    {
                        lc = left[index];
                    }
                    catch
                    {
                        lc = '*';
                    }
                    try
                    {
                        rc = right[index];
                    }
                    catch
                    {
                        rc = '*';
                    }

                    if (lc == '*' || rc == '*')
                    {
                        checking = false;
                        if (rc == '*')
                        {
                            // wrong order
                        }
                        else
                        {
                            Console.WriteLine(i + 1);
                            total += i + 1;
                        }

                    }
                    else if (lc == rc)
                    {
                        // nothing happens
                    }
                    else if (lc == ']')
                    {
                        checking = false;
                        total += i + 1;
                        Console.WriteLine(i + 1);
                    }
                    else if (rc == ']')
                    {
                        checking = false;
                    }
                    else if (lc != '[' && rc != '[' && lc != ',' && rc != ',' && lc != ']' && rc != ']')
                    {
                        int l = Convert.ToInt32(lc);
                        int r = Convert.ToInt32(rc);

                        if (l > r)
                        {
                            checking = false;
                        }
                        else
                        {
                            checking = false;
                            total += i + 1;
                            Console.WriteLine(i + 1);
                        }
                    }
                    else
                    {
                        // nothing gets here
                        Console.WriteLine(lc + " " + rc);
                    }

                    index++;


                }







            }

            Console.WriteLine("Total: " + total);




            // 5925 is to high
            // 5743 is to low
        }
        public static void Part1Try2()
        {

            List<string[]> data = Input.Day13.DemoBare2();
            // 10 == :


            int total = 0;

            for (int i = 0; i < data.Count; i++)
            {

                string left = data[i][0];
                string right = data[i][1];

                int indexL = 0;
                int indexR = 0;

                int openL = 0;
                int openR = 0;

                char l = '*';
                char r = '*';

                bool running = true;
                bool foundLeft = false;
                bool foundRight = false;


                while (running)
                {

                    while (!foundLeft) // left
                    {
                        try
                        {
                            if (left[indexL] == '[')
                            {
                                openL++;
                            }
                            else if (left[indexL] == ']')
                            {
                                openL--;
                            }
                            else
                            {
                                l = left[indexL];
                                foundLeft = true;
                            }
                        }
                        catch
                        {
                            running = false;
                            foundLeft = true;
                            total += i + 1;
                            Console.WriteLine(i + 1);
                        }
                        indexL++;

                    }

                    while (!foundRight) // right
                    {
                        try
                        {
                            if (right[indexR] == '[')
                            {
                                openR++;
                            }
                            else if (right[indexR] == ']')
                            {
                                openR--;
                                if (openR < openL)
                                {
                                    running = false;
                                }
                            }
                            else
                            {
                                r = right[indexR];
                                foundRight = true;

                            }
                        }
                        catch
                        {
                            running = false;
                            foundRight = true;
                        }
                        indexR++;

                    }
                    if (foundLeft && foundRight)
                    {
                        int leftVal = Convert.ToInt32(l);
                        int rightVal = Convert.ToInt32(r);
                        if (leftVal > rightVal)
                        {
                            running = false;
                        }
                        foundLeft = false;
                        foundRight = false;
                    }

                }


            }

            Console.WriteLine(total);





        }

        public static int GetIndexShift(string input)
        {
            int openCount = 0;
            int length = 0;
            foreach (var crtr in input)
            {
                length++;
                if (crtr == '[')
                {
                    openCount++;
                }
                else if (crtr == ']')
                {
                    openCount--;
                }
                if (openCount == 0)
                {
                    return length;
                }

            }
            Console.WriteLine("something went wrong 1");
            return 0;
        }
        public static string CutOutList(string toCut)
        {
            int openCount = 0;
            int length = 0;
            foreach (var crtr in toCut)
            {
                length++;
                if(crtr == '[')
                {
                    openCount++;
                }
                else if(crtr == ']')
                {
                    openCount--;
                }
                if (openCount == 0)
                {
                    return toCut.Substring(0, length);
                }

            }

            Console.WriteLine("something went wrong 2");
            return "";
        }

        public static void CompairLists(string list1, string list2)
        {
            int index1 = 1;
            int index2 = 1;
            int indexShift1;
            int indexShift2;
            while (index2 < list2.Length)
            {

                if (index1 >= list1.Length)
                {
                    throw new Exception("+");
                }

                if (list1[index1] == ',')
                {
                    index1++;
                    index2++;
                }
                else
                {
                    if (list1[index1] == '[' || list2[index2] == '[')
                    {
                        if (list1[index1] == list2[index2])
                        {
                            indexShift1 = GetIndexShift(list1.Substring(index1));
                            indexShift2 = GetIndexShift(list2.Substring(index2));

                            CompairLists(CutOutList(list1.Substring(index1)), CutOutList(list2.Substring(index2)));

                            index1 += indexShift1;
                            index2 += indexShift2;
                        }
                        else
                        {
                            if (list1[index1] == ']')
                            {
                                throw new Exception("+");
                            }
                            else if (list2[index2] == ']')
                            {
                                throw new Exception("-");
                            }
                            if (list1[index1] == '[')
                            {
                                indexShift1 = GetIndexShift(list1.Substring(index1));
                                CompairLists(CutOutList(list1.Substring(index1)), $"[{list2[index2]}]");
                                index1 += indexShift1;
                                index2++;
                            }
                            else
                            {
                                indexShift2 = GetIndexShift(list2.Substring(index2));
                                CompairLists($"[{list1[index1]}]", CutOutList(list2.Substring(index2)));
                                index2 += indexShift2;
                                index1++;
                            }
                        }
                    }
                    else
                    {
                        int char1 = list1[index1];
                        int char2 = list2[index2];

                        if (char1 == char2)
                        {
                            //go to next
                            index1++;
                            index2++;
                        }
                        else if (char1 == ']')
                        {
                            throw new Exception("+");
                        }
                        else if (char2 == ']')
                        {
                            throw new Exception("-");
                        }
                        else if (char1 < char2)
                        {
                            throw new Exception("+");
                        }
                        else if (char1 > char2)
                        {
                            throw new Exception("-");
                        }


                    }
                }

            }
            if(index1 < list1.Length - 1)
            {
                throw new Exception("-");
            }

        }
        public static void Part1Try3()
        {
            int notCount = 0;
            int indexTotal = 0;
            int index = 0;
            foreach(var strings in Input.Day13.Full())
            {
                index++;
                indexTotal += index;
                try
                {
                    CompairLists(strings[0], strings[1]);
                    Console.WriteLine(index + " => runtrough");
                }
                catch (Exception e)
                {
                    if (e.Message == "-")
                    {
                        notCount += index;
                    }
                    else if(e.Message == "+")
                    {
                        Console.WriteLine(index);
                        // Good
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong 3");
                    }
                }

            }

            Console.WriteLine(indexTotal - notCount);




        }
        public static void Part2()
        {
            int notCount = 0;
            int indexTotal = 0;
            int index = 0;

            List<string> toOrder = new List<string>();
            foreach(var strings in Input.Day13.Full())
            {
                toOrder.Add(strings[0]);
                toOrder.Add(strings[1]);
            }
            toOrder.Add("[[2]]");
            toOrder.Add("[[6]]");

            ImmutableList<string> gettingOrdered = toOrder.ToImmutableList<string>();
            toOrder.Clear();

            //Pre-order
            for(int i = 47; i < 58; i++)
            {
                foreach(var packet in gettingOrdered)
                {
                    string thisPacket = packet.Replace("[", "");
                    if(i == 47)
                    {
                        if (thisPacket[0] == ']')
                        {
                            toOrder.Add(packet);
                        }
                    }
                    else if (thisPacket[0] == i)
                    {
                        toOrder.Add(packet);
                    }
                
                }
            }


            bool ordering = true;
            while (ordering)
            {
                ordering = false;

                gettingOrdered = toOrder.ToImmutableList<string>();
                toOrder.Clear();

                int index1 = 0;
                int index2 = 1;


                for(int i = 0; i < gettingOrdered.Count; i++)
                {
                    try
                    {
                        CompairLists(gettingOrdered[index1], gettingOrdered[index2]);

                        //debug
                        Console.WriteLine(index + " => runtrough");
                    }
                    catch (Exception e)
                    {
                        if (e.Message == "+")
                        {
                            toOrder.Add(gettingOrdered[index1]);
                            index1 = index2;
                            index2 = i+2;
                        }
                        else if (e.Message == "-")
                        {
                            toOrder.Add(gettingOrdered[index2]);
                            index1 = index1;
                            index2 ++;
                            ordering = true;
                        }
                        else
                        {
                            toOrder.Add(gettingOrdered[index1]);
                        }
                    }

                }

            }
            int a = 0;
            int b = 0;
            for (int p = 0; p < toOrder.Count; p++)
            {
                if(toOrder[p] == "[[2]]")
                {
                    a = p + 1;
                }
                if (toOrder[p] == "[[6]]")
                {
                    b = p + 1;
                }
            }
            Console.WriteLine(a*b);

            // 22713 is the right answer
        }
    }
}
