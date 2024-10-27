
//Create a base class Shape with a method Draw(). Create two derived classes Circle and 
//Rectangle, both inheriting from Shape, and override the Draw() method to show specific 
//behavior.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public class Shape
    {
        // Virtual Draw method in the base class
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    // Derived class Circle that inherits from Shape
    public class Circle : Shape
    {
        // Override the Draw method for Circle
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class Rectangle that inherits from Shape
    public class Rectangle : Shape
    {
        // Override the Draw method for Rectangle
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}
