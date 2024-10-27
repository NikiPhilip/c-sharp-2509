


//1.Create a class named Product with the following: 
//o Fields for name, price, and discount. 
//o Three constructors: 
// A constructor that initializes only the name. 
// A constructor that initializes name and price. 
// A constructor that initializes name, price, and discount. 
//2. Implement a method CalculateFinalPrice() that computes the final price after applying 
//the discount (if applicable). 
//3. In the Main() method: 
//o Create different Product objects using various constructors. 
//o Display the details of each product, including the final price after any applicable 
//discount.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Product
    {
        public string Name;
        public decimal Price;
        public decimal Discount;

        // Constructor that initializes only the name
        public Product(string name)
        {
            Name = name;
            Price = 0.00m;
            Discount = 0.00m;
        }

        // Constructor that initializes name and price
        public Product(string name, decimal price) : this(name)
        {
            Price = price;
        }

        // Constructor that initializes name, price, and discount
        public Product(string name, decimal price, decimal discount) : this(name, price)
        {
            Discount = discount;
        }

        // Method to calculate the final price after applying the discount
        public decimal CalculateFinalPrice()
        {
            decimal discountAmount = (Price * Discount) / 100;
            return Price - discountAmount;
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product: {Name}");
            Console.WriteLine($"Price: {Price}");
            if (Discount > 0)
            {
                Console.WriteLine($"Discount: {Discount}%");
                Console.WriteLine($"Final Price: {CalculateFinalPrice()}");
            }
            else
            {
                Console.WriteLine("No discount applied.");
                Console.WriteLine($"Final Price: {Price}");
            }
            Console.WriteLine();
        }
    }
}
