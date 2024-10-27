
//Create an abstract class Vehicle with an abstract method Drive(). Create two derived classes Car 
//and Bike that implement the Drive() method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public abstract class Vehicle2
    {
        // Abstract method Drive, no implementation in the base class
        public abstract void Drive();
    }

    // Derived class Car that inherits from Vehicle
    public class Car : Vehicle2
    {
        // Implementing the Drive method for Car
        public override void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    // Derived class Bike that inherits from Vehicle
    public class Bike : Vehicle2
    {
        // Implementing the Drive method for Bike
        public override void Drive()
        {
            Console.WriteLine("Riding a bike.");
        }
    }
}