
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    public class University
    {
        private List<Department> departments = new List<Department>();

        // Nested Department class
        public class Department
        {
            public string Name { get; set; }
            public List<Course> Courses { get; set; }

            public Department(string name)
            {
                Name = name;
                Courses = new List<Course>();
            }

            // Method to add a course to the department
            public void AddCourse(string courseName, string courseCode, int credits)
            {
                Courses.Add(new Course(courseName, courseCode, credits));
            }
        }

        // Nested Course class
        public class Course
        {
            public string CourseName { get; set; }
            public string CourseCode { get; set; }
            public int Credits { get; set; }

            public Course(string courseName, string courseCode, int credits)
            {
                CourseName = courseName;
                CourseCode = courseCode;
                Credits = credits;
            }
        }

        // Method to add a new department to the university
        public void AddDepartment(string name)
        {
            departments.Add(new Department(name));
        }

        // Method to add a course to a specific department
        public void AddCourseToDepartment(string departmentName, string courseName, string courseCode, int credits)
        {
            Department department = departments.Find(d => d.Name == departmentName);
            if (department != null)
            {
                department.AddCourse(courseName, courseCode, credits);
            }
            else
            {
                Console.WriteLine($"Department with name {departmentName} not found.");
            }
        }

        // Method to display department and course details
        public void DisplayCourseDetails()
        {
            foreach (var department in departments)
            {
                Console.WriteLine($"Department: {department.Name}");
                foreach (var course in department.Courses)
                {
                    Console.WriteLine($"  Course: {course.CourseName}, Code: {course.CourseCode}, Credits: {course.Credits}");
                }
            }
        }
    }
}
