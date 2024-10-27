using System;

namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Toyota Corolla");
            Car car2 = new Car("Honda Civic");
            Car car3 = new Car("Tesla Model 3");

            // Display the total number of cars created
            Console.WriteLine($"Total number of cars created: {Car.GetCarCount()}");
            Console.ReadLine();
        }
    }
}
