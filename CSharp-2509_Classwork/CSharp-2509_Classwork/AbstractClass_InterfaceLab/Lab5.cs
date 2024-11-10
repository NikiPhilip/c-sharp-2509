
//Create a static class MathOperations with a static method Add() and Multiply(). Demonstrate
//calling these methods without creating an instance of the class.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    //Defining static class MathOperations
    public static class MathOperations
    {

        //Static method for adding two numbers
        public static int Add(int number1,int number2)
        {
            return number1 + number2;

        }

        //Static method for multiplying two numbers
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
    
}
