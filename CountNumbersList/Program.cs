using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbersList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort();
            int item1count = input.Count(x => x ==input.First());
            Console.WriteLine($"{input.First()} ->{item1count}");
            for (int i = 1; i < input.Count; i++)
            { 
                if (input[i]!=input[i-1])
                {
                    var sameNums = input.Count(x => x == input[i]);
                    Console.WriteLine($"{input[i]} ->{sameNums} ");
                }
                
            }
        }
    }
}
