//Create a base class Person with a property Name. In the derived class Student, hide the Name 
//property using the new keyword and use base to access the base class's Name property.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Person4
    {
        // Property for Name
        public virtual string Name { get; set; }
    }

    // Derived class Student that hides the Name property
    public class Student2 : Person4
    {
        // Hiding the Name property using new keyword
        public new string Name
        {
            get { return "Student Name Hidden"; } 
            set {  }
            
        }

        // Method to display names
        public void DisplayNames()
        {
            Console.WriteLine($"Base Name (from Person): {base.Name}"); 
            Console.WriteLine($"Derived Name (from Student): {Name}"); 
        }
    }
}