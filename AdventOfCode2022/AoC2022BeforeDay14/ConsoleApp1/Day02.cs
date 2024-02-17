using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day02
    {
        public static void Main()
        {
            Console.Write("Part ? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("1. A la Char ?\n2. A la String ?");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Chars();
                }
                else if (choice == "2")
                {
                    Strings();
                }
                else
                {
                    Console.WriteLine("Not possible..");
                    Main();
                }
            }
            else if (choice == "2")
            {
                Part2();
            }
            else
            {
                Console.WriteLine("Not possible..");
                Main();
            }
        }
        public static void Chars()
        {

            string[] puzzelInput = { "AX", "BX", "CX", "CY", "BY", "CZ", "CX", "CY", "CY", "BY", "BY", "CZ", "CY", "AY", "BZ", "BZ", "CY", "BZ", "AY", "CY", "BY", "CY", "BY", "BX", "AY", "AY", "CY", "BX", "CX", "BY", "AY", "CZ", "CX", "BY", "BY", "AY", "CX", "BY", "BY", "BZ", "BY", "AX", "CY", "AY", "BX", "CY", "AY", "CX", "AZ", "AX", "CY", "AY", "AY", "BZ", "BY", "AY", "CY", "BZ", "CY", "AY", "AY", "CY", "BY", "BX", "BX", "CY", "BY", "BX", "AX", "BZ", "AX", "BY", "AY", "BZ", "BX", "BY", "AY", "CX", "CY", "CY", "AY", "AZ", "CZ", "AY", "BZ", "CY", "AY", "CX", "CZ", "BZ", "BY", "BY", "AY", "CZ", "CY", "BY", "AZ", "AY", "AZ", "AY", "AY", "AY", "AY", "CY", "BY", "BY", "AZ", "AY", "AY", "AX", "BZ", "CY", "AY", "BY", "BY", "AY", "AY", "BY", "BY", "CX", "CY", "BZ", "CY", "CY", "BY", "BZ", "CX", "AX", "AX", "AZ", "BY", "BZ", "CY", "CY", "CY", "AY", "CX", "BX", "BY", "BY", "CY", "CZ", "CY", "AY", "CY", "BZ", "CX", "BY", "AY", "CY", "CY", "CZ", "BX", "BY", "BY", "AY", "CZ", "CY", "BY", "CY", "BZ", "CY", "AY", "BY", "BZ", "CX", "AY", "BY", "BY", "CZ", "AY", "CY", "AX", "BY", "BY", "BY", "BZ", "BX", "CY", "BX", "CZ", "BY", "BY", "CY", "BY", "BZ", "AX", "CZ", "BY", "CY", "CY", "CX", "CX", "AY", "CY", "BZ", "CY", "BY", "CZ", "BX", "AX", "AY", "BY", "CZ", "CZ", "CY", "BX", "BX", "BX", "BY", "BX", "CY", "CY", "BX", "BY", "BZ", "BZ", "CY", "CY", "AY", "BY", "BY", "BY", "BY", "BX", "AY", "BY", "CZ", "BZ", "CY", "BY", "BY", "BX", "AY", "CZ", "CY", "CY", "CY", "CZ", "CY", "BX", "CX", "CZ", "BX", "BY", "AY", "CY", "AY", "BY", "BX", "CX", "CX", "CY", "CY", "CY", "BY", "CY", "AY", "BY", "AY", "CZ", "BY", "CY", "AY", "BY", "AY", "AY", "BX", "BY", "BY", "AX", "CX", "BX", "CY", "AY", "BY", "AY", "CZ", "BY", "CZ", "BZ", "BY", "AY", "CY", "CX", "BX", "CY", "AZ", "AX", "BZ", "AY", "BX", "CY", "CY", "CY", "AY", "CZ", "AX", "BZ", "CY", "BY", "BY", "BY", "CY", "AY", "CX", "BX", "BX", "CY", "BZ", "CY", "BX", "CY", "BY", "AY", "CY", "BZ", "AY", "AY", "CY", "BY", "BX", "AY", "CZ", "BY", "CZ", "BX", "BY", "AY", "CZ", "CY", "CY", "BY", "CY", "BX", "CY", "BY", "BX", "CY", "BX", "AX", "BY", "AZ", "CY", "AY", "BY", "BX", "CY", "BX", "CY", "CY", "BY", "CY", "CY", "BX", "BX", "CY", "AY", "BX", "CY", "BY", "AY", "BX", "BY", "AY", "AZ", "AY", "CY", "AX", "BY", "CZ", "BY", "AY", "BY", "AX", "CX", "BY", "AY", "AY", "BY", "BY", "BY", "AY", "BZ", "CX", "AY", "BX", "BY", "AZ", "BZ", "AX", "BY", "CX", "CX", "AY", "BY", "CY", "BZ", "BY", "AZ", "CZ", "AY", "AY", "AX", "BY", "BY", "CX", "AY", "CZ", "AY", "AY", "BY", "AY", "BZ", "BY", "BX", "CX", "CY", "AY", "BZ", "AY", "BY", "AY", "AY", "CY", "AX", "CY", "BX", "BX", "BY", "BX", "BZ", "BY", "CY", "CY", "CZ", "BZ", "AZ", "BY", "CY", "CY", "CY", "BY", "AY", "BZ", "CY", "CZ", "BY", "BY", "BY", "BY", "CX", "BZ", "AY", "AY", "BY", "BX", "BY", "BX", "AY", "CY", "BX", "BY", "CY", "BY", "CY", "CY", "CX", "BY", "BX", "CZ", "BY", "AY", "BX", "CY", "AZ", "CY", "CX", "BY", "CZ", "CY", "BX", "CY", "AY", "AX", "BX", "CX", "AY", "CZ", "CY", "BY", "BX", "CY", "BX", "BZ", "BZ", "BY", "BZ", "BX", "CY", "CY", "BY", "BY", "CY", "BY", "BY", "BZ", "BY", "AX", "BY", "CX", "BY", "AX", "CY", "BY", "AY", "BZ", "BZ", "AY", "AX", "CY", "BY", "BY", "CX", "AY", "CY", "BY", "CZ", "BX", "AY", "AY", "BZ", "AY", "BX", "BX", "CY", "AX", "BX", "BX", "BY", "BY", "BY", "BZ", "AY", "CY", "AY", "CY", "AZ", "CX", "BY", "CY", "BY", "CY", "BX", "BZ", "AX", "AY", "CY", "CY", "BY", "AY", "AY", "AY", "AY", "AY", "CY", "CX", "BY", "BZ", "BZ", "BY", "BZ", "BZ", "BX", "AY", "BZ", "BY", "CZ", "BY", "CZ", "AZ", "CY", "CX", "BY", "BY", "BY", "AZ", "CY", "AY", "BY", "AY", "AY", "AX", "BY", "BZ", "BX", "AX", "CZ", "BX", "CY", "BX", "BY", "BX", "AY", "BX", "BY", "CZ", "CY", "CX", "BY", "BY", "AX", "CY", "BY", "AY", "CY", "CX", "BZ", "CY", "AY", "CX", "BY", "CY", "CX", "CX", "CZ", "CY", "CX", "AY", "CY", "CY", "BX", "BX", "BY", "CZ", "BY", "BZ", "BY", "CY", "BX", "AY", "BY", "BY", "BX", "BY", "BY", "CY", "BZ", "BY", "CX", "AY", "AY", "CY", "CZ", "BY", "BX", "CY", "CY", "CY", "AY", "CX", "AY", "BY", "BX", "AY", "BY", "CY", "BX", "CY", "BY", "AY", "AZ", "CY", "BY", "CY", "AY", "BX", "BX", "BY", "CY", "BX", "BY", "CZ", "CY", "CY", "AY", "CY", "BZ", "BZ", "BY", "CY", "CZ", "AX", "BY", "BZ", "CZ", "BX", "AY", "AX", "BX", "BX", "AZ", "BX", "CY", "CY", "BY", "CY", "BY", "AY", "BY", "CX", "BZ", "CX", "BX", "CX", "BY", "CY", "CY", "BY", "BY", "CY", "CX", "BX", "AY", "CY", "AX", "BY", "BY", "BY", "CY", "BZ", "CY", "CZ", "BX", "CY", "AY", "BY", "AY", "CY", "AZ", "BZ", "BY", "AY", "BZ", "BY", "CX", "BY", "CY", "CY", "AY", "CY", "AY", "BY", "CZ", "CX", "CY", "CX", "BX", "BY", "CZ", "AY", "CY", "CZ", "CY", "CY", "CY", "BY", "BZ", "BY", "CY", "CZ", "BZ", "CY", "CX", "AZ", "BY", "AY", "BY", "BY", "AX", "CZ", "CY", "BY", "BY", "CY", "CY", "BY", "CY", "CY", "BX", "BY", "CX", "BX", "BY", "CX", "CY", "BZ", "CX", "CX", "BY", "AY", "BY", "CY", "BX", "AY", "CY", "CX", "CX", "AZ", "BZ", "AY", "CY", "CY", "AX", "AY", "BY", "BY", "CY", "CY", "CY", "CZ", "BY", "CY", "AY", "BX", "CZ", "AY", "CX", "BY", "BY", "BY", "CZ", "BY", "CY", "BY", "BX", "CY", "CY", "AY", "BY", "BY", "BX", "BY", "BZ", "BY", "AX", "CY", "BX", "BY", "BX", "BY", "BY", "CY", "CY", "CY", "BY", "BY", "BX", "AY", "CZ", "BX", "BX", "CX", "CY", "AY", "BY", "BY", "CY", "CY", "CZ", "AX", "BX", "AX", "AZ", "AX", "CY", "CY", "AX", "BY", "CZ", "BX", "CY", "BX", "BY", "BY", "BX", "CY", "BX", "AY", "BY", "BY", "BX", "BY", "CY", "BY", "BY", "CY", "CY", "BX", "CY", "BX", "CY", "CY", "CZ", "CY", "BX", "BY", "AY", "CY", "AY", "BY", "CY", "CY", "BX", "BY", "BY", "AY", "BY", "AY", "BX", "AX", "CX", "BY", "AZ", "AY", "BX", "BX", "AY", "BX", "BX", "CX", "CX", "BX", "BZ", "CZ", "AY", "BX", "BY", "BZ", "CY", "CY", "CY", "AZ", "BX", "BZ", "BX", "BY", "BZ", "BY", "BZ", "CY", "BY", "CX", "CY", "BX", "CZ", "AZ", "AX", "BY", "CY", "AY", "CY", "AY", "AX", "CY", "BY", "BY", "AY", "CY", "CX", "BZ", "BY", "BZ", "CY", "AY", "CX", "AY", "CY", "CY", "BX", "CY", "AY", "CY", "CX", "BY", "BZ", "AY", "BX", "AX", "AY", "CY", "BY", "AY", "BY", "CY", "CZ", "BX", "AY", "AY", "AY", "AZ", "AY", "BY", "CY", "CY", "BZ", "BX", "CY", "AY", "BX", "BY", "BX", "CY", "BY", "AX", "CX", "CY", "BX", "BY", "BZ", "BX", "BY", "AY", "BX", "BZ", "CY", "AY", "CX", "CZ", "CX", "AZ", "BZ", "BY", "CX", "BX", "CY", "BY", "AY", "CX", "AY", "BX", "BY", "CY", "BY", "CY", "BZ", "BX", "AY", "AX", "CY", "CY", "BY", "BY", "BY", "BY", "CZ", "AX", "CY", "CY", "BY", "BZ", "CZ", "AY", "BX", "CY", "CY", "BZ", "BY", "BY", "BX", "BZ", "BY", "CY", "CY", "CY", "BY", "AX", "AY", "CY", "AY", "AX", "AY", "CY", "BX", "CY", "CX", "BY", "BY", "CZ", "CZ", "BY", "BY", "CX", "CY", "BZ", "AY", "CX", "BX", "CY", "BY", "BZ", "AY", "BZ", "BX", "BY", "AY", "BY", "CZ", "AY", "BX", "AY", "BY", "BX", "AY", "CY", "AY", "BZ", "BZ", "BY", "AX", "AY", "CZ", "BY", "BZ", "CY", "BY", "BX", "BZ", "BY", "AX", "AY", "CZ", "CY", "AZ", "BZ", "BX", "BX", "BY", "CY", "BY", "CY", "BY", "BZ", "CZ", "BX", "AY", "CY", "CY", "CY", "CX", "CY", "AY", "BX", "AY", "BX", "AY", "CY", "AY", "BY", "BY", "CZ", "BY", "CY", "CY", "BZ", "AY", "CY", "BY", "BY", "CY", "CZ", "BX", "AY", "CX", "CY", "BY", "BX", "AY", "BY", "AY", "AX", "CX", "CY", "CY", "AY", "BY", "AY", "AY", "AY", "BX", "BZ", "CZ", "CZ", "BX", "CY", "BX", "CY", "BX", "CY", "CY", "CY", "BX", "BY", "AZ", "CY", "BX", "CY", "BY", "BY", "CY", "AY", "CY", "BX", "BY", "AX", "CY", "CY", "BY", "BX", "BZ", "CZ", "AY", "AY", "BY", "AX", "AY", "BX", "CY", "BZ", "BY", "BZ", "BY", "AY", "BY", "BY", "BX", "AX", "BZ", "BY", "AY", "BX", "BZ", "BY", "BX", "CZ", "CZ", "BX", "AY", "CY", "CY", "BY", "CY", "BY", "BY", "BY", "BX", "BZ", "BZ", "BY", "BX", "BY", "BX", "BY", "CZ", "CY", "BZ", "CZ", "CY", "BY", "CX", "CZ", "BX", "CY", "CY", "BY", "CY", "BZ", "BY", "BY", "AY", "CY", "CX", "AY", "CY", "BX", "BY", "CY", "BX", "CY", "CY", "CX", "CZ", "BX", "CX", "AY", "BX", "AY", "BZ", "AZ", "CY", "AY", "AX", "BY", "BZ", "AY", "BY", "CY", "AY", "BY", "CX", "CY", "CY", "CX", "CX", "CY", "BX", "BZ", "CX", "BY", "CY", "CY", "CY", "CZ", "BZ", "CZ", "BZ", "CX", "BY", "AZ", "CZ", "BY", "BY", "BY", "CY", "BX", "BX", "BY", "CY", "CX", "AY", "CZ", "BZ", "AY", "BY", "BZ", "CY", "BX", "CX", "AY", "BY", "BY", "CZ", "BX", "AZ", "CZ", "BX", "CY", "BX", "CY", "CX", "CY", "CY", "CY", "BY", "BZ", "BZ", "CY", "BZ", "CY", "CZ", "BY", "CY", "CY", "CZ", "BX", "AY", "BY", "BY", "BY", "AZ", "BX", "CY", "CY", "AY", "CY", "CY", "BX", "CX", "AY", "BY", "AY", "CZ", "AY", "CZ", "BZ", "AZ", "AY", "BX", "CY", "BX", "CY", "CX", "AY", "BY", "BY", "CZ", "CZ", "BZ", "CY", "BY", "BZ", "BX", "AZ", "CY", "CX", "BY", "CZ", "AY", "BX", "CX", "CX", "BZ", "CX", "BZ", "BZ", "AY", "BY", "BX", "BZ", "CX", "BY", "AY", "CY", "CY", "BY", "BZ", "CX", "BY", "BY", "CY", "AY", "CZ", "CZ", "BY", "BY", "BX", "CY", "BX", "BY", "CY", "CY", "BX", "BZ", "BY", "CZ", "AY", "AX", "CY", "AY", "BZ", "BX", "BZ", "BZ", "BY", "BY", "BY", "AY", "AX", "AY", "BY", "AY", "CY", "CY", "CY", "BY", "CY", "CY", "BX", "CY", "BY", "AY", "AY", "CZ", "BY", "BX", "CX", "BX", "BY", "AY", "BX", "BY", "BZ", "CY", "AY", "AZ", "BX", "CY", "CX", "BY", "BX", "CY", "CZ", "CY", "AY", "AX", "CZ", "CX", "AY", "AX", "BY", "CX", "CX", "CY", "CZ", "CX", "BZ", "BY", "AY", "BY", "CY", "CY", "CY", "CY", "CX", "BY", "AY", "AY", "CY", "AY", "AY", "CY", "AY", "CX", "BX", "AY", "AY", "AY", "AY", "BX", "CY", "AY", "CY", "BY", "BY", "CY", "BX", "CY", "AY", "CZ", "AX", "BX", "CY", "CY", "BY", "AY", "AY", "CY", "CX", "BX", "BZ", "BX", "CX", "AY", "BY", "BX", "BY", "BZ", "AY", "BY", "BZ", "AY", "CZ", "BY", "CX", "CY", "AY", "CZ", "CY", "BX", "BY", "CY", "CZ", "AY", "BX", "BX", "AY", "BZ", "BY", "CZ", "BX", "BX", "CZ", "AY", "CZ", "AY", "CX", "BX", "CY", "AY", "BZ", "BY", "BX", "CZ", "AY", "BX", "CX", "CY", "BY", "CZ", "CY", "CY", "AY", "CZ", "CY", "AY", "BY", "BY", "CY", "AY", "BY", "BY", "BZ", "AY", "CZ", "AZ", "CZ", "BX", "BY", "CX", "AY", "AY", "CY", "AY", "BY", "CX", "AX", "AY", "BY", "CY", "CX", "AY", "AY", "BX", "CY", "BY", "CZ", "CX", "BX", "CY", "AX", "AY", "AY", "BY", "CY", "CZ", "AY", "BY", "CY", "CY", "BX", "AY", "BY", "BX", "CY", "BZ", "CY", "BX", "AY", "BY", "CY", "CZ", "BY", "CY", "AZ", "CZ", "BX", "BY", "CY", "BY", "AY", "BY", "BX", "CZ", "CZ", "CX", "BY", "CY", "CY", "BY", "BY", "AY", "BZ", "BX", "CY", "BY", "CY", "BZ", "CZ", "CZ", "CY", "BY", "AY", "CX", "BX", "BX", "BY", "CY", "CY", "BY", "BZ", "CY", "BX", "CY", "CZ", "BX", "AY", "BX", "CY", "CX", "AY", "BX", "AY", "AY", "CY", "BY", "CY", "BX", "CY", "BY", "CY", "BX", "CY", "BY", "AY", "AY", "CZ", "BX", "CY", "CZ", "BY", "AX", "CX", "BX", "BX", "CY", "BX", "CX", "BY", "AY", "BY", "CY", "BY", "CY", "CY", "AX", "CX", "CY", "BY", "BY", "CY", "CY", "AY", "AY", "CZ", "CY", "CY", "BX", "AY", "CZ", "BY", "BY", "BY", "CZ", "BZ", "BZ", "CX", "CY", "BY", "BY", "AY", "CY", "CY", "BY", "CY", "AY", "CY", "BY", "CY", "BZ", "BY", "AY", "BY", "BX", "CZ", "CX", "CX", "AY", "CZ", "BY", "BX", "AY", "BY", "AX", "BY", "BY", "BY", "BX", "CY", "CY", "AY", "AY", "BY", "BZ", "BY", "BX", "BZ", "CX", "BY", "AY", "BZ", "BX", "AY", "BY", "AY", "BX", "BX", "BX", "BY", "CX", "BX", "CX", "CY", "BY", "AX", "BY", "CY", "BY", "CY", "BY", "BY", "AY", "BZ", "BX", "BY", "BY", "BY", "AZ", "AY", "CY", "CZ", "CX", "BZ", "CY", "BY", "AY", "BX", "BY", "CX", "BX", "BY", "CY", "BZ", "CY", "BZ", "BZ", "BY", "BX", "BY", "BY", "BY", "CY", "AY", "AX", "CY", "BY", "CZ", "BZ", "CY", "CX", "BX", "CX", "BX", "CZ", "AY", "CY", "BZ", "CY", "AX", "BZ", "BY", "BX", "BY", "BX", "CX", "CX", "BZ", "BZ", "CY", "BY", "BX", "BX", "BZ", "AY", "AY", "AY", "BZ", "BX", "CZ", "BY", "BY", "CY", "CY", "BX", "BY", "CY", "BY", "BY", "AX", "BZ", "AZ", "BZ", "CX", "BZ", "AY", "BZ", "BY", "BZ", "AY", "BY", "CY", "CZ", "BY", "CX", "BX", "BY", "AY", "BZ", "CY", "CX", "CZ", "AY", "BY", "CY", "AX", "CZ", "BX", "CY", "AY", "BY", "BZ", "AY", "BX", "CY", "BY", "CZ", "CY", "BY", "BY", "CY", "CY", "CY", "AY", "BZ", "CY", "BX", "AY", "CY", "AY", "AX", "BZ", "AY", "BX", "BY", "BX", "AY", "CZ", "BY", "BZ", "CX", "CY", "CY", "BZ", "BY", "CY", "CX", "CY", "CY", "BY", "BY", "AY", "BX", "CY", "CY", "CY", "CY", "BY", "BY", "CZ", "CX", "BY", "CZ", "AY", "BX", "AY", "BY", "CX", "BX", "BX", "BY", "AX", "CX", "CY", "BY", "CY", "CX", "BY", "CZ", "BY", "AY", "CY", "CY", "AX", "AY", "CY", "AY", "AY", "CY", "AY", "BY", "AY", "BZ", "BX", "AX", "AX", "AZ", "BY", "BY", "CX", "CY", "CX", "CX", "AY", "BX", "BY", "BY", "AX", "BX", "BY", "BY", "CY", "BY", "CY", "CX", "AX", "CY", "BY", "CY", "BY", "CZ", "BX", "BY", "BX", "BX", "CY", "BY", "AX", "CY", "BY", "BX", "AY", "BX", "AY", "CY", "BZ", "BY", "AY", "AY", "BY", "BX", "BY", "CY", "BY", "BY", "AY", "AY", "CY", "BY", "CZ", "CX", "CZ", "CX", "CZ", "AY", "BY", "AY", "CY", "CY", "BY", "CY", "BX", "BX", "AY", "BY", "BY", "AY", "BX", "BY", "BY", "CX", "CY", "CX", "CY", "CY", "CY", "CX", "CZ", "BX", "BY", "CY", "BY", "BY", "CY", "BX", "CY", "BY", "BY", "BZ", "BX", "AZ", "CY", "CY", "AY", "BY", "BY", "AY", "BX", "CY", "BY", "BY", "BZ", "BX", "CY", "BY", "AY", "BZ", "CY", "CX", "CY", "CY", "BY", "AY", "CY", "CX", "AY", "BY", "BZ", "BX", "CZ", "AX", "CY", "BY", "BZ", "CY", "BY", "BY", "BY", "BY", "CY", "BY", "CY", "BY", "AY", "AY", "AX", "BY", "CY", "CY", "CY", "CX", "CZ", "CX", "BX", "AY", "CY", "AY", "BY", "CY", "CZ", "AY", "BX", "BX", "AY", "BX", "CY", "BY", "BY", "BY", "BY", "CZ", "CY", "BY", "BX", "AY", "BZ", "AY", "CY", "BZ", "AY", "BY", "CY", "CY", "BY", "BY", "CY", "AZ", "CY", "CX", "CY", "CY", "CY", "BX", "CY", "AY", "CY", "BX", "BY", "CY", "CX", "BY", "BY", "AY", "BX", "AY", "AY", "BY", "AY", "CY", "BY", "BZ", "AY", "CZ", "BY", "BY", "BX", "AY", "BX", "CY", "AY", "AY", "AY", "BY", "BZ", "CY", "CY", "BX", "AY", "CY", "AY", "BY", "BX", "BY", "BY", "CX", "BY", "BY", "BY", "BY", "AY", "AY", "CY", "AX", "BX", "AY", "BX", "BZ", "BZ", "BZ", "BY", "BY", "CY", "CY", "CZ", "BZ", "BZ", "CY", "BY", "BY", "CX", "CY", "CY", "BY", "AY", "BX", "AY", "BY", "AY", "CY", "BZ", "AY", "BY", "BY", "BY", "CZ", "AY", "AY", "CY", "BY", "CY", "BY", "CY", "BZ", "CY", "CX", "CY", "CY", "BY", "AX", "CY", "AY", "CX", "AX", "AY", "BZ", "CY", "CY", "BY", "CY", "CY", "BY", "CY", "CZ", "BY", "AX", "CY", "BX", "AY", "CY", "BZ", "BY", "BZ", "AY", "BY", "BZ", "CX", "BY", "CY", "AX", "CX", "AX", "BY", "BX", "CY", "CY", "BY", "BY", "CY", "BZ", "CX", "AY", "AY", "BY", "BX", "BY", "AY", "BY", "BZ", "CX", "AY", "BX", "CY", "CY", "AX", "BY", "CZ", "BX", "BY", "BY", "CY", "BZ", "BY", "BZ", "AY", "CY", "CY", "BY", "CZ", "CY", "AX", "AY", "CY", "BZ", "AY", "AX", "CY", "BX", "BX", "AY", "BY", "BZ", "AY", "CY", "BY", "CZ", "CY", "CY", "BY", "CY", "BZ", "CY", "BY", "CZ", "AX", "AY", "AZ", "CY", "BY", "BZ", "BX", "BX", "CY", "AX", "CY", "BX", "BX", "CY", "AZ", "BX", "AZ", "BY", "BY", "AY", "BZ", "CY", "BY", "CY", "CY", "AY", "CY", "BY", "CZ", "CZ", "BY", "BX", "CY", "CY", "CY", "BY", "CY", "BZ", "BZ", "AX", "CX", "BX", "CZ", "CY", "BX", "BY", "AZ", "CY", "BZ", "BY", "CY", "BX", "BZ", "BY", "AY", "BY", "BX", "CY", "BY", "BZ", "CY", "CZ", "CZ", "CY", "AY", "CX", "BY", "AY", "BZ", "CY", "AX", "CX", "CZ", "CZ", "AY", "BY", "CX", "CY", "CY", "BX", "CX", "CY", "BX", "BX", "CY", "BY", "BY", "BY", "BY" };
            int score = 0;


            for (int i = 0; i < puzzelInput.Length; i++)
            {

                char against = puzzelInput[i][0];
                char reply = puzzelInput[i][1];


                //ROCK
                if (reply == 'X')
                {
                    score += 1;

                    //ROCK
                    if (against == 'A')
                    {
                        score += 3;
                    }
                    //PAPER
                    else if (against == 'B')
                    {
                        score += 0;
                    }
                    //SCISSORS
                    else if (against == 'C')
                    {
                        score += 6;
                    }
                }
                //PAPER
                else if (reply == 'Y')
                {
                    score += 2;

                    //ROCK
                    if (against == 'A')
                    {
                        score += 6;
                    }
                    //PAPER
                    else if (against == 'B')
                    {
                        score += 3;
                    }
                    //SCISSORS
                    else if (against == 'C')
                    {
                        score += 0;
                    }
                }

                //SCISSORS
                else if (reply == 'Z')
                {
                    score += 3;

                    //ROCK
                    if (against == 'A')
                    {
                        score += 0;
                    }
                    //PAPER
                    else if (against == 'B')
                    {
                        score += 6;
                    }
                    //SCISSORS
                    else if (against == 'C')
                    {
                        score += 3;
                    }
                }
            }
            Console.WriteLine($"totale score zal {score} zijn");

        }
        public static void Strings()
        {

            string[] puzzelInput = { "AX", "BX", "CX", "CY", "BY", "CZ", "CX", "CY", "CY", "BY", "BY", "CZ", "CY", "AY", "BZ", "BZ", "CY", "BZ", "AY", "CY", "BY", "CY", "BY", "BX", "AY", "AY", "CY", "BX", "CX", "BY", "AY", "CZ", "CX", "BY", "BY", "AY", "CX", "BY", "BY", "BZ", "BY", "AX", "CY", "AY", "BX", "CY", "AY", "CX", "AZ", "AX", "CY", "AY", "AY", "BZ", "BY", "AY", "CY", "BZ", "CY", "AY", "AY", "CY", "BY", "BX", "BX", "CY", "BY", "BX", "AX", "BZ", "AX", "BY", "AY", "BZ", "BX", "BY", "AY", "CX", "CY", "CY", "AY", "AZ", "CZ", "AY", "BZ", "CY", "AY", "CX", "CZ", "BZ", "BY", "BY", "AY", "CZ", "CY", "BY", "AZ", "AY", "AZ", "AY", "AY", "AY", "AY", "CY", "BY", "BY", "AZ", "AY", "AY", "AX", "BZ", "CY", "AY", "BY", "BY", "AY", "AY", "BY", "BY", "CX", "CY", "BZ", "CY", "CY", "BY", "BZ", "CX", "AX", "AX", "AZ", "BY", "BZ", "CY", "CY", "CY", "AY", "CX", "BX", "BY", "BY", "CY", "CZ", "CY", "AY", "CY", "BZ", "CX", "BY", "AY", "CY", "CY", "CZ", "BX", "BY", "BY", "AY", "CZ", "CY", "BY", "CY", "BZ", "CY", "AY", "BY", "BZ", "CX", "AY", "BY", "BY", "CZ", "AY", "CY", "AX", "BY", "BY", "BY", "BZ", "BX", "CY", "BX", "CZ", "BY", "BY", "CY", "BY", "BZ", "AX", "CZ", "BY", "CY", "CY", "CX", "CX", "AY", "CY", "BZ", "CY", "BY", "CZ", "BX", "AX", "AY", "BY", "CZ", "CZ", "CY", "BX", "BX", "BX", "BY", "BX", "CY", "CY", "BX", "BY", "BZ", "BZ", "CY", "CY", "AY", "BY", "BY", "BY", "BY", "BX", "AY", "BY", "CZ", "BZ", "CY", "BY", "BY", "BX", "AY", "CZ", "CY", "CY", "CY", "CZ", "CY", "BX", "CX", "CZ", "BX", "BY", "AY", "CY", "AY", "BY", "BX", "CX", "CX", "CY", "CY", "CY", "BY", "CY", "AY", "BY", "AY", "CZ", "BY", "CY", "AY", "BY", "AY", "AY", "BX", "BY", "BY", "AX", "CX", "BX", "CY", "AY", "BY", "AY", "CZ", "BY", "CZ", "BZ", "BY", "AY", "CY", "CX", "BX", "CY", "AZ", "AX", "BZ", "AY", "BX", "CY", "CY", "CY", "AY", "CZ", "AX", "BZ", "CY", "BY", "BY", "BY", "CY", "AY", "CX", "BX", "BX", "CY", "BZ", "CY", "BX", "CY", "BY", "AY", "CY", "BZ", "AY", "AY", "CY", "BY", "BX", "AY", "CZ", "BY", "CZ", "BX", "BY", "AY", "CZ", "CY", "CY", "BY", "CY", "BX", "CY", "BY", "BX", "CY", "BX", "AX", "BY", "AZ", "CY", "AY", "BY", "BX", "CY", "BX", "CY", "CY", "BY", "CY", "CY", "BX", "BX", "CY", "AY", "BX", "CY", "BY", "AY", "BX", "BY", "AY", "AZ", "AY", "CY", "AX", "BY", "CZ", "BY", "AY", "BY", "AX", "CX", "BY", "AY", "AY", "BY", "BY", "BY", "AY", "BZ", "CX", "AY", "BX", "BY", "AZ", "BZ", "AX", "BY", "CX", "CX", "AY", "BY", "CY", "BZ", "BY", "AZ", "CZ", "AY", "AY", "AX", "BY", "BY", "CX", "AY", "CZ", "AY", "AY", "BY", "AY", "BZ", "BY", "BX", "CX", "CY", "AY", "BZ", "AY", "BY", "AY", "AY", "CY", "AX", "CY", "BX", "BX", "BY", "BX", "BZ", "BY", "CY", "CY", "CZ", "BZ", "AZ", "BY", "CY", "CY", "CY", "BY", "AY", "BZ", "CY", "CZ", "BY", "BY", "BY", "BY", "CX", "BZ", "AY", "AY", "BY", "BX", "BY", "BX", "AY", "CY", "BX", "BY", "CY", "BY", "CY", "CY", "CX", "BY", "BX", "CZ", "BY", "AY", "BX", "CY", "AZ", "CY", "CX", "BY", "CZ", "CY", "BX", "CY", "AY", "AX", "BX", "CX", "AY", "CZ", "CY", "BY", "BX", "CY", "BX", "BZ", "BZ", "BY", "BZ", "BX", "CY", "CY", "BY", "BY", "CY", "BY", "BY", "BZ", "BY", "AX", "BY", "CX", "BY", "AX", "CY", "BY", "AY", "BZ", "BZ", "AY", "AX", "CY", "BY", "BY", "CX", "AY", "CY", "BY", "CZ", "BX", "AY", "AY", "BZ", "AY", "BX", "BX", "CY", "AX", "BX", "BX", "BY", "BY", "BY", "BZ", "AY", "CY", "AY", "CY", "AZ", "CX", "BY", "CY", "BY", "CY", "BX", "BZ", "AX", "AY", "CY", "CY", "BY", "AY", "AY", "AY", "AY", "AY", "CY", "CX", "BY", "BZ", "BZ", "BY", "BZ", "BZ", "BX", "AY", "BZ", "BY", "CZ", "BY", "CZ", "AZ", "CY", "CX", "BY", "BY", "BY", "AZ", "CY", "AY", "BY", "AY", "AY", "AX", "BY", "BZ", "BX", "AX", "CZ", "BX", "CY", "BX", "BY", "BX", "AY", "BX", "BY", "CZ", "CY", "CX", "BY", "BY", "AX", "CY", "BY", "AY", "CY", "CX", "BZ", "CY", "AY", "CX", "BY", "CY", "CX", "CX", "CZ", "CY", "CX", "AY", "CY", "CY", "BX", "BX", "BY", "CZ", "BY", "BZ", "BY", "CY", "BX", "AY", "BY", "BY", "BX", "BY", "BY", "CY", "BZ", "BY", "CX", "AY", "AY", "CY", "CZ", "BY", "BX", "CY", "CY", "CY", "AY", "CX", "AY", "BY", "BX", "AY", "BY", "CY", "BX", "CY", "BY", "AY", "AZ", "CY", "BY", "CY", "AY", "BX", "BX", "BY", "CY", "BX", "BY", "CZ", "CY", "CY", "AY", "CY", "BZ", "BZ", "BY", "CY", "CZ", "AX", "BY", "BZ", "CZ", "BX", "AY", "AX", "BX", "BX", "AZ", "BX", "CY", "CY", "BY", "CY", "BY", "AY", "BY", "CX", "BZ", "CX", "BX", "CX", "BY", "CY", "CY", "BY", "BY", "CY", "CX", "BX", "AY", "CY", "AX", "BY", "BY", "BY", "CY", "BZ", "CY", "CZ", "BX", "CY", "AY", "BY", "AY", "CY", "AZ", "BZ", "BY", "AY", "BZ", "BY", "CX", "BY", "CY", "CY", "AY", "CY", "AY", "BY", "CZ", "CX", "CY", "CX", "BX", "BY", "CZ", "AY", "CY", "CZ", "CY", "CY", "CY", "BY", "BZ", "BY", "CY", "CZ", "BZ", "CY", "CX", "AZ", "BY", "AY", "BY", "BY", "AX", "CZ", "CY", "BY", "BY", "CY", "CY", "BY", "CY", "CY", "BX", "BY", "CX", "BX", "BY", "CX", "CY", "BZ", "CX", "CX", "BY", "AY", "BY", "CY", "BX", "AY", "CY", "CX", "CX", "AZ", "BZ", "AY", "CY", "CY", "AX", "AY", "BY", "BY", "CY", "CY", "CY", "CZ", "BY", "CY", "AY", "BX", "CZ", "AY", "CX", "BY", "BY", "BY", "CZ", "BY", "CY", "BY", "BX", "CY", "CY", "AY", "BY", "BY", "BX", "BY", "BZ", "BY", "AX", "CY", "BX", "BY", "BX", "BY", "BY", "CY", "CY", "CY", "BY", "BY", "BX", "AY", "CZ", "BX", "BX", "CX", "CY", "AY", "BY", "BY", "CY", "CY", "CZ", "AX", "BX", "AX", "AZ", "AX", "CY", "CY", "AX", "BY", "CZ", "BX", "CY", "BX", "BY", "BY", "BX", "CY", "BX", "AY", "BY", "BY", "BX", "BY", "CY", "BY", "BY", "CY", "CY", "BX", "CY", "BX", "CY", "CY", "CZ", "CY", "BX", "BY", "AY", "CY", "AY", "BY", "CY", "CY", "BX", "BY", "BY", "AY", "BY", "AY", "BX", "AX", "CX", "BY", "AZ", "AY", "BX", "BX", "AY", "BX", "BX", "CX", "CX", "BX", "BZ", "CZ", "AY", "BX", "BY", "BZ", "CY", "CY", "CY", "AZ", "BX", "BZ", "BX", "BY", "BZ", "BY", "BZ", "CY", "BY", "CX", "CY", "BX", "CZ", "AZ", "AX", "BY", "CY", "AY", "CY", "AY", "AX", "CY", "BY", "BY", "AY", "CY", "CX", "BZ", "BY", "BZ", "CY", "AY", "CX", "AY", "CY", "CY", "BX", "CY", "AY", "CY", "CX", "BY", "BZ", "AY", "BX", "AX", "AY", "CY", "BY", "AY", "BY", "CY", "CZ", "BX", "AY", "AY", "AY", "AZ", "AY", "BY", "CY", "CY", "BZ", "BX", "CY", "AY", "BX", "BY", "BX", "CY", "BY", "AX", "CX", "CY", "BX", "BY", "BZ", "BX", "BY", "AY", "BX", "BZ", "CY", "AY", "CX", "CZ", "CX", "AZ", "BZ", "BY", "CX", "BX", "CY", "BY", "AY", "CX", "AY", "BX", "BY", "CY", "BY", "CY", "BZ", "BX", "AY", "AX", "CY", "CY", "BY", "BY", "BY", "BY", "CZ", "AX", "CY", "CY", "BY", "BZ", "CZ", "AY", "BX", "CY", "CY", "BZ", "BY", "BY", "BX", "BZ", "BY", "CY", "CY", "CY", "BY", "AX", "AY", "CY", "AY", "AX", "AY", "CY", "BX", "CY", "CX", "BY", "BY", "CZ", "CZ", "BY", "BY", "CX", "CY", "BZ", "AY", "CX", "BX", "CY", "BY", "BZ", "AY", "BZ", "BX", "BY", "AY", "BY", "CZ", "AY", "BX", "AY", "BY", "BX", "AY", "CY", "AY", "BZ", "BZ", "BY", "AX", "AY", "CZ", "BY", "BZ", "CY", "BY", "BX", "BZ", "BY", "AX", "AY", "CZ", "CY", "AZ", "BZ", "BX", "BX", "BY", "CY", "BY", "CY", "BY", "BZ", "CZ", "BX", "AY", "CY", "CY", "CY", "CX", "CY", "AY", "BX", "AY", "BX", "AY", "CY", "AY", "BY", "BY", "CZ", "BY", "CY", "CY", "BZ", "AY", "CY", "BY", "BY", "CY", "CZ", "BX", "AY", "CX", "CY", "BY", "BX", "AY", "BY", "AY", "AX", "CX", "CY", "CY", "AY", "BY", "AY", "AY", "AY", "BX", "BZ", "CZ", "CZ", "BX", "CY", "BX", "CY", "BX", "CY", "CY", "CY", "BX", "BY", "AZ", "CY", "BX", "CY", "BY", "BY", "CY", "AY", "CY", "BX", "BY", "AX", "CY", "CY", "BY", "BX", "BZ", "CZ", "AY", "AY", "BY", "AX", "AY", "BX", "CY", "BZ", "BY", "BZ", "BY", "AY", "BY", "BY", "BX", "AX", "BZ", "BY", "AY", "BX", "BZ", "BY", "BX", "CZ", "CZ", "BX", "AY", "CY", "CY", "BY", "CY", "BY", "BY", "BY", "BX", "BZ", "BZ", "BY", "BX", "BY", "BX", "BY", "CZ", "CY", "BZ", "CZ", "CY", "BY", "CX", "CZ", "BX", "CY", "CY", "BY", "CY", "BZ", "BY", "BY", "AY", "CY", "CX", "AY", "CY", "BX", "BY", "CY", "BX", "CY", "CY", "CX", "CZ", "BX", "CX", "AY", "BX", "AY", "BZ", "AZ", "CY", "AY", "AX", "BY", "BZ", "AY", "BY", "CY", "AY", "BY", "CX", "CY", "CY", "CX", "CX", "CY", "BX", "BZ", "CX", "BY", "CY", "CY", "CY", "CZ", "BZ", "CZ", "BZ", "CX", "BY", "AZ", "CZ", "BY", "BY", "BY", "CY", "BX", "BX", "BY", "CY", "CX", "AY", "CZ", "BZ", "AY", "BY", "BZ", "CY", "BX", "CX", "AY", "BY", "BY", "CZ", "BX", "AZ", "CZ", "BX", "CY", "BX", "CY", "CX", "CY", "CY", "CY", "BY", "BZ", "BZ", "CY", "BZ", "CY", "CZ", "BY", "CY", "CY", "CZ", "BX", "AY", "BY", "BY", "BY", "AZ", "BX", "CY", "CY", "AY", "CY", "CY", "BX", "CX", "AY", "BY", "AY", "CZ", "AY", "CZ", "BZ", "AZ", "AY", "BX", "CY", "BX", "CY", "CX", "AY", "BY", "BY", "CZ", "CZ", "BZ", "CY", "BY", "BZ", "BX", "AZ", "CY", "CX", "BY", "CZ", "AY", "BX", "CX", "CX", "BZ", "CX", "BZ", "BZ", "AY", "BY", "BX", "BZ", "CX", "BY", "AY", "CY", "CY", "BY", "BZ", "CX", "BY", "BY", "CY", "AY", "CZ", "CZ", "BY", "BY", "BX", "CY", "BX", "BY", "CY", "CY", "BX", "BZ", "BY", "CZ", "AY", "AX", "CY", "AY", "BZ", "BX", "BZ", "BZ", "BY", "BY", "BY", "AY", "AX", "AY", "BY", "AY", "CY", "CY", "CY", "BY", "CY", "CY", "BX", "CY", "BY", "AY", "AY", "CZ", "BY", "BX", "CX", "BX", "BY", "AY", "BX", "BY", "BZ", "CY", "AY", "AZ", "BX", "CY", "CX", "BY", "BX", "CY", "CZ", "CY", "AY", "AX", "CZ", "CX", "AY", "AX", "BY", "CX", "CX", "CY", "CZ", "CX", "BZ", "BY", "AY", "BY", "CY", "CY", "CY", "CY", "CX", "BY", "AY", "AY", "CY", "AY", "AY", "CY", "AY", "CX", "BX", "AY", "AY", "AY", "AY", "BX", "CY", "AY", "CY", "BY", "BY", "CY", "BX", "CY", "AY", "CZ", "AX", "BX", "CY", "CY", "BY", "AY", "AY", "CY", "CX", "BX", "BZ", "BX", "CX", "AY", "BY", "BX", "BY", "BZ", "AY", "BY", "BZ", "AY", "CZ", "BY", "CX", "CY", "AY", "CZ", "CY", "BX", "BY", "CY", "CZ", "AY", "BX", "BX", "AY", "BZ", "BY", "CZ", "BX", "BX", "CZ", "AY", "CZ", "AY", "CX", "BX", "CY", "AY", "BZ", "BY", "BX", "CZ", "AY", "BX", "CX", "CY", "BY", "CZ", "CY", "CY", "AY", "CZ", "CY", "AY", "BY", "BY", "CY", "AY", "BY", "BY", "BZ", "AY", "CZ", "AZ", "CZ", "BX", "BY", "CX", "AY", "AY", "CY", "AY", "BY", "CX", "AX", "AY", "BY", "CY", "CX", "AY", "AY", "BX", "CY", "BY", "CZ", "CX", "BX", "CY", "AX", "AY", "AY", "BY", "CY", "CZ", "AY", "BY", "CY", "CY", "BX", "AY", "BY", "BX", "CY", "BZ", "CY", "BX", "AY", "BY", "CY", "CZ", "BY", "CY", "AZ", "CZ", "BX", "BY", "CY", "BY", "AY", "BY", "BX", "CZ", "CZ", "CX", "BY", "CY", "CY", "BY", "BY", "AY", "BZ", "BX", "CY", "BY", "CY", "BZ", "CZ", "CZ", "CY", "BY", "AY", "CX", "BX", "BX", "BY", "CY", "CY", "BY", "BZ", "CY", "BX", "CY", "CZ", "BX", "AY", "BX", "CY", "CX", "AY", "BX", "AY", "AY", "CY", "BY", "CY", "BX", "CY", "BY", "CY", "BX", "CY", "BY", "AY", "AY", "CZ", "BX", "CY", "CZ", "BY", "AX", "CX", "BX", "BX", "CY", "BX", "CX", "BY", "AY", "BY", "CY", "BY", "CY", "CY", "AX", "CX", "CY", "BY", "BY", "CY", "CY", "AY", "AY", "CZ", "CY", "CY", "BX", "AY", "CZ", "BY", "BY", "BY", "CZ", "BZ", "BZ", "CX", "CY", "BY", "BY", "AY", "CY", "CY", "BY", "CY", "AY", "CY", "BY", "CY", "BZ", "BY", "AY", "BY", "BX", "CZ", "CX", "CX", "AY", "CZ", "BY", "BX", "AY", "BY", "AX", "BY", "BY", "BY", "BX", "CY", "CY", "AY", "AY", "BY", "BZ", "BY", "BX", "BZ", "CX", "BY", "AY", "BZ", "BX", "AY", "BY", "AY", "BX", "BX", "BX", "BY", "CX", "BX", "CX", "CY", "BY", "AX", "BY", "CY", "BY", "CY", "BY", "BY", "AY", "BZ", "BX", "BY", "BY", "BY", "AZ", "AY", "CY", "CZ", "CX", "BZ", "CY", "BY", "AY", "BX", "BY", "CX", "BX", "BY", "CY", "BZ", "CY", "BZ", "BZ", "BY", "BX", "BY", "BY", "BY", "CY", "AY", "AX", "CY", "BY", "CZ", "BZ", "CY", "CX", "BX", "CX", "BX", "CZ", "AY", "CY", "BZ", "CY", "AX", "BZ", "BY", "BX", "BY", "BX", "CX", "CX", "BZ", "BZ", "CY", "BY", "BX", "BX", "BZ", "AY", "AY", "AY", "BZ", "BX", "CZ", "BY", "BY", "CY", "CY", "BX", "BY", "CY", "BY", "BY", "AX", "BZ", "AZ", "BZ", "CX", "BZ", "AY", "BZ", "BY", "BZ", "AY", "BY", "CY", "CZ", "BY", "CX", "BX", "BY", "AY", "BZ", "CY", "CX", "CZ", "AY", "BY", "CY", "AX", "CZ", "BX", "CY", "AY", "BY", "BZ", "AY", "BX", "CY", "BY", "CZ", "CY", "BY", "BY", "CY", "CY", "CY", "AY", "BZ", "CY", "BX", "AY", "CY", "AY", "AX", "BZ", "AY", "BX", "BY", "BX", "AY", "CZ", "BY", "BZ", "CX", "CY", "CY", "BZ", "BY", "CY", "CX", "CY", "CY", "BY", "BY", "AY", "BX", "CY", "CY", "CY", "CY", "BY", "BY", "CZ", "CX", "BY", "CZ", "AY", "BX", "AY", "BY", "CX", "BX", "BX", "BY", "AX", "CX", "CY", "BY", "CY", "CX", "BY", "CZ", "BY", "AY", "CY", "CY", "AX", "AY", "CY", "AY", "AY", "CY", "AY", "BY", "AY", "BZ", "BX", "AX", "AX", "AZ", "BY", "BY", "CX", "CY", "CX", "CX", "AY", "BX", "BY", "BY", "AX", "BX", "BY", "BY", "CY", "BY", "CY", "CX", "AX", "CY", "BY", "CY", "BY", "CZ", "BX", "BY", "BX", "BX", "CY", "BY", "AX", "CY", "BY", "BX", "AY", "BX", "AY", "CY", "BZ", "BY", "AY", "AY", "BY", "BX", "BY", "CY", "BY", "BY", "AY", "AY", "CY", "BY", "CZ", "CX", "CZ", "CX", "CZ", "AY", "BY", "AY", "CY", "CY", "BY", "CY", "BX", "BX", "AY", "BY", "BY", "AY", "BX", "BY", "BY", "CX", "CY", "CX", "CY", "CY", "CY", "CX", "CZ", "BX", "BY", "CY", "BY", "BY", "CY", "BX", "CY", "BY", "BY", "BZ", "BX", "AZ", "CY", "CY", "AY", "BY", "BY", "AY", "BX", "CY", "BY", "BY", "BZ", "BX", "CY", "BY", "AY", "BZ", "CY", "CX", "CY", "CY", "BY", "AY", "CY", "CX", "AY", "BY", "BZ", "BX", "CZ", "AX", "CY", "BY", "BZ", "CY", "BY", "BY", "BY", "BY", "CY", "BY", "CY", "BY", "AY", "AY", "AX", "BY", "CY", "CY", "CY", "CX", "CZ", "CX", "BX", "AY", "CY", "AY", "BY", "CY", "CZ", "AY", "BX", "BX", "AY", "BX", "CY", "BY", "BY", "BY", "BY", "CZ", "CY", "BY", "BX", "AY", "BZ", "AY", "CY", "BZ", "AY", "BY", "CY", "CY", "BY", "BY", "CY", "AZ", "CY", "CX", "CY", "CY", "CY", "BX", "CY", "AY", "CY", "BX", "BY", "CY", "CX", "BY", "BY", "AY", "BX", "AY", "AY", "BY", "AY", "CY", "BY", "BZ", "AY", "CZ", "BY", "BY", "BX", "AY", "BX", "CY", "AY", "AY", "AY", "BY", "BZ", "CY", "CY", "BX", "AY", "CY", "AY", "BY", "BX", "BY", "BY", "CX", "BY", "BY", "BY", "BY", "AY", "AY", "CY", "AX", "BX", "AY", "BX", "BZ", "BZ", "BZ", "BY", "BY", "CY", "CY", "CZ", "BZ", "BZ", "CY", "BY", "BY", "CX", "CY", "CY", "BY", "AY", "BX", "AY", "BY", "AY", "CY", "BZ", "AY", "BY", "BY", "BY", "CZ", "AY", "AY", "CY", "BY", "CY", "BY", "CY", "BZ", "CY", "CX", "CY", "CY", "BY", "AX", "CY", "AY", "CX", "AX", "AY", "BZ", "CY", "CY", "BY", "CY", "CY", "BY", "CY", "CZ", "BY", "AX", "CY", "BX", "AY", "CY", "BZ", "BY", "BZ", "AY", "BY", "BZ", "CX", "BY", "CY", "AX", "CX", "AX", "BY", "BX", "CY", "CY", "BY", "BY", "CY", "BZ", "CX", "AY", "AY", "BY", "BX", "BY", "AY", "BY", "BZ", "CX", "AY", "BX", "CY", "CY", "AX", "BY", "CZ", "BX", "BY", "BY", "CY", "BZ", "BY", "BZ", "AY", "CY", "CY", "BY", "CZ", "CY", "AX", "AY", "CY", "BZ", "AY", "AX", "CY", "BX", "BX", "AY", "BY", "BZ", "AY", "CY", "BY", "CZ", "CY", "CY", "BY", "CY", "BZ", "CY", "BY", "CZ", "AX", "AY", "AZ", "CY", "BY", "BZ", "BX", "BX", "CY", "AX", "CY", "BX", "BX", "CY", "AZ", "BX", "AZ", "BY", "BY", "AY", "BZ", "CY", "BY", "CY", "CY", "AY", "CY", "BY", "CZ", "CZ", "BY", "BX", "CY", "CY", "CY", "BY", "CY", "BZ", "BZ", "AX", "CX", "BX", "CZ", "CY", "BX", "BY", "AZ", "CY", "BZ", "BY", "CY", "BX", "BZ", "BY", "AY", "BY", "BX", "CY", "BY", "BZ", "CY", "CZ", "CZ", "CY", "AY", "CX", "BY", "AY", "BZ", "CY", "AX", "CX", "CZ", "CZ", "AY", "BY", "CX", "CY", "CY", "BX", "CX", "CY", "BX", "BX", "CY", "BY", "BY", "BY", "BY" };
            int score = 0;


            for (int i = 0; i < puzzelInput.Length; i++)
            {

                string against = puzzelInput[i].Substring(0, 1);
                string reply = puzzelInput[i].Substring(1, 1);

                //ROCK
                if (reply == "X")
                {
                    score += 1;

                    //ROCK
                    if (against == "A")
                    {
                        score += 3;
                    }
                    //PAPER
                    else if (against == "B")
                    {
                        score += 0;
                    }
                    //SCISSORS
                    else if (against == "C")
                    {
                        score += 6;
                    }
                }
                //PAPER
                else if (reply == "Y")
                {
                    score += 2;

                    //ROCK
                    if (against == "A")
                    {
                        score += 6;
                    }
                    //PAPER
                    else if (against == "B")
                    {
                        score += 3;
                    }
                    //SCISSORS
                    else if (against == "C")
                    {
                        score += 0;
                    }
                }

                //SCISSORS
                else if (reply == "Z")
                {
                    score += 3;

                    //ROCK
                    if (against == "A")
                    {
                        score += 0;
                    }
                    //PAPER
                    else if (against == "B")
                    {
                        score += 6;
                    }
                    //SCISSORS
                    else if (against == "C")
                    {
                        score += 3;
                    }
                }
            }
            Console.WriteLine($"totale score zal {score} zijn");

        }
        public static void Part2()
        {

            string[] puzzelInput = { "AX", "BX", "CX", "CY", "BY", "CZ", "CX", "CY", "CY", "BY", "BY", "CZ", "CY", "AY", "BZ", "BZ", "CY", "BZ", "AY", "CY", "BY", "CY", "BY", "BX", "AY", "AY", "CY", "BX", "CX", "BY", "AY", "CZ", "CX", "BY", "BY", "AY", "CX", "BY", "BY", "BZ", "BY", "AX", "CY", "AY", "BX", "CY", "AY", "CX", "AZ", "AX", "CY", "AY", "AY", "BZ", "BY", "AY", "CY", "BZ", "CY", "AY", "AY", "CY", "BY", "BX", "BX", "CY", "BY", "BX", "AX", "BZ", "AX", "BY", "AY", "BZ", "BX", "BY", "AY", "CX", "CY", "CY", "AY", "AZ", "CZ", "AY", "BZ", "CY", "AY", "CX", "CZ", "BZ", "BY", "BY", "AY", "CZ", "CY", "BY", "AZ", "AY", "AZ", "AY", "AY", "AY", "AY", "CY", "BY", "BY", "AZ", "AY", "AY", "AX", "BZ", "CY", "AY", "BY", "BY", "AY", "AY", "BY", "BY", "CX", "CY", "BZ", "CY", "CY", "BY", "BZ", "CX", "AX", "AX", "AZ", "BY", "BZ", "CY", "CY", "CY", "AY", "CX", "BX", "BY", "BY", "CY", "CZ", "CY", "AY", "CY", "BZ", "CX", "BY", "AY", "CY", "CY", "CZ", "BX", "BY", "BY", "AY", "CZ", "CY", "BY", "CY", "BZ", "CY", "AY", "BY", "BZ", "CX", "AY", "BY", "BY", "CZ", "AY", "CY", "AX", "BY", "BY", "BY", "BZ", "BX", "CY", "BX", "CZ", "BY", "BY", "CY", "BY", "BZ", "AX", "CZ", "BY", "CY", "CY", "CX", "CX", "AY", "CY", "BZ", "CY", "BY", "CZ", "BX", "AX", "AY", "BY", "CZ", "CZ", "CY", "BX", "BX", "BX", "BY", "BX", "CY", "CY", "BX", "BY", "BZ", "BZ", "CY", "CY", "AY", "BY", "BY", "BY", "BY", "BX", "AY", "BY", "CZ", "BZ", "CY", "BY", "BY", "BX", "AY", "CZ", "CY", "CY", "CY", "CZ", "CY", "BX", "CX", "CZ", "BX", "BY", "AY", "CY", "AY", "BY", "BX", "CX", "CX", "CY", "CY", "CY", "BY", "CY", "AY", "BY", "AY", "CZ", "BY", "CY", "AY", "BY", "AY", "AY", "BX", "BY", "BY", "AX", "CX", "BX", "CY", "AY", "BY", "AY", "CZ", "BY", "CZ", "BZ", "BY", "AY", "CY", "CX", "BX", "CY", "AZ", "AX", "BZ", "AY", "BX", "CY", "CY", "CY", "AY", "CZ", "AX", "BZ", "CY", "BY", "BY", "BY", "CY", "AY", "CX", "BX", "BX", "CY", "BZ", "CY", "BX", "CY", "BY", "AY", "CY", "BZ", "AY", "AY", "CY", "BY", "BX", "AY", "CZ", "BY", "CZ", "BX", "BY", "AY", "CZ", "CY", "CY", "BY", "CY", "BX", "CY", "BY", "BX", "CY", "BX", "AX", "BY", "AZ", "CY", "AY", "BY", "BX", "CY", "BX", "CY", "CY", "BY", "CY", "CY", "BX", "BX", "CY", "AY", "BX", "CY", "BY", "AY", "BX", "BY", "AY", "AZ", "AY", "CY", "AX", "BY", "CZ", "BY", "AY", "BY", "AX", "CX", "BY", "AY", "AY", "BY", "BY", "BY", "AY", "BZ", "CX", "AY", "BX", "BY", "AZ", "BZ", "AX", "BY", "CX", "CX", "AY", "BY", "CY", "BZ", "BY", "AZ", "CZ", "AY", "AY", "AX", "BY", "BY", "CX", "AY", "CZ", "AY", "AY", "BY", "AY", "BZ", "BY", "BX", "CX", "CY", "AY", "BZ", "AY", "BY", "AY", "AY", "CY", "AX", "CY", "BX", "BX", "BY", "BX", "BZ", "BY", "CY", "CY", "CZ", "BZ", "AZ", "BY", "CY", "CY", "CY", "BY", "AY", "BZ", "CY", "CZ", "BY", "BY", "BY", "BY", "CX", "BZ", "AY", "AY", "BY", "BX", "BY", "BX", "AY", "CY", "BX", "BY", "CY", "BY", "CY", "CY", "CX", "BY", "BX", "CZ", "BY", "AY", "BX", "CY", "AZ", "CY", "CX", "BY", "CZ", "CY", "BX", "CY", "AY", "AX", "BX", "CX", "AY", "CZ", "CY", "BY", "BX", "CY", "BX", "BZ", "BZ", "BY", "BZ", "BX", "CY", "CY", "BY", "BY", "CY", "BY", "BY", "BZ", "BY", "AX", "BY", "CX", "BY", "AX", "CY", "BY", "AY", "BZ", "BZ", "AY", "AX", "CY", "BY", "BY", "CX", "AY", "CY", "BY", "CZ", "BX", "AY", "AY", "BZ", "AY", "BX", "BX", "CY", "AX", "BX", "BX", "BY", "BY", "BY", "BZ", "AY", "CY", "AY", "CY", "AZ", "CX", "BY", "CY", "BY", "CY", "BX", "BZ", "AX", "AY", "CY", "CY", "BY", "AY", "AY", "AY", "AY", "AY", "CY", "CX", "BY", "BZ", "BZ", "BY", "BZ", "BZ", "BX", "AY", "BZ", "BY", "CZ", "BY", "CZ", "AZ", "CY", "CX", "BY", "BY", "BY", "AZ", "CY", "AY", "BY", "AY", "AY", "AX", "BY", "BZ", "BX", "AX", "CZ", "BX", "CY", "BX", "BY", "BX", "AY", "BX", "BY", "CZ", "CY", "CX", "BY", "BY", "AX", "CY", "BY", "AY", "CY", "CX", "BZ", "CY", "AY", "CX", "BY", "CY", "CX", "CX", "CZ", "CY", "CX", "AY", "CY", "CY", "BX", "BX", "BY", "CZ", "BY", "BZ", "BY", "CY", "BX", "AY", "BY", "BY", "BX", "BY", "BY", "CY", "BZ", "BY", "CX", "AY", "AY", "CY", "CZ", "BY", "BX", "CY", "CY", "CY", "AY", "CX", "AY", "BY", "BX", "AY", "BY", "CY", "BX", "CY", "BY", "AY", "AZ", "CY", "BY", "CY", "AY", "BX", "BX", "BY", "CY", "BX", "BY", "CZ", "CY", "CY", "AY", "CY", "BZ", "BZ", "BY", "CY", "CZ", "AX", "BY", "BZ", "CZ", "BX", "AY", "AX", "BX", "BX", "AZ", "BX", "CY", "CY", "BY", "CY", "BY", "AY", "BY", "CX", "BZ", "CX", "BX", "CX", "BY", "CY", "CY", "BY", "BY", "CY", "CX", "BX", "AY", "CY", "AX", "BY", "BY", "BY", "CY", "BZ", "CY", "CZ", "BX", "CY", "AY", "BY", "AY", "CY", "AZ", "BZ", "BY", "AY", "BZ", "BY", "CX", "BY", "CY", "CY", "AY", "CY", "AY", "BY", "CZ", "CX", "CY", "CX", "BX", "BY", "CZ", "AY", "CY", "CZ", "CY", "CY", "CY", "BY", "BZ", "BY", "CY", "CZ", "BZ", "CY", "CX", "AZ", "BY", "AY", "BY", "BY", "AX", "CZ", "CY", "BY", "BY", "CY", "CY", "BY", "CY", "CY", "BX", "BY", "CX", "BX", "BY", "CX", "CY", "BZ", "CX", "CX", "BY", "AY", "BY", "CY", "BX", "AY", "CY", "CX", "CX", "AZ", "BZ", "AY", "CY", "CY", "AX", "AY", "BY", "BY", "CY", "CY", "CY", "CZ", "BY", "CY", "AY", "BX", "CZ", "AY", "CX", "BY", "BY", "BY", "CZ", "BY", "CY", "BY", "BX", "CY", "CY", "AY", "BY", "BY", "BX", "BY", "BZ", "BY", "AX", "CY", "BX", "BY", "BX", "BY", "BY", "CY", "CY", "CY", "BY", "BY", "BX", "AY", "CZ", "BX", "BX", "CX", "CY", "AY", "BY", "BY", "CY", "CY", "CZ", "AX", "BX", "AX", "AZ", "AX", "CY", "CY", "AX", "BY", "CZ", "BX", "CY", "BX", "BY", "BY", "BX", "CY", "BX", "AY", "BY", "BY", "BX", "BY", "CY", "BY", "BY", "CY", "CY", "BX", "CY", "BX", "CY", "CY", "CZ", "CY", "BX", "BY", "AY", "CY", "AY", "BY", "CY", "CY", "BX", "BY", "BY", "AY", "BY", "AY", "BX", "AX", "CX", "BY", "AZ", "AY", "BX", "BX", "AY", "BX", "BX", "CX", "CX", "BX", "BZ", "CZ", "AY", "BX", "BY", "BZ", "CY", "CY", "CY", "AZ", "BX", "BZ", "BX", "BY", "BZ", "BY", "BZ", "CY", "BY", "CX", "CY", "BX", "CZ", "AZ", "AX", "BY", "CY", "AY", "CY", "AY", "AX", "CY", "BY", "BY", "AY", "CY", "CX", "BZ", "BY", "BZ", "CY", "AY", "CX", "AY", "CY", "CY", "BX", "CY", "AY", "CY", "CX", "BY", "BZ", "AY", "BX", "AX", "AY", "CY", "BY", "AY", "BY", "CY", "CZ", "BX", "AY", "AY", "AY", "AZ", "AY", "BY", "CY", "CY", "BZ", "BX", "CY", "AY", "BX", "BY", "BX", "CY", "BY", "AX", "CX", "CY", "BX", "BY", "BZ", "BX", "BY", "AY", "BX", "BZ", "CY", "AY", "CX", "CZ", "CX", "AZ", "BZ", "BY", "CX", "BX", "CY", "BY", "AY", "CX", "AY", "BX", "BY", "CY", "BY", "CY", "BZ", "BX", "AY", "AX", "CY", "CY", "BY", "BY", "BY", "BY", "CZ", "AX", "CY", "CY", "BY", "BZ", "CZ", "AY", "BX", "CY", "CY", "BZ", "BY", "BY", "BX", "BZ", "BY", "CY", "CY", "CY", "BY", "AX", "AY", "CY", "AY", "AX", "AY", "CY", "BX", "CY", "CX", "BY", "BY", "CZ", "CZ", "BY", "BY", "CX", "CY", "BZ", "AY", "CX", "BX", "CY", "BY", "BZ", "AY", "BZ", "BX", "BY", "AY", "BY", "CZ", "AY", "BX", "AY", "BY", "BX", "AY", "CY", "AY", "BZ", "BZ", "BY", "AX", "AY", "CZ", "BY", "BZ", "CY", "BY", "BX", "BZ", "BY", "AX", "AY", "CZ", "CY", "AZ", "BZ", "BX", "BX", "BY", "CY", "BY", "CY", "BY", "BZ", "CZ", "BX", "AY", "CY", "CY", "CY", "CX", "CY", "AY", "BX", "AY", "BX", "AY", "CY", "AY", "BY", "BY", "CZ", "BY", "CY", "CY", "BZ", "AY", "CY", "BY", "BY", "CY", "CZ", "BX", "AY", "CX", "CY", "BY", "BX", "AY", "BY", "AY", "AX", "CX", "CY", "CY", "AY", "BY", "AY", "AY", "AY", "BX", "BZ", "CZ", "CZ", "BX", "CY", "BX", "CY", "BX", "CY", "CY", "CY", "BX", "BY", "AZ", "CY", "BX", "CY", "BY", "BY", "CY", "AY", "CY", "BX", "BY", "AX", "CY", "CY", "BY", "BX", "BZ", "CZ", "AY", "AY", "BY", "AX", "AY", "BX", "CY", "BZ", "BY", "BZ", "BY", "AY", "BY", "BY", "BX", "AX", "BZ", "BY", "AY", "BX", "BZ", "BY", "BX", "CZ", "CZ", "BX", "AY", "CY", "CY", "BY", "CY", "BY", "BY", "BY", "BX", "BZ", "BZ", "BY", "BX", "BY", "BX", "BY", "CZ", "CY", "BZ", "CZ", "CY", "BY", "CX", "CZ", "BX", "CY", "CY", "BY", "CY", "BZ", "BY", "BY", "AY", "CY", "CX", "AY", "CY", "BX", "BY", "CY", "BX", "CY", "CY", "CX", "CZ", "BX", "CX", "AY", "BX", "AY", "BZ", "AZ", "CY", "AY", "AX", "BY", "BZ", "AY", "BY", "CY", "AY", "BY", "CX", "CY", "CY", "CX", "CX", "CY", "BX", "BZ", "CX", "BY", "CY", "CY", "CY", "CZ", "BZ", "CZ", "BZ", "CX", "BY", "AZ", "CZ", "BY", "BY", "BY", "CY", "BX", "BX", "BY", "CY", "CX", "AY", "CZ", "BZ", "AY", "BY", "BZ", "CY", "BX", "CX", "AY", "BY", "BY", "CZ", "BX", "AZ", "CZ", "BX", "CY", "BX", "CY", "CX", "CY", "CY", "CY", "BY", "BZ", "BZ", "CY", "BZ", "CY", "CZ", "BY", "CY", "CY", "CZ", "BX", "AY", "BY", "BY", "BY", "AZ", "BX", "CY", "CY", "AY", "CY", "CY", "BX", "CX", "AY", "BY", "AY", "CZ", "AY", "CZ", "BZ", "AZ", "AY", "BX", "CY", "BX", "CY", "CX", "AY", "BY", "BY", "CZ", "CZ", "BZ", "CY", "BY", "BZ", "BX", "AZ", "CY", "CX", "BY", "CZ", "AY", "BX", "CX", "CX", "BZ", "CX", "BZ", "BZ", "AY", "BY", "BX", "BZ", "CX", "BY", "AY", "CY", "CY", "BY", "BZ", "CX", "BY", "BY", "CY", "AY", "CZ", "CZ", "BY", "BY", "BX", "CY", "BX", "BY", "CY", "CY", "BX", "BZ", "BY", "CZ", "AY", "AX", "CY", "AY", "BZ", "BX", "BZ", "BZ", "BY", "BY", "BY", "AY", "AX", "AY", "BY", "AY", "CY", "CY", "CY", "BY", "CY", "CY", "BX", "CY", "BY", "AY", "AY", "CZ", "BY", "BX", "CX", "BX", "BY", "AY", "BX", "BY", "BZ", "CY", "AY", "AZ", "BX", "CY", "CX", "BY", "BX", "CY", "CZ", "CY", "AY", "AX", "CZ", "CX", "AY", "AX", "BY", "CX", "CX", "CY", "CZ", "CX", "BZ", "BY", "AY", "BY", "CY", "CY", "CY", "CY", "CX", "BY", "AY", "AY", "CY", "AY", "AY", "CY", "AY", "CX", "BX", "AY", "AY", "AY", "AY", "BX", "CY", "AY", "CY", "BY", "BY", "CY", "BX", "CY", "AY", "CZ", "AX", "BX", "CY", "CY", "BY", "AY", "AY", "CY", "CX", "BX", "BZ", "BX", "CX", "AY", "BY", "BX", "BY", "BZ", "AY", "BY", "BZ", "AY", "CZ", "BY", "CX", "CY", "AY", "CZ", "CY", "BX", "BY", "CY", "CZ", "AY", "BX", "BX", "AY", "BZ", "BY", "CZ", "BX", "BX", "CZ", "AY", "CZ", "AY", "CX", "BX", "CY", "AY", "BZ", "BY", "BX", "CZ", "AY", "BX", "CX", "CY", "BY", "CZ", "CY", "CY", "AY", "CZ", "CY", "AY", "BY", "BY", "CY", "AY", "BY", "BY", "BZ", "AY", "CZ", "AZ", "CZ", "BX", "BY", "CX", "AY", "AY", "CY", "AY", "BY", "CX", "AX", "AY", "BY", "CY", "CX", "AY", "AY", "BX", "CY", "BY", "CZ", "CX", "BX", "CY", "AX", "AY", "AY", "BY", "CY", "CZ", "AY", "BY", "CY", "CY", "BX", "AY", "BY", "BX", "CY", "BZ", "CY", "BX", "AY", "BY", "CY", "CZ", "BY", "CY", "AZ", "CZ", "BX", "BY", "CY", "BY", "AY", "BY", "BX", "CZ", "CZ", "CX", "BY", "CY", "CY", "BY", "BY", "AY", "BZ", "BX", "CY", "BY", "CY", "BZ", "CZ", "CZ", "CY", "BY", "AY", "CX", "BX", "BX", "BY", "CY", "CY", "BY", "BZ", "CY", "BX", "CY", "CZ", "BX", "AY", "BX", "CY", "CX", "AY", "BX", "AY", "AY", "CY", "BY", "CY", "BX", "CY", "BY", "CY", "BX", "CY", "BY", "AY", "AY", "CZ", "BX", "CY", "CZ", "BY", "AX", "CX", "BX", "BX", "CY", "BX", "CX", "BY", "AY", "BY", "CY", "BY", "CY", "CY", "AX", "CX", "CY", "BY", "BY", "CY", "CY", "AY", "AY", "CZ", "CY", "CY", "BX", "AY", "CZ", "BY", "BY", "BY", "CZ", "BZ", "BZ", "CX", "CY", "BY", "BY", "AY", "CY", "CY", "BY", "CY", "AY", "CY", "BY", "CY", "BZ", "BY", "AY", "BY", "BX", "CZ", "CX", "CX", "AY", "CZ", "BY", "BX", "AY", "BY", "AX", "BY", "BY", "BY", "BX", "CY", "CY", "AY", "AY", "BY", "BZ", "BY", "BX", "BZ", "CX", "BY", "AY", "BZ", "BX", "AY", "BY", "AY", "BX", "BX", "BX", "BY", "CX", "BX", "CX", "CY", "BY", "AX", "BY", "CY", "BY", "CY", "BY", "BY", "AY", "BZ", "BX", "BY", "BY", "BY", "AZ", "AY", "CY", "CZ", "CX", "BZ", "CY", "BY", "AY", "BX", "BY", "CX", "BX", "BY", "CY", "BZ", "CY", "BZ", "BZ", "BY", "BX", "BY", "BY", "BY", "CY", "AY", "AX", "CY", "BY", "CZ", "BZ", "CY", "CX", "BX", "CX", "BX", "CZ", "AY", "CY", "BZ", "CY", "AX", "BZ", "BY", "BX", "BY", "BX", "CX", "CX", "BZ", "BZ", "CY", "BY", "BX", "BX", "BZ", "AY", "AY", "AY", "BZ", "BX", "CZ", "BY", "BY", "CY", "CY", "BX", "BY", "CY", "BY", "BY", "AX", "BZ", "AZ", "BZ", "CX", "BZ", "AY", "BZ", "BY", "BZ", "AY", "BY", "CY", "CZ", "BY", "CX", "BX", "BY", "AY", "BZ", "CY", "CX", "CZ", "AY", "BY", "CY", "AX", "CZ", "BX", "CY", "AY", "BY", "BZ", "AY", "BX", "CY", "BY", "CZ", "CY", "BY", "BY", "CY", "CY", "CY", "AY", "BZ", "CY", "BX", "AY", "CY", "AY", "AX", "BZ", "AY", "BX", "BY", "BX", "AY", "CZ", "BY", "BZ", "CX", "CY", "CY", "BZ", "BY", "CY", "CX", "CY", "CY", "BY", "BY", "AY", "BX", "CY", "CY", "CY", "CY", "BY", "BY", "CZ", "CX", "BY", "CZ", "AY", "BX", "AY", "BY", "CX", "BX", "BX", "BY", "AX", "CX", "CY", "BY", "CY", "CX", "BY", "CZ", "BY", "AY", "CY", "CY", "AX", "AY", "CY", "AY", "AY", "CY", "AY", "BY", "AY", "BZ", "BX", "AX", "AX", "AZ", "BY", "BY", "CX", "CY", "CX", "CX", "AY", "BX", "BY", "BY", "AX", "BX", "BY", "BY", "CY", "BY", "CY", "CX", "AX", "CY", "BY", "CY", "BY", "CZ", "BX", "BY", "BX", "BX", "CY", "BY", "AX", "CY", "BY", "BX", "AY", "BX", "AY", "CY", "BZ", "BY", "AY", "AY", "BY", "BX", "BY", "CY", "BY", "BY", "AY", "AY", "CY", "BY", "CZ", "CX", "CZ", "CX", "CZ", "AY", "BY", "AY", "CY", "CY", "BY", "CY", "BX", "BX", "AY", "BY", "BY", "AY", "BX", "BY", "BY", "CX", "CY", "CX", "CY", "CY", "CY", "CX", "CZ", "BX", "BY", "CY", "BY", "BY", "CY", "BX", "CY", "BY", "BY", "BZ", "BX", "AZ", "CY", "CY", "AY", "BY", "BY", "AY", "BX", "CY", "BY", "BY", "BZ", "BX", "CY", "BY", "AY", "BZ", "CY", "CX", "CY", "CY", "BY", "AY", "CY", "CX", "AY", "BY", "BZ", "BX", "CZ", "AX", "CY", "BY", "BZ", "CY", "BY", "BY", "BY", "BY", "CY", "BY", "CY", "BY", "AY", "AY", "AX", "BY", "CY", "CY", "CY", "CX", "CZ", "CX", "BX", "AY", "CY", "AY", "BY", "CY", "CZ", "AY", "BX", "BX", "AY", "BX", "CY", "BY", "BY", "BY", "BY", "CZ", "CY", "BY", "BX", "AY", "BZ", "AY", "CY", "BZ", "AY", "BY", "CY", "CY", "BY", "BY", "CY", "AZ", "CY", "CX", "CY", "CY", "CY", "BX", "CY", "AY", "CY", "BX", "BY", "CY", "CX", "BY", "BY", "AY", "BX", "AY", "AY", "BY", "AY", "CY", "BY", "BZ", "AY", "CZ", "BY", "BY", "BX", "AY", "BX", "CY", "AY", "AY", "AY", "BY", "BZ", "CY", "CY", "BX", "AY", "CY", "AY", "BY", "BX", "BY", "BY", "CX", "BY", "BY", "BY", "BY", "AY", "AY", "CY", "AX", "BX", "AY", "BX", "BZ", "BZ", "BZ", "BY", "BY", "CY", "CY", "CZ", "BZ", "BZ", "CY", "BY", "BY", "CX", "CY", "CY", "BY", "AY", "BX", "AY", "BY", "AY", "CY", "BZ", "AY", "BY", "BY", "BY", "CZ", "AY", "AY", "CY", "BY", "CY", "BY", "CY", "BZ", "CY", "CX", "CY", "CY", "BY", "AX", "CY", "AY", "CX", "AX", "AY", "BZ", "CY", "CY", "BY", "CY", "CY", "BY", "CY", "CZ", "BY", "AX", "CY", "BX", "AY", "CY", "BZ", "BY", "BZ", "AY", "BY", "BZ", "CX", "BY", "CY", "AX", "CX", "AX", "BY", "BX", "CY", "CY", "BY", "BY", "CY", "BZ", "CX", "AY", "AY", "BY", "BX", "BY", "AY", "BY", "BZ", "CX", "AY", "BX", "CY", "CY", "AX", "BY", "CZ", "BX", "BY", "BY", "CY", "BZ", "BY", "BZ", "AY", "CY", "CY", "BY", "CZ", "CY", "AX", "AY", "CY", "BZ", "AY", "AX", "CY", "BX", "BX", "AY", "BY", "BZ", "AY", "CY", "BY", "CZ", "CY", "CY", "BY", "CY", "BZ", "CY", "BY", "CZ", "AX", "AY", "AZ", "CY", "BY", "BZ", "BX", "BX", "CY", "AX", "CY", "BX", "BX", "CY", "AZ", "BX", "AZ", "BY", "BY", "AY", "BZ", "CY", "BY", "CY", "CY", "AY", "CY", "BY", "CZ", "CZ", "BY", "BX", "CY", "CY", "CY", "BY", "CY", "BZ", "BZ", "AX", "CX", "BX", "CZ", "CY", "BX", "BY", "AZ", "CY", "BZ", "BY", "CY", "BX", "BZ", "BY", "AY", "BY", "BX", "CY", "BY", "BZ", "CY", "CZ", "CZ", "CY", "AY", "CX", "BY", "AY", "BZ", "CY", "AX", "CX", "CZ", "CZ", "AY", "BY", "CX", "CY", "CY", "BX", "CX", "CY", "BX", "BX", "CY", "BY", "BY", "BY", "BY" };
            int score = 0;


            for (int i = 0; i < puzzelInput.Length; i++)
            {

                char against = puzzelInput[i][0];
                char outcome = puzzelInput[i][1];


                //LOSE
                if (outcome == 'X')
                {
                    score += 0;

                    //ROCK
                    if (against == 'A')
                    {
                        score += 3;
                    }
                    //PAPER
                    else if (against == 'B')
                    {
                        score += 1;
                    }
                    //SCISSORS
                    else if (against == 'C')
                    {
                        score += 2;
                    }
                }
                //DRAW
                else if (outcome == 'Y')
                {
                    score += 3;

                    //ROCK
                    if (against == 'A')
                    {
                        score += 1;
                    }
                    //PAPER
                    else if (against == 'B')
                    {
                        score += 2;
                    }
                    //SCISSORS
                    else if (against == 'C')
                    {
                        score += 3;
                    }
                }

                //WIN
                else if (outcome == 'Z')
                {
                    score += 6;

                    //ROCK
                    if (against == 'A')
                    {
                        score += 2;
                    }
                    //PAPER
                    else if (against == 'B')
                    {
                        score += 3;
                    }
                    //SCISSORS
                    else if (against == 'C')
                    {
                        score += 1;
                    }
                }
            }
            Console.WriteLine($"totale score zal {score} zijn");


        }
    }
}
