using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alice", 30);
            Console.WriteLine("Person1 details:");
            person1.Display();

            // Create another object using the copy constructor
            Person person2 = new Person(person1);
            Console.WriteLine("\nPerson2 (copied from Person1) details:");
            person2.Display();

            // Modify person2's data to see if it affects person1
            person2.Name = "Bob";
            person2.Age = 35;
            Console.WriteLine("\nPerson2 details after modification:");
            person2.Display();

            // Check person1's data to confirm that it hasn't been changed
            Console.WriteLine("\nPerson1 details after modifying Person2:");
            person1.Display();

            // Copy object via direct assignment (this only copies the reference)
            Person person3 = person1;
            Console.WriteLine("\nPerson3 (reference copy from Person1) details:");
            person3.Display();

            // Modify person3's data and check if it affects person1
            person3.Name = "Charlie";
            person3.Age = 40;
            Console.WriteLine("\nPerson3 details after modification:");
            person3.Display();

            // Check person1's data again to see if it has been affected
            Console.WriteLine("\nPerson1 details after modifying Person3 (reference copy):");
            person1.Display();
            Console.ReadLine();
        }
    }
}
