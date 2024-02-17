using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day16 // Flow rate
    {
        public static void Main()
        {
            Console.Write("Part ? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Part1Redo();
                // 1638 is the answer
            }
            else if (choice == "2")
            {
                Part2Try1();
            }
            else
            {
                Console.WriteLine("Not possible..");
                Main();
            }
        }
        public static void Part1Try1()
        {
            List<List<string>> valveInfo = Input.Day16.FullUnConverted();

            List<List<string>> paths = new List<List<string>> { new List<string> { "AA", "0", "AA", "RI", "AO"} };

            string to = "AA";

            int valveIndex = -1;
            for (int i = 0; i < paths.Count; i++)
            {
                for (int flow = 2; flow < paths[i].Count; flow++)
                {
                    GetValue.Specific.FlowRate(valveInfo, valveIndex);
                }
                if (paths[i].IndexOf(to) < 0)
                {
                    paths[i].Add(to);
                }
                else
                {
                    int j = 0;
                    do
                    {

                        if (valveInfo[j].IndexOf(to) > -1)
                        {
                            valveIndex = j;
                        }
                        j++;
                    } while (valveIndex < 0);
                }

            }

        }

        public static Dictionary<string, ValveInfo> allData = Input.Day16.Nano();
        public static int highestRelease = 0;
        public static int maxTime = 15;
        public static Dictionary<string, bool> CopyValves(Dictionary<string, bool> valves)
        {
            Dictionary<string, bool> valvesCopy = new Dictionary<string, bool>();
            foreach (var pair in valves)
            {
                valvesCopy.Add(pair.Key, pair.Value);
            }
            return valvesCopy;
        }
        private static void AtValve(int flowrate, int totalReleased, int time, Dictionary<string, bool> valves, string currentValve)
        {


            // to stop infinate loop
            if (time >= maxTime)
            {
                // time up!
                return;
            }

            // OPTIE 2: DONT OPEN THE VALVE
            // so values didnt change yet 
            foreach (var connection in allData[currentValve].Connections)
            {
                Console.Write($"({time}) {currentValve} -> ");

                // travel to every possible connection
                TravleToNextValve(flowrate, totalReleased, time, CopyValves(valves), connection);
            }

            // OPTIE 2: OPEN THE VALVE

            if (valves[currentValve] = false)
            {
                // open the valve
                valves[currentValve] = true;

                // takes 1 minute
                time++;

                // valves are flowing during this minute
                totalReleased += flowrate;

                // check if this total release is the highest
                if (totalReleased > highestRelease)
                {
                    highestRelease = totalReleased;
                }

                // time up?
                if (time >= maxTime)
                {
                    // time up!
                    return;
                }

                // increase the flowrate for opening this valve
                flowrate += allData[currentValve].FlowRate;
                // to add next minute

                foreach (var connection in allData[currentValve].Connections)
                {
                    // travel to every possible connection
                    TravleToNextValve(flowrate, totalReleased, time, CopyValves(valves), connection);
                }
            }

        }
        private static void TravleToNextValve(int flowrate, int totalReleased, int time, Dictionary<string, bool> valves, string currentValve)
        {
            

            // traveling takes a minute
            time++;

            Console.WriteLine($"{currentValve} ({time});");

            // valves are flowing during that minute
            totalReleased += flowrate;

            // check if this total release is the highest
            if (totalReleased > highestRelease)
            {
                highestRelease = totalReleased;
            }

            // time up?
            if (time >= maxTime)
            {
                // time up!
                return;
            }

            // what to do?
            AtValve(flowrate, totalReleased, time, valves, currentValve);
        }
        public static void Part1Try2()
        {

            Dictionary<string, bool> valves = new Dictionary<string, bool>();

            foreach (var valve in allData)
            {
                valves.Add(valve.Key, false);
            }

            AtValve(0, 0, 0, valves, "AA");

            Console.WriteLine(highestRelease);

        }
        public static void Part1Try3()
        {
            Dictionary<string, int> valves = new Dictionary<string, int>();

            foreach (var valve in allData)
            {
                valves.Add(valve.Key, 0);
            }


            string currentLocation = "AA";

            Dictionary<string, int> searchPath = new Dictionary<string, int>();

            // set all nodes to -1
            foreach (var valve in allData)
            {
                searchPath.Add(valve.Key, -1);
            }

            // add 1 way entry to start position ??


            string startposition = "AA";
            int steps = 0;
            currentLocation = startposition;
            searchPath[currentLocation] = steps;
            int mapedNodes = 1;

            while (mapedNodes != searchPath.Count)
            {
                List<string> nextNodes = new List<string>();
                foreach (var node in searchPath)
                {
                    if (node.Value == steps)
                    {
                        nextNodes.Add(node.Key);
                    }
                }

                steps++;

                foreach (var node in nextNodes)
                {
                    foreach (var connection in allData[node].Connections)
                    {
                        if (searchPath[connection] == -1)
                        {
                            searchPath[connection] = steps;
                            mapedNodes++;
                        }
                    }
                }
            }
            Console.WriteLine($"maped nodes = {mapedNodes}");
            foreach (var node in searchPath)
            {
                Console.WriteLine($"{node.Key}: {node.Value}");
            }

            int totalRelease = 0;
            int timeLeft = 15;

            Dictionary<string, int> highestPostential = new Dictionary<string, int>();

            highestPostential.Add("AA", 0);

            foreach(var node in searchPath)
            {
                int timePotential = timeLeft - node.Value - 1;
                int releasePotential = timePotential * allData[node.Key].FlowRate;

                if(releasePotential > highestPostential["something"])
                {

                }
            }

        }
        public static void Part1Try4()
        {
            PossiblePath.Main();

        }
        public static void Part1Redo()
        { // Directions method

            //List<int> Directions = new List<int>();

            //bool running = true;

            //while (running)
            //{

            //}

            PathFinder test = new PathFinder();

            test.Run();



        }
        public static void Part2Try1()
        {
            DuoPath.RunSimulation("AA");
            // 12 steps
            // till 1926, to low

            //2050 is to low

            //2083 is not right
        }
    }
}
