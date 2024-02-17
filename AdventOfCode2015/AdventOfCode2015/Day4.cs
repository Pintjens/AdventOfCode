using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AdventOfCode2015
{
    internal class Day4
    {
        public static void PartPicker()
        {
            Console.Write("Part? : ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "1":
                    Part1();
                    break;
                case "2":
                    Part2();
                    break;
                default:
                    Console.WriteLine("Not Possible");
                    PartPicker();
                    break;
            }
        }
        public static void Part1()
        {
            string input = Inputs.Day4.Full();

            string findStartWith = "00000";
            MD5 md5 = MD5.Create();

            int check = 0;
            bool looking = true;
            for(check = 0; looking; check++)
            {

                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input + check);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                //if (Convert.ToHexString(hashBytes).Substring(0,5) == findStartWith)
                //{
                //    looking = false;
                //    Console.WriteLine(Convert.ToHexString(hashBytes));
                //    Console.WriteLine(Convert.ToHexString(hashBytes).Length);
                //    Console.WriteLine(Convert.ToDecimal(hashBytes));
                //    Console.WriteLine(check);
                //}
                if (hashBytes[0] == 0 && hashBytes[1] == 0 && hashBytes[2] < 16)
                {
                    looking = false;
                    Console.WriteLine(Convert.ToHexString(hashBytes));
                    Console.WriteLine(Convert.ToHexString(hashBytes).Length);
                    Console.WriteLine(check);
                }
            }





            // 282750 is to high
            // 282749 is the right answer

        }
        public static void Part2()
        {
            string input = Inputs.Day4.Full();

            string findStartWith = "000000";
            MD5 md5 = MD5.Create();

            ulong check = 0;
            bool looking = true;
            for (check = 0; looking; check++)
            {

                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input + check);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                if (hashBytes[0] + hashBytes[1] + hashBytes[2] == 0)
                {
                    looking = false;
                    Console.WriteLine(check);
                }
            }
        }
    }
}
