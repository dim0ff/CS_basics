using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {
                5, 4, 3, 2, 1 
            };

            int smallest = 0;
            int indexOfSmallest = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        smallest = arr[j];
                        indexOfSmallest = j;
                    }
                }

                arr[indexOfSmallest] = arr[i];
                arr[i] = smallest;
            }

            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
