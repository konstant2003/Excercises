using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {

            //int input = 0;
            //while (input % 2 == 1)
            //{
            //    Console.WriteLine("Enter an odd number");
            //    input = int.Parse(Console.ReadLine());
            //}
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write(j+ " ");                   
                }
                Console.WriteLine();
            }

        }
    }
}
