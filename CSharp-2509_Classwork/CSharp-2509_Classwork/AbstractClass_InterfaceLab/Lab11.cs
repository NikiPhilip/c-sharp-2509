
//Create an enum CarType with values Sedan, SUV, Truck, and Coupe. Write a Car class with a
//property Type of type CarType. Write a method that takes a CarType value and displays a 
//message specific to that type of car. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    public class Car3
    {
        public enum CarType
        {
            Sedan,
            SUV,
            Truck,
            Coupe
        }
        // Property to hold the type of car
        public CarType Type { get; set; }

        // Method to display a message specific to the car type
        public void DisplayCarTypeMessage()
        {
            switch (Type)
            {
                case CarType.Sedan:
                    Console.WriteLine("You have chosen a Sedan. It's great for city driving.");
                    break;
                case CarType.SUV:
                    Console.WriteLine("You have chosen an SUV. It's perfect for off-road adventures.");
                    break;
                case CarType.Truck:
                    Console.WriteLine("You have chosen a Truck. It's built for hauling.");
                    break;
                case CarType.Coupe:
                    Console.WriteLine("You have chosen a Coupe. It's stylish and sporty.");
                    break;
                default:
                    Console.WriteLine("Unknown car type.");
                    break;
            }
        }

    }
}