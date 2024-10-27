using System;

namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"System-wide Application Name: {Configuration.ApplicationName}");


            Configuration user1 = new Configuration("Intel 12");
            user1.DisplaySettings();

            Configuration user2 = new Configuration("Intel 15");
            user2.DisplaySettings();
            Console.ReadLine();
        }
    }
}
