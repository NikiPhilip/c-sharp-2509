

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;
using System.Xml.Linq;

namespace C_Anonymous_Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {


            //1.//Create an anonymous type to represent a book with properties for Title, Author, and Price. 
            //Display the details of the book. 

            //var book = new
            //{
            //    Title = "The Great Gatsby",
            //    Author = "F. Scott Fitzgerald",
            //    Price = 300.99
            //};

            //// Display the book details
            //Console.WriteLine($"Title: {book.Title}");
            //Console.WriteLine($"Author: {book.Author}");
            //Console.WriteLine($"Price: Rs.{book.Price}");
            //Console.ReadLine();


            //2.Declare a var variable to hold a list of integers, add some numbers to it, and print them.

            //var numbers = new List<int>();

            //// Add some numbers to the list
            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);
            //numbers.Add(40);
            //numbers.Add(50);

            //// Print the numbers in the list
            //Console.WriteLine("Numbers in the list:");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.ReadLine();

            //3.Declare a dynamic variable, assign different types of values to it, and observe the 
            //behavior.

            //dynamic input = 23;
            //Console.WriteLine($"Value:{input},Type:{input.GetType()}");
            //input = "Hello";
            //Console.WriteLine($"Value:{input},Type:{input.GetType()}");

            //input = 3.22;
            //Console.WriteLine($"Value:{input},Type:{input.GetType()}");

            //input = true;
            //Console.WriteLine($"Value:{input},Type:{input.GetType()}");
            //Console.ReadLine();

            //3.Delegate Create a simple calculator using delegates. Define a delegate OperationDelegate that can 
            //        represent different arithmetic operations(addition, subtraction, multiplication, division). 
            //Implement methods for each operation and allow the user to select an operation to perform on
            //two input numbers.




            //// Ask the user for input
            //Console.WriteLine("Enter first number:");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter second number:");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Select an operation:");
            //Console.WriteLine("1. Add");
            //Console.WriteLine("2. Subtract");
            //Console.WriteLine("3. Multiply");
            //Console.WriteLine("4. Divide");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //// Declare a delegate variable
            //Calculator.OperationDelegate operation = null;

            //// Assign the corresponding method to the delegate based on user choice
            //switch (choice)
            //{
            //    case 1:
            //        operation = Calculator.Add;
            //        break;
            //    case 2:
            //        operation = Calculator.Subtract;
            //        break;
            //    case 3:
            //        operation = Calculator.Multiply;
            //        break;
            //    case 4:
            //        operation = Calculator.Divide;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice.");
            //        return;
            //}

            //// Perform the operation using the delegate
            //double result = operation(num1, num2);

            //// Display the result
            //if (!double.IsNaN(result))
            //{
            //    Console.WriteLine($"Result: {result}");
            //}
            //Console.ReadLine();


            //4.Create an event called OnCompleted in a class Process. Raise the event when a process is 
            //completed.Subscribe to the event from the main program to display a message.

            //    // Create an instance of Process
            //    Process process = new Process();

            //    // Subscribe to the OnCompleted event
            //    process.OnCompleted += Process_OnCompleted;

            //    // Start the process
            //    process.StartProcess();
            //    Console.ReadLine();
            //}

            //// Event handler method for the OnCompleted event
            //private static void Process_OnCompleted(object sender, EventArgs e)
            //{
            //    Console.WriteLine("Process completed successfully!");
            //}


            //5.Write a delegate GreetDelegate that takes a string parameter. Assign an anonymous method to 
            //the delegate that prints a greeting message.

            //public delegate void GreetDelegate(string name);
            //static void Main(string[] args)
            //{
            //    GreetDelegate greet = delegate (string name)
            //    {
            //        Console.WriteLine($"Hi {name}");
            //    };

            //    greet("Alice");
            //    Console.ReadLine();
            //}

            //6. Write a lambda expression that takes two integers and returns their product. Use Func<int, int, 
            //int> for the delegate type.

            //Func<int, int, int> multiply = (a, b) => a * b;

            //// Use the lambda expression
            //int result = multiply(5, 3);
            //Console.WriteLine($"The product is: {result}");
            //Console.ReadLine();


            //7.Create an expression tree for a lambda expression that adds two integers. Compile and execute 
            // the expression.
            //ParameterExpression paramA = Expression.Parameter(typeof(int), "a");
            //ParameterExpression paramB = Expression.Parameter(typeof(int), "b");

            //// Define the body of the expression: a + b
            //BinaryExpression body = Expression.Add(paramA, paramB);

            //// Create a lambda expression tree
            //Expression<Func<int, int, int>> addExpression = Expression.Lambda<Func<int, int, int>>(body, paramA, paramB);

            //// Compile the expression tree into executable code
            //Func<int, int, int> add = addExpression.Compile();

            //// Execute the compiled expression
            //int result = add(10, 5);
            //Console.WriteLine($"The sum is: {result}");
            //Console.ReadLine();

            //8.Create a delegate called StringOperationDelegate that accepts a string parameter and returns a 
            //string.Write three different methods that modify the string in different way.

            // Initialize the delegate with different methods and test each
            //StringOperations.StringOperationDelegate operation;

            //// Assign and execute ToUpperCase
            //operation = StringOperations.ToUpperCase;
            //Console.WriteLine("Uppercase: " + operation("Hello World"));

            //// Assign and execute ReverseString
            //operation = StringOperations.ReverseString;
            //Console.WriteLine("Reversed: " + operation("Hello World"));

            //// Assign and execute ReplaceSpacesWithHyphens
            //operation = StringOperations.ReplaceSpacesWithHyphens;
            //Console.WriteLine("Hyphenated: " + operation("Hello World"));
            //Console.ReadLine();

            //9.Given a list of products with properties Name and Price, use lambda expressions to: 
            //1. Filter the list to find products that cost more than $50. 
            //2. Sort the list by price in descending order.
            //3. Select and display only the names of products from the filtered list.

            //List<Product> products = new List<Product>
            //{
            //new Product { Name = "Laptop", Price = 999.99m },
            //new Product { Name = "Headphones", Price = 49.99m },
            //new Product { Name = "Keyboard", Price = 75.50m },
            //new Product { Name = "Mouse", Price = 25.99m },
            //new Product { Name = "Monitor", Price = 150.00m }
            //};

            //// 1. Filter the list to find products that cost more than $50
            //var filteredProducts = products.Where(p => p.Price > 50);

            //// 2. Sort the filtered list by price in descending order
            //var sortedProducts = filteredProducts.OrderByDescending(p => p.Price);

            //// 3. Select and display only the names of products from the filtered and sorted list
            //var productNames = sortedProducts.Select(p => p.Name);

            //// Display the product names
            //Console.WriteLine("Products that cost more than 50, sorted by price:");
            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();

            //10.Create a delegate called CalculationDelegate that takes two integers and returns an integer. 
            //Implement methods for addition and subtraction, and write a method Calculate that accepts two
            //integers and a delegate as parameters.Use the delegate to perform addition and subtraction
            //operations by passing different methods.

            //int addResult = AddDelegate.Calculate(10, 5, AddDelegate.Add);
            //Console.WriteLine("Addition Result: " + addResult);

            //// Use the Calculate method with subtraction
            //int subtractResult = AddDelegate.Calculate(10, 5, AddDelegate.Subtract);
            //Console.WriteLine("Subtraction Result: " + subtractResult);
            //Console.ReadLine();

            //11Write a C# program that simulates a long-running operation using Task.Delay() and runs 
            //asynchronously.Display a message before and after the operation completes.


            //public static async Task LongRunningOperationAsync()
            //{
            //    Console.WriteLine("Operation started...");

            //    // Simulate a long-running operation with Task.Delay
            //    await Task.Delay(3000); // Delay for 3 seconds

            //    Console.WriteLine("Operation completed!");
            //}

            //public static async Task Main()
            //{
            //    Console.WriteLine("Starting the long-running operation.");

            //    // Run the long-running operation asynchronously
            //    await LongRunningOperationAsync();

            //    Console.WriteLine("The long-running operation has finished.");
            //    Console.ReadLine();
            //}


            //12.Create a method that downloads data from a sample URL asynchronously. Use HttpClient to 
            //fetch the data and print the length of the content.The method should use async and await
            //keywords.
            //public static async Task DownloadDataAsync(string url)
            //{
            //    using (HttpClient client = new HttpClient())

            //        try
            //    {
            //        Console.WriteLine("Starting data download...");

            //        // Asynchronously download the data from the URL
            //        string content = await client.GetStringAsync(url);

            //        // Print the length of the content
            //        Console.WriteLine($"Downloaded data length: {content.Length} characters");
            //    }
            //    catch (HttpRequestException e)
            //    {
            //        Console.WriteLine($"Request error: {e.Message}");
            //    }


            //}

            //public static async Task Main()
            //{
            //    // Sample URL for testing
            //    string url = "https://www.example.com";

            //    // Call the asynchronous download method
            //    await DownloadDataAsync(url);

            //    Console.WriteLine("Data download completed.");
            //    Console.ReadLine();
            //}

            //   13. Write a C# program that calculates the sum of an array of integers asynchronously using 
            //Task<int>.Return the result from the asynchronous method and display it.

            //public static async Task<int> CalculateSumAsync(int[] numbers)
            //{
            //    return await Task.Run(() =>
            //    {
            //        // Calculate the sum of the array
            //        int sum = numbers.Sum();
            //        return sum;
            //    });
            //}

            //public static async Task Main()
            //{
            //    int[] numbers = { 1, 2, 3, 4, 5 };

            //    Console.WriteLine("Calculating sum asynchronously...");

            //    // Call the asynchronous method to calculate the sum
            //    int result = await CalculateSumAsync(numbers);

            //    // Display the result
            //    Console.WriteLine($"The sum of the array is: {result}");
            //    Console.ReadLine();
            //}
            //14.Modify the previous example to handle exceptions that might occur during the sum calculation. 
            //Catch the exception in the Main method and display an error message.

            //public static async Task<int> CalculateSumAsync(int[] numbers)
            //{
            //    if (numbers == null)
            //    {
            //        throw new ArgumentNullException("The array of numbers cannot be null.");
            //    }

            //    // Perform the sum calculation asynchronously
            //    return await Task.Run(() =>
            //    {
            //        int sum = numbers.Sum();
            //        return sum;
            //    });
            //}


            //public static async Task Main()
            //{
            //    int[] numbers = null; // This will trigger an exception for demonstration

            //    //int[] numbers = { 1, 2, 3, 4, 5 };

            //    Console.WriteLine("Calculating sum asynchronously...");

            //    try
            //    {
            //        // Call the asynchronous method to calculate the sum
            //        int result = await CalculateSumAsync(numbers);

            //        // Display the result
            //        Console.WriteLine($"The sum of the array is: {result}");
            //    }
            //    catch (ArgumentNullException ex)
            //    {
            //        // Display only the message part of the exception
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            //    }
            //    Console.ReadLine();
            //}

            //15.Create a program that runs multiple tasks in parallel to simulate multiple operations, such as 
            //calculating the factorial of different numbers.Print the result of each task when completed.


            //public static BigInteger CalculateFactorial(int number)
            //{
            //    BigInteger result = 1;
            //    for (int i = 1; i <= number; i++)
            //    {
            //        result *= i;
            //    }
            //    return result;
            //}

            //public static async Task Main()
            //{
            //    int[] numbers = { 5, 6, 7, 8 }; // Numbers for which we want to calculate factorials
            //    List<Task> tasks = new List<Task>();

            //    Console.WriteLine("Starting factorial calculations...");

            //    // Create tasks to calculate factorials in parallel
            //    foreach (int number in numbers)
            //    {
            //        Task task = Task.Run(() =>
            //        {
            //            BigInteger factorial = CalculateFactorial(number);
            //            Console.WriteLine($"Factorial of {number} is {factorial}");
            //        });

            //        tasks.Add(task);
            //    }

            //    // Await all tasks to complete
            //    await Task.WhenAll(tasks);

            //    Console.WriteLine("All factorial calculations completed.");
            //    Console.ReadLine();
            //}

            //16. Write a LINQ query using both query syntax and method syntax to retrieve all 
            //numbers greater than 5 from a list of integers.


            //// Sample list of integers
            //List<int> numbers = new List<int> { 1, 3, 5, 7, 9, 11 };

            //// Query syntax
            //var querySyntaxResult = from number in numbers
            //                        where number > 5
            //                        select number;

            //// Method syntax
            //var methodSyntaxResult = numbers.Where(number => number > 5);

            //// Display results from query syntax
            //Console.WriteLine("Numbers greater than 5 (Query Syntax):");
            //foreach (var num in querySyntaxResult)
            //{
            //    Console.WriteLine(num);
            //}

            //// Display results from method syntax
            //Console.WriteLine("Numbers greater than 5 (Method Syntax):");
            //foreach (var num in methodSyntaxResult)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.ReadLine();

            //17. Given a list of strings representing student names, write a LINQ query that selects 
            //the names starting with the letter 'A' and orders them alphabetically.
            // Sample list of student names
            //List<string> studentNames = new List<string> { "Alice", "Bob", "Amanda", "Charlie", "Anna", "Brian" };

            //// Query syntax
            //var querySyntaxResult = from name in studentNames
            //                        where name.StartsWith("A")
            //                        orderby name
            //                        select name;

            //// Method syntax
            //var methodSyntaxResult = studentNames
            //                            .Where(name => name.StartsWith("A"))
            //                            .OrderBy(name => name);

            //// Display results from query syntax
            //Console.WriteLine("Names starting with 'A' (Query Syntax):");
            //foreach (var name in querySyntaxResult)
            //{
            //    Console.WriteLine(name);
            //}

            //// Display results from method syntax
            //Console.WriteLine("Names starting with 'A' (Method Syntax):");
            //foreach (var name in methodSyntaxResult)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();


            //18.Write a LINQ query to find the sum of all even numbers in an array of integers.

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int sumOfEvens = numbers.Where(n => n % 2 == 0).Sum();

            //Console.WriteLine($"Sum of even numbers: {sumOfEvens}");
            //Console.ReadLine();


            //19. Create an XML document representing a list of books, and use LINQ to XML to 
            // query the titles of books published after 2015.

            //    XDocument booksXml = new XDocument(
            //    new XElement("Books",
            //        new XElement("Book",
            //            new XElement("Title", "C# Programming Basics"),
            //            new XElement("Author", "John Doe"),
            //            new XElement("Year", 2016)
            //        ),
            //        new XElement("Book",
            //            new XElement("Title", "Advanced .NET"),
            //            new XElement("Author", "Jane Smith"),
            //            new XElement("Year", 2014)
            //        ),
            //        new XElement("Book",
            //            new XElement("Title", "Learning LINQ"),
            //            new XElement("Author", "Robert King"),
            //            new XElement("Year", 2018)
            //        )
            //    )
            //);

            //    // Display the XML for reference
            //    Console.WriteLine("XML Document:");
            //    Console.WriteLine(booksXml);
            //    Console.ReadLine();



            //20. Given a database table Employees with columns ID, Name, and Department, write a 
            // LINQ to SQL query to select all employees from the "IT" department.

            // Initialize the database context.
            YourDataContext db = new YourDataContext();

            // LINQ query to select all employees from the "IT" department.
            var itEmployees = from employee in db.Employees
                              where employee.Department == "IT"
                              select employee;

            // Output the results.
            foreach (var employee in itEmployees)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Department: {employee.Department}");
            }
            Console.ReadLine();
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }

        // Mock database context with a sample Employees table.
        public class YourDataContext
        {
            public List<Employee> Employees { get; set; }

            // Initialize the database context with sample data.
            public YourDataContext()
            {
                Employees = new List<Employee>
                {
                    new Employee { ID = 1, Name = "Alice", Department = "IT" },
                    new Employee { ID = 2, Name = "Bob", Department = "HR" },
                    new Employee { ID = 3, Name = "Charlie", Department = "IT" },
                    new Employee { ID = 4, Name = "Diana", Department = "Finance" }
                };
            }

        }
    }
}
