
//Create a base class Animal with a virtual method MakeSound(). Derive classes Dog and Cat that 
//override the MakeSound() method to provide their specific implementation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    public class Animal
    {
        //Declaring virtual method MakeSound
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal is making sound");
        }
    }
    //Class Dog is inheriting class Animal
    public class Dog:Animal
    {
        //Overriding method MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    //Class inherits from class Animal
    public class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat is meowing");
        }
    }


}
