using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee employee1 = new Employee();
                employee1.Salary = 500;
                Console.WriteLine($"The employee salary is {employee1.Salary}");
                Employee employee2 = new Employee();
                employee2.Salary = -4;
                Console.WriteLine("The employee's salary is " + employee1.Salary);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
