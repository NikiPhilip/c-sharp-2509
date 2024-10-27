using System;

namespace Assignment13
{
    internal class Mathoperations
    {
        public static readonly double Pi;


        static Mathoperations()
        {
            Pi = 3.14;
            Console.WriteLine("Static constructor called. Pi initialized.");
        }

        // Method to calculate the area of a circle
        public static double CalculateCircleArea(double radius)
        {
            return Pi * radius * radius;
        }
    }
}

