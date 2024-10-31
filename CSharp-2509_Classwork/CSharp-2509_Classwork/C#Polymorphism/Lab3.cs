
//Write a program demonstrating method overriding by creating a base class Vehicle and a derived 
//class Car that overrides the Drive() method. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Polymorphism
{
    public class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving a Vehicle");
        }

    }
    public class Car:Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
