
//: Design a Print class that contains overloaded methods to print different 
//types of data: a string, an integer, and an array of integers.

using System;

namespace Assignment_8
{
    internal class Print
    {
        public void PrintData(int data)
        {
            Console.WriteLine("Integer:" + data);
        }
        public void PrintData(string data)
        {
            Console.WriteLine("String: " + data);
        }

        public void PrintData(int[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
