//Create a C# program to show method overloading by implementing a Multiply method with 
//different parameter types, numbers and order.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Polymorphism
{
    internal class Calculator
    {
        public void Multiply(int a,int b)
        {
            int prod = a * b;
            Console.WriteLine("Product of two numbers are " + prod);
        }
        public void Multiply(double a,double b)
        {
            double prod = a * b;
            Console.WriteLine("Product of two double numbers " + prod);
        }

        public void Multiply(double a,double b,double c)
        {
            double prod = a * b * c;
            Console.WriteLine("Product of three numbers "+ prod);
        }
    }
}
