using System;

namespace Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a number can be divided by 7 and 5.");     
            Console.WriteLine("Enter your number!");
            int inputnum = int.Parse(Console.ReadLine());
            if(inputnum%35==0)
            {
                Console.WriteLine("ba4ka manqk");
            }
            else { Console.WriteLine("ne ba4ka manqk"); }
        }
    }
}
