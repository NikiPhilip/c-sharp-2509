//Create a class Employee with a method Work(). Derive a class Manager that overrides the 
//Work() method to show a different implementation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Employee
    {
        // Virtual Work method in the base class
        public virtual void Work()
        {
            Console.WriteLine("Employee is working on general tasks.");
        }
    }

    // Derived class Manager that inherits from Employee
    public class Manager : Employee
    {
        // Override the Work method for Manager
        public override void Work()
        {
            Console.WriteLine("Manager is overseeing the team's work.");
        }
    }
}