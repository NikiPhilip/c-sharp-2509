using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            // Add products to the cart
            try
            {
                cart.AddProduct("Laptop", 1200.99m, 1);  // Valid product
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding product: {ex.Message}");
            }

            try
            {
                cart.AddProduct("Printer", -32m, 1);  // Invalid product (negative price)
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding product: {ex.Message}");
            }

            try
            {
                cart.AddProduct("Smartphone", 799.50m, 2);  // Valid product
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding product: {ex.Message}");
            }

            try
            {
                cart.AddProduct("Headphones", 150.75m, 1);  // Valid product
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding product: {ex.Message}");
            }

            // Display the cart and the total price
            cart.DisplayCart();
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
