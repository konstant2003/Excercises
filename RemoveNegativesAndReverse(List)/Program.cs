using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> output = new List<int>();
            foreach (var item in input)
            {
                if (item>=0)
                {
                    output.Add(item);
                }
            }
            output.Reverse();
            if (output.Count >0 )
            {
                Console.WriteLine(String.Join(" ", output));                
            }
            else { Console.WriteLine("empty"); }
        }
    }
}
