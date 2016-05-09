using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] nums = new int[length];

            for (int i = 0; i < length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int storeBigger;

            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        storeBigger = nums[i];
                        nums[i] = nums[j];
                        nums[j] = storeBigger;
                    }
                }
            }

            Console.WriteLine(string.Join("\n", nums));
        }
    }
}
