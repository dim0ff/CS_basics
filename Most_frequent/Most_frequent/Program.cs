using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_frequent
{
    class Program
    {
        static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            List<int> arr = new List<int>();
            List<int> sorted = new List<int>();
            int maxSubsetLenght = 0;

            for (int i = 0; i < n; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }


            for (int i = 1; i <= (int)Math.Pow(2, n) - 1; i++)
            {
                int tempSubsetLenght = 0;
                List<int> temp = new List<int>();


                for (int j = 1; j <= n; j++)
                {
                    if (((i >> (j - 1)) & 1) == 1)
                    {
                        temp.Add(arr[j - 1]);
                        tempSubsetLenght++;
                    }

                }

                if ((tempSubsetLenght > maxSubsetLenght) && (CheckAscending(temp)))
                {
                    sorted = temp;
                    maxSubsetLenght = tempSubsetLenght;
                }
            }

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i]);
            }
        }
    }
}
