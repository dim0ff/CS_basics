using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tres4 = {
                    "CHU",
                    "TEL", 
                    "OFT",
                    "IVA",
                    "EMY",
                    "VNB",
                    "POQ",
                    "ERI",
                    "CAD",
                    "K-A",
                    "IIA",
                    "YLO",
                    "PLA"
            };

            int num = int.Parse(Console.ReadLine());
            int[] digits = new int[32];

            int digitCount = 0;

            do
            {
                digits[digitCount] = (int)(num % 9);
                num /= 9;
                digitCount++;
            }
            while (num > 0);

            for (int i = digitCount - 1; i >= 0; i--)
            {
                Console.Write(tres4[digits[i]]);
            }

            Console.WriteLine();
        }
    }
}