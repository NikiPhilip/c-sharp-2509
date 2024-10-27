
//Develop a student management system that stores student details. Each 
//student has a name, ID, and a list of grades. Implement methods to add a grade and calculate the 
//average grade.
using System;
using System.Collections.Generic;

namespace Assignment5
{
    public class Student
    {
        public string Student_name;
        public int Student_id;
        public List<double> Grades = new List<double>();

        public Student(string student_name, int student_id)
        {
            Student_name = student_name;
            Student_id = student_id;

        }


        public void add_grade(double grade)
        {
            if (grade > 0 && grade < 100)
            {
                Grades.Add(grade);
                Console.WriteLine($"Grade {grade} added successfully");
            }
            else
            {
                Console.WriteLine("Invalid grade");
            }
        }
        public double average()
        {
            if (Grades.Count == 0)
            {
                Console.WriteLine("No grades found");
            }
            double sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Count;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student_name:{Student_name}, studemt_id:{Student_id},Average grade:{average():0.00}");
        }
    }
}
