

//You need to create a Shopping Cart class that holds a list of Product objects. The Product class
//will be a nested class. The system should allow users to add products to the cart and display the 
//total price. 
//Tasks: 
//1.Create a ShoppingCart class that contains:
//o A list of Product objects. 
//o Methods to add products and calculate the total price. 
//2. Create a nested Product class with properties for Name, Price, and Quantity. 
//3. Demonstrate adding products and displaying the total price in the Main() method.


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    public class ShoppingCart
    {
        // List to hold products
        private List<Product> products = new List<Product>();

        // Nested Product class
        public class Product
        {


            public string Name;
            private decimal price;
            private int quantity;   
            
            public decimal Price
            {
                get
                {
                    return price;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Price can't be zero");
                    }
                    price = value;
                }
            }

            public int Quantity
            {
                get
                {
                    return quantity;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Price can't be zero");
                    }
                    quantity = value;
                }
            }


            
            public Product(string name, decimal price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }

        // Method to add a product to the shopping cart
        public void AddProduct(string name, decimal price, int quantity)
        {
            Product product = new Product(name, price, quantity);
            products.Add(product);
        }

        // Method to calculate the total price of the shopping cart
        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.Price * product.Quantity;
            }
            return total;
        }

        // Method to display all products in the cart and the total price
        public void DisplayCart()
        {
            Console.WriteLine("Products in your cart:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
            Console.WriteLine($"Total Price: {CalculateTotalPrice()}");
        }



    }


 }