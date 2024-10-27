using System;

public record Student(string Name, int Age, string Grade);

class Program
{
    // Method that accepts a tuple and returns a Student record
    public static Student CreateStudent((string Name, int Age, string Grade) studentTuple)
    {
        return new Student(studentTuple.Name, studentTuple.Age, studentTuple.Grade);
    }

    static void Main(string[] args)
    {
        // 1. Using tuples to store student details
        (string Name, int Age, string Grade) studentTuple1 = ("Alice", 20, "A");
        (string Name, int Age, string Grade) studentTuple2 = ("Bob", 21, "B");

        // 2. Creating Student records using tuples
        Student student1 = CreateStudent(studentTuple1);
        Student student2 = CreateStudent(studentTuple2);

        // 3. Displaying the details of the students
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, Grade: {student1.Grade}");

        Console.WriteLine("\nStudent 2 Details:");
        Console.WriteLine($"Name: {student2.Name}, Age: {student2.Age}, Grade: {student2.Grade}");

        // 4. Working with tuples directly
        Console.WriteLine("\nUsing tuples directly:");
        Console.WriteLine($"Student 1: Name: {studentTuple1.Name}, Age: {studentTuple1.Age}, Grade: {studentTuple1.Grade}");
        Console.WriteLine($"Student 2: Name: {studentTuple2.Name}, Age: {studentTuple2.Age}, Grade: {studentTuple2.Grade}");
    }
}
