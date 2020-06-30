using System;

namespace Play_with_int_double_and_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            string input = Console.ReadLine();

            if (input=="1")
            {
                Console.WriteLine("Plese enter an int:");
                int inputint = int.Parse(Console.ReadLine());
                Console.WriteLine($"{inputint+1}");
            }
            if (input == "2")
            {
                Console.WriteLine("Plese enter a double:");
                double inputdouble = double.Parse(Console.ReadLine());
                Console.WriteLine($"{inputdouble + 1}");
            }
            if (input=="3")
            {
                Console.WriteLine("Plese enter a string:");
                string inputstring = Console.ReadLine();
                Console.WriteLine($"{inputstring}*");
            }
        }
    }
}
