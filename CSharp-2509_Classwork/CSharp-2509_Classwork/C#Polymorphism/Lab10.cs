using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Polymorphism
{
    public abstract class Animal
    {
        // Readonly property for species, set only during object construction
        public string Species { get; }

        // Constructor to initialize the readonly property
        protected Animal(string species)
        {
            Species = species;
        }

        // Abstract method to be implemented by derived classes
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public Dog() : base("Dog") { }

        // Overriding MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine($"{Species} says: Woof!");
        }
    }

    public class Cat : Animal
    {
        public Cat() : base("Cat") { }

        // Overriding MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine($"{Species} says: Meow!");
        }
    }
}