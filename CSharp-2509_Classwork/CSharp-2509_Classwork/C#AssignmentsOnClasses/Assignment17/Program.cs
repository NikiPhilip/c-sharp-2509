using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using constructor that initializes only the name
            Product product1 = new Product("Laptop");
            product1.DisplayProductDetails();

            // Using constructor that initializes name and price
            Product product2 = new Product("Smartphone", 799.99m);
            product2.DisplayProductDetails();

            // Using constructor that initializes name, price, and discount
            Product product3 = new Product("TV", 1200.00m, 15);
            product3.DisplayProductDetails();
            Console.ReadLine();
        }
    }
}
