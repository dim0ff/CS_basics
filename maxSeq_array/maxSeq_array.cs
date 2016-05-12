using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxSeq = 1;
            int currSeq = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currSeq++;
                }
                else
                {
                    currSeq = 1;
                }

                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                }
            }
            Console.WriteLine(maxSeq);
        }
    }
}
