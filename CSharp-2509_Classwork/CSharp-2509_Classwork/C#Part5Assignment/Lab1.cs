
//Create a Library class to store and manage books in a single-dimensional array where 
//each element represents a book title. Also, use a two-dimensional array in a Classroom class
//where each element represents the seat of a student based on rows and columns.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignment
{
    public class Library
    {
        private string[] books; // Single-dimensional array to store book titles
        private int count; // To keep track of the number of books

        public Library(int size)
        {
            books = new string[size]; // Initialize the array with a specified size
            count = 0; // Initialize book count
        }

        // Method to add a book title
        public void AddBook(string title)
        {
            if (count < books.Length)
            {
                books[count] = title; // Add the book title to the array
                count++; // Increment the count of books
                Console.WriteLine($"Added book: {title}");
            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books.");
            }
        }

        // Method to display all book titles
        public void DisplayBooks()
        {
            Console.WriteLine("Books in the Library:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}: {books[i]}");
            }
        }
    }

    public class Classroom
    {
        private string[,] seats; // Two-dimensional array to represent seating
        private int rows; // Number of rows
        private int columns; // Number of columns

        public Classroom(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            seats = new string[rows, columns]; // Initialize the array with specified dimensions
        }

        // Method to assign a student to a seat
        public void AssignSeat(int row, int column, string studentName)
        {
            if (row < rows && column < columns && seats[row, column] == null)
            {
                seats[row, column] = studentName; // Assign the student name to the specified seat
                Console.WriteLine($"{studentName} has been assigned to seat ({row + 1}, {column + 1}).");
            }
            else
            {
                Console.WriteLine("Seat is either occupied or out of bounds.");
            }
        }

        // Method to display seating arrangement
        public void DisplaySeating()
        {
            Console.WriteLine("Classroom Seating Arrangement:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Display the seat or "Empty" if the seat is unoccupied
                    Console.Write(seats[i, j] ?? "Empty");
                    Console.Write("\t");
                }
                Console.WriteLine(); // Newline after each row
            }
        }
    }
}