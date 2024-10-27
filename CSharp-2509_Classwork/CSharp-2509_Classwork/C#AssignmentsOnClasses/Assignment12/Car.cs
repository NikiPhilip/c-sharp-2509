using System;

namespace Assignment12
{
    public class Car
    {
        private static int carCount;


        public string Model { get; private set; }


        static Car()
        {
            carCount = 0;
            Console.WriteLine("Static constructor: Car counter initialized.");
        }


        public Car(string model)
        {
            Model = model;
            carCount++;
            Console.WriteLine($"Car created: {Model}, Total cars: {carCount}");
        }


        public static int GetCarCount()
        {
            return carCount;
        }
    }
}
