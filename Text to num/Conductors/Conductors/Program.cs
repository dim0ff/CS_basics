using System;
using System.Collections.Generic;
using System.Linq;

namespace Conductors
{
    class Program
    {
        static void Main(string[] args)
        {
            int binaryTicket = int.Parse(Console.ReadLine());
            int binaryPerforator = int.Parse(Console.ReadLine());

            string binaryTicket01 = Convert.ToString(binaryTicket, 2);

            for (int pos = 0; pos < 26; pos++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    var posInBinaryTicket = pos + j;
                    var posInPerforator = j;

                    int bitInBinaryTicket = (binaryTicket & (1 << posInBinaryTicket)) >> posInBinaryTicket;
                    int bitInPerforator = (binaryPerforator & (1 << posInPerforator)) >> posInPerforator;

                    if (bitInBinaryTicket != bitInPerforator)
                    {
                        match = false;
                        break;
                    }
                    else
                    {
                        bitInBinaryTicket = 0;
                    }
                }

                Console.WriteLine(binaryTicket01);
            }
        }
    }
}
