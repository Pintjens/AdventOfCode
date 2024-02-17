using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day21
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

        internal class Monkey
        {

            public static List<Monkey> AllMonkies = new List<Monkey>();

            internal abstract class Task
            {
                abstract public double Act { set; get; }



            }


            internal class Yell : Task
            {
                public double Value;
                public override double Act
                {
                    set
                    {
                        this.Value = value;
                    }
                    get
                    {
                        return this.Value;
                    }
                }

                public Yell(double value)
                {
                    this.Value = value;
                }
            }


            internal class Calculate : Task
            {
                public string[] MonkeyNames  = new string[2];
                public double[] Values = new double[2];
                public char Operation;


                public override double Act
                {
                    set
                    {

                    }
                    get
                    {
                        for (int i = 0; i < MonkeyNames.Length; i++)
                        {
                            this.Values[i] = AllMonkies.Find(x => x.Name == MonkeyNames[i]).Job.Act;
                        }


                        double outcome;
                        double value1 = this.Values[0];
                        double value2 = this.Values[1];

                        switch (this.Operation)
                        {
                            case '-':
                                outcome = value1 - value2;
                                break;
                            case '+':
                                outcome = value1 + value2;
                                break;
                            case '*':
                                outcome = value1 * value2;
                                break;
                            case '/':
                                outcome = value1 / value2;
                                break;
                            default: // '='
                                Console.WriteLine("1: " + value1);
                                Console.WriteLine("2: " + value2);
                                if (value1 < value2)
                                {
                                    throw new Exception("To High");
                                }
                                else if(value1 > value2)
                                {
                                    throw new Exception("To Low");
                                }
                                else
                                {
                                    throw new Exception("Yes");
                                }

                        }

                        return outcome;

                    }
                }

                public Calculate(string memory)
                {
                    string[] input = memory.Split(' ');

                    this.MonkeyNames[0] = input[0];
                    this.MonkeyNames[1] = input[2];

                    this.Operation = input[1][0];

                }


            }

            public string Name;

            public Task Job;


            public Monkey(string name, string task)
            {
                this.Name = name;

                double toYell;
                if (double.TryParse(task, out toYell))
                {
                    this.Job = new Yell(toYell);
                }
                else
                {
                    this.Job = new Calculate(task);
                }

                AllMonkies.Add(this);

            }

        }
        public static void Part1()
        { 

            foreach(string monkey in Input.Day21.Full())
            {
                string[] split = monkey.Split(": ");
                new Monkey(split[0], split[1]);
            }

            //Monkey targetMonkey = Monkey.AllMonkies.Find(x => x.Name == "root");

            Console.WriteLine(Monkey.AllMonkies.Find(x => x.Name == "root").Job.Act);


            //945240480 is to low
            //54703080378102
        }

        public static void Part2()
        {
            foreach (string monkey in Input.Day21.Full())
            {
                string[] split = monkey.Split(": ");
                if (split[0] == "root")
                {
                    new Monkey("root", split[1].Replace('-', '+').Replace('+', '/').Replace('/', '*').Replace('*', '='));
                }
                else
                {
                    new Monkey(split[0], split[1]);
                }
            }


            Monkey me = Monkey.AllMonkies.Find(x => x.Name == "humn");

            Monkey root = Monkey.AllMonkies.Find(x => x.Name == "root");



            bool found = false;
            bool lengthFound = false;
            int length = 1;

            while (!lengthFound)
            {
                Console.WriteLine(length);
                
                
                
                me.Job.Act = Convert.ToDouble(new String('9', length));

                try
                {
                    double x = root.Job.Act;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    if (e.Message == "To Low")
                    {
                        length += 1;
                    }
                    else if (e.Message == "To High")
                    {
                        lengthFound = true;
                    }
                    else
                    {
                        Console.WriteLine("Yes");
                        Console.WriteLine(length + "9s");

                        lengthFound = true;
                    }
                    Console.WriteLine();
                }
            }



            int index = 0;



            int[] tryValueArr = new int[length];

            for(int i = 0; i < tryValueArr.Length; i++)
            {
                tryValueArr[i] = 9;
            }

            while (!found)
            {
                //me.Job.Act = tryValue;

                ////Console.WriteLine(Monkey.AllMonkies.Find(x => x.Name == "humn").Job.Act);
                ///

                string tryString = "";
                foreach(int value in tryValueArr)
                {
                    Console.Write(value);
                    tryString += value;
                }
                Console.WriteLine();
                me.Job.Act = Convert.ToDouble(tryString);

                try
                {
                    double x = root.Job.Act;
                    //value 2 will stay the same. You only have a influence on value 1
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    if (e.Message == "To Low")
                    {
                        tryValueArr[index] ++;

                        Console.WriteLine(tryValueArr[index]);

                        index += 1;
                        Console.ReadLine();

                        Console.Write("new index: " + index);
                    }
                    else if (e.Message == "To High")
                    {
                        if (tryValueArr[index] == 0)
                        {
                            index++;
                            Console.ReadLine();
                        }
                        else
                        {
                            tryValueArr[index] --;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yes");
                        Console.WriteLine();

                        found = true;
                    }
                    Console.WriteLine();
                }

            }
            //while (!found)
            //{
            //    Console.Write("> ");
            //    double tryValue = Convert.ToDouble(Console.ReadLine());

            //    me.Job.Act = tryValue;

            //    //Console.WriteLine(Monkey.AllMonkies.Find(x => x.Name == "humn").Job.Act);

            //    try
            //    {
            //        double x = root.Job.Act;
            //        //value 2 will stay the same. You only have a influence on value 1
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);

            //        if (e.Message == "Yes")
            //        {
            //            Console.WriteLine();

            //            found = true;
            //        }
            //    }

            //}


            // 3952673930912 is the right answer

        }
    }
}
