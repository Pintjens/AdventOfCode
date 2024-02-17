using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2015
{
    internal class Day7
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
        internal abstract class Gate
        {
            public static int Outputs = 0;
            private static List<Gate> allGates = new List<Gate>();
            public static ImmutableList<Gate> AllGates
            {
                get
                {
                    return allGates.ToImmutableList<Gate>();
                }
            }
            private string name;
            public string Name
            {
                get
                {
                    return this.name;
                }
            }

            public abstract ushort GetOutput();

            private Gate(string name)
            {
                this.name = name;
                allGates.Add(this);
            }

            internal class Start : Gate
            {
                private static ushort newStarts = 0;
                private ushort input;
                public override ushort GetOutput()
                {
                    Outputs++;
                    Console.Clear();
                    Console.WriteLine(Outputs);
                    return this.input;
                }
                public Start(string name, ushort input) : base(name)
                {
                    this.input = input;
                }
                public Start(ushort input): this($"NewStart{newStarts}", input)
                {
                    newStarts++;
                }
            }
            internal class Wire: Gate
            {
                private string input;
                public override ushort GetOutput()
                {
                    Outputs++;
                    Console.Clear();
                    Console.WriteLine(Outputs);
                    return allGates.Find(x => x.Name == input).GetOutput();
                }
                public Wire(string name, string input):base(name)
                {
                    this.input = input;
                }
            }
            internal class And : Gate
            {
                private string inputGateNameA;
                private string inputGateNameB;
                public override ushort GetOutput()
                {
                    Outputs++;
                    Console.Clear();
                    Console.WriteLine(Outputs);
                    return (ushort)(allGates.Find(x => x.Name == inputGateNameA).GetOutput() & allGates.Find(x => x.Name == inputGateNameB).GetOutput());
                }
                public And(string name, string inputA, string inputB): base(name)
                {
                    this.inputGateNameA = inputA;
                    this.inputGateNameB = inputB;
                }
            }
            internal class Or : Gate
            {
                private string inputGateNameA;
                private string inputGateNameB;
                public override ushort GetOutput()
                {
                    Outputs++;
                    Console.Clear();
                    Console.WriteLine(Outputs);
                    return (ushort)(allGates.Find(x => x.Name == inputGateNameA).GetOutput() | allGates.Find(x => x.Name == inputGateNameB).GetOutput());
                }
                public Or(string name, string inputA, string inputB): base(name)
                {
                    this.inputGateNameA = inputA;
                    this.inputGateNameB = inputB;
                }
            }
            internal class Not : Gate
            {
                private string inputGateName;
                public override ushort GetOutput()
                {
                    Outputs++;
                    Console.Clear();
                    Console.WriteLine(Outputs);
                    return (ushort)~allGates.Find(x => x.Name == inputGateName).GetOutput();
                }
                public Not(string name, string input) : base(name)
                {
                    this.inputGateName = input;
                }
            }
            internal class RShift : Gate
            {
                private string inputGateName;
                private byte shift;
                public override ushort GetOutput()
                {
                    Outputs++;
                    Console.Clear();
                    Console.WriteLine(Outputs);
                    return (ushort)(allGates.Find(x => x.Name == inputGateName).GetOutput() >> shift);
                }
                public RShift(string name, string input, byte shift) : base(name)
                {
                    this.inputGateName = input;
                    this.shift = shift;
                }
            }
            internal class LShift : Gate
            {
                private string inputGateName;
                private byte shift;
                public override ushort GetOutput()
                {
                    Outputs++;
                    Console.Clear();
                    Console.WriteLine(Outputs);
                    return (ushort)(allGates.Find(x => x.Name == inputGateName).GetOutput() << shift);
                }
                public LShift(string name, string input, byte shift): base(name)
                {
                    this.inputGateName = input;
                    this.shift = shift;
                }
            }
        }


        public static void Part1()
        {

            // Build the dataset

            foreach (string wire in Inputs.Day7.Full())
            {
                string[] wireparts = wire.Split(' ');

                if (wireparts.Length > 4)
                {
                    string name = wireparts[4];
                    string inputA = wireparts[0];
                    string inputB = wireparts[2];

                    switch (wireparts[1][0])
                    {
                        case 'L':
                            new Gate.LShift(name, inputA, Convert.ToByte(inputB));
                            break;
                        case 'R':
                            new Gate.RShift(name, inputA, Convert.ToByte(inputB));
                            break;
                        default:
                            ushort input;

                            try
                            {
                                input = Convert.ToUInt16(wireparts[0]);
                                Gate newStart = new Gate.Start(input);
                                inputA = newStart.Name;
                            }
                            catch
                            {
                                // Nothing changes
                            }
                            try
                            {
                                input = Convert.ToUInt16(wireparts[2]);
                                Gate newStart = new Gate.Start(input);
                                inputB = newStart.Name;
                            }
                            catch
                            {
                                // Nothing changes
                            }


                            switch (wireparts[1][0])
                            {
                                case 'A':
                                    new Gate.And(name, inputA, inputB);
                                    break;
                                case 'O':
                                    new Gate.Or(name, inputA, inputB);
                                    break;
                                default:
                                    Console.WriteLine("Something went wrong 1");
                                    break;
                            }
                            break;
                    }

                }
                else if (wireparts.Length > 3)
                { // NOT
                    new Gate.Not(wireparts[3], wireparts[1]);
                }
                else
                { // Start
                    try
                    {
                        new Gate.Start(wireparts[2], Convert.ToUInt16(wireparts[0]));
                    }
                    catch
                    {
                        new Gate.Wire(wireparts[2], wireparts[0]);
                    }

                }
            }


            // Ask the question
            Console.WriteLine(Gate.AllGates.Find(x => x.Name == "a").GetOutput());

            ////Demo
            //Console.WriteLine(Gate.AllGates.Find(x => x.Name == "d").GetOutput());
            //Console.WriteLine(Gate.AllGates.Find(x => x.Name == "e").GetOutput());
            //Console.WriteLine(Gate.AllGates.Find(x => x.Name == "f").GetOutput());
            //Console.WriteLine(Gate.AllGates.Find(x => x.Name == "g").GetOutput());
            //Console.WriteLine(Gate.AllGates.Find(x => x.Name == "h").GetOutput());
            //Console.WriteLine(Gate.AllGates.Find(x => x.Name == "i").GetOutput());
            //Console.WriteLine(Gate.AllGates.Find(x => x.Name == "x").GetOutput());
            //Console.WriteLine(Gate.AllGates.Find(x => x.Name == "y").GetOutput());

        }
        public static void Part2()
        {

        }
    }
}
