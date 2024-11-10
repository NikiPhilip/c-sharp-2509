
//Create a Library class that contains an array of Book objects. Implement an indexer that allows 
//accessing the books by index. Write a method to display all the books in the library.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    public class Library
    {
        private Book[] books;

        // Constructor to initialize the library with a specified number of books
        public Library(int size)
        {
            books = new Book[size];
        }

        // Indexer to allow access to books by index
        public Book this[int index]
        {
            get
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return books[index];
            }
            set
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                books[index] = value;
            }
        }

        // Method to display all books in the library
        public void DisplayAllBooks()
        {
            Console.WriteLine("Books in the library:");
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    Console.WriteLine($"[{i}] Title: {books[i].Title}, Author: {books[i].Author}");
                }
            }
        }
    }
}