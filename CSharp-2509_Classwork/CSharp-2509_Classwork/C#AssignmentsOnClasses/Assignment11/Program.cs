using System;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bank account1 = new Bank(1000.50);
            account1.DisplayAccountDetails();


            Bank account2 = new Bank(500);
            account2.DisplayAccountDetails();


            Console.WriteLine($"Static Interest Rate: {Bank.InterestRate}%");
            Console.ReadLine();
        }
    }
}
