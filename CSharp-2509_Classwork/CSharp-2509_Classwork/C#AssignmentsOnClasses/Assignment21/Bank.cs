using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    // Bank class containing a list of customers
    public class Bank
    {
        private List<Customer> customers = new List<Customer>();

        // Nested Customer class
        public class Customer
        {
            public string Name { get; set; }
            public List<Account> Accounts { get; set; }

            public Customer(string name)
            {
                Name = name;
                Accounts = new List<Account>();
            }

            // Method to add an account to a customer
            public void AddAccount(int accountNumber, decimal initialBalance)
            {
                Accounts.Add(new Account(accountNumber, initialBalance));
            }
        }

        // Nested Account class
        public class Account
        {
            public int AccountNumber { get; set; }
            public decimal Balance { get; set; }

            public Account(int accountNumber, decimal initialBalance)
            {
                AccountNumber = accountNumber;
                Balance = initialBalance;
            }
        }

        // Method to add a new customer to the bank
        public void AddCustomer(string name)
        {
            customers.Add(new Customer(name));
        }

        // Method to add an account for a specific customer
        public void AddAccountToCustomer(string customerName, int accountNumber, decimal initialBalance)
        {
            Customer customer = customers.Find(c => c.Name == customerName);
            if (customer != null)
            {
                customer.AddAccount(accountNumber, initialBalance);
            }
            else
            {
                Console.WriteLine($"Customer with name {customerName} not found.");
            }
        }

        // Method to display customer details and their accounts
        public void DisplayCustomerDetails()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer: {customer.Name}");
                foreach (var account in customer.Accounts)
                {
                    Console.WriteLine($"  Account Number: {account.AccountNumber}, Balance: {account.Balance}");
                }
            }
        }
    }
}