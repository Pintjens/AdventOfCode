using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Encrypt
    {
        public static void Encripting()
        {
            string choice;
            string input = "";

            string decryptedText = "";
            string charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789+/";

            Console.WriteLine(charSet.IndexOf("pqrs"));

            do
            {
                Console.WriteLine("==========\nWat wil je doen?\n1 - Een boodschap encrypteren\n2 - Een boodschap decrypteren\n3 - Stoppen\n==========");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    string encryptedText = "";
                    Console.Write("Welke boodschap zou je graag encrypteren? ");
                    input = Console.ReadLine();

                    // dit moet eigenlijk in een eigen functie
                    int checkSum = 0;
                    foreach (char letter in input)
                    {
                        checkSum += Convert.ToInt32(letter);
                    }


                    // dit moet eigenlijk ook in een eigen functie
                    int i;
                    string base3;
                    for (i = 0; i < input.Length - 3; i += 3)
                    {
                        base3 = input.Substring(i, 3);
                        encryptedText += Encrypter(base3);

                    }
                    base3 = input.Substring(i);
                    while (base3.Length < 3)
                    {
                        base3 = base3 + " ";
                    }
                    if (base3.Length == 3)
                    {
                        encryptedText += Encrypter(base3);
                    }


                    // zonder de checksum char
                    Console.WriteLine(encryptedText);

                    encryptedText += charSet[checkSum % charSet.Length];
                    // met checksum char
                    Console.WriteLine(encryptedText);

                }

                if (choice == "2")
                {
                    // dit is perfect
                    string encryptedText = "";
                    Console.Write("welke boodschap zou je graag decrypteren? ");
                    encryptedText = Console.ReadLine();

                    decryptedText = Decrypter(encryptedText.Substring(0, encryptedText.Length - 1));
                    Console.WriteLine(decryptedText);



                    // hier zit nog ergens iets verkeerd
                    int checkSum = 0;
                    foreach (char letter in decryptedText)
                    {
                        checkSum += Convert.ToInt32(letter);
                    }

                    if (checkSum % charSet.Length != charSet.IndexOf(encryptedText[encryptedText.Length - 1])){
                        Console.WriteLine("Er werd onderweg aan de boodschap gefoefeld..");
                    }


                }

                Console.WriteLine();

            } while (choice != "3");


        }
        public static string Decrypter(string encryptedText)
        {

            int[,,,] codeArray = CodeArrayBuilder();

            string decryptedText = "";

            string charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789+/";

            for (int l = 0; l < encryptedText.Length; l += 4)
            {
                string base4 = encryptedText.Substring(l, 4);

                int a = charSet.IndexOf(base4[0]);
                int b = charSet.IndexOf(base4[1]);
                int c = charSet.IndexOf(base4[2]);
                int d = charSet.IndexOf(base4[3]);

                int i = 0;
                int j = 0;
                int k = 0;

                while (i < 255)
                {
                    while (j < 255)
                    {
                        while (k < 255)
                        {
                            if (codeArray[i, j, k, 0] == a && codeArray[i, j, k, 1] == b && codeArray[i, j, k, 2] == c && codeArray[i, j, k, 3] == d)
                            {
                                decryptedText += Convert.ToString(Convert.ToChar(i));
                                decryptedText += Convert.ToString(Convert.ToChar(j));
                                decryptedText += Convert.ToString(Convert.ToChar(k));
                                // hier zou die er eigenlijk al uit mogen springen
                                // best per 4 naar een eigen functie sturen dus =)
                            }
                            k++;
                        }
                        k = 0;
                        j++;

                    }
                    j = 0;
                    i++;

                }  
            }
            return decryptedText;
        }

        public static string Encrypter(string base3)
        {
            // dit is ook perfect
            int[,,,] codeArray = CodeArrayBuilder();

            string charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789+/";

            int a = Convert.ToInt32(base3[0]);
            int b = Convert.ToInt32(base3[1]);
            int c = Convert.ToInt32(base3[2]);
            string encrypted4 = "";

            for (int k = 0; k < 4; k++)
            {
                encrypted4 += charSet[codeArray[a, b, c, k]];
            }

            return encrypted4;
        }
        public static string CodeStringBuilder() // alternatieve optie proberen uitbouwen
        {
            string codeString = "";


            

            return codeString;
        }
        public static int[,,,] CodeArrayBuilder()
        {

            // dit kan waarschijnlijk mooier

            int[,,,] codeArray = new int[255, 255, 255, 4];
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < 255; i++)
            {
                for (int j = 0; j < 255; j++)
                {
                    for (int k = 0; k < 255; k++)
                    {

                        codeArray[i, j, k, 0] = a;
                        codeArray[i, j, k, 1] = b;
                        codeArray[i, j, k, 2] = c;
                        codeArray[i, j, k, 3] = d;
                        d++;
                        if (d == 64)
                        {
                            d = 0;
                            c++;
                        }
                        if (c == 64)
                        {
                            c = 0;
                            b++;
                        }
                        if (b == 64)
                        {
                            b = 0;
                            a++;
                        }
                        if (a == 64)
                        {
                            return codeArray;
                        }
                    }
                }
            }
            // om foutmelding op te heffen
            return codeArray;
        }
    }
}


