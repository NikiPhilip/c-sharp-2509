using System;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Fiona", 13);
            student1.add_grade(60);
            student1.add_grade(70);
            student1.average();
            student1.DisplayStudentInfo();
            Console.ReadLine();
        }

    }
}
