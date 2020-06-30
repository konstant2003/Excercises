using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Data
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string PersonalID { get; set; }
        public string EmployeeID { get; set; }

        public Employee(string firstName, string lastName, int age, char gender, string personalID, string employeeID)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            PersonalID = personalID;
            EmployeeID = employeeID;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Last name: {LastName}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Personal ID: {PersonalID}");
            Console.WriteLine($"Unique Employee number: {EmployeeID}");
        }
    }
}

