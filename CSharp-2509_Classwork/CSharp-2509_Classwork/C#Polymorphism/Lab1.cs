//Create a C# program demonstrating polymorphism by using a base class Shape and derived 
//classes Circle and Rectangle. Each derived class should implement a method Draw(). Show 
//how polymorphism helps in calling the correct method based on the object type.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Polymorphism;

namespace C_Polymorphism
{
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Shape is being drawn");
        }
    }

    public class Circle : Shape
    {
        public override void draw()
        {
        Console.WriteLine("Drawing a Circle");
        }
     }

    public class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }


}
