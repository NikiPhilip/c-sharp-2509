using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 To demonstrate Polymorphism and its Advantages
            //Shape[] shapes = new Shape[3];
            //shapes[0] = new Circle();
            //shapes[1] = new Rectangle();
            //shapes[2] = new Shape();

            //foreach (Shape shape in shapes)
            //{
            //    shape.draw();

            //}

            //Console.ReadLine();

            //2  Method Overloading and its uses 

            //Calculator calculator = new Calculator();
            //calculator.Multiply(3, 5);
            //calculator.Multiply(3.4, 5.6);
            //calculator.Multiply(3, 6, 4);
            //Console.ReadLine();


            //3 Method Overriding  
            //Vehicle vehicle = new Vehicle();
            //vehicle.Drive();
            //Vehicle myCar = new Car();
            //myCar.Drive();
            //Car car = new Car();
            //car.Drive();
            //Console.ReadLine();

            //5  Polymorphism with Static Data and Methods.
            // Create Manager and Developer objects (polymorphism in action)
            //Employee emp1 = new Manager();
            //Employee emp2 = new Developer();
            //Employee emp3 = new Developer();



            //// Call the Work method on each object (demonstrates method overriding)
            //emp1.Work();
            //emp2.Work();
            //emp3.Work();

            //// Display the total number of employees using the static method
            //Employee.DisplayEmployeeCount();
            //Console.ReadLine();

            //6  Polymorphism with Arrays as Properties in a Class 
            // Creating an array of tasks for Manager and Developer
            //string[] managerTasks = { "Plan project", "Assign tasks", "Review progress" };
            //string[] developerTasks = { "Write code", "Fix bugs", "Implement features" };

            //Employee2 emp1 = new Manager2("Alice", managerTasks);
            //Employee2 emp2 = new Developer2("Bob", developerTasks);


            //Employee2[] employees = { emp1, emp2 };

            //foreach (var employee in employees)
            //{
            //    employee.DisplayTasks();
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            ////7  Understanding Early Binding and Late Binding in C#

            //Calculator2 calc = new Calculator2();
            //Console.WriteLine("Showing method overloading{Early Binding}");
            //Console.WriteLine($"Add(3,6): {calc.Add(3, 6)}");
            //Console.WriteLine($"Add(4.2,5.1):{calc.Add(4.2, 5.1)}");
            //Console.WriteLine($"Add(2,5,7): {calc.Add(2, 5, 7)}");

            //Shape2 rectangle = new Rectangle2(5, 7);
            //Shape2 circle = new Circle2(5);

            //Console.WriteLine($"Area of Rectangle:{rectangle.CalculateArea()}");
            //Console.WriteLine($"Area of Circle:{circle.CalculateArea()}");
            //Console.ReadLine();

            //8 Achieving Runtime Polymorphism with Abstract Classes and 
            //Interfaces in C#
            //Shape3 rectangle = new Rectangle3(5, 3);
            //Shape3 circle = new Circle3(2);

            //IShape iRectangle = rectangle as IShape;
            //IShape iCircle = circle as IShape;

            //Console.WriteLine("Runtime Polymorphism with Abstract Class:");
            //Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            //Console.WriteLine($"Rectangle Perimeter: {rectangle.CalculatePerimeter()}");
            //Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            //Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");

            //Console.WriteLine("\nRuntime Polymorphism with Interface:");
            //Console.WriteLine($"Rectangle Area (IShape): {iRectangle.CalculateArea()}");
            //Console.WriteLine($"Rectangle Perimeter (IShape): {iRectangle.CalculatePerimeter()}");
            //Console.WriteLine($"Circle Area (IShape): {iCircle.CalculateArea()}");
            //Console.WriteLine($"Circle Perimeter (IShape): {iCircle.CalculatePerimeter()}");
            //Console.ReadLine();

            //9 Demonstrating the Need for Multiple Inheritance of Interfaces 
            //Car2 myCar = new Car2(80);

            //// Using the IMovable interface
            //Console.WriteLine("Using IMovable:");
            //myCar.Move();

            //// Using the IDrawable interface
            //Console.WriteLine("\nUsing IDrawable:");
            //myCar.Draw();
            //Console.ReadLine();

            //10  Polymorphism in C# with Readonly Property

            Animal myDog = new Dog();
            Animal myCat = new Cat();

            Console.WriteLine("Polymorphism with readonly field:");
            myDog.MakeSound();
            myCat.MakeSound();

            // Accessing the readonly Species field
            Console.WriteLine($"\nReadonly field values:");
            Console.WriteLine($"Dog species: {myDog.Species}");
            Console.WriteLine($"Cat species: {myCat.Species}");
            Console.ReadLine() ;







        }
    }
}
