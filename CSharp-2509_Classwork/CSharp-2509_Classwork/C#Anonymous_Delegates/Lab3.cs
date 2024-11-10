using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Anonymous_Delegates
{
    public class Calculator
    {
        public delegate double OperationDelegate(double num1, double num2);

        // Methods for each operation
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return double.NaN; // Return Not a Number if division by zero
            }
            return num1 / num2;
        }

    }
}
