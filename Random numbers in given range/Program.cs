using System;

namespace Random_numbers_in_given_range
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min;
            int max;
            do
            {
                Console.WriteLine("Enter min number");
                min = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter max number");
                max = int.Parse(Console.ReadLine());
            } while (min > max);
                var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{rand.Next(min, max)} ");
            }
        }
    }
}
