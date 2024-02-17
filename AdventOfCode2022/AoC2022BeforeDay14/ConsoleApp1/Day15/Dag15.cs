
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading.Channels;
using static AdventOfCode.Day15.Day15;
using static AdventOfCode.GetValue;
using static AdventOfCode.Day15.Sensor;


namespace AdventOfCode.Day15
{
    internal class Day15 // Manhattan Distance // Part 2 Is A Nice One To Optimize =) 
    {
        private static List<SensorBeaconPair> AllCoordinats = new List<SensorBeaconPair>();

        public static void Main()
        {
            Console.Write("Part ? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Part1Try4();
            }
            else if (choice == "x")
            {
                Part2Try2();
            }
            else if (choice == "2")
            {
                Part2Try3Refactor();
            }
            else
            {
                Console.WriteLine("Not possible..");
                Main();
            }
        }
        public class SensorBeaconPair
        {
            private Coordinats sensor;
            public Coordinats Sensor
            {
                set
                {
                    sensor = value;
                }
                get
                {
                    return sensor;
                }
            }
            private Coordinats beacon;
            public Coordinats Beacon
            {
                set
                {
                    beacon = value;
                }
                get
                {
                    return beacon;
                }
            }
            public SensorBeaconPair(Coordinats sensorLocation, Coordinats beaconLocation)
            {
                Sensor = sensorLocation;
                Beacon = beaconLocation;
            }

            public override string ToString()
            {
                return $"Sensor at {Sensor}, Beacon at {Beacon}";
            }
        }
        private static void LoadData()
        {

            int[,,] data = Input.Day15.Demo();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                AllCoordinats.Add(new SensorBeaconPair(new Coordinats(data[i, 0, 0], data[i, 0, 1]), new Coordinats(data[i, 1, 0], data[i, 1, 1])));
            }
        }

        public static void Part1Try1()
        {
            //    int[,,] data = Input.Day15();

            //    // min -792661
            //    // max 4064129
            //    // dif 4856790

            //    char[,] datamap = Printers.InitiateCharMap(5000000, 5000000);

            //    int correction = 800000;
            //    // alles +800000

            //    for (int i = 0; i < data.GetLength(0); i++)
            //    {
            //        // Sensor
            //        int xS = data[i, 0, 0];
            //        int yS = data[i, 0, 1];
            //        //Beacon
            //        int xB = data[i, 1, 0];
            //        int yB = data[i, 1, 1];

            //        int difX = Math.Abs(xS - xB);
            //        int difY = Math.Abs(yS - yB);
            //        int dif = difX + difY;

            //        int[] start = { yS - dif + correction, yB + correction };

            //        for (int j = 0; j < dif; j++)
            //        {
            //            Day14.AlterRockMap(datamap, start, 1, j);
            //            Day14.AlterRockMap(datamap, start, 3, j);
            //            start[0]++;
            //        }
            //        for (int j = dif; j > 0; j--)
            //        {
            //            Day14.AlterRockMap(datamap, start, 1, j);
            //            Day14.AlterRockMap(datamap, start, 3, j);
            //            start[0]++;
            //        }
            //        Printers.DrawCharMap(datamap);

            //    }

        }

        public static void Part1Try2()
        {
            LoadData();
            int referenceRow = 2000000;
            bool inRange = false;
            int maxReachX = 0;
            int minReachX = 2000000000;


            for (int i = 0; i < AllCoordinats.Count; i++)
            {
                SensorBeaconPair pair = AllCoordinats[i];
                int manhattanDistance = GetValue.SetSign.Positive(pair.Sensor.X - pair.Beacon.X) + GetValue.SetSign.Positive(pair.Sensor.Y - pair.Beacon.Y);
                int maxReachY = pair.Sensor.Y + manhattanDistance;
                int minReachY = pair.Sensor.Y - manhattanDistance;

                if (referenceRow <= maxReachY && referenceRow >= minReachY)
                {
                    //in range of row 2.000.000
                    inRange = true;
                    if (pair.Sensor.X - manhattanDistance < minReachX)
                    {
                        minReachX = pair.Sensor.X - manhattanDistance;
                    }
                    if (pair.Sensor.X + manhattanDistance > maxReachX)
                    {
                        maxReachX = pair.Sensor.X + manhattanDistance;
                    }
                }
                else
                {
                    inRange = false;
                    AllCoordinats.Remove(pair);
                    i--;
                }
            }

            //Console.WriteLine("max x = " + maxReachX); // 4408356 
            //Console.WriteLine("min x = " + minReachX); //-2509639

            int xRange = maxReachX - minReachX;
            //Console.WriteLine(xRange); // 6917995

            char[] rowY = new char[xRange];

            foreach (SensorBeaconPair pair in AllCoordinats)
            {
                //Console.WriteLine(pair);
                int manhattanDistance = GetValue.SetSign.Positive(pair.Sensor.X - pair.Beacon.X) + GetValue.SetSign.Positive(pair.Sensor.Y - pair.Beacon.Y);
                int xStart = pair.Sensor.X - minReachX;

                int yDiff = GetValue.SetSign.Positive(pair.Sensor.Y - referenceRow);
                int straal = manhattanDistance - yDiff;

                rowY[xStart] = 'X';
                for (int i = 0; i < straal; i++)
                {
                    rowY[xStart + i] = 'X';
                    rowY[xStart - i] = 'X';
                }
            }


            int checkedIndexes = 0;
            foreach (char check in rowY)
            {
                if (check == 'X')
                {
                    checkedIndexes++;
                }
            }
            Console.WriteLine(checkedIndexes);


            // 4652213 is to low
            // 4652215 is to low
            // 4591887
        }

