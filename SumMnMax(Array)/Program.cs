using System;
using System.Linq;

namespace SumMnMax_Array_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(input.Sum());
            Console.WriteLine(input.Min());
            Console.WriteLine(input.Max());
            Console.WriteLine(input.First());
            Console.WriteLine(input.Last());
            Console.WriteLine(input.Average());
        }
    }
}
