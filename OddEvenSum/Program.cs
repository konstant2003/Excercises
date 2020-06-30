using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n * 2];
            for (int i = 0; i < n*2; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            int oddsum=0;
            int evensum=0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0) { oddsum = oddsum + input[i]; }
                if (i % 2 == 1) { evensum = evensum + input[i]; }
            }
            if (oddsum == evensum) { Console.WriteLine($"Yes, sum={oddsum}"); }
            else { Console.WriteLine($"No, diff={Math.Abs(evensum - oddsum)}"); }

           
        }
    }
}
