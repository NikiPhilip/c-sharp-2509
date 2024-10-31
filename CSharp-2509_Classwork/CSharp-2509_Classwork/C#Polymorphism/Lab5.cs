
//Create a C# program that demonstrates polymorphism using a base class Employee and derived 
//classes Manager and Developer. Include a static field to keep track of the total number of 
//employees and a static method to display the total count. Use method overriding to demonstrate 
//polymorphism, while also explaining the need for static members in this context.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Polymorphism;

namespace C_Polymorphism
{
    public class Employee
    {
        protected static int employeeCount = 0;

        
        public Employee()
        {
            employeeCount++;
        }

        // Static method to display the total number of employees
        public static void DisplayEmployeeCount()
        {
            Console.WriteLine("Total number of employees: " + employeeCount);
        }

        // Virtual method to be overridden in derived classes
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }

    public class Manager : Employee
    {
        // Override the Work method for Manager
        public override void Work()
        {
            Console.WriteLine("Manager is overseeing work.");
        }
    }

    public class Developer : Employee
    {
        // Override the Work method for Developer
        public override void Work()
        {
            Console.WriteLine("Developer is writing code.");
        }
    }
}