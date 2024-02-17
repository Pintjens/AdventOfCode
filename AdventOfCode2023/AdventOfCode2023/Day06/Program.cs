namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string demo = "Time:      7  15   30\r\nDistance:  9  40  200";

            string temp = /*correct input string here*/ demo;
            for (int i = 0; i < 9; i++)
            {
                temp = temp.Replace("  ", " ");
            }
            temp = temp.Replace("Time: ", "").Replace("Distance: ", "");

            string[] split = temp.Split("\r\n");
            string[] times = split[0].Split(' ');
            string[] distances = split[1].Split(' ');

            List<ulong[]> races = new List<ulong[]>();

            split = temp.Replace(" ", "").Split("\r\n");
            races.Add(new ulong[] { ulong.Parse(split[0]), ulong.Parse(split[1])});

            for (int i = 0; i < times.Length; i++)
            {
                races.Add(new ulong[] { ulong.Parse(times[i]), ulong.Parse(distances[i]) });
            }

            ulong marginOfError = 1;
            ulong part2 = 0;

            for(int r = 0; r < races.Count; r++)
            {
                ulong firstWinOption = 0;
                ulong lastWinOption = 0;
                ulong pressTime = 0;
                while (firstWinOption == 0)
                {
                    if ((races[r][0] - pressTime) * pressTime > races[r][1]) firstWinOption = pressTime; 
                    pressTime++;
                }

                pressTime = races[r][0];
                while (lastWinOption == 0)
                {
                    if ((races[r][0] - pressTime) * pressTime > races[r][1]) lastWinOption = pressTime;
                    pressTime--;
                }

                if (r == 0) part2 = lastWinOption - firstWinOption + 1; 
                else marginOfError *= (lastWinOption - firstWinOption +1);
            }
            Console.WriteLine("Part 1: " + marginOfError);
            Console.WriteLine("Part 2: " + part2);
        }
    }
}
