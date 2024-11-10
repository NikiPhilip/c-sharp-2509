
//Write a program that demonstrates the difference between an abstract class and an interface by
//creating an abstract class Bird with an abstract method Fly(), and an interface ISwim with a 
//method Swim().


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    //Defining abstract class Bird
    public abstract class Bird
    {
        public abstract void Fly();

        //Defining and implementing method Eat
        public void Eat()
        {
            Console.WriteLine("The bird is eating");
        }
    }

    //Defining interface ISwim
    public interface ISwim
    {
        void Swim();
    }

    public class Fish : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("The fish is swimming");
        }
    }

    //Class Pigeon implements abstract class Bird and interface ISwim
    public class Penguin:Bird,ISwim
    {
        public string name {  get; set; }
        public Penguin(string name)
        { 
            this.name = name; 
        }
        public override void Fly()
        {
            Console.WriteLine($"The {name} penguin is flying");
        }

        public void Swim()
        {
            Console.WriteLine($"The {name} penguin is Swimming");
        }
    }

   
}
