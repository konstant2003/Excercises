using System;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Enter first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender (m or f)");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter personal ID");
            string personalID = Console.ReadLine();
            Console.WriteLine("Enter employee ID");
            string employeeID = Console.ReadLine();
             
            Employee employee = new Employee(firstname, lastname, age, gender, personalID, employeeID);

            employee.DisplayInfo();
        }
    }
}
