
//Create a sealed class MathOperations with a method Add(). Show that it cannot be inherited.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public sealed class MathOperations
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    // Attempting to inherit from a sealed class will cause a compilation error
    
    //public class AdvancedMathOperations : MathOperations
    //{
        
    //    // This will cause a compile-time error:
    //    // "Cannot derive from sealed type 'MathOperations'"
    //}
    
}