using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            // Adding customers
            bank.AddCustomer("John Doe");
            bank.AddCustomer("Jane Smith");

            // Adding accounts for customers
            bank.AddAccountToCustomer("John Doe", 1001, 1500.50m);
            bank.AddAccountToCustomer("John Doe", 1002, 2500.75m);
            bank.AddAccountToCustomer("Jane Smith", 2001, 3000.00m);

            // Displaying customer details
            bank.DisplayCustomerDetails();

            Console.ReadLine();
        }
    }
}
