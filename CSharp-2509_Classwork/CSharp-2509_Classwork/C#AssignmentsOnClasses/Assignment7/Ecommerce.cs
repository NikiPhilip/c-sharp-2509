
//Design an e-commerce system that manages products and orders. Each 
//product has a name, price, and stock quantity. Implement methods to create an order that reduces 
//stock quantity. Implement getters and setters to ensure that the price cannot be negative and the 
//stock cannot be less than zero.

using System;
using System.Collections.Generic;

namespace Assignment7
{
    public class EProduct
    {
        public string Name;
        private int price;
        private int stockquantity;

        public int Price
        {

            get { return price; }

            set
            {
                if (price < 0)
                {
                    throw new ArgumentException("Price is negative");
                }
                price = value;
            }

        }
        public int Stockquantity
        {
            get { return stockquantity; }
            set
            {
                if (stockquantity < 0)
                {
                    throw new ArgumentException("Stock quantity can't be zero");
                }
                stockquantity = value;
            }
        }
        public EProduct(string name, int price, int stockquantity)
        {
            this.Name = name;
            this.Price = price;
            this.Stockquantity = stockquantity;
        }
    }

    public class Order
    {
        public List<EProduct> OrderedProducts = new List<EProduct>();


        public void AddProductToOrder(EProduct product, int quantity)
        {
            if (quantity <= product.Stockquantity)
            {
                OrderedProducts.Add(product);
                product.Stockquantity -= quantity;
                Console.WriteLine($"Added {quantity} of {product.Name} to order. Remaining stock: {product.Stockquantity}");
            }
            else
            {
                Console.WriteLine($"Insufficient stock for {product.Name}. Only {product.Stockquantity} left.");
            }
        }

        // Method to display order details
        public void DisplayOrderDetails()
        {
            Console.WriteLine("Order Details:");
            foreach (var product in OrderedProducts)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Remaining Stock: {product.Stockquantity}");
            }
        }
    }


    public class ECommerceSystem
    {
        public List<EProduct> products = new List<EProduct>();

        // Method to add a new product
        public void AddProduct(string name, int price, int stock)
        {
            products.Add(new EProduct(name, price, stock));
            Console.WriteLine($"Added product: {name}, Price: {price}, Stock: {stock}");
        }

        // Method to create an order for a product
        public void CreateOrder(string productName, int quantity)
        {
            EProduct product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                Order order = new Order();
                order.AddProductToOrder(product, quantity);
                order.DisplayOrderDetails();
            }
            else
            {
                Console.WriteLine($"Product {productName} not found.");
            }
        }

        // Method to display all products
        public void DisplayProducts()
        {
            Console.WriteLine("Available Products:");
            foreach (EProduct product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Stock: {product.Stockquantity}");
            }
        }
    }
}
