using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Polymorphism
{
    public class Calculator2
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

    }

    public class Shape2
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        
    }
    public class Rectangle2 : Shape2
    {
        private double length;
        private double width;

        public Rectangle2(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return length * width;
        }
    }
    public class Circle2 : Shape2
    {
        private double radius;
        public const double pi = 3.14;
        public Circle2(double radius)
        {
            this.radius = radius;

        }
        public override double CalculateArea()
        {
            return pi * radius * radius;
        }
    }
    public class Square : Shape2
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public override double CalculateArea()
        {
            return side * side;
        }
    }
}
