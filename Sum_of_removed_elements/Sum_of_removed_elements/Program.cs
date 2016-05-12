using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_removed_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int maxes = int.Parse(Console.ReadLine());

            int[] firstCharArr = new int[length];
            int[] largestInts = new int[maxes];

            int sumOfLargest = 0;

            for (int i = 0; i < firstCharArr.Length; i++)
            {
                firstCharArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < maxes; i++)
            {
                int max = firstCharArr.Max();
                largestInts[i] = max;
                int numToRemove = max;
                firstCharArr = firstCharArr.Where(val => val != numToRemove).ToArray();
            }

            for (int i = 0; i < largestInts.Length; i++)
            {
                sumOfLargest += largestInts[i];
            }

            Console.WriteLine(sumOfLargest);
        }
    }
}
