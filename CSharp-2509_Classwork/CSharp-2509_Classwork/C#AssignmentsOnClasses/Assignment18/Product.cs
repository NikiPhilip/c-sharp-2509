using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Product
    {

        public string Name;
        public decimal Price;
        public string Category;

        // Constructor that initializes all three properties
        public Product(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        // Constructor with default values for the properties
        public Product()
        {
            Name = "Default Product";
            Price = 0.00m;
            Category = "Miscellaneous";
        }

        // Static method to create a Product object
        public static Product CreateProduct(string name, decimal price, string category)
        {
            return new Product(name, price, category);
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine();
        }
    }
}