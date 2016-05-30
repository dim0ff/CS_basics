using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class DecimalToBinarysdfds
{
    class DecimalToBinarydsfasdf
    {

        static void Main()
        {
            int fromBase = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int toBase = int.Parse(Console.ReadLine());

            ArbitraryToDec(fromBase, number, toBase);
        }

        public static void ArbitraryToDec(int fromBase, string number, int toBase)
        {
            int dec = 0;

            switch (fromBase)
            {
                case 2:
                    dec = Convert.ToInt32(number, 2);
                    DecToArbitraray(dec, toBase);
                    break;
                case 10:
                    dec = int.Parse(number);
                    DecToArbitraray(dec, toBase);
                    break;
                case 16:
                    dec = Convert.ToInt32(number, 16);
                    DecToArbitraray(dec, toBase);
                    break;
            }
        }

        public static void DecToArbitraray(int dec, int toBase)
        {
            string binary = "";
            string DecTo16 = "";

            switch (toBase)
            {
                case 2:
                    binary = Convert.ToString(dec, toBase);
                    Console.WriteLine(binary);
                    break;
                case 10:
                    Console.WriteLine(dec);
                    break;
                case 16:
                    DecTo16 = Convert.ToString(dec, 16);
                    Console.WriteLine(DecTo16);
                    break;
            }
        }
    }
}
