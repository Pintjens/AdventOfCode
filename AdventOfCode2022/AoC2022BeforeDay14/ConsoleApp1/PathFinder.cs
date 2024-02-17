using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdventOfCode
{
    public class PathFinder
    {

        public static int maxTime = 26;

        private static Dictionary<string, ValveInfo> allData = Input.Day16.Full();

        private static Dictionary<string, bool> valveStates = new Dictionary<string, bool>();

        public static int HighestFlow = 0;

        public static ImmutableList<int> HighestFlowPath;

        public static bool ValvesLeftToOpen()
        {
            foreach (var valve in valveStates)
            {
                if (valve.Value == false)
                {
                    return true;
                }
            }
            return false;
        }

        private int currentFlow = 0;

        private List<int> instructions = new List<int>();

        private static Dictionary<string, bool> baseValveStates;

        private string[] positions = new string[2];

        private List<string>[] positionsSindsLastOpening = { new List<string>(), new List<string>()};

        public static ImmutableDictionary<string, bool> BaseValveStates
        {
            get
            {
                return baseValveStates.ToImmutableDictionary<string, bool>();
            }
        }

        private void SetBaseValveStates()
        {
            Dictionary<string, bool> valveStates = new Dictionary<string, bool>();

            foreach(var valve in allData)
            {
                if (valve.Value.FlowRate > 0)
                {
                    valveStates.Add(valve.Key, false);
                }
                else
                {
                    valveStates.Add(valve.Key, true);
                }
            }

            baseValveStates = valveStates;

        }

        public void Run()
        {

            SetBaseValveStates();

            for (int i = 0; i < 26; i++)
            {
                instructions.Add(-1);
                instructions.Add(-1);
            }
            instructions[0] = 0;
            instructions[1] =0;
            instructions[2] =1;
            instructions[3] =1;
            instructions[4] =-1;

            instructions[5] =0;
            instructions[6] =0;
            instructions[7] =0;
            instructions[8] =0;
            instructions[9] =0;
            instructions[10] =0;
            instructions[11] =-1; //1478

            //instructions[12] =;
            //instructions[13] =;


            DateTime runStartTime = DateTime.Now;
            DateTime runEndTime = DateTime.Now;

            bool running = true;
            while (running)
            {
                //reset current flow
                this.currentFlow = 0;
                //reset valve states
                valveStates.Clear();
                foreach (var state  in BaseValveStates)
                {
                    valveStates.Add(state.Key, state.Value);
                }

                //(re)set position to start
                this.positions[0] = "AA";
                this.positions[1] = "AA";
                this.positionsSindsLastOpening[0].Clear();
                this.positionsSindsLastOpening[1].Clear();

                //-1 = open the valve (if still closed)
                // 0 = move to connection (index 0)
                // 1 = move to connection (index 1)
                // ...

                bool nextSet = false;

                //run instructions
                for (int i = 0; i < instructions.Count; i++)
                {

                    int timeLeft = (maxTime*2 - i -1) / 2 ;

                    int runnerIndex = 0;

                    if (i % 2 != 0)
                    {
                        runnerIndex = 1;
                    }

                    string runnerPosition = positions[runnerIndex];

                    int instruction = instructions[i];

                    if (instruction == -1)
                    {
                        if (valveStates[runnerPosition] == true)
                        {
                            if(i == 11)
                            {
                                running = false;
                                break;
                            }

                            instructions[i] += 1;
                            i--;

                            nextSet = true;
                        }
                        else
                        {
                            //open valve
                            positionsSindsLastOpening[runnerIndex].Clear();
                            valveStates[runnerPosition] = true;
                            currentFlow += allData[runnerPosition].FlowRate * timeLeft;

                            // highest flow?
                            if (currentFlow > HighestFlow)
                            {
                                HighestFlow = currentFlow;
                                HighestFlowPath = instructions.ToImmutableList();

                                Console.WriteLine($"Highest flow found: {HighestFlow}");
                            }

                            //check if all valves are open
                            if (!ValvesLeftToOpen())
                            {
                                for (int j = i - 1; true; j--)
                                {
                                    if (instructions[j] == -1)
                                    {
                                        instructions[j]++;
                                        break;
                                    }
                                    instructions[j] = -1;
                                }

                                // stop current run
                                i = instructions.Count;

                                nextSet = true;
                            }
                        }
                    }
                    else
                    {
                        if (instruction >= allData[runnerPosition].Connections.Count)
                        {   //no more connections
                            try
                            {
                                if(i == 12)
                                {
                                    running = false;
                                    break;
                                }

                                instructions[i - 1]++;
                                instructions[i] = -1;

                                // stop current run
                                i = instructions.Count;

                                nextSet = true;
                            }
                            catch
                            {
                                i = instructions.Count;
                                running = false;

                                runEndTime = DateTime.Now;
                            }
                        }
                        else if (positionsSindsLastOpening[runnerIndex].Contains(allData[runnerPosition].Connections[instruction]))
                        {   //just been there
                            instructions[i]++;
                            i--;

                            nextSet = true;
                        }
                        else
                        {
                            positionsSindsLastOpening[runnerIndex].Add(runnerPosition);
                            positions[runnerIndex] = allData[runnerPosition].Connections[instruction];
                        }

                    }


                }
                if (!nextSet)
                {
                    instructions[instructions.Count - 1] += 1;
                }



            }

            //ended
            Console.WriteLine("\n\n----------------------------\n\nHighest flow path:");
            for (int i = 0; i < HighestFlowPath.Count; i++)
            {
                Console.Write(HighestFlowPath[i] + " > ");
            }
            Console.WriteLine();

            Console.WriteLine("Gives a total flow of: " + HighestFlow);

            Console.WriteLine("\nFound in " + runEndTime.Subtract(runStartTime).TotalSeconds + " seconds");


        }


    }
}
