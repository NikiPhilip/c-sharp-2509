
//Create a C# program that demonstrates the concept of multiple inheritance through interfaces. 
//The program will define two interfaces, IMovable and IDrawable, and implement them in a class
//Car that showcases how a class can inherit from multiple interfaces.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Polymorphism
{
    public interface IMovable
    {
        // Method to start moving
        void Move();

        // Property to indicate the speed of movement
        int Speed { get; set; }
    }

    public interface IDrawable
    {
        // Method to draw an object
        void Draw();
    }

    public class Car2 : IMovable, IDrawable
    {
        public int Speed { get; set; }

        public Car2(int speed)
        {
            Speed = speed;
        }

        // Implementing the Move method from IMovable
        public void Move()
        {
            Console.WriteLine($"The car is moving at {Speed} km/h.");
        }

        // Implementing the Draw method from IDrawable
        public void Draw()
        {
            Console.WriteLine("Drawing the car on the screen.");
        }
    }
}