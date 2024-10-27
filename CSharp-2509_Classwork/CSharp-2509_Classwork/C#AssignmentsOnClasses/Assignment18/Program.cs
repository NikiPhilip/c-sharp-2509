using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 1200.00m, "Electronics");
            Console.WriteLine("Product created using constructor:");
            product1.DisplayProductDetails();

            // 2. Creating an instance using the static method
            Product product2 = Product.CreateProduct("Smartphone", 799.99m, "Electronics");
            Console.WriteLine("Product created using static method:");
            product2.DisplayProductDetails();

            // 3. Creating an instance using the default constructor with default values
            Product product3 = new Product();
            Console.WriteLine("Product created using default constructor:");
            product3.DisplayProductDetails();

            Type productType = typeof(Product);
            object[] parameters = new object[] { "Tablet", 499.99m, "Electronics" };
            Product product4 = (Product)Activator.CreateInstance(productType, parameters);
            Console.WriteLine("Product created using Activator.CreateInstance:");
            product4.DisplayProductDetails();
            Console.ReadLine();
        }
    }
}
