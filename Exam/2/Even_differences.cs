using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBastun
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] sequence = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long sum = 0;
            int i = 1;

            while (i < sequence.Length)
            {
                long absDiff = Math.Abs(sequence[i] - sequence[i - 1]);
                Console.WriteLine(absDiff);
                if (absDiff % 2 == 0)
                {
                    i += 2;
                    sum += absDiff;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
