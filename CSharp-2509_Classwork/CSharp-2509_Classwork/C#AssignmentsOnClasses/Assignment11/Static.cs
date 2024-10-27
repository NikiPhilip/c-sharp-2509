using System;

namespace Assignment11
{
    internal class Bank
    {

        public static double InterestRate;


        private double Balance;


        static Bank()
        {
            InterestRate = 3.5;
            Console.WriteLine($"Interest rate initialized to {InterestRate}%.");
        }


        public Bank(double initialBalance)
        {
            if (initialBalance < 0)
            {
                Console.WriteLine("Initial balance cannot be negative.");
                Balance = 0;
            }
            else
            {
                Balance = initialBalance;
            }
            Console.WriteLine($"Account created with balance: Rs {Balance}");
        }


        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Balance: Rs {Balance}, Interest Rate: {InterestRate}%");
        }
    }

}

