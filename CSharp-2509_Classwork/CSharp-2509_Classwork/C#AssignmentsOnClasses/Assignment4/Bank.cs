using System;

namespace Assignment4
{
    public class Bank
    {
        public string Account_holder_name;
        public string Account_number;
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (balance < 0)
                {
                    throw new ArgumentException("Balance is negative");
                }
                balance = value;
            }

        }
        public Bank(string account_holder_name, string account_number)
        {
            Account_holder_name = account_holder_name;
            Account_number = account_number;
            balance = 0;

        }
        public void deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("The new balance is " + balance);
            }
        }
        public void withdraw(double amount)
        {
            if (amount > 0 && amount < balance)
            {
                balance -= amount;
                Console.WriteLine("The new balance is " + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}
