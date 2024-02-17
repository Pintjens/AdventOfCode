namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "Game 1: 2 blue, 4 green; 7 blue, 1 red, 14 green; 5 blue, 13 green, 1 red; 1 red, 7 blue, 11 green\r\nGame 2: 6 blue, 3 green; 4 red, 1 green, 7 blue; 2 green\r\nGame 3: 4 blue, 3 red; 2 blue, 4 red, 7 green; 1 blue, 6 red, 7 green; 5 green, 10 blue; 9 green, 1 blue, 6 red; 8 blue, 1 red, 12 green\r\nGame 4: 15 blue, 4 green, 5 red; 2 red, 2 green, 5 blue; 3 green, 13 blue; 17 blue, 1 green, 5 red\r\nGame 5: 11 green, 4 red, 3 blue; 8 blue, 6 green; 8 green, 2 red, 9 blue; 4 red, 16 blue; 8 blue, 10 red, 6 green; 9 blue, 3 red, 10 green\r\nGame 6: 4 green, 9 red, 2 blue; 7 red, 2 green, 15 blue; 13 red, 2 green, 6 blue; 5 green, 7 blue, 6 red; 19 red, 15 blue, 4 green\r\nGame 7: 12 blue, 5 red; 5 green, 6 blue; 5 red, 15 blue; 5 blue, 5 red, 5 green; 1 green, 11 blue, 2 red\r\nGame 8: 6 red, 11 green; 5 red, 2 blue, 7 green; 7 red, 6 green\r\nGame 9: 5 red, 1 blue, 11 green; 4 green, 1 blue; 8 green, 2 red; 1 green, 2 red, 2 blue; 3 green, 2 red\r\nGame 10: 7 blue, 4 red, 11 green; 13 green, 1 red, 1 blue; 7 blue, 6 green\r\nGame 11: 4 blue, 7 red, 2 green; 1 green, 14 red, 3 blue; 2 green, 5 red, 3 blue\r\nGame 12: 6 green, 6 blue, 1 red; 1 green, 3 red, 2 blue; 2 blue, 6 red, 7 green\r\nGame 13: 6 red, 10 green, 13 blue; 3 red, 12 green, 9 blue; 11 blue, 1 green; 4 red, 3 blue, 13 green; 12 green, 10 blue, 6 red; 13 blue, 3 green, 3 red\r\nGame 14: 8 green, 1 blue, 17 red; 7 green, 11 blue, 19 red; 19 red, 9 blue, 2 green; 8 green, 20 red, 12 blue; 16 red, 3 green, 11 blue\r\nGame 15: 3 red, 1 green, 5 blue; 9 blue, 4 green; 6 blue, 5 green, 9 red\r\nGame 16: 13 blue, 1 red; 2 blue, 2 green; 1 green; 10 blue, 8 red; 4 red, 3 green, 9 blue\r\nGame 17: 10 blue, 2 red; 3 green, 4 red; 6 blue, 1 red, 6 green; 5 green, 7 blue, 5 red\r\nGame 18: 3 red, 1 green; 2 red, 5 blue; 5 blue, 2 red\r\nGame 19: 7 green, 4 blue, 1 red; 1 green, 4 blue, 4 red; 6 blue, 8 green; 4 green, 2 blue, 1 red; 1 red, 1 blue, 2 green\r\nGame 20: 13 green, 1 red, 1 blue; 12 green, 1 blue; 5 green, 1 blue, 2 red; 16 green, 3 red; 2 red, 9 green\r\nGame 21: 8 red, 2 green, 2 blue; 5 red, 3 blue; 2 blue, 5 red, 2 green; 7 blue\r\nGame 22: 9 red, 12 blue, 7 green; 7 red, 13 blue, 4 green; 9 blue, 13 red, 1 green; 3 blue, 4 red, 5 green\r\nGame 23: 7 green, 12 red; 6 red, 7 green, 4 blue; 1 blue, 11 red, 5 green; 4 green, 2 blue, 6 red; 12 green, 6 red, 3 blue\r\nGame 24: 11 red, 4 blue; 9 blue, 6 green, 17 red; 8 green, 2 red; 16 blue, 6 red, 2 green\r\nGame 25: 7 red, 4 blue; 7 blue, 4 green; 10 blue, 4 red, 2 green; 6 green, 4 blue, 1 red; 10 blue, 2 red, 4 green\r\nGame 26: 7 green, 8 red, 6 blue; 5 red, 3 green, 2 blue; 13 blue, 6 green, 5 red; 10 blue, 4 red, 8 green; 2 red, 2 blue, 1 green; 8 blue, 1 green, 4 red\r\nGame 27: 7 green, 3 blue, 13 red; 1 green, 17 red, 1 blue; 16 red, 3 blue, 3 green; 5 green, 3 red, 5 blue; 13 red, 4 green, 8 blue; 6 blue, 2 green, 15 red\r\nGame 28: 8 blue, 5 red, 18 green; 1 green, 6 red; 7 blue, 18 green, 5 red; 16 green, 3 red, 7 blue; 6 blue, 18 green; 8 blue, 8 green, 7 red\r\nGame 29: 4 blue, 1 red; 6 blue, 1 red; 17 blue, 1 green\r\nGame 30: 1 red, 2 green, 5 blue; 2 blue, 7 green, 6 red; 11 blue, 4 red, 2 green; 5 green, 6 blue, 4 red; 5 red, 8 blue, 7 green\r\nGame 31: 10 green, 9 blue; 5 green, 9 blue, 1 red; 1 red, 8 blue\r\nGame 32: 3 red, 5 green; 5 red, 5 blue, 14 green; 2 red, 2 green; 11 green, 3 red, 5 blue\r\nGame 33: 7 blue, 10 green, 8 red; 18 blue, 15 green, 4 red; 6 red, 1 green; 18 blue, 8 red, 11 green\r\nGame 34: 3 green; 2 red, 5 green; 5 blue, 3 green; 3 blue, 5 green, 1 red\r\nGame 35: 1 blue, 5 green, 6 red; 3 green, 2 red, 3 blue; 4 red, 9 blue, 3 green; 1 green, 12 blue, 1 red\r\nGame 36: 14 green, 3 blue, 16 red; 1 green, 2 red, 4 blue; 4 blue, 9 green, 18 red; 4 blue, 4 green, 14 red; 4 blue, 11 green\r\nGame 37: 7 green, 2 blue, 3 red; 8 green, 9 red, 2 blue; 4 blue, 15 green, 18 red\r\nGame 38: 11 red, 1 blue, 6 green; 6 green, 2 blue, 1 red; 6 blue, 17 red, 2 green; 17 red, 9 blue, 3 green; 7 red, 7 blue, 3 green; 3 green, 7 red, 7 blue\r\nGame 39: 1 blue, 2 green; 1 blue, 2 green, 7 red; 1 blue, 4 red, 2 green; 1 blue, 12 red\r\nGame 40: 1 blue, 4 red, 15 green; 12 green, 1 blue, 15 red; 15 red, 8 green\r\nGame 41: 5 blue, 5 green, 1 red; 9 red, 8 green, 9 blue; 10 red, 10 blue, 4 green; 3 blue, 17 red, 3 green; 3 blue, 4 red, 2 green\r\nGame 42: 2 blue, 10 red, 17 green; 6 red, 10 green, 10 blue; 3 blue, 6 green, 8 red; 9 green, 2 blue, 8 red; 13 green, 5 blue; 4 red, 18 green, 11 blue\r\nGame 43: 8 red, 3 blue, 6 green; 2 red, 8 green, 10 blue; 5 blue, 9 red, 9 green; 1 green, 15 red, 8 blue\r\nGame 44: 11 green, 19 red, 14 blue; 1 red, 19 green, 9 blue; 7 green, 8 red, 10 blue; 14 green, 8 blue, 15 red; 7 green, 3 red, 2 blue\r\nGame 45: 4 green, 9 blue, 4 red; 7 blue, 13 green, 2 red; 12 green, 10 blue, 10 red\r\nGame 46: 10 red, 2 green, 1 blue; 10 red, 10 green, 1 blue; 1 blue, 13 green; 1 blue, 2 green, 10 red; 1 blue, 7 red, 11 green; 10 red, 5 green\r\nGame 47: 3 blue, 2 green, 12 red; 5 blue, 7 red; 5 green, 14 red; 12 red, 7 green, 5 blue\r\nGame 48: 5 red, 1 blue, 3 green; 7 red, 8 green, 4 blue; 4 blue, 5 green, 17 red; 1 blue, 12 red\r\nGame 49: 2 green, 7 red, 1 blue; 11 green, 5 red; 4 red, 1 blue, 1 green; 11 green, 1 blue, 7 red\r\nGame 50: 10 red, 3 blue, 6 green; 1 blue, 5 red, 3 green; 6 blue, 11 red, 12 green; 10 green\r\nGame 51: 18 blue, 1 green, 1 red; 15 blue; 13 blue, 11 green, 4 red; 8 red, 1 green, 18 blue; 10 green, 7 blue, 8 red\r\nGame 52: 13 green, 15 blue; 6 blue, 4 red, 8 green; 6 red, 13 green, 11 blue; 2 red, 7 green, 13 blue; 12 green, 2 blue, 3 red; 6 red, 11 green, 1 blue\r\nGame 53: 2 red, 2 green; 3 green, 1 blue, 1 red; 1 blue, 4 green, 7 red; 4 red, 1 blue; 4 red, 5 green, 2 blue\r\nGame 54: 8 blue, 2 red, 5 green; 6 green, 2 blue, 3 red; 1 blue, 8 green, 4 red\r\nGame 55: 6 green, 6 blue, 3 red; 13 green, 1 red; 2 blue, 1 red, 1 green; 14 green, 1 blue, 1 red; 1 blue, 2 red, 9 green; 9 green, 2 blue, 4 red\r\nGame 56: 4 green, 6 blue, 1 red; 5 red, 3 blue; 6 red, 1 blue; 9 green, 5 blue, 7 red\r\nGame 57: 5 red, 5 green, 8 blue; 11 red, 3 blue, 8 green; 7 green, 9 blue, 11 red; 3 green, 2 blue, 12 red\r\nGame 58: 3 green, 3 red; 4 red, 1 green; 1 red, 6 green; 5 green; 5 red, 1 blue, 3 green; 3 red, 1 blue\r\nGame 59: 2 green, 2 blue; 7 red, 18 green; 2 blue, 7 red, 16 green; 7 red, 10 green\r\nGame 60: 3 blue, 4 red; 4 blue, 3 red, 3 green; 16 green\r\nGame 61: 1 blue, 2 red, 8 green; 9 blue, 4 green, 12 red; 10 green, 2 red; 5 blue, 11 red, 1 green; 10 green, 3 blue, 8 red; 5 red, 2 green\r\nGame 62: 15 red, 10 blue, 7 green; 4 blue, 9 red, 4 green; 4 red, 2 blue, 2 green; 11 green, 2 red; 8 blue, 2 green; 2 green, 8 red, 8 blue\r\nGame 63: 2 green, 3 blue, 1 red; 7 blue, 5 red; 7 blue\r\nGame 64: 3 green, 5 blue, 6 red; 9 green, 4 red; 13 red, 1 blue, 5 green; 4 blue, 13 red, 8 green\r\nGame 65: 7 green, 1 blue; 1 red, 14 blue, 4 green; 8 blue, 6 red; 14 green, 4 red\r\nGame 66: 6 red, 11 green, 7 blue; 1 blue, 6 red; 13 red, 7 blue, 3 green; 8 red, 6 blue, 15 green; 7 green, 6 blue, 4 red; 4 red, 1 blue, 20 green\r\nGame 67: 4 blue, 9 green; 15 red, 16 green, 3 blue; 1 green, 14 red, 3 blue; 3 red, 2 blue, 3 green; 4 green, 3 blue, 12 red\r\nGame 68: 5 green, 3 blue, 2 red; 4 green, 8 blue, 11 red; 6 red, 6 blue, 4 green; 8 red, 5 blue, 7 green; 6 blue, 6 green, 11 red; 2 blue, 3 green, 3 red\r\nGame 69: 15 blue, 16 green, 5 red; 10 blue, 3 red, 13 green; 4 red, 5 blue, 2 green; 1 red; 11 green, 5 red, 15 blue\r\nGame 70: 8 red, 9 blue, 12 green; 3 red, 2 blue, 14 green; 10 blue, 1 red, 18 green; 1 blue, 7 red, 16 green; 3 green, 4 red, 16 blue; 10 green, 6 red\r\nGame 71: 12 blue, 7 red, 16 green; 2 red, 9 blue, 15 green; 1 red, 11 blue, 11 green; 15 red, 16 blue, 2 green\r\nGame 72: 1 blue, 11 red, 6 green; 1 red, 2 blue, 5 green; 4 green, 2 red; 2 green, 12 red\r\nGame 73: 1 blue, 1 red; 2 red, 4 blue, 2 green; 1 blue, 2 green, 10 red; 8 red\r\nGame 74: 12 red, 1 green, 4 blue; 1 red, 5 blue, 1 green; 11 green, 16 red, 7 blue; 7 red, 1 blue, 1 green; 12 red, 11 green, 12 blue; 11 green, 6 red\r\nGame 75: 12 green, 8 red, 3 blue; 7 red, 10 green; 1 green, 7 blue, 1 red\r\nGame 76: 4 green, 1 red, 3 blue; 7 blue, 3 green, 3 red; 4 blue, 2 red, 3 green; 4 blue, 1 green\r\nGame 77: 2 green, 12 blue, 10 red; 5 blue, 7 red; 2 red, 6 green; 1 blue, 2 red, 6 green\r\nGame 78: 2 green, 4 blue, 4 red; 8 green, 10 red, 10 blue; 5 green, 8 blue, 10 red; 6 green, 2 red\r\nGame 79: 3 green, 2 blue, 11 red; 8 red, 11 green, 1 blue; 1 blue, 16 red; 5 red, 7 green, 16 blue; 12 red, 7 green, 9 blue; 4 red, 20 blue, 12 green\r\nGame 80: 3 red, 5 green; 2 blue, 4 green; 2 red, 12 green, 4 blue; 10 green, 1 blue, 1 red; 4 blue, 3 red\r\nGame 81: 1 blue, 1 green, 1 red; 5 green, 3 red, 1 blue; 1 blue, 6 green; 1 green; 1 red, 5 green, 2 blue; 1 blue, 1 red, 3 green\r\nGame 82: 7 green, 10 blue, 3 red; 10 green, 12 red, 12 blue; 18 red, 8 green, 14 blue; 3 red, 3 green, 10 blue; 3 red, 1 blue, 5 green; 1 green, 8 blue\r\nGame 83: 9 red, 3 blue; 14 blue, 8 red, 3 green; 14 blue, 5 green, 4 red\r\nGame 84: 2 blue, 3 red, 6 green; 11 green, 2 red, 1 blue; 17 green, 3 blue, 3 red; 1 red, 1 blue; 1 red, 2 blue, 19 green\r\nGame 85: 3 green, 2 blue, 3 red; 4 red, 5 blue, 8 green; 15 green, 1 red, 9 blue; 12 green, 3 blue, 2 red\r\nGame 86: 15 green, 7 red, 10 blue; 2 blue, 2 red, 1 green; 4 red, 1 green, 9 blue; 7 red, 14 blue, 5 green\r\nGame 87: 1 green, 3 blue, 1 red; 2 blue, 1 green; 1 blue, 2 green, 1 red\r\nGame 88: 2 green, 6 blue, 5 red; 5 blue, 2 red; 3 red, 13 blue; 9 blue, 10 red, 1 green\r\nGame 89: 6 green, 10 red, 2 blue; 7 red, 1 blue, 8 green; 4 blue, 3 red, 5 green; 4 green, 4 blue, 10 red\r\nGame 90: 8 red, 7 blue; 4 green, 3 red, 1 blue; 5 blue, 2 green\r\nGame 91: 15 green, 14 red; 12 red, 16 green, 2 blue; 8 red, 10 green; 1 green, 6 red; 8 green, 12 red\r\nGame 92: 4 blue, 4 green, 9 red; 1 blue, 17 green; 1 green; 15 green, 3 blue, 12 red; 11 red, 1 blue, 7 green; 7 blue, 13 red, 8 green\r\nGame 93: 10 blue, 12 red; 10 blue, 11 green, 8 red; 1 blue, 11 green, 7 red; 10 blue, 15 red, 5 green; 11 red, 8 green, 9 blue; 10 green, 3 blue\r\nGame 94: 1 blue, 2 red; 4 red, 1 green, 5 blue; 3 red, 2 green; 2 green, 2 blue; 1 red, 5 blue, 1 green; 4 blue, 1 red, 2 green\r\nGame 95: 1 red, 1 blue, 3 green; 2 green, 6 blue; 1 green, 13 blue, 1 red; 3 green, 15 blue\r\nGame 96: 16 blue, 7 green, 5 red; 5 green, 5 blue, 6 red; 3 green, 17 blue, 10 red; 13 blue, 2 red, 1 green\r\nGame 97: 12 red; 1 blue, 6 red, 1 green; 9 red, 2 blue, 1 green; 1 green, 2 blue, 1 red; 15 red, 1 blue; 1 blue\r\nGame 98: 11 red, 6 blue, 13 green; 4 blue, 2 red, 12 green; 2 blue, 8 green, 10 red\r\nGame 99: 2 red, 1 blue; 4 green; 7 green, 1 blue, 1 red; 5 green, 2 red; 1 blue, 2 red, 9 green; 2 green, 3 red\r\nGame 100: 7 red, 11 blue; 10 red, 5 blue, 1 green; 7 red, 1 green, 13 blue; 9 red; 9 red, 19 blue; 9 red, 9 blue";

            string demo = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";

            string[] gameArr = input.Split("\r\n");

            int idSum = 0;
            double powSum = 0;

            // regexpresions ?

            foreach (string game in gameArr)
            {
                string[] idsplit = game.Split(": ");

                int id = Convert.ToInt32(idsplit[0].Split(' ')[1]);

                string[] turnSplit = idsplit[1].Split("; ");

                int maxRed = 0;
                int maxGreen = 0;
                int maxBlue = 0;

                foreach (string turn in turnSplit)
                {
                    string[] turnSets = turn.Split(", ");

                    foreach (string turnSet in turnSets)
                    {
                        string[] setSplit = turnSet.Split(' ');

                        int cubeCount = Convert.ToInt32(setSplit[0]);

                        switch (setSplit[1])
                        {
                            case "red":
                                if (cubeCount > maxRed)
                                {
                                    maxRed = cubeCount;
                                }
                                break;
                            case "green":
                                if (cubeCount > maxGreen)
                                {
                                    maxGreen = cubeCount;
                                }
                                break;
                            case "blue":
                                if (cubeCount > maxBlue)
                                {
                                    maxBlue = cubeCount;
                                }
                                break;
                            default:
                                Console.WriteLine("something went wrong");
                                break;
                        }


                    }
                }

                powSum += (maxRed * maxGreen * maxBlue);

                if (maxRed <= 12 && maxGreen <= 13 && maxBlue <= 14)
                {
                    idSum += id;

                }

            }

            Console.WriteLine("id sum = " + idSum);
            Console.WriteLine("pow sum = " + powSum);

            // 4056 is to high part 1
            // 31913 to low part 2
        }
    }
}
