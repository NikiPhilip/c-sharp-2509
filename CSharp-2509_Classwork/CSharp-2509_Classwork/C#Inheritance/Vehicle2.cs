using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Vehicle3
    {
        public string Brand { get; set; }

        // Constructor that accepts brand
        public Vehicle3(string brand)
        {
            Brand = brand;
            Console.WriteLine($"Vehicle Brand: {Brand}");
        }
    }

    // Derived class Car that inherits from Vehicle
    public class Car3 : Vehicle3
    {
        // Additional property for Car
        public string Model { get; set; }

        // Constructor for Car that accepts brand and model
        public Car3(string brand, string model) : base(brand)
        {
            Model = model;
            Console.WriteLine($"Car Model: {Model}");
        }
    }
}