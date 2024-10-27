
//Create a Rectangle class with overloaded methods to calculate the area. 
//Implement methods that take either width and height or just one side length (for a square). 
using System;

namespace Assignment9
{
    public class Rectangle
    {
        public void Area(int width, int height)
        {
            int rectangleArea = width * height;
            Console.WriteLine("Area of rectangle: " + rectangleArea);
        }
        public void Area(int side)
        {
            int squareArea = side * side;
            Console.WriteLine("Area of square: " + squareArea);

        }
    }
}
