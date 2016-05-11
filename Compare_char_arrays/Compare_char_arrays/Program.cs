using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char[]arr1 = str1.ToCharArray();


            string str2 = Console.ReadLine();
            char[] arr2 = str2.ToCharArray();

            int index = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                index = i;
                if (arr1[i] != arr2[i])
                {
                    break;
                }
            }
            if (arr1[index] < arr2[index])
            {
                Console.WriteLine("<");
            }
            else if (arr1[index] > arr2[index])
            {
                Console.WriteLine(">");
            }
            else if (index != arr1.Length - 1)
            {
                Console.WriteLine(">");
            }
            else if (index != arr2.Length - 1)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
