using System;
using System.Collections.Generic;

namespace Assignment3
{

    //   3. Design a library management system that manages books.Each book has a
    //title, author, and ISBN number.The system should allow adding a book, removing a book, and
    //displaying all books.
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        public override string ToString()
        {
            return $"{Title} by {Author} (ISBN:{ISBN})";
        }
    }
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(string isbn)
        {
            books.RemoveAll(b => b.ISBN == isbn);
        }
        public void DisplayAll()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
