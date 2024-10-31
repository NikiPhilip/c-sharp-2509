
//Create a C# program demonstrating polymorphism using a base class Employee and derived 
//classes Manager and Developer. In this program, each employee should have a collection of 
//tasks (stored in an array) assigned to them. Use arrays as properties in the class to handle this
//data, and demonstrate how polymorphism and arrays work together in the solution.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Polymorphism
{
    public class Employee2
    {
        public string Name { get; set; }
        public string[] Tasks { get; set; }

        // Constructor
        public Employee2(string name, string[] tasks)
        {
            Name = name;
            Tasks = tasks;
        }

        // Virtual method to display tasks
        public virtual void DisplayTasks()
        {
            Console.WriteLine($"{Name}'s Tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine($"- {task}");
            }
        }
    }

    public class Manager2 : Employee2
    {
        // Constructor
        public Manager2(string name, string[] tasks) : base(name, tasks) { }

        // Overriding the DisplayTasks method
        public override void DisplayTasks()
        {
            Console.WriteLine($"Manager {Name} is overseeing the following tasks:");
            base.DisplayTasks(); // Call the base class method to display tasks
        }
    }

    public class Developer2 : Employee2
    {
        // Constructor
        public Developer2(string name, string[] tasks) : base(name, tasks) { }

        // Overriding the DisplayTasks method
        public override void DisplayTasks()
        {
            Console.WriteLine($"Developer {Name} is working on these tasks:");
            base.DisplayTasks(); // Call the base class method to display tasks
        }
    }
}