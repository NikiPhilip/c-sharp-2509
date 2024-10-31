//Create a C# program that demonstrates how runtime polymorphism is achieved using abstract 
//classes and interfaces. Define an abstract class Shape and an interface IShape, implementing
//these in derived classes to showcase polymorphism.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Polymorphism
{
    public abstract class Shape3
    {
        // Abstract method to be implemented by derived classes
        public abstract double CalculateArea();

        // Abstract method to be implemented by derived classes
        public abstract double CalculatePerimeter();
    }

    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    public class Rectangle3 : Shape3, IShape
    {
        private double length;
        private double width;

        public Rectangle3(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Implementing the abstract method from Shape
        public override double CalculateArea()
        {
            return length * width;
        }

        // Implementing the abstract method from Shape
        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }

    public class Circle3 : Shape3, IShape
    {
        private double radius;

        public Circle3(double radius)
        {
            this.radius = radius;
        }

        // Implementing the abstract method from Shape
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        // Implementing the abstract method from Shape
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
