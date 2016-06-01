using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBastun
{
    class Program
    {
        static void ToBinary(int x)
        {
            string yada = Convert.ToString(x, 2).PadLeft(8, '0');
        }
        static void Main(string[] args)
        {
            var binaryCode = String.Join("", Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            var code = binaryCode.Split(new char[] { '0' }, StringSplitter.Select(x => x.Length));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                var line = Console.ReadLine();
                int index = int.Parse(line.Substring(1));
                reverseTable[index] = line[0];
            }

            var text = code.Select(x => reverseTable[x]).ToArray();

            Console.WriteLine(text);
        }
    }
}
