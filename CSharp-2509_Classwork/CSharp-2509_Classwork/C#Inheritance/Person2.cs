
//Create a base class Person with a parameterized constructor. Create a derived class Employee
//that calls the base class constructor.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Parameterized constructor for the base class Person
        public Person2(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Person Constructor: Name = {Name}, Age = {Age}");
        }
    }

    // Derived class Employee that inherits from Person
    public class Employee2 : Person2
    {
        public int EmployeeId { get; set; }

        // Parameterized constructor for the derived class Employee
        public Employee2(string name, int age, int employeeId)
            : base(name, age)  // Call the base class constructor
        {
            EmployeeId = employeeId;
            Console.WriteLine($"Employee Constructor: EmployeeId = {EmployeeId}");
        }
    }
}
