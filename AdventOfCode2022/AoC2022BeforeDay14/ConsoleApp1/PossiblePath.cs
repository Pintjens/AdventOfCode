using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class PossiblePath
    {
        private static List<PossiblePath> allPossiblePaths = new List<PossiblePath>();
        private static PossiblePath HighestFlowPath = new PossiblePath(new Dictionary<string, bool>(), "", "", 0, 0, 0, false);
        private static List<int> pathsToRemove = new List<int>();

        private static Dictionary<string, int> highestFlowAtValve = new Dictionary<string, int>();
        public static Dictionary<string, int> HighestFlowAtValve
        {
            get
            {
                return highestFlowAtValve;
            }
        }

        private static int highestRelease = 0;
        public static int HighestRelease
        {
            get
            {
                return highestRelease;
            }
            set
            {
                highestRelease = value;
            }
        }

        // a list (dictionary) of opened valves
        private Dictionary<string, bool> valveStates = new Dictionary<string, bool>();
        public Dictionary<string, bool> ValveStates
        {
            set
            {
                this.valveStates = value;
            }
            get
            {
                return this.valveStates;
            }
        }

        //previous location
        private string previousLocation;
        public string PreviousLocation
        {
            set
            {
                this.previousLocation = value;
            }
            get
            {
                return this.previousLocation;
            }
        }

        //current location in the maze
        private string currentLocation;
        public string CurrentLocation
        {
            set
            {
                currentLocation = value;
            }
            get
            {
                return this.currentLocation;
            }
        }

        // realised flow
        private int totalFlow = 0; //start at 0
        public int TotalFlow
        {
            set
            {
                this.totalFlow = value;
            }
            get
            {
                return this.totalFlow;
            }
        }

        private static int timeLeft = 30;
        public static int TimeLeft
        {
            get
            {
                return timeLeft;
            }
        }

        // ended?
        private bool ended = false; //start at false
        public bool Ended
        {
            set
            {
                this.ended = value;
            }
            get
            {
                return this.ended;
            }
        }

        private int valvesLeftToOpen;
        public int ValvesLeftToOpen
        {
            set
            {
                this.valvesLeftToOpen = value;
            }
            get
            {
                return this.valvesLeftToOpen;
            }
        }

        private int stepsSindsLastOpening;
        public int StepsSindsLastOpening
        {
            set
            {
                this.stepsSindsLastOpening = value;
            }
            get
            {
                return this.stepsSindsLastOpening;
            }
        }

        public PossiblePath(Dictionary<string, bool> valveStates, string previousLocation, string currentLocation, int totalFlow, int stepsSindsLastOpening, int valvesLeftToOpen, bool opening)
        {
            this.ValveStates = valveStates;
            this.PreviousLocation = previousLocation;
            this.CurrentLocation = currentLocation;
            this.TotalFlow = totalFlow;
            this.ValvesLeftToOpen = valvesLeftToOpen;
            if (!opening)
            {
                this.StepsSindsLastOpening = stepsSindsLastOpening + 1;
            }
            if (this.StepsSindsLastOpening > valveStates.Count)
            {
                this.Ended = true;
            }
            else
            {
                allPossiblePaths.Add(this);
            }
        }
        public static Dictionary<string, ValveInfo> allData = Input.Day16.Full();
        private static Dictionary<string, bool> CopyValveStates(Dictionary<string, bool> oldValveStates)
        {
            Dictionary<string, bool> newValveStates = new Dictionary<string, bool>();
            foreach (var valve in oldValveStates)
            {
                newValveStates.Add(valve.Key, valve.Value);
            }
            return newValveStates;
        }
        public static void CleanUpPaths()
        {

            for(int i = (pathsToRemove.Count - 1); i >= 0; i--)
            {

                allPossiblePaths.RemoveAt(pathsToRemove[i]);
            }

            pathsToRemove.Clear();

        }
        public void OpenValve()
        {
            this.ValveStates[currentLocation] = true;
            this.stepsSindsLastOpening = 0;
            this.TotalFlow += (allData[currentLocation].FlowRate * (timeLeft - 1));
            this.ValvesLeftToOpen--;
            if(this.TotalFlow > HighestFlowAtValve[this.CurrentLocation])
            {
                HighestFlowAtValve[this.CurrentLocation] = this.TotalFlow;
            }

            if (this.TotalFlow > HighestRelease)
            {
                HighestRelease = this.totalFlow;
                HighestFlowPath = this;
            }

        }
        public void DontOpenValve()
        {
            foreach (var connection in allData[this.CurrentLocation].Connections)
            {

                if (connection == this.previousLocation && this.valveStates[this.currentLocation] == false)
                //right back to where you come from?
                {
                    // nothing happens
                }
                else
                {
                    PossiblePath newPath = new PossiblePath(CopyValveStates(this.valveStates), this.CurrentLocation, connection, this.TotalFlow, this.StepsSindsLastOpening, this.valvesLeftToOpen, false);
                }
            }
        }


        private static Dictionary<string, bool> ReadInValves()
        {
            Dictionary<string, bool> valveStates = new Dictionary<string, bool>();

            foreach (var valve in allData)
            {
                valveStates.Add(valve.Key, false);
            }

            return valveStates;
        }



        public static void Main()
        {
            // create start point
            int totalValvesWithFlow = 0;
            foreach (var valve in allData)
            {
                HighestFlowAtValve[valve.Key] = 0;
                if (valve.Value.FlowRate > 0)
                {
                    totalValvesWithFlow++;
                }
            }
            PossiblePath startPoint = new PossiblePath(ReadInValves(), "Nowhere", "AA", 0, 0, totalValvesWithFlow, true);

            Step();

            Console.WriteLine("finished");

            Console.WriteLine(HighestRelease);

            int firstHighestRealeasePath = allPossiblePaths.Count;
            int latestHighestReleasePath = 0;
            int highestRealesePathCount = 0;

            for (int i = 0; i < allPossiblePaths.Count; i++)
            {
                if (allPossiblePaths[i].totalFlow == HighestRelease)
                {
                    highestRealesePathCount++;
                    if(i > latestHighestReleasePath)
                    {
                        latestHighestReleasePath = i;
                    }
                    if(i < firstHighestRealeasePath)
                    {
                        firstHighestRealeasePath = i;
                    }
                }
            }

            Console.WriteLine($"Nbr of highest paths: {highestRealesePathCount}, first index of them: {firstHighestRealeasePath}, last index of them: {latestHighestReleasePath}");

        }
        private bool EndPath()
        {

            if (this.valveStates[this.CurrentLocation] == true && HighestFlowAtValve[this.CurrentLocation] > this.TotalFlow)
            {
                return true;
            }

            return false;
        }
        private static void FindDeadEnds()
        {
            for(int i = 0; i < allPossiblePaths.Count; i++)
            {
                if (HighestFlowAtValve[allPossiblePaths[i].CurrentLocation] > allPossiblePaths[i].TotalFlow)
                {
                    if (allPossiblePaths[i].ValveStates[allPossiblePaths[i].CurrentLocation] == true)
                    {
                        if (!pathsToRemove.Contains(i))
                        {
                            pathsToRemove.Add(i);
                        }
                    }
                }
            }
        }
        public static void Step()
        {
            Console.WriteLine(DateTime.Now.TimeOfDay + "\t Time left: " + timeLeft + "\t Paths: " + (allPossiblePaths.Count - pathsToRemove.Count));

            

            CleanUpPaths();

            int possiblePathCount = allPossiblePaths.Count;
            for (int i = 0; i < possiblePathCount; i++)
            {
                if (allPossiblePaths[i].Ended)
                {
                    if (allPossiblePaths[i].TotalFlow < HighestRelease)
                    {
                        pathsToRemove.Add(i);
                    }
                }
                else
                {
                    if (allPossiblePaths[i].EndPath())
                    {
                        allPossiblePaths[i].Ended = true;
                    }
                    else
                    {
                        allPossiblePaths[i].DontOpenValve();

                        if (allPossiblePaths[i].valveStates[allPossiblePaths[i].currentLocation] == true || allData[allPossiblePaths[i].currentLocation].FlowRate == 0)
                        {
                            allPossiblePaths[i].Ended = true;
                        }
                        else
                        {
                            allPossiblePaths[i].OpenValve();
                        }
                    }
                }
            }

            timeLeft--;

            if (TimeLeft <= 0)
            {
                return;
            }
            // else: go again
            Step();

        }




    }
}
