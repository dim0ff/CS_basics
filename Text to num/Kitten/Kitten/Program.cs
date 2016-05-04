using System;
using System.Collections.Generic;
using System.Linq;

namespace Kitten
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsNum; i++)
            {
                int[] individualSpeeds = new int[carsNum];
                for (int j = 0; j < individualSpeeds.Length; j++)
                {
                    individualSpeeds[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine(individualSpeeds);
                }
            }
            
            //for each element of the array, see if it's larger than the neighbour on the left. If yes, make them equal
//            foreach (speed in individualSpeeds)
//            {
//                if(individualSpeeds[car] > individualSpeeds[car - 1]) {

//}
//            }

        }
    }
}
