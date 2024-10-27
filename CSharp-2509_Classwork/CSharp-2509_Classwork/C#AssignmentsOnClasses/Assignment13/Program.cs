using System;

namespace Assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The value of Pi is: {Mathoperations.Pi}");

            // Using the CalculateCircleArea method
            double radius = 5.0;
            double area = Mathoperations.CalculateCircleArea(radius);
            Console.WriteLine($"The area of a circle with radius {radius} is: {area}");
            Console.ReadLine();
        }
    }
}
