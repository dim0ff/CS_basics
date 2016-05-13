using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadane_s_algo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 
                2, 3, -6, -1, 2, -1, 6, 4, -8, 8
            };

            int currentSum = 0;
            int maxSubarraySum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //if next element is -, then set the sum back to 0
                currentSum = Math.Max(0, currentSum + arr[i]);
                //check if this is the maximum we have
                maxSubarraySum = Math.Max(currentSum, maxSubarraySum);
            }

            Console.WriteLine(maxSubarraySum);
        }
    }
}
