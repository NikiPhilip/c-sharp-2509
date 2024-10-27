
//2.Create a base class Animal with a method Eat(). Derive a class Dog that inherits Animal and add 
//a method Bark(). Further derive a class Puppy from Dog and add a method Weep(). Show the 
//behavior.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Animal
    {
        // Method in the base class
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Derived class Dog from Animal
    public class Dog : Animal
    {
        // Method specific to Dog
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    // Derived class Puppy from Dog
    public class Puppy : Dog
    {
        // Method specific to Puppy
        public void Weep()
        {
            Console.WriteLine("Puppy is weeping.");
        }
    }
}
