using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class DuoPath
    {
        private static Dictionary<string, ValveInfo> allData = Input.Day16.Full();

        // STATICS
        private static List<DuoPath> allPaths = new List<DuoPath>();
        public static ImmutableList<DuoPath> AllPaths
        {
            get
            {
                return allPaths.ToImmutableList<DuoPath>();
            }
        }

        private static int timeLeft = 26;
        public static int TimeLeft
        {
            set
            {
                timeLeft = TimeLeft - 1;
            }
            get
            {
                return timeLeft;
            }
        }

        private static Dictionary<int, Dictionary<int, int>> allPossibleValveStatesAndPositions = new Dictionary<int, Dictionary<int, int>>();

        private static int highestReportedEndFlow = 0;
        public static int HighestReportedEndFlow
        {
            set
            {
                highestReportedEndFlow = value;
            }
            get
            {
                return highestReportedEndFlow;
            }
        }

        private static List<int> deadEnds = new List<int>();
        public static ImmutableList<int> DeadEnds
        {
            get
            {
                return deadEnds.ToImmutableList<int>();
            }
        }


        // ATTRIBUTES
        private bool ended = false;
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
        internal class PathWalker
        {
            private string currentPosition = "Nowhere";
            public string CurrentPosition
            {
                set
                {
                    this.previousPosition = this.CurrentPosition;
                    this.currentPosition = value;
                }
                get
                {
                    return this.currentPosition;
                }
            }

            private string previousPosition;
            public string PreviousPosition
            {
                get
                {
                    return this.previousPosition;
                }
            }

            private int stepsSindsLastOpening;
            public int StepsSindsLastOpening
            {
                set
                {
                    if(value == 0)
                    {
                        this.stepsSindsLastOpening = 0;
                    }
                    else
                    {
                        this.stepsSindsLastOpening++;
                    }

                }
                get
                {
                    return this.stepsSindsLastOpening;
                }
            }
            public PathWalker(string currentPosition)
            {
                this.CurrentPosition = currentPosition;
                this.StepsSindsLastOpening = 0;

            }
        }

        private PathWalker[] pathWalkers = new PathWalker[] {new PathWalker("Start"), new PathWalker("Start")};
        public string[] Positions
        {
            set
            {
                this.pathWalkers[0].CurrentPosition = value[0];
                this.pathWalkers[1].CurrentPosition = value[1];
            }
            get
            {
                string[] positions = { this.pathWalkers[0].CurrentPosition, this.pathWalkers[1].CurrentPosition };
                return positions;
            }
        }

        private string positionElephant
        {
            get
            {
                return this.Positions[0];
            }
        }
        private string positionMe
        {
            get
            {
                return this.Positions[1];
            }
        }

        private int flowAtEnd = 0;
        public int FlowAtEnd
        {
            set
            {
                this.flowAtEnd = value;
            }
            get
            {
                return this.flowAtEnd;
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

        //CONSTRUCTORS
        private DuoPath(bool ended, Dictionary<string, bool> valveStates, string[] positions, int flowAtEnd, int valvesLeftToOpen)
        {


            this.Ended = ended;
            this.ValveStates = valveStates;
            this.Positions = positions;
            this.FlowAtEnd = flowAtEnd;
            this.ValvesLeftToOpen = valvesLeftToOpen;

            if (this.FlowAtEnd > HighestReportedEndFlow)
            {
                HighestReportedEndFlow = this.FlowAtEnd;
            }

            int valvesHash = valveStates.GetHashCode();
            int positionHash = positions[0].GetHashCode() + positions[1].GetHashCode();

            if (allPossibleValveStatesAndPositions.ContainsKey(valvesHash))
            {
                Dictionary<int, int> valveStateOption = allPossibleValveStatesAndPositions[valvesHash];

                if (valveStateOption.ContainsKey(positionHash))
                {
                    if (flowAtEnd <= valveStateOption[positionHash])
                    {
                        this.Ended = true;
                    }
                    else
                    {
                        valveStateOption[positionHash] = flowAtEnd;
                    }

                }
                else
                {
                    valveStateOption.Add(positionHash, flowAtEnd);
                }
            }
            else
            {
                Dictionary<int, int> newValveStateOption = new Dictionary<int, int>();
                newValveStateOption.Add(positionHash, flowAtEnd);
                allPossibleValveStatesAndPositions.Add(valvesHash, newValveStateOption);
            }

            if(this.Ended == false)
            {
                allPaths.Add(this);
            }
        }

        //METHODES
        private static Dictionary<string, bool> CopyValveStates(Dictionary<string, bool> oldValveStates)
        {
            Dictionary<string, bool> newValveStates = new Dictionary<string, bool>();
            foreach (var valve in oldValveStates)
            {
                newValveStates.Add(valve.Key, valve.Value);
            }
            return newValveStates;
        }

        private static void FindDeadEnds()
        { // Separate method before or after the step to get them in the right order

            //To use the indexes
            for (int i = 0; i < allPaths.Count; i++)
            {
                if (allPaths[i].Ended || allPaths[i].ValvesLeftToOpen == 0 || allPaths[i].pathWalkers[0].StepsSindsLastOpening >= allData.Count || allPaths[i].pathWalkers[1].StepsSindsLastOpening >= allData.Count)
                {
                    deadEnds.Add(i);
                }
                else if(TimeLeft < 16 && allPaths[i].FlowAtEnd == 0)
                {
                    deadEnds.Add(i);
                }
                else
                {
                    int valvesHash = allPaths[i].ValveStates.GetHashCode();
                    int positionHash = allPaths[i].Positions[0].GetHashCode() + allPaths[i].Positions[1].GetHashCode();

                    Dictionary<int, int> valveStateOption = allPossibleValveStatesAndPositions[valvesHash];

                    if (allPaths[i].FlowAtEnd < valveStateOption[positionHash])
                    {
                        deadEnds.Add(i);
                    }
                }
            }
        }
        private static void CleanUpDeadEnds()
        {
            // From back to front to avoid index shifting while removing
            ImmutableList<int> toRemove = DeadEnds;
            for (int i = toRemove.Count - 1; i > -1; i--)
            {
                allPaths.RemoveAt(toRemove[i]);
            }

            // Empty the dead-end list for the next run;
            deadEnds.Clear();
        }
        private void OpenNoValves()
        {
            foreach(var connectionElephant in allData[this.positionElephant].Connections)
            {
                foreach(var connectionMe in allData[this.positionMe].Connections)
                {
                    if (this.ValveStates[this.positionMe] == true && (connectionMe == this.pathWalkers[0].PreviousPosition || connectionMe == this.pathWalkers[1].PreviousPosition))
                    {
                        //It would be pointless
                    }
                    else if (this.ValveStates[this.positionElephant] == true && (connectionElephant == this.pathWalkers[0].PreviousPosition || connectionElephant == this.pathWalkers[1].PreviousPosition))
                    {
                        //It would be pointless too
                    }
                    else
                    {
                        DuoPath newPath = new DuoPath(false, this.ValveStates, new string[] { connectionElephant, connectionMe }, this.FlowAtEnd, this.ValvesLeftToOpen);
                        newPath.pathWalkers[0].StepsSindsLastOpening = 1; // +1
                        newPath.pathWalkers[1].StepsSindsLastOpening = 1; // +1
                    }

                }
            }
        
        }
        private void OpenOneValve(char whoOpens) /* E: Elephant, M: Me */
        {

            if (whoOpens == 'E')
            {
                // Elephant stays, opens and ads flow
                string elephant = this.positionElephant;
                int newFlowRate = this.FlowAtEnd + (allData[elephant].FlowRate * TimeLeft);

                Dictionary<string, bool> newValveStates = CopyValveStates(this.ValveStates);
                newValveStates[elephant] = true;

                // I move to every possible connection
                foreach (var connection in allData[this.positionMe].Connections)
                {
                    DuoPath newPath = new DuoPath(false, newValveStates, new string[] { elephant, connection }, newFlowRate, this.ValvesLeftToOpen - 1);
                    newPath.pathWalkers[0].StepsSindsLastOpening = 0;
                    newPath.pathWalkers[1].StepsSindsLastOpening = 1;
                    
                }
            }
            else if (whoOpens == 'M')
            {
                // I stay, open and ad flow
                string me = this.positionMe;
                int newFlowRate = this.FlowAtEnd + (allData[me].FlowRate * TimeLeft);

                Dictionary<string, bool> newValveStates = CopyValveStates(this.ValveStates);
                newValveStates[me] = true;

                // Elephant moves to every possible connection
                foreach (var connection in allData[this.positionElephant].Connections)
                {
                    DuoPath newPath = new DuoPath(false, newValveStates, new string[] { connection, me}, newFlowRate, this.ValvesLeftToOpen - 1);
                    newPath.pathWalkers[0].StepsSindsLastOpening = 1;
                    newPath.pathWalkers[1].StepsSindsLastOpening = 0;
                }
            }
            else
            {
                throw new ArgumentException("specify the side to be opened");
            }
        }
        private void OpenTwoValve()
        {
            Dictionary<string, bool> newValveStates = CopyValveStates(this.ValveStates);
            newValveStates[this.positionElephant] = true;
            newValveStates[this.positionMe] = true;

            int newFlowAtEnd = this.FlowAtEnd + ((allData[this.positionElephant].FlowRate + allData[this.positionMe].FlowRate) * TimeLeft);

            DuoPath newPath = new DuoPath(false, newValveStates, new string[] { this.positionElephant, this.positionMe }, newFlowAtEnd, this.ValvesLeftToOpen - 2);
            newPath.pathWalkers[0].StepsSindsLastOpening = 0;
            newPath.pathWalkers[1].StepsSindsLastOpening = 0;
        }
        private static void Step()
        {
            Console.WriteLine($"{DateTime.Now.TimeOfDay}\n Highest flow: {HighestReportedEndFlow}\tPaths dirty: {allPaths.Count}");

            FindDeadEnds();

            CleanUpDeadEnds();

            Console.WriteLine($" Time left: {TimeLeft}\t\tPaths clean: {allPaths.Count}\n{DateTime.Now.TimeOfDay}\n");

            TimeLeft = -1;

            ImmutableList<DuoPath> currentPaths = AllPaths;
            allPaths.Clear();

            // To use path index later
            int nbrOfPathsThisStep = currentPaths.Count;
            for (int i = 0; i < nbrOfPathsThisStep; i++)
            {

                // Make it a variable for readability
                // It a reference type after all, so lets make the most of that
                DuoPath currentPath = currentPaths[i];
                Dictionary<string, bool> currentValveStates = currentPath.ValveStates;


                // Open No Valves
                currentPath.OpenNoValves();

                if (currentPath.positionElephant == currentPath.positionMe)
                { // If we are at the same position

                    if (currentValveStates[currentPath.positionElephant] == false)
                    { // And that valve is still closed, Elephant stays to open the valve
                        currentPath.OpenOneValve('E');
                    }
                    else
                    {
                        // End path
                    }
                }
                else
                {   // We are not at the same valve

                    if (currentValveStates[currentPath.positionMe] == false && currentValveStates[currentPath.positionElephant] == false)
                    { // If they are both closed

                        // Open only Elephant valve
                        currentPath.OpenOneValve('E');

                        // Open only My valve
                        currentPath.OpenOneValve('M');

                        // Open both valves
                        currentPath.OpenTwoValve();

                    }
                    else if (currentValveStates[currentPath.positionMe] == true && currentValveStates[currentPath.positionElephant] == true)
                    { // If the are both already open

                        // End path
                    }
                    else
                    {   // One of the 2 valves is closes

                        if (currentValveStates[currentPath.positionElephant] == false)
                        { // Elephant is at the valve that is still closed

                            currentPath.OpenOneValve('E');
                        }
                        else
                        { // I am at the valve that is still closed

                            currentPath.OpenOneValve('M');
                        }
                    }
                }

                currentPath.Ended = true;

            }

            if (TimeLeft == 0)
            {
                //End steps.
                return;
            }
            // Else: Go again.



            Step();
        }

        public static void RunSimulation(string startNode)
        {
            // Set defaults
            Dictionary<string, bool> initialValveStates = new Dictionary<string, bool>();
            int valvesWithFlowPotential = 0;
            foreach (var valve in allData)
            {
                if (valve.Value.FlowRate > 0)
                {
                    valvesWithFlowPotential++;
                    initialValveStates.Add(valve.Key, false);
                }
                else
                {
                    // set valves without flow-potential to open by default
                    initialValveStates.Add(valve.Key, true);
                }
            }

            DuoPath startPoint = new DuoPath(false, initialValveStates, new string[] { startNode, startNode }, 0, valvesWithFlowPotential);



            // Run the steps
            Step();


            // Get conclusions


            // Print conclusions
        }
    }
}