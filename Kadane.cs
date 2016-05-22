using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadane
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {
                1,-1,2,5,-10
            };

            int currentMaxSum = 0;
            if (arr[0] >= 0)
            {
                currentMaxSum = arr[0];
            }

            int globalMaxSum = 0;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (currentMaxSum + arr[i] >= 0)
                {
                    currentMaxSum += arr[i];
                    if (currentMaxSum > globalMaxSum)
                    {
                        globalMaxSum = currentMaxSum;
                    }
                }
                else
                {
                    if (currentMaxSum >= 0)
                    {
                        currentMaxSum = arr[i];
                    }
                }

            }

            Console.WriteLine(globalMaxSum);
        }
    }
}
