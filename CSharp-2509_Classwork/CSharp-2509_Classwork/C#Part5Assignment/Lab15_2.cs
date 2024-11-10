using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignment
{
    public class MathOperations2
    {
        // Method to divide two integers
        public void Divide(int a, int b)
        {
            try
            {
                // Attempt to perform the division
               int result=a/b; // Cast to double for accurate division
                Console.WriteLine($"Result:{result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
                
            }
        }
    }

}
