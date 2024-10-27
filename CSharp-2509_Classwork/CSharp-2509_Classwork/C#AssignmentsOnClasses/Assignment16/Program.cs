using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Using constructor that initializes only make
            Car car1 = new Car("Toyota");
            car1.DisplayDetails();
            Console.WriteLine();

            // Using constructor that initializes make and model
            Car car2 = new Car("Honda", "Civic");
            car2.DisplayDetails();
            Console.WriteLine();

            // Using constructor that initializes make, model, and year
            Car car3 = new Car("Ford", "Mustang", 2021);
            car3.DisplayDetails();
            Console.WriteLine();

            // Using constructor that initializes all fields
            Car car4 = new Car("Tesla", "Model 3", 2023, 40000m);
            car4.DisplayDetails();
            Console.ReadLine();
        }
    }
}
