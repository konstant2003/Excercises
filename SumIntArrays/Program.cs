using System;
using System.Collections.Generic;
using System.Linq;

namespace SumIntArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] output = new int[input1.Length];
            
            //int inputsum = input1.Sum();
            //Console.WriteLine(inputsum);
            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = input1[i] + input2[i];

            }
            Console.WriteLine(String.Join(" ", output));
            
        }
    }
}
