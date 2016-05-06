using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_increasing_subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] nums = new int[length];

            int currentSeq = 1;
            int maxSeq = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (currentSeq > maxSeq)
                {
                    maxSeq = currentSeq;
                }
            }

            Console.WriteLine(maxSeq);
        }
    }
}
