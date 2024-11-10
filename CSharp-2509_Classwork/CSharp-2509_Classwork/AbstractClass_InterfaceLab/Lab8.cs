//Create a partial class Employee with a partial method CalculateSalary(). Implement the partial 
//method in another part of the class and demonstrate its usage. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    public partial class Employee
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        // Declaration of the partial method CalculateSalary
        partial void CalculateSalary();
    }
}