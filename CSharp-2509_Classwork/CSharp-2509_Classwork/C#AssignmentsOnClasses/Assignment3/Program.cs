using System;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Two States", "Chetan Bhagat", "134 - 9223");
            Book book2 = new Book("Famous Five", "Enid Blyton", "213-9372");

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);


            library.DisplayAll();

            library.RemoveBook("213-9372");
            library.DisplayAll();
            Console.ReadLine();
        }



    }
}
