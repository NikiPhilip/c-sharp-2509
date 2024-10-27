//Create a simple banking system that allows account creation and basic 
//transactions. Each account has an account number, account holder name, and balance. Implement 
//deposit and withdrawal methods. Use getters and setters to manage access to the balance,
//ensuring it cannot be set to a negative value.
using System;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bank bank1 = new Bank("Fiona", "12368");
                bank1.deposit(500);
                Bank bank2 = new Bank("Rahul", "2342");
                bank2.deposit(-23);
                bank1.withdraw(6000);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadLine();
        }
    }
}
