using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendListsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            List<int> result = new List<int>();
            for (int i = input.Length-1 ; i >=0 ; i--)
            {
                int[] convertion = input[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                result.AddRange(convertion);
            }

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
