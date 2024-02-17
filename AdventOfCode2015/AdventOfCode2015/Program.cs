namespace AdventOfCode2015
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Day? : ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "1":
                    Day1.PartPicker();
                    break;
                case "2":
                    Day2.PartPicker();
                    break;
                case "3":
                    Day3.PartPicker();
                    break;
                case "4":
                    Day4.PartPicker();
                    break;
                case "5":
                    Day5.PartPicker();
                    break;
                case "6":
                    Day6.PartPicker();
                    break;
                case "7":
                    Day7.PartPicker();
                    break;
                case "8":
                    Day2.PartPicker();
                    break;
                case "9":
                    Day3.PartPicker();
                    break;
                case "10":
                    Day4.PartPicker();
                    break;
                case "11":
                    Day5.PartPicker();
                    break;
                case "12":
                    Day6.PartPicker();
                    break;
                default:
                    Console.WriteLine("Not Possible");
                    Main();
                    break;
            }
        }
    }
}