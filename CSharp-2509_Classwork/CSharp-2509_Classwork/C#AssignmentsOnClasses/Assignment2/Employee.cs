
using System;

namespace Assignment2
{

    //2.Design an Employee class with properties for Name and Salary.Use
    //getters and setters to manage access to the salary, ensuring it cannot be set to a negative value.
    //using System;
    public class Employee
    {
        public string name;
        private int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary can't be negative");

                }
                salary = value;

            }
        }
    }

}
