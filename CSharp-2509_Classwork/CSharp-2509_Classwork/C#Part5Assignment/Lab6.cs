
//: Create a method Divide that takes two integers, calculates their quotient and 
//remainder, and returns both values using the out keyword.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignment
{
    public class MathOperations
    {
        // Method to calculate quotient and remainder using out parameters
        public void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            // Calculate quotient and remainder
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
    }
}
