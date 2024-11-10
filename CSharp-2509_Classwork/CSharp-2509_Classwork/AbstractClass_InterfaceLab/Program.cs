using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static AbstractClass_InterfaceLab.Car3;

namespace AbstractClass_InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Abstract Class
            //Vehicle myCar = new Car();
            //Vehicle myMotorcycle = new Motorcycle();

            //Console.WriteLine("Starting engines:");
            //myCar.StartEngine();
            //myMotorcycle.StartEngine();

            //Console.WriteLine("\nStopping engines:");
            //myCar.StopEngine();
            //myMotorcycle.StopEngine();
            //Console.ReadLine();

            //2 Virtual Functions

            //Animal animal = new Animal();
            //animal.MakeSound();
            //Animal cat = new Cat();
            //cat.MakeSound();
            //Animal dog = new Dog();
            //dog.MakeSound();
            //Console.ReadLine();

            //3 Interface
            //IDrive car = new Car2("Toyota");
            //IDrive truck = new Truck("Benz");
            //car.Drive();
            //truck.Drive();
            //Console.ReadLine();

            //4 Difference between abstract class and interface

            //Creating pigeon instance
            //Penguin penguin = new Penguin("Emperor");
            //penguin.Fly();
            //penguin.Eat();
            //penguin.Swim();
            //Fish fish = new Fish(); 
            //fish.Swim();
            //Console.ReadLine();

            //5 Static methods without instance creation

            //int sum = MathOperations.Add(3, 6);
            //int product = MathOperations.Multiply(4, 2);
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Product: {product}");
            //Console.ReadLine();

            //6 Extension methods
            //int number1 = 4;
            //int number2 = 7;

            //// Using the IsEven extension method on int instances
            //Console.WriteLine($"{number1} is even: {number1.IsEven()}"); 
            //Console.WriteLine($"{number2} is even: {number2.IsEven()}");
            //Console.ReadLine() ;

            //7 Partial class

            //Person person = new Person();
            //person.Name = "Rahul";
            //person.ShowDetails();
            //Console.ReadLine();

            //8 Partial Method

            // Creating an instance of the Employee partial class
            //Employee employee = new Employee
            //{
            //    Name = "Alice",
            //    HourlyRate = 20.0,
            //    HoursWorked = 160
            //};

            //// Calling DisplaySalary to calculate and display the salary
            //employee.DisplaySalary(); 
            //Console.ReadLine();

            ////9 Indexers
            //Library library = new Library(3);

            //// Add books to the library using the indexer
            //library[0] = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            //library[1] = new Book("1984", "George Orwell");
            //library[2] = new Book("To Kill a Mockingbird", "Harper Lee");

            //// Display all books in the library
            //library.DisplayAllBooks();
            //Console.ReadLine();

            //10 

            //// Taking input for the division
            //Console.Write("Enter the numerator: ");
            //int numerator = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the denominator: ");
            //int denominator = Convert.ToInt32(Console.ReadLine());

            //// Attempting to perform division with exception handling
            //try
            //{
            //    double result = Exception.Divide(numerator, denominator);
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    // Custom error message for division by zero
            //    Console.WriteLine("Error: Division by zero is not allowed.");
            //}
            //catch (FormatException ex)
            //{
            //    // Custom error message for invalid input format
            //    Console.WriteLine("Error: Invalid input format. Please enter valid integers.");
            //}
            //finally
            //{
            //    // This block will execute regardless of whether an exception occurred
            //    Console.WriteLine("Thank you for using the division program.");
            //}
            //Console.ReadLine();



            ////11 
            //Car3 sedan = new Car3 { Type = CarType.Sedan };
            //Car3 suv = new Car3 { Type = CarType.SUV };
            //Car3 truck = new Car3 { Type = CarType.Truck };
            //Car3 coupe = new Car3 { Type = CarType.Coupe };

            //// Display messages for each car type
            //sedan.DisplayCarTypeMessage(); 
            //suv.DisplayCarTypeMessage();    
            //truck.DisplayCarTypeMessage();   
            //coupe.DisplayCarTypeMessage();
            //Console.ReadLine();


            //12
            Type calculatorType = typeof(Calculator);

            Console.WriteLine("Class Attributes:");
            foreach (DeveloperAttribute attr in calculatorType.GetCustomAttributes(typeof(DeveloperAttribute), false))
            {
                Console.WriteLine($"Developer: {attr.Name}, Last Modified: {attr.LastModified}");
            }

            // Retrieve the DeveloperAttribute from the Add method
            MethodInfo addMethod = calculatorType.GetMethod("Add");
            Console.WriteLine("\nMethod Attributes:");
            foreach (DeveloperAttribute attr in addMethod.GetCustomAttributes(typeof(DeveloperAttribute), false))
            {
                Console.WriteLine($"Developer: {attr.Name}, Last Modified: {attr.LastModified}");
            }
            Console.ReadLine();
        }
    }
}
