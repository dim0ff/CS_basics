using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int Total = int.Parse(Console.ReadLine());
            int cur = 1;
            var pc = Enumerable.Range(2, Total).ToList();

            while (cur <= Math.Sqrt(Total))
            {
                cur = pc.First(i => i > cur);
                pc.RemoveAll(i => i != cur && i % cur == 0);
            }

            Console.WriteLine(pc.Max());
        }
    }
}
