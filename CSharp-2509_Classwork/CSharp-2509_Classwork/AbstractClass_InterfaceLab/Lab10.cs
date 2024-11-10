
//Write a method Divide that takes two integers as input and returns their division. If a division by 
//zero occurs, catch the exception and display a custom error message. Demonstrate exception 
//handling with a try-catch-finally block.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    public class Exception
    {


        public static double Divide(int numerator, int denominator)
        {
            // Check if the denominator is zero and throw an exception if so
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }

            // Perform the division and return the result
            return (double)numerator / denominator;
        }
    }
}
