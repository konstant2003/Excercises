using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbersList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort();
            input.Reverse(); 
            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i])%1==0 )
                {
                    Console.Write($"{input[i]} ");
                }
            }

        }
    }
}