        public static void Part1Try3()
        {

            //LoadData();
            //int referenceRow = 10;

            //char[] rowY = new char[12000000];

            //foreach (SensorBeaconPair pair in AllCoordinats)
            //{
            //    Console.WriteLine(pair);
            //    int manhattanDistance = GetManhattanDistance(pair.Sensor.X, pair.Sensor.Y, pair.Beacon.X, pair.Beacon.Y);
            //    int maxReachY = pair.Sensor.Y + manhattanDistance;
            //    int minReachY = pair.Sensor.Y - manhattanDistance;
            //    int offset = 3000000;
            //    if (referenceRow <= maxReachY && referenceRow >= minReachY)
            //    {
            //        int yIndex = pair.Sensor.X + offset;
            //        int range = GetValue.SetSign.Positive(pair.Sensor.Y - referenceRow);
            //        rowY[yIndex] = 'X';
            //        for (int i = 1; i <= range; i++)
            //        {
            //            rowY[yIndex - i] = 'X';
            //            rowY[yIndex + i] = 'X';
            //        }
            //    }
            //}

            //int checkedCount = 0;
            //foreach(char check in rowY)
            //{
            //    if(check == 'X')
            //    {
            //        checkedCount++;
            //    }
            //}

            //Console.WriteLine(checkedCount);



        }


