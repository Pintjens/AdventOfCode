using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Printers
    {
        public static void PrintCharList(List<char> charList)
        {
            foreach (char character in charList)
            {
                Console.Write(character);
            }
            Console.WriteLine("|");
        }
        public static void DrawCharMap(char[,] map, bool wait = true)
        {
            Console.Clear();
            for (int row = 0; row < map.GetLength(0); row++) // map.GetLength(0)
            {
                for (int column = 0; column < map.GetLength(1); column++)
                {
                    Console.Write(map[row, column]);
                }
                Console.WriteLine();
            }
            if (wait)
            {
                Console.ReadLine();
            }
        }
        public static char[,] InitiateCharMap(int rows, int columns, char symbol = '.')
        {
            char[,] charMap = new char[rows, columns];

            for (int i = 0; i < charMap.GetLength(0); i++)
            {
                for (int j = 0; j < charMap.GetLength(1); j++)
                {
                    charMap[i, j] = symbol;
                }
            }
            return charMap;
        }
    }
}
