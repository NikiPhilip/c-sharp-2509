
//Create a base class Person with a method DisplayInfo(). Derive a class Employee that overrides 
//DisplayInfo() but still calls the base class's DisplayInfo() using base.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Person3
    {
        // Properties for Person
        public string Name { get; set; }
        public int Age { get; set; }

        // Method to display information about the person
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Derived class Employee that inherits from Person
    public class Employee3 : Person3
    {
        // Additional property for Employee
        public string JobTitle { get; set; }

        // Overriding DisplayInfo() method
        public override void DisplayInfo()
        {
            // Call the base class's DisplayInfo() method
            base.DisplayInfo();
            // Display additional information specific to Employee
            Console.WriteLine($"Job Title: {JobTitle}");
        }
    }
}
