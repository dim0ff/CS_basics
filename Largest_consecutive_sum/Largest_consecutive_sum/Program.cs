using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_consecutive_sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int maxCount = int.MinValue;
            int currentCount = 1;
            int number = 0;
            for (int index = 0; index < n; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            for (int index = 1; index < n; index++)
            {
                if (arr[index] == arr[index - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    number = arr[index];
                }
            }
            if (n == 1)
            {
                maxCount = 1;
                number = arr[0];
            }
            Console.WriteLine("{0} " + "(" + "{1}" + " times" + ")", number, maxCount);

        }  
    }
}
