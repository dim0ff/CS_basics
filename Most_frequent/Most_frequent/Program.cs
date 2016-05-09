using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_frequent
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] nums = new int[] {
                1,2,3,2,4,2,5,6,3,6,7,2,5,6,7,8,9,4,3,6,6,5,7,6
            };

            Array.Sort(nums);


            int highestCount = 0;
            int count = 1;
            int mostFrequent = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if (nums[j] == nums[j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > highestCount)
                    {
                        mostFrequent = nums[j];
                    }
                }
            }

            Console.WriteLine(mostFrequent);
        }
    }
}
