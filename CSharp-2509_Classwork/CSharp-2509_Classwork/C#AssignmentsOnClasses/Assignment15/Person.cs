using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    internal class Person
    {
        // Fields of the class
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize the fields
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy constructor that creates a new object from an existing object
        public Person(Person existingPerson)
        {
            Name = existingPerson.Name;  
            Age = existingPerson.Age;    
        }

        // Method to display person details
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

}

