using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] {
                1,2,3,4,5,6
            };

            var searched = Array.BinarySearch(arr, 4);
            Console.WriteLine(searched);  
        }
    }
}
