using System;

namespace Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print printer = new Print();
            printer.PrintData("Hello, World!");
            printer.PrintData(12345);
            printer.PrintData(new int[] { 1, 2, 3, 4, 5 });
            Console.ReadLine();
        }
    }
}
