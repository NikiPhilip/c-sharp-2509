

//1.Create a class named Car with the following: 
//o Fields for make, model, year, and price. 
//o Multiple constructors: 
// A constructor that initializes only the make. 
// A constructor that initializes make and model. 
// A constructor that initializes make, model, and year. 
// A constructor that initializes all fields: make, model, year, and price. 
//o Use constructor chaining to avoid duplicating the logic for initializing fields. 
//2. In the Main() method: 
//o Create several Car objects using different constructors. 
//o Display the details of each car to verify that all fields are initialized correctly. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    public class Car
    {
        public string Make{ get; set; }
        public string Model;
        public int Year;
        public decimal Price;

        public Car(string make)
        {
            Make = make;
            Model = "Unknown";
            Year = 0;
            Price = 0.00m;
        }

        // Constructor that initializes make and model
        public Car(string make, string model) : this(make)
        {
            Model = model;
        }

        // Constructor that initializes make, model, and year
        public Car(string make, string model, int year) : this(make, model)
        {
            Year = year;
        }

        
        public Car(string make, string model, int year, decimal price) : this(make, model, year)
        {
            Price = price;
        }

        // Method to display car details
        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine();
        }
    }
    

    
}
