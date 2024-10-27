

//You need to create a University class that holds a list of Department objects. Each Department 
//can have multiple Course objects (nested class). Implement methods to add departments, add 
//courses, and display course information. 
//Tasks: 
//1.Create a University class with :
//o A list of Department objects.
//o Methods to add departments and courses, and to display course details.
//2. Create a nested Department class with properties for Name and a list of courses. 
//3. Create a nested Course class with properties for CourseName, CourseCode, and Credits. 
//4. Demonstrate the functionality in the Main() method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            // Adding departments
            university.AddDepartment("Computer Science");
            university.AddDepartment("Mathematics");

            // Adding courses to departments
            university.AddCourseToDepartment("Computer Science", "Data Structures", "CS101", 4);
            university.AddCourseToDepartment("Computer Science", "Operating Systems", "CS102", 3);
            university.AddCourseToDepartment("Mathematics", "Calculus", "MATH101", 4);
            university.AddCourseToDepartment("Mathematics", "Linear Algebra", "MATH102", 3);

            // Displaying course details for all departments
            university.DisplayCourseDetails();

            Console.ReadLine();
        }
    }
}
