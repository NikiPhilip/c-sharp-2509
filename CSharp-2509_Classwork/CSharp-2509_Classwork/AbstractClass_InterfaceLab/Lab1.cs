using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    public abstract class Vehicle
    {
        // Abstract method to be implemented by derived classes
        public abstract void StartEngine();

        // Concrete method to stop the engine
        public void StopEngine()
        {
            Console.WriteLine("The engine has been stopped.");
        }
    }

    public class Car : Vehicle
    {
        // Implementing the StartEngine method specifically for Car
        public override void StartEngine()
        {
            Console.WriteLine("Car engine starts with a quiet purr.");
        }
    }

    public class Motorcycle : Vehicle
    {
        // Implementing the StartEngine method specifically for Motorcycle
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine starts with a loud roar.");
        }
    }
}