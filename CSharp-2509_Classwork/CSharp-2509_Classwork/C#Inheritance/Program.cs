using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.
            //Person person = new Person("Alice", 35);
            //Console.WriteLine("Person Details:");
            //person.DisplayInfo();

            //// Create a Student object
            //Student student = new Student("Bob", 20, "A");
            //Console.WriteLine("\nStudent Details:");
            //student.DisplayStudentInfo();

            //Console.ReadLine();


            //2
            //Puppy puppy = new Puppy();

            //// Call methods from Puppy, Dog, and Animal
            //puppy.Eat();    // Inherited from Animal
            //puppy.Bark();   // Inherited from Dog
            //puppy.Weep();   // Specific to Puppy

            //Console.ReadLine();


            //3
            // Create an object of PrinterScanner class
            //PrinterScanner device = new PrinterScanner();

            //// Call the Print method
            //device.Print();

            //// Call the Scan method
            //device.Scan();

            //Console.ReadLine();

            //4
            //Shape circle = new Circle();
            //Shape rectangle = new Rectangle();

            //// Call the Draw method on both objects
            //circle.Draw();        // Calls Circle's overridden Draw method
            //rectangle.Draw();     // Calls Rectangle's overridden Draw method

            //Console.ReadLine();



            //5
            //ElectricCar myCar = new ElectricCar();

            //// Call the Move method from IMovable (overridden in ElectricCar)
            //myCar.Move();

            //// Call the Recharge method from IRechargeable
            //myCar.Recharge();

            //Console.ReadLine();


            //6
            //Employee employee = new Employee();
            //employee.Work();  // Calls Employee's Work method

            //// Create an object of Manager class
            //Manager manager = new Manager();
            //manager.Work();  // Calls Manager's overridden Work method

            //Console.ReadLine();

            //7
            //Vehicle2 car = new Car();
            //car.Drive();  // Calls Car's Drive method

            //// Create an object of Bike class
            //Vehicle2 bike = new Bike();
            //bike.Drive();  // Calls Bike's Drive method

            //Console.ReadLine();


            //8
            //MathOperations math = new MathOperations();
            //AdvancedMathOperations mathoperations = new AdvancedMathOperations();
            //int sum= mathoperations.Add(3, 5);


            //// Call the Add method
            //int result = math.Add(10, 20);
            //Console.WriteLine("The result of addition is: " + result);

            //Console.ReadLine();


            //9
            //Employee2 employee = new Employee2("John", 30, 12345);

            //Console.ReadLine();

            //10
            //IRaceable raceCar = new RaceCar();

            //// Call the methods from the interfaces
            //raceCar.Drive();
            //raceCar.Race();

            //Console.ReadLine();

            //11
            //Dog2 myDog = new Dog2();
            //myDog.Name = "Buddy";

            //// Demonstrating the IS-A relationship
            //myDog.Eat();  // Dog IS-A Animal, so it can call Eat()
            //myDog.Bark(); // Dog has its own method Bark()

            //Console.ReadLine();

            //12
            //Engine carEngine = new Engine(300);

            //// Create an instance of Car with the Engine
            //Car2 myCar = new Car2(carEngine);

            //// Display the details of the Car
            //myCar.DisplayCarDetails();

            //Console.ReadLine();

            //13
            // Create an instance of Employee
            //Employee3 employee = new Employee3
            //{
            //    Name = "Alice",
            //    Age = 30,
            //    JobTitle = "Software Developer"
            //};

            //// Call the overridden DisplayInfo() method
            //employee.DisplayInfo();

            //Console.ReadLine();

            //14
            //Student2 student = new Student2();
            //student.Name = "John Doe"; // This won't affect the base Name

            //// Display names using the DisplayNames method
            //student.DisplayNames();

            //Console.ReadLine();

            //15
            // Create an instance of Car
            Car3 myCar = new Car3("Toyota", "Camry");

            Console.ReadLine();
        }
    }
}
    