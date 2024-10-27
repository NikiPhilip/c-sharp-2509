//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment19
//{
//    public record Student(string Name, int Age, string Grade);

//    class Student
//    {
//        // Method that accepts a tuple and returns a Student record
//        public static Student CreateStudent((string Name, int Age, string Grade) studentTuple)
//        {
//            return new Student(studentTuple.Name, studentTuple.Age, studentTuple.Grade);
//        }
//    }
//}