        public static void Part1Try4()
        {
            int y = 2000000;

            int[,,] allData = Input.Day15.Full();

            for (int pair = 0; pair < allData.GetLength(0); pair++)
            {
                new Sensor(new int[,] { { allData[pair, 0, 0], allData[pair, 0, 1] }, { allData[pair, 1, 0], allData[pair, 1, 1] } });
                new Beacon(new int[] { allData[pair, 1, 0], allData[pair, 1, 1] });
            }



            //List<int> xs = new List<int>();
            //List<int[]> ranges = new List<int[]>();

            Dictionary<int, bool> xDic = new Dictionary<int, bool>();

            int sensorNbr = 0;

            foreach (Sensor sensor in Sensor.AllSensors)
            {
                sensorNbr++;
                Console.WriteLine($"Sensor nbr: {sensorNbr}");
                if (sensor.Pos.Y - sensor.Range <= y && sensor.Pos.Y + sensor.Range >= y)
                {
                    //y = in range

                    // Width = 1 + ((dif(y , sy) - range).setSignPos) * 2

                    // Diff = (y) - (sy)

                    int radiusOfRange = GetValue.SetSign.Positive(GetValue.SetSign.Positive(y - sensor.Pos.Y) - sensor.Range);

                    xDic[sensor.Pos.X] = true;

                    //if (!xs.Contains(sensor.Pos.X))
                    //{
                    //    xs.Add(sensor.Pos.X);
                    //}
                    for (int r = 1; r <= radiusOfRange; r++)
                    {
                        xDic[sensor.Pos.X + r] = true;
                        xDic[sensor.Pos.X - r] = true;


                        //if (!xs.Contains(sensor.Pos.X - r))
                        //{
                        //    xs.Add(sensor.Pos.X - r);
                        //}
                        //if (!xs.Contains(sensor.Pos.X + r))
                        //{
                        //    xs.Add(sensor.Pos.X + r);
                        //}
                    }
                }
            }
            List<int> exclude = new List<int>();
            foreach (Sensor sensor in Sensor.AllSensors)
            {
                if (sensor.Pos.Y == y)
                {
                    if (!exclude.Contains(sensor.Pos.X))
                    {
                        exclude.Add(sensor.Pos.X);
                    }
                }
            }
            foreach (Beacon beacon in Beacon.AllBeacons)
            {
                if (beacon.Pos.Y == y)
                {
                    if (!exclude.Contains(beacon.Pos.X))
                    {
                        exclude.Add(beacon.Pos.X);
                    }
                }
            }







            Console.WriteLine(xDic.Count - exclude.Count);

            Console.WriteLine();


        }
        public static void Part2Try1()
        {
            int maxX = 4000000;
            int maxY = maxX;

            int[,,] allData = Input.Day15.Full();

            for (int pair = 0; pair < allData.GetLength(0); pair++)
            {
                new Sensor(new int[,] { { allData[pair, 0, 0], allData[pair, 0, 1] }, { allData[pair, 1, 0], allData[pair, 1, 1] } });
            }
            int x = 0;
            int y = 0;
            try
            {
                for (x = 0; x <= maxX; x++)
                {
                    if (x % 100 == 0)
                    {
                        Console.WriteLine("x = " + x);
                    }
                    for (y = 0; y <= maxY; y++)
                    {
                        bool untouched = true;
                        foreach (Sensor sensor in Sensor.AllSensors)
                        {
                            if (sensor.Range >= ManhattanDistance(sensor.Pos.X, sensor.Pos.Y, x, y))
                            {

                                // covered
                                untouched = false;
                                break;
                            }
                        }
                        if (untouched)
                        {
                            throw new Exception($"x = {x}, y = {y}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"found uncovered position at: {e.Message}");
            }

            Console.WriteLine(x * 4000000 + y);

            // TO SLOW
        }
        public static void Part2Try2()
        {

            int maxX = 4000000;
            int maxY = maxX;


            int[,,] allData = Input.Day15.Full();

            for (int pair = 0; pair < allData.GetLength(0); pair++)
            {
                new Sensor(new int[,] { { allData[pair, 0, 0], allData[pair, 0, 1] }, { allData[pair, 1, 0], allData[pair, 1, 1] } });
            }
            string checkedUntillFile = File.ReadAllText(@"C:\Users\BertP\Documents\AP\Semester 1\ProgrammerenIntro C#\AdventOfCode\ConsoleApp1\CheckedUntill.txt");

            int y = Convert.ToInt32(checkedUntillFile);
            int x = 0;


            try
            {
                long now = DateTime.Now.Ticks;

                // not in the first 12500
                // not in the first 35500
                // not in the first 45500
                for (y = y; y <= maxY; y++)
                {
                    if (y % 1000 == 0)
                    {
                        Console.WriteLine("y = " + y);
                        Console.WriteLine($"In {Math.Round((DateTime.Now.Ticks - now) / 10000000.0, 3)} seconds");

                        File.WriteAllText(@"C:\Users\BertP\Documents\AP\Semester 1\ProgrammerenIntro C#\AdventOfCode\ConsoleApp1\CheckedUntill.txt", Convert.ToString(y));
                        now = DateTime.Now.Ticks;
                    }

                    bool[] xs = new bool[maxX + 1];

                    foreach (Sensor sensor in Sensor.AllSensors)
                    {
                        if (sensor.Pos.Y - sensor.Range <= y && sensor.Pos.Y + sensor.Range >= y)
                        {
                            int radiusOfRange = GetValue.SetSign.Positive(GetValue.SetSign.Positive(y - sensor.Pos.Y) - sensor.Range);

                            xs[sensor.Pos.X] = true;

                            for (int r = 1; r <= radiusOfRange; r++)
                            {
                                if (sensor.Pos.X + r <= maxX)
                                {
                                    xs[sensor.Pos.X + r] = true;
                                }
                                if (sensor.Pos.X - r >= 0)
                                {
                                    xs[sensor.Pos.X - r] = true;
                                }

                            }
                        }
                    }

                    for (x = 0; x < xs.Length; x++)
                    {
                        if (!xs[x])
                        {
                            throw new Exception($"x = {x}, y = {y}");
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"found uncovered position at: {e.Message}");
            }

            Console.WriteLine(x * 4000000 + y);
        }
        public static void CompairRanges(int[] arr1, int[] arr2)
        {

            if (arr1[0] < arr2[0] && arr1.Last() < arr2.Last())
            {
                throw new Exception("+");
            }
            else if (arr1[0] > arr2[0] && arr1.Last() > arr2.Last())
            {
                throw new Exception("-");
            }
            else if (arr1[0] <= arr2[0] && arr1.Last() >= arr2.Last())
            {
                throw new Exception("1");
            }
            else if (arr1[0] >= arr2[0] && arr1.Last() <= arr2.Last())
            {
                throw new Exception("2");
            }




        }
        public static List<int[]> SortRanges(List<int[]> ranges)
        {

            List<int[]> sorted = ranges;
            ImmutableList<int[]> gettingSorted;

            bool sorting = true;
            while (sorting)
            {
                sorting = false;

                gettingSorted = sorted.ToImmutableList();
                sorted.Clear();


                int index1 = 0;
                int index2 = 1;


                for (int i = 0; i < gettingSorted.Count; i++)
                {
                    try
                    {
                        CompairRanges(gettingSorted[index1], gettingSorted[index2]);

                        //debug
                        Console.WriteLine(" => runtrough");
                    }
                    catch (Exception e)
                    {
                        if (e.Message == "+")
                        {
                            sorted.Add(gettingSorted[index1]);
                            index1 = index2;
                            index2 = i + 2;
                        }
                        else if (e.Message == "-")
                        {
                            sorted.Add(gettingSorted[index2]);
                            index1 = index1;
                            index2++;
                            sorting = true;
                        }
                        else if (e.Message == "1")
                        { // Keep 1

                            index1 = index1;
                            index2++;
                            sorting = true;
                        }
                        else if (e.Message == "2")
                        { // Keep 2
                            index1 = index2;
                            index2 = i + 2;
                            sorting = true;
                        }
                        else
                        {
                            if (i + 1 == gettingSorted.Count) // last one
                            {
                                sorted.Add(gettingSorted[index1]);
                            }
                            else
                            {
                                Console.WriteLine("Something went wrong 1");
                            }
                        }
                    }

                }

            }
            return sorted;

        }

        public static void Part2Try3()
        {
            long nowStart = DateTime.Now.Ticks;
            //Dictionary<int,Dictionary<int, bool>> checkedPoints = new Dictionary<int,Dictionary<int, bool>>();
            Dictionary<int, List<int[]>> checkedRanges = new Dictionary<int, List<int[]>>();

            int maxX = 4000000;
            int maxY = maxX;

            for (int yi = 0; yi <= maxY; yi++)
            {
                checkedRanges.Add(yi, new List<int[]>());
            }

            int y = 0;
            int x = 0;

            // Getting the full dataset
            int[,,] allData = Input.Day15.Full();

            // Formating the full dataset to Sensor object
            for (int pair = 0; pair < allData.GetLength(0); pair++)
            {
                new Sensor(new int[,] { { allData[pair, 0, 0], allData[pair, 0, 1] }, { allData[pair, 1, 0], allData[pair, 1, 1] } });
            }

            long now = DateTime.Now.Ticks;

            int sensorNr = 0;
            foreach (Sensor sensor in Sensor.AllSensors)
            {
                sensorNr++;
                //Console.WriteLine("Sensor: " + sensorNr);
                //Console.WriteLine($"In {Math.Round((DateTime.Now.Ticks - now) / 10000000.0, 3)} seconds");

                //now = DateTime.Now.Ticks;



                int ymin = sensor.Pos.Y - sensor.Range;
                int ymax = sensor.Pos.Y + sensor.Range;
                if (ymin < 0)
                {
                    ymin = 0;
                }
                if (ymax > maxY)
                {
                    ymax = maxY;
                }

                for (y = ymin; y <= ymax; y++)
                {
                    int radiusOfRange = GetValue.SetSign.Positive(GetValue.SetSign.Positive(y - sensor.Pos.Y) - sensor.Range);
                    int xmin = sensor.Pos.X - radiusOfRange;
                    int xmax = sensor.Pos.X + radiusOfRange;
                    if (xmin < 0)
                    {
                        xmin = 0;
                    }
                    if (xmax > maxX)
                    {
                        xmax = maxX;
                    }

                    checkedRanges[y].Add(new int[] { xmin, xmax });

                    //for(x = xmin; x <= xmax; x++)
                    //{

                    //    thisY[x] = true;
                    //}

                }

            }

            //for(int line = 0; line < checkedRanges.Count; line++)
            //{
            //    checkedRanges[line] = SortRanges(checkedRanges[line]);
            //}


            int i = 0;
            int ranges = 0;

            int lookFor = 0;

            bool finding = true;
            while (finding)
            {
                for (ranges = 0; ranges < checkedRanges.Count; ranges++)
                {
                    finding = false;


                    lookFor = 0;
                    int stopAt = maxX;

                    List<int[]> theseRanges = checkedRanges[ranges];
                    // For readability


                    for (i = 0; i < theseRanges.Count; i++)
                    {
                        if (theseRanges[i][0] <= lookFor && theseRanges[i][1] > lookFor)
                        {
                            if (theseRanges[i][1] >= stopAt)
                            {
                                finding = true;
                                break;
                            }
                            else
                            {
                                lookFor = theseRanges[i][1];

                                i = -1;
                            }
                        }
                    }

                    if (finding == false)
                    {
                        break;
                    }

                }


            }

            Console.WriteLine($"x = {lookFor + 1}, y ={ranges}");

            Console.WriteLine();



            //try
            //{
            //    for (y = 0; y <= maxY; y++)
            //    {
            //        for (x = 0; x <= maxX; x++)
            //        {
            //            if (!checkedPoints[y][x])
            //            {
            //                throw new Exception($"x = {x}, y = {y}");
            //            }
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"found uncovered position at: {e.Message}");
            //}


            Console.WriteLine((lookFor + 1) * 4000000.0 + ranges);

            Console.WriteLine($"In {Math.Round((DateTime.Now.Ticks - nowStart) / 10000000.0, 3)} seconds");
        } //12,5 second
        public static void Part2Try3Refactor()
        {
            // Start Timer
            long nowStart = DateTime.Now.Ticks;

            // All the X-ranges of all the beacons per Y-line
            Dictionary<int, List<int[]>> collectedXRanges = new Dictionary<int/*Y*/, List<int[]/*XCoverages*/>>();
            // So if a beacon covers y:12 from x:3 until x:9 the Dictionary will contain a int[3,9] in the List at Key:12

            // Max distance to search 
            int max = 4000000;

            // Initialize the Dictionary
            for (int y = 0; y <= max; y++)
            {
                collectedXRanges.Add(y, new List<int[]>());
            }


            // Reference the full dataset for readability
            int[,,] allData = Input.Day15.Full();

            // Going trough all the sensors
            for (int pair = 0; pair < allData.GetLength(0); pair++)
            {

                //Define the sensor parameters
                int sensorX = allData[pair, 0, 0];
                int sensorY = allData[pair, 0, 1];

                int mhtnDsta = ManhattanDistance(sensorX, sensorY, allData[pair, 1, 0], allData[pair, 1, 1]);



                // Until
                int ymax = sensorY + mhtnDsta;
                int sensorRangeOnThisY;

                //For the Y-reach of this sensor
                for (int y = mhtnDsta > sensorY ? 0 : sensorY - mhtnDsta; y <= ymax && y <= max; y++)
                {
                    sensorRangeOnThisY = GetValue.SetSign.Positive(GetValue.SetSign.Positive(y - sensorY) - mhtnDsta);
                    collectedXRanges[y].Add(new int[] { sensorRangeOnThisY > sensorX ? 0 : sensorX - sensorRangeOnThisY, sensorX + sensorRangeOnThisY });

                }

            }

            int startOfNextRange;
            double frecuency = 0;

            for (int y = 0; y <= max; y++)
            {
                startOfNextRange = 0;
                while (startOfNextRange < max)
                {
                    int[] currentRange = collectedXRanges[y].Find(r => r[0] <= startOfNextRange && r[1] > startOfNextRange);
                    if (currentRange is null)
                    {
                        // Calculate the puzzle answer
                        frecuency = (startOfNextRange) * 4000000.0 + y;
                        y = max;
                        break;
                    }
                    startOfNextRange = currentRange[1] + 1;

                }
            }

            // Print total runtime
            Console.WriteLine($"In {Math.Round((DateTime.Now.Ticks - nowStart) / 10000000.0, 3)} seconds\n");

            // This is the correct answer
            double target = 13081194638237;

            //Console.WriteLine($"x = {lookFor + 1}, y ={ranges}");
            Console.WriteLine("Makes: {0}", frecuency);
            Console.WriteLine($"Targt: {target}\n");
            Console.WriteLine(frecuency == target ? "Pass" : "Fail");
        }
    }
}
