using System;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.SetTime(10, 45);
            time.DisplayTime();


            time.SetTime(3723);
            time.DisplayTime();

            time.SetTime(25, 61);
            time.SetTime(90000);
            Console.ReadLine();
        }
    }
}
