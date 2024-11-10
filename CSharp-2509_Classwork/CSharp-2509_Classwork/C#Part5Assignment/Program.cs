using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static C_Part5Assignment.Library;

namespace C_Part5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////1 Single and Multi-D arrays
            //Library library = new Library(5); // Maximum 5 books
            //library.AddBook("The Great Gatsby");
            //library.AddBook("1984");
            //library.AddBook("To Kill a Mockingbird");
            //library.AddBook("Moby Dick");
            //library.AddBook("War and Peace");
            //library.AddBook("The Catcher in the Rye");

            //// Create a Classroom object
            //Classroom classroom = new Classroom(3, 4); // 3 rows and 4 columns
            //classroom.AssignSeat(0, 0, "Alice");
            //classroom.AssignSeat(0, 1, "Bob");
            //classroom.AssignSeat(1, 0, "Charlie");
            //classroom.AssignSeat(1, 1, "David");
            //classroom.AssignSeat(3, 0, "Eve"); // This will show out of bounds message
            //classroom.DisplaySeating();
            //Console.ReadLine();

            //2- Array of objects


            //MovieLibrary library = new MovieLibrary(5);
            //Movie movie1 = new Movie("Swades", 2005);
            //Movie movie2 = new Movie("Taare zameen par", 2007);
            //Movie movie3 = new Movie("Dhoom2", 2006);

            //Movie movie4 = new Movie("Thanmathra", 2007);

            //Movie movie5 = new Movie("The intern", 2015);

            //Movie movie6 = new Movie("Interstellar", 2014);

            //library.Addmovie(movie1);

            //library.Addmovie(movie2);
            //library.Addmovie(movie3);
            //library.Addmovie(movie4);
            //library.Addmovie(movie5);
            //library.Addmovie(movie6);
            //library.Displaymovies();
            //Console.ReadLine();


            ////3-Enumerations
            //Order order1 = Order.AddOrder( 301,"Alice");
            //Order order2 = Order.AddOrder(302, "Bob");

            //order1.status = OrderStatus.Shipped;
            //order2.status = OrderStatus.Delivered;

            //// Display all orders
            //Order.DisplayAllOrders();
            //Console.ReadLine();

            //4
            //Circle circle1 = new Circle(5.0);
            //Circle circle2 = circle1; // Copy of circle1's value to circle2

            //Console.WriteLine("Original Circle struct values:");
            //Console.WriteLine($"circle1 Radius: {circle1.Radius}, Area: {circle1.CalculateArea()}");
            //Console.WriteLine($"circle2 Radius: {circle2.Radius}, Area: {circle2.CalculateArea()}");

            //// Modifying circle2's Radius
            //circle2.Radius = 10.0;

            //Console.WriteLine("\nAfter modifying circle2 Radius:");
            //Console.WriteLine($"circle1 Radius: {circle1.Radius}, Area: {circle1.CalculateArea()}"); // Unchanged
            //Console.WriteLine($"circle2 Radius: {circle2.Radius}, Area: {circle2.CalculateArea()}"); // Changed

            //// Working with Shape class (reference type)
            //Shape shape1 = new Shape(5.0);
            //Shape shape2 = shape1; // Reference to the same object as shape1

            //Console.WriteLine("\nOriginal Shape class values:");
            //Console.WriteLine($"shape1 Radius: {shape1.Radius}, Area: {shape1.CalculateArea()}");
            //Console.WriteLine($"shape2 Radius: {shape2.Radius}, Area: {shape2.CalculateArea()}");

            //// Modifying shape2's Radius
            //shape2.Radius = 10.0;

            //Console.WriteLine("\nAfter modifying shape2 Radius:");
            //Console.WriteLine($"shape1 Radius: {shape1.Radius}, Area: {shape1.CalculateArea()}"); // Changed
            //Console.WriteLine($"shape2 Radius: {shape2.Radius}, Area: {shape2.CalculateArea()}"); // Changed

            //Console.ReadLine();

            ////5
            //Game game = new Game();
            //int playerScore = 50;

            //Console.WriteLine($"Initial Score: {playerScore}");

            //// Calling IncreaseScore with a ref parameter
            //game.IncreaseScore(ref playerScore);

            //Console.WriteLine($"Final Score: {playerScore}");            
            //Console.ReadLine();

            //6
            //MathOperations math = new MathOperations();
            //int dividend = 17;
            //int divisor = 4;

            //// Variables to store quotient and remainder
            //int quotient, remainder;

            //// Call Divide method with out parameters
            //math.Divide(dividend, divisor, out quotient, out remainder);

            //Console.WriteLine($"Dividend: {dividend}, Divisor: {divisor}");
            //Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
            //Console.ReadLine();


            //7  Write a C# program that demonstrates a FileNotFoundException and an 
            //IndexOutOfRangeException.Explain what causes these exceptions.

            // Attempt to open a file that doesn't exist
            //    string filePath = "test.txt";
            //    try
            //    {
            //        Console.WriteLine("Attempting to read from a file that does not exist:");
            //        string content = File.ReadAllText(filePath);
            //        Console.WriteLine(content);
            //    }

            //    catch (FileNotFoundException ex)
            //    {
            //        Console.WriteLine("FileNotFoundException caught!");
            //        Console.WriteLine("Message: " + ex.Message);
            //    }

            //        Console.WriteLine();

            //// Demonstrating IndexOutOfRangeException
            //    try
            //    {
            //        // Create an array with 3 elements
            //        int[] numbers = { 1, 2, 3 };

            //        // Attempt to access an index out of range
            //        Console.WriteLine(numbers[5]);
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine("IndexOutOfRangeException caught!");
            //        Console.WriteLine("Message: " + ex.Message);
            //    }
            //    Console.ReadLine();

            //8 Create a method GetUserInput that prompts the user to enter an integer. If the input is 
            //invalid, catch the exception and prompt the user again until they enter a valid integer.
            //{
            //    int userInput = GetUserInput();
            //    Console.WriteLine($"You entered a valid integer: {userInput}");
            //    Console.ReadLine();

            //}

            //// Method to get user input and validate it as an integer
            //static int GetUserInput()
            //{
            //    while (true) // Loop until valid input is provided
            //    {
            //        Console.Write("Please enter an integer: ");
            //        string input = Console.ReadLine();

            //        try
            //        {
            //            // Attempt to convert the input to an integer
            //            int number = int.Parse(input);
            //            return number; // Return the valid integer
            //        }
            //        catch (FormatException)
            //        {
            //            // Handle the case where the input is not a valid integer format
            //            Console.WriteLine("Invalid input. Please enter a valid integer.");
            //        }
            //        catch (OverflowException)
            //        {
            //            // Handle the case where the input integer is too large or too small
            //            Console.WriteLine("Input is too large or too small. Please enter a valid integer.");
            //        }
            //    }


            //9 Create a method that calculates the division of two integers. Use multiple catch blocks 
            //to handle DivideByZeroException and FormatException.
            //{
            //    DivideIntegers();
            //    Console.ReadLine();
            //}


            //// Method to perform division with exception handling
            //static void DivideIntegers()
            //{
            //    try
            //    {
            //        Console.Write("Enter the first integer: ");
            //        int num1 = int.Parse(Console.ReadLine());

            //        Console.Write("Enter the second integer: ");
            //        int num2 = int.Parse(Console.ReadLine());

            //        int result = num1 / num2;
            //        Console.WriteLine($"Result of division: {result}");
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        // Catch block for division by zero
            //        Console.WriteLine("Error: Division by zero is not allowed.");
            //    }
            //    catch (FormatException)
            //    {
            //        // Catch block for invalid format (non-integer input)
            //        Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            //    }

            //}

            //10  Write a method ReadFile that opens a file, reads its contents, and closes it. Use a 
            //finally block to ensure the file is closed, even if an exception occurs.
            //{
            //    string filePath = @"C:\Users\nikit\source\repos\C#Part5Assignment\bin\Debug\sample.txt";


            //    ReadFile(filePath);
            //    Console.ReadLine();
            //}

            //// Method to open, read, and close a file with exception handling
            //static void ReadFile(string filePath)
            //{
            //    StreamReader reader = null; // Initialize StreamReader

            //    try
            //    {
            //        // Attempt to open the file
            //        reader = new StreamReader(filePath);
            //        string content = reader.ReadToEnd(); // Read the entire file content
            //        Console.WriteLine("File Contents:");
            //        Console.WriteLine(content);
            //    }
            //    catch (FileNotFoundException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    catch (IOException ex)
            //    {
            //        Console.WriteLine("An I/O error occurred: " + ex.Message);
            //    }
            //    finally
            //    {
            //        // Ensure the file is closed, even if an exception occurs
            //        if (reader != null)
            //        {
            //            reader.Close();
            //            Console.WriteLine("File closed.");
            //        }
            //    }


            //}
            //11  Explain the purpose of the throw keyword in C#. Create a method ValidateAge that 
            //throws an exception if the age is below 18, and handle it in the calling method.

            //    {
            //    try
            //    {
            //        // Call ValidateAge method with an age input
            //        int age = 15; // Test with an age below 18 to trigger the exception
            //        ValidateAge(age);
            //        Console.WriteLine("Age is valid.");
            //        }
            //        catch (Exception ex)
            //        {
            //            // Handle the exception
            //            Console.WriteLine("Exception caught: " + ex.Message);
            //        }

            //        Console.ReadLine();
            //    }

            //// Method to validate age
            //static void ValidateAge(int age)
            //{
            //    if (age < 18)
            //    {
            //        // Throw an exception if age is less than 18
            //        throw new ArgumentException("Age must be at least 18.");
            //    }
            //}
            //12 Custom Exception Create a custom exception class NegativeNumberException to handle negative inputs. 
            //Write a method CheckNumber that throws this exception if the number is negative.

            //    {
            //        try
            //        {
            //            int number = -5;
            //            CheckNegative(number);
            //            Console.WriteLine("The number is positive");
            //        }
            //        catch (NegativeNumberException ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }

            //        Console.ReadLine();
            //    }

            //    static void CheckNegative(int number)
            //    {
            //        if (number < 0)
            //        {
            //            throw new NegativeNumberException("Number must be greater than 0 ");
            //        }

            //    }

            //class NegativeNumberException : Exception
            //{
            //    public NegativeNumberException(string message) : base(message) { }

            //}


            //13 Log4net
            //{
            //    LoggingExample.Divide(10, 0);
            //    Console.ReadLine();
            //}

            //public class LoggingExample
            //{
            //    public static void Divide(int a, int b)
            //    {
            //        try
            //        {
            //            int result = a / b;
            //            Console.WriteLine("Result: " + result);
            //        }
            //        catch (DivideByZeroException ex)
            //        {
            //            Logger.LogError("Attempted to divide by zero.", ex);
            //            Console.WriteLine("DivideByZeroException caught and logged.");
            //        }
            //    }
            //}

            //15 

            //FileProcessor fileProcessor = new FileProcessor();

            //// Example of a file path (replace with an actual file path to test)
            //string filePath = @"C:\Users\nikit\source\repos\C#Part5Assignment\bin\Debug\test.txt";

            //// Attempt to read the file content
            //fileProcessor.ReadFileContent(filePath);

            //// Pause the console
            //Console.ReadLine();

            //Lab15_2

            //MathOperations2 mathOperations = new MathOperations2();

            //// Example usage
            //Console.WriteLine("Enter the numerator: ");
            //int numerator = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the denominator: ");
            //int denominator = Convert.ToInt32(Console.ReadLine());

            //// Call the Divide method and store the result
            // mathOperations.Divide(numerator, denominator);
         
            //Console.ReadLine();

            //15_3


            //Person person = new Person(); // Create a new Person instance

            //try
            //{
            //    Console.Write("Enter the age of the person: ");
            //    int age = int.Parse(Console.ReadLine()); // Read age input from user
            //    person.SetAge(age); 
            //    Console.WriteLine($"Person's age set to: {person.Age}");
            //}
            //catch (InvalidAgeException ex) // Catch the custom exception
            //{
            //    Console.WriteLine("Invalid age provided: " + ex.Message); // Print error message
            //}
            //catch (FormatException) // Handle format exception if input is not a valid integer
            //{
            //    Console.WriteLine("Invalid input! Please enter a valid integer for age.");
            //}

            //Console.ReadLine(); // Wait for user input before closing


            //15_4
            FileProcessor2 fileProcessor = new FileProcessor2();
            fileProcessor.ReadFileContent("nonexistentfile.txt"); // Provide a file path that does not exist

            Console.WriteLine(); // Separator for clarity in output

            // Demonstrate DivideByZeroException
            MathOperations3 mathOps = new MathOperations3();
            int result = mathOps.Divide(10, 0); // Attempt division by zero
            Console.WriteLine("Result of division: " + result);

            Console.WriteLine(); // Separator for clarity in output

            // Demonstrate InvalidAgeException
            Person2 person = new Person2();
            try
            {
                person.SetAge(130); // Attempt to set an invalid age
                Console.WriteLine("Person's age set to: " + person.Age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Invalid age provided: " + ex.Message);
            }

            Console.ReadLine();
        }

    }
}
