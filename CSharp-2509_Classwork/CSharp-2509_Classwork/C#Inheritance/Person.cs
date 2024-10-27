//Create a base class Person with properties like Name and Age. Derive a class Student from
//Person and add a property Grade. Create objects and display the data. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Person
    {
        // Properties for Name and Age
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize Name and Age
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display Person information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Derived class: Student, inheriting from Person
    public class Student : Person
    {
        // Additional property: Grade
        public string Grade { get; set; }

        // Constructor to initialize Name, Age, and Grade
        public Student(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        // Override DisplayInfo to include Grade information
        public void DisplayStudentInfo()
        {
            base.DisplayInfo();  // Call the base class DisplayInfo method
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}