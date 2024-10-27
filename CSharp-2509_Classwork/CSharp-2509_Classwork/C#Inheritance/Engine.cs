
//Create a class Engine with properties like HorsePower. Create a class Car that contains an instance 
//of Engine and shows the HAS-A relationship. Demonstrate how the Car can use its Engine to show 
//engine-related details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Engine
    {
        // Property for HorsePower
        public int HorsePower { get; set; }

        // Constructor for Engine
        public Engine(int horsePower)
        {
            HorsePower = horsePower;
        }

        // Method to display engine details
        public void DisplayEngineDetails()
        {
            Console.WriteLine($"Engine HorsePower: {HorsePower} HP");
        }
    }
    public class Car2
    {
        // Property for Car's Engine
        public Engine Engine { get; set; }

        // Constructor for Car
        public Car2(Engine engine)
        {
            Engine = engine; // Assign the passed Engine instance to the Car
        }

        // Method to display Car details
        public void DisplayCarDetails()
        {
            Console.WriteLine("Car Details:");
            Engine.DisplayEngineDetails(); // Use Engine's method to display engine details
        }
    }
}