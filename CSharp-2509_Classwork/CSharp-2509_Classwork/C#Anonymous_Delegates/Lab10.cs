using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Anonymous_Delegates
{
    public class AddDelegate
    {


        public delegate int CalculationDelegate(int x, int y);

        // Method for addition
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Method for subtraction
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method that accepts two integers and a CalculationDelegate to perform the operation
        public static int Calculate(int x, int y, CalculationDelegate operation)
        {
            return operation(x, y);
        }
    }
}
