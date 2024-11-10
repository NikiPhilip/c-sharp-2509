//Create a Circle struct to represent a circle as a value type, and a Shape class to
//represent a reference type. Show how changing values affects each.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignment
{
    public struct Circle
    {
        // Properties for the Circle struct
        public double Radius { get; set; }

        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Method to calculate the area of the circle
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Shape
    {
        // Properties for the Shape class
        public double Radius { get; set; }

        // Constructor
        public Shape(double radius)
        {
            Radius = radius;
        }

        // Method to calculate the area of the shape 
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}