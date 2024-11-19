using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject9
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return a / b;
        }

    }
}