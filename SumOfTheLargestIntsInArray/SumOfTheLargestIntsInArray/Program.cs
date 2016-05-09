using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTheLargestIntsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int largestElementsNum = int.Parse(Console.ReadLine());
            int[] nums = new int[length];

            int sum = 0;
            int largestNum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < largestElementsNum; i++)
            {
                int maxValue = nums.Max();
                int maxIndex = nums.ToList().IndexOf(maxValue);
                sum += maxValue;
                var numz = new List<int>(nums);
                numz.Remove(maxValue);
                nums = numz.ToArray();
            }

            Console.WriteLine(sum);
        }
    }
}
