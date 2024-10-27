
//Create a base class Animal with properties like Name and methods like Eat(). Create a derived class
//Dog that inherits from Animal and adds its own method Bark(). Show how the IS-A relationship 
//works. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Animal2
    {
        // Property for Name
        public string Name { get; set; }

        // Method to simulate eating
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Derived class Dog that inherits from Animal
    public class Dog2 : Animal2
    {
        // Method to simulate barking
        public void Bark()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }
}
