using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
     public partial class Employee
    {
        public double Salary { get; private set; }

        // Implementation of the partial method CalculateSalary
        partial void CalculateSalary()
        {
            Salary = HourlyRate * HoursWorked;
        }

        // Method to trigger the CalculateSalary partial method
        public void DisplaySalary()
        {
            // Calling the partial method
            CalculateSalary();
            Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
        }
    }
}
