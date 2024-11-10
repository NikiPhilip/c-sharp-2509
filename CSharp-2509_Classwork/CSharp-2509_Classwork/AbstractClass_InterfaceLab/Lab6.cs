//Create an extension method IsEven() for the int type that returns true if the number is even and 
//false if it is odd.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    // Defining a static class to hold the extension method
    public static class IntExtensions
    {
        // Defining the IsEven extension method for int type
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}