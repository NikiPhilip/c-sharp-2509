
//o Create a main class ExceptionDemo with the Main method. 
//o In the Main method: 
// Create an instance of FileProcessor and call ReadFileContent() with a file 
//path that does not exist to trigger and handle the FileNotFoundException. 
// Create an instance of MathOperations and call Divide() with b as 0 to 
//trigger and handle the DivideByZeroException. 
//Create an instance of Person, call SetAge() with an invalid age (like -5 or 130) to trigger and 
//handle the InvalidAgeException.


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignment
{
    public class InvalidAgeException2 : Exception
    {
        public InvalidAgeException2(string message) : base(message) { }
    }

    // Class representing a person
    public class Person2
    {
        private int age;

        public int Age
        {
            get { return age; }
        }

        public void SetAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException("Age must be between 0 and 120.");
            }
            this.age = age;
        }
    }

    // Class to process file operations
    public class FileProcessor2
    {
        public void ReadFileContent(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
        }
    }

    // Class to perform math operations
    public class MathOperations3
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero: " + ex.Message);
                return 0; // Return 0 or another suitable default value
            }
        }
    }

}
