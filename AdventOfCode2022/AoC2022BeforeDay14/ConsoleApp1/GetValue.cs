using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class GetValue
    {
        internal class MinMax
        {
            public static int[] intAr2(int[,] source)
            {

                int[] returny = { source[0, 0], source[0, 0] };

                for (int i = 0; i < source.GetLength(0); i++)
                {
                    for (int j = 0; j < source.GetLength(1); j++)
                    {
                        if (source[i, j] < returny[0])
                        {
                            returny[0] = source[i, j];
                        }
                        if (source[i, j] > returny[1])
                        {
                            returny[1] = source[i, j];
                        }
                    }

                }

                return returny;
            }
            public static int[] intAr3(int[,,] source)
            {

                int[] returny = { source[0, 0, 0], source[0, 0, 0] };

                for (int i = 0; i < source.GetLength(0); i++)
                {
                    for (int j = 0; j < source.GetLength(1); j++)
                    {
                        for (int k = 0; k < source.GetLength(2); k++)
                        {
                            if (source[i,j,k] < returny[0])
                            {
                                returny[0] = source[i, j, k];
                            }
                            if (source[i, j, k] > returny[1])
                            {
                                returny[1] = source[i, j, k];
                            }
                        }
                    }
                }

                return returny;
            }
        }
        internal class Specific
        {
            public static int FlowRate(List<List<string>> valveData, int valveIndex)
            {
                return Convert.ToInt32(valveData[valveIndex]);
                Console.WriteLine(valveData[valveIndex]);
            }
        }
        internal class SetSign
        {
            public static int Positive(int signedInt)
            {
                return Convert.ToInt32(Math.Sqrt(Math.Pow(signedInt, 2)));
            }
        }
        public static int ManhattanDistance(int sX, int sY, int bX, int bY)
        {
            return GetValue.SetSign.Positive(sX - bX) + GetValue.SetSign.Positive(sY - bY);
            // checked it, its right!
        }

    }
}
