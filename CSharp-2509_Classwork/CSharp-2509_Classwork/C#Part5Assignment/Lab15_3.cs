using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignment
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    // Class representing a person
    public class Person
    {
        private int age; // Private field to store age

        public int Age // Public property to get age
        {
            get { return age; }
        }

        // Method to set age with validation
        public void SetAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException("Age must be between 0 and 120.");
            }
            this.age = age; // Set age if valid
        }
    }
}