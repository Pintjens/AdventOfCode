namespace AdventOfCode2017
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
                    Day0.PartPicker();
                    break;
                case "3":
                    Day0.PartPicker();
                    break;
                case "4":
                    Day0.PartPicker();
                    break;
                case "5":
                    Day0.PartPicker();
                    break;
                case "6":
                    Day0.PartPicker();
                    break;
                default:
                    Console.WriteLine("Not Possible..");
                    Main();
                    break;
            }
        }
    }
}