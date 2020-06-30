using System;
using System.Linq;

namespace ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = new char[3];
            for (int i = 0; i < 3; i++)
            {
                input[i] =char.Parse(Console.ReadLine());
            }
            //var output = input.Reverse();
            Array.Reverse(input);
            string result = new string(input);
            Console.WriteLine(result);
            //foreach (var item in input)
            //{
            //    Console.Write(item);
            //}
        }
    }
}
