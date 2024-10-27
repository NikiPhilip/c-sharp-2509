using System;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                ECommerceSystem ecommerceSystem = new ECommerceSystem();

                ecommerceSystem.AddProduct("Laptop", 1200, 10);
                ecommerceSystem.AddProduct("Smartphone", 799, 20);


                ecommerceSystem.DisplayProducts();


                ecommerceSystem.CreateOrder("Laptop", 2);


                ecommerceSystem.CreateOrder("Smartphone", 25);


                ecommerceSystem.DisplayProducts();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
