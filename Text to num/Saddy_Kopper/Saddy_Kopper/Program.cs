using System;
using System.Linq;

namespace Saddy_Kopper
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int columns = 9;
            int catHeadWidth = 3;
            int catHeadHeight = 0;

            string empty = " ";

            //for each increment of rows by 4, the columns add 2
            for (int i = 10; i <= rows; i += 4)
            {
                catHeadHeight++;
                catHeadWidth++;
                columns += 2;
            }
            catHeadHeight--;

            int row = 1;
            int col = 1;

            for (int i = 0; i < rows; i++)
            {

                //always the width, without the 2 ears (2 chars)
                int spaceBetweenEars = catHeadWidth - 2;
                Console.WriteLine(empty + symbol + String.Concat(Enumerable.Repeat(" ", spaceBetweenEars)) + symbol);

                for (int catHeadRows = 0; i < catHeadHeight; catHeadRows++)
                {
                    Console.WriteLine(empty + String.Concat(Enumerable.Repeat(symbol, catHeadWidth)));
                }
                int catNeckHeight = catHeadHeight;

                for (int l = 0; l < catNeckHeight; l++)
                {
                    Console.WriteLine(empty + empty + String.Concat(Enumerable.Repeat(symbol, catHeadWidth)));
                }

                Console.WriteLine();
            }
        }
    }
}

