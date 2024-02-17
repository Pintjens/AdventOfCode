using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day11
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

            List<List<List<int>>> monkeys = new List<List<List<int>>> { new List<List<int>> { new List<int> { 0 }, new List<int> { 54, 89, 94 }, new List<int> { 0, 1000, 7 }, new List<int> { 17 }, new List<int> { 5 }, new List<int> { 3 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 1 }, new List<int> { 66, 71 }, new List<int> { 0, 100, 4 }, new List<int> { 3 }, new List<int> { 0 }, new List<int> { 3 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 2 }, new List<int> { 76, 55, 80, 55, 55, 96, 78 }, new List<int> { 0, 100, 2 }, new List<int> { 5 }, new List<int> { 7 }, new List<int> { 4 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 3 }, new List<int> { 93, 69, 76, 66, 89, 54, 59, 94 }, new List<int> { 0, 100, 7 }, new List<int> { 7 }, new List<int> { 5 }, new List<int> { 2 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 4 }, new List<int> { 80, 54, 58, 75, 99 }, new List<int> { 0, 1000, 17 }, new List<int> { 11 }, new List<int> { 1 }, new List<int> { 6 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 5 }, new List<int> { 69, 70, 85, 83 }, new List<int> { 0, 100, 8 }, new List<int> { 19 }, new List<int> { 2 }, new List<int> { 7 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 6 }, new List<int> { 89 }, new List<int> { 0, 100, 6 }, new List<int> { 2 }, new List<int> { 0 }, new List<int> { 1 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 7 }, new List<int> { 62, 80, 58, 57, 93, 56 }, new List<int> { 0, 1000, 0 }, new List<int> { 13 }, new List<int> { 6 }, new List<int> { 4 }, new List<int> { 0 } } };
            //List<List<List<int>>> monkeys = new List<List<List<int>>> {  new List<List<int>>{ new List<int> {0  }, new List<int>{ 79, 98  }, new List<int> { 0, 1000, 19 }, new List<int> { 23 }, new List<int> { 2 }, new List<int> { 3 }, new List<int> { 0 }}, new List<List<int>> { new List<int> { 1 }, new List<int> { 54, 65, 75, 74 }, new List<int> { 0, 100, 6 }, new List<int> { 19 }, new List<int> { 2 }, new List<int> { 0 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 2 }, new List<int> { 79, 60, 97 }, new List<int> { 0, 1000, 0 }, new List<int> { 13 }, new List<int> { 1 }, new List<int> { 3 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 3 }, new List<int> { 74 }, new List<int> { 0, 100, 3 }, new List<int> { 17 }, new List<int> { 0 }, new List<int> { 1 }, new List<int> { 0 } }};


            for (int round = 1; round <= 20; round++)
            {

                foreach (List<List<int>> monkey in monkeys)
                {

                    List<int> monkeyItems = monkey[1];
                    int monkeyNr = monkey[0][0];
                    int operation = monkey[2][1];
                    int operationBy = monkey[2][2];
                    int testBy = monkey[3][0];
                    int ifTrueTo = monkey[4][0];
                    int ifFalseTo = monkey[5][0];
                    bool operationToBeSet = false;
                    if (operationBy == 0)
                    {
                        operationToBeSet = true;
                    }

                    foreach (int item in monkeyItems)
                    {
                        int worryLvl = item;
                        if (operationToBeSet)
                        {
                            operationBy = worryLvl;
                        }
                        switch (operation)
                        {
                            case 100:
                                worryLvl += operationBy;
                                break;
                            case 1000:
                                worryLvl *= operationBy;
                                break;
                        }


                        worryLvl /= 3;

                        if (worryLvl % testBy == 0)
                        {
                            monkeys[ifTrueTo][1].Add(worryLvl);
                        }
                        else
                        {
                            monkeys[ifFalseTo][1].Add(worryLvl);
                        }

                        monkeys[monkeyNr][6][0]++;
                    }
                    monkeys[monkeyNr][1] = new List<int>();
                }
            }


            int monkeyBusiness = 0;
            int highestInspectCount = 0;
            int scndHighInspectCoun = 0;
            int inspectCount;
            foreach (List<List<int>> monkey in monkeys)
            {
                inspectCount = monkey[6][0];
                if (inspectCount > highestInspectCount)
                {
                    scndHighInspectCoun = highestInspectCount;
                    highestInspectCount = inspectCount;
                }
                else if (inspectCount > scndHighInspectCoun)
                {
                    scndHighInspectCoun = inspectCount;
                }
            }

            monkeyBusiness = highestInspectCount * scndHighInspectCoun;

            Console.WriteLine(monkeyBusiness);
            // 125640 is to high
            // 112554 is to high
            // 106525 is to low
            // 112548 isnt it
            // ist 110888
        }
        public static void Part2()
        {
            Console.WriteLine("Try 1 or 2?");
            string choise = Console.ReadLine();

            if (choise == "1")
            {
                Part2Try1();
            }
            else if (choise == "2")
            {
                Part2Try2();
            }
            else
            {
                Console.WriteLine("Ongeldige keuze.");
                Part2();
            }
        }
        public static void Part2Try1()
        {


            //List<List<List<int>>> monkeys = new List<List<List<int>>> { new List<List<int>> { new List<int> { 0 }, new List<int> { 54, 89, 94 }, new List<int> { 0, 1000, 7 }, new List<int> { 17 }, new List<int> { 5 }, new List<int> { 3 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 1 }, new List<int> { 66, 71 }, new List<int> { 0, 100, 4 }, new List<int> { 3 }, new List<int> { 0 }, new List<int> { 3 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 2 }, new List<int> { 76, 55, 80, 55, 55, 96, 78 }, new List<int> { 0, 100, 2 }, new List<int> { 5 }, new List<int> { 7 }, new List<int> { 4 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 3 }, new List<int> { 93, 69, 76, 66, 89, 54, 59, 94 }, new List<int> { 0, 100, 7 }, new List<int> { 7 }, new List<int> { 5 }, new List<int> { 2 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 4 }, new List<int> { 80, 54, 58, 75, 99 }, new List<int> { 0, 1000, 17 }, new List<int> { 11 }, new List<int> { 1 }, new List<int> { 6 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 5 }, new List<int> { 69, 70, 85, 83 }, new List<int> { 0, 100, 8 }, new List<int> { 19 }, new List<int> { 2 }, new List<int> { 7 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 6 }, new List<int> { 89 }, new List<int> { 0, 100, 6 }, new List<int> { 2 }, new List<int> { 0 }, new List<int> { 1 }, new List<int> { 0 } }, new List<List<int>> { new List<int> { 7 }, new List<int> { 62, 80, 58, 57, 93, 56 }, new List<int> { 0, 1000, 0 }, new List<int> { 13 }, new List<int> { 6 }, new List<int> { 4 }, new List<int> { 0 } } };
            List<List<List<ulong>>> monkeys = new List<List<List<ulong>>> { new List<List<ulong>> { new List<ulong> { 0 }, new List<ulong> { 79, 98 }, new List<ulong> { 0, 1000, 19 }, new List<ulong> { 23 }, new List<ulong> { 2 }, new List<ulong> { 3 }, new List<ulong> { 0 } }, new List<List<ulong>> { new List<ulong> { 1 }, new List<ulong> { 54, 65, 75, 74 }, new List<ulong> { 0, 100, 6 }, new List<ulong> { 19 }, new List<ulong> { 2 }, new List<ulong> { 0 }, new List<ulong> { 0 } }, new List<List<ulong>> { new List<ulong> { 2 }, new List<ulong> { 79, 60, 97 }, new List<ulong> { 0, 1000, 0 }, new List<ulong> { 13 }, new List<ulong> { 1 }, new List<ulong> { 3 }, new List<ulong> { 0 } }, new List<List<ulong>> { new List<ulong> { 3 }, new List<ulong> { 74 }, new List<ulong> { 0, 100, 3 }, new List<ulong> { 17 }, new List<ulong> { 0 }, new List<ulong> { 1 }, new List<ulong> { 0 } } };
            //List<List<List<decimal>>> monkeys = new List<List<List<decimal>>> { new List<List<decimal>> { new List<decimal> { 0 }, new List<decimal> { 79, 98 }, new List<decimal> { 0, 1000, 19 }, new List<decimal> { 23 }, new List<decimal> { 2 }, new List<decimal> { 3 }, new List<decimal> { 0 } }, new List<List<decimal>> { new List<decimal> { 1 }, new List<decimal> { 54, 65, 75, 74 }, new List<decimal> { 0, 100, 6 }, new List<decimal> { 19 }, new List<decimal> { 2 }, new List<decimal> { 0 }, new List<decimal> { 0 } }, new List<List<decimal>> { new List<decimal> { 2 }, new List<decimal> { 79, 60, 97 }, new List<decimal> { 0, 1000, 0 }, new List<decimal> { 13 }, new List<decimal> { 1 }, new List<decimal> { 3 }, new List<decimal> { 0 } }, new List<List<decimal>> { new List<decimal> { 3 }, new List<decimal> { 74 }, new List<decimal> { 0, 100, 3 }, new List<decimal> { 17 }, new List<decimal> { 0 }, new List<decimal> { 1 }, new List<decimal> { 0 } } };
            for (int round = 1; round <= 20; round++)
            {

                foreach (List<List<ulong>> monkey in monkeys)
                {

                    List<ulong> monkeyItems = monkey[1];
                    int monkeyNr = Convert.ToInt32(monkey[0][0]);
                    ulong operation = Convert.ToUInt64(monkey[2][1]);
                    ulong operationBy = Convert.ToUInt64(monkey[2][2]);
                    ulong testBy = monkey[3][0];
                    int ifTrueTo = Convert.ToInt32(monkey[4][0]);
                    int ifFalseTo = Convert.ToInt32(monkey[5][0]);
                    bool operationToBeSet = false;
                    if (operationBy == 0)
                    {
                        operationToBeSet = true;
                    }

                    foreach (ulong item in monkeyItems)
                    {
                        ulong worryLvl = item;
                        if (operationToBeSet)
                        {
                            operationBy = worryLvl;
                        }
                        switch (operation)
                        {
                            case 100:
                                worryLvl += operationBy;
                                break;
                            case 1000:
                                worryLvl *= operationBy;
                                break;
                        }
                        worryLvl /= 3;


                        if (worryLvl % testBy == 0)
                        {
                            monkeys[ifTrueTo][1].Add(worryLvl);
                        }
                        else
                        {
                            monkeys[ifFalseTo][1].Add(worryLvl);
                        }

                        monkeys[monkeyNr][6][0]++;
                    }
                    monkeys[monkeyNr][1] = new List<ulong>();
                }
                if (round == 1 || round == 20 || round % 1000 == 0)
                {
                    foreach (List<List<ulong>> monkey in monkeys)
                    {
                        Console.WriteLine(monkey[6][0]);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }

            }


            int monkeyBusiness = 0;
            int highestInspectCount = 0;
            int scndHighInspectCoun = 0;
            int inspectCount;
            foreach (List<List<ulong>> monkey in monkeys)
            {
                inspectCount = Convert.ToInt32(monkey[6][0]);
                Console.WriteLine(monkey[6][0]);
                if (inspectCount > highestInspectCount)
                {
                    scndHighInspectCoun = highestInspectCount;
                    highestInspectCount = inspectCount;
                }
                else if (inspectCount > scndHighInspectCoun)
                {
                    scndHighInspectCoun = inspectCount;
                }
            }

            monkeyBusiness = highestInspectCount * scndHighInspectCoun;

            Console.WriteLine(monkeyBusiness);

            // 26301492 is to low
            // 235675443 is to low
            // not %11 = 322525677 (to low)
            // not 299982399
        }
        public static void Part2Try2()
        {

            // 4 Monkeys
            string rawInput = @"Monkey 0:\r\n  Starting items: 79, 98\r\n  Operation: new = old * 19\r\n  Test: divisible by 23\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 3\r\n\r\nMonkey 1:\r\n  Starting items: 54, 65, 75, 74\r\n  Operation: new = old + 6\r\n  Test: divisible by 19\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 0\r\n\r\nMonkey 2:\r\n  Starting items: 79, 60, 97\r\n  Operation: new = old * old\r\n  Test: divisible by 13\r\n    If true: throw to monkey 1\r\n    If false: throw to monkey 3\r\n\r\nMonkey 3:\r\n  Starting items: 74\r\n  Operation: new = old + 3\r\n  Test: divisible by 17\r\n    If true: throw to monkey 0\r\n    If false: throw to monkey 1";
            List<ulong>[] monkeyInventories = new List<ulong>[4];

            // 8 Monkeys
            //string rawInput = @"Monkey 0:\r\n  Starting items: 54, 89, 94\r\n  Operation: new = old * 7\r\n  Test: divisible by 17\r\n    If true: throw to monkey 5\r\n    If false: throw to monkey 3\r\n\r\nMonkey 1:\r\n  Starting items: 66, 71\r\n  Operation: new = old + 4\r\n  Test: divisible by 3\r\n    If true: throw to monkey 0\r\n    If false: throw to monkey 3\r\n\r\nMonkey 2:\r\n  Starting items: 76, 55, 80, 55, 55, 96, 78\r\n  Operation: new = old + 2\r\n  Test: divisible by 5\r\n    If true: throw to monkey 7\r\n    If false: throw to monkey 4\r\n\r\nMonkey 3:\r\n  Starting items: 93, 69, 76, 66, 89, 54, 59, 94\r\n  Operation: new = old + 7\r\n  Test: divisible by 7\r\n    If true: throw to monkey 5\r\n    If false: throw to monkey 2\r\n\r\nMonkey 4:\r\n  Starting items: 80, 54, 58, 75, 99\r\n  Operation: new = old * 17\r\n  Test: divisible by 11\r\n    If true: throw to monkey 1\r\n    If false: throw to monkey 6\r\n\r\nMonkey 5:\r\n  Starting items: 69, 70, 85, 83\r\n  Operation: new = old + 8\r\n  Test: divisible by 19\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 7\r\n\r\nMonkey 6:\r\n  Starting items: 89\r\n  Operation: new = old + 6\r\n  Test: divisible by 2\r\n    If true: throw to monkey 0\r\n    If false: throw to monkey 1\r\n\r\nMonkey 7:\r\n  Starting items: 62, 80, 58, 57, 93, 56\r\n  Operation: new = old * old\r\n  Test: divisible by 13\r\n    If true: throw to monkey 6\r\n    If false: throw to monkey 4\r\n";
            //List<ulong>[] monkeyInventories = new List<ulong>[8];

            string[] input = rawInput.Split("\\r\\n");


            
            monkeyInventories[0] = new List<ulong> { 79, 98 };
            monkeyInventories[1] = new List<ulong> { 54, 65, 75, 74 };
            monkeyInventories[3] = new List<ulong> { 79, 60, 97 };
            monkeyInventories[4] = new List<ulong> { 74 };
            // 2 = *
            // 1 = +
            // 0 = old

            foreach (string line in input)
            {
                Console.WriteLine(line);
            }

            



        }
    }
}
