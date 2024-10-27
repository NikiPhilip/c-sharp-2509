

//Create two interfaces IPrintable and IScannable with respective methods Print() and Scan(). 
//Implement both interfaces in a class PrinterScanner.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public interface IPrintable
    {
        void Print();  // Method declaration for printing
    }

    // Interface IScannable
    public interface IScannable
    {
        void Scan();  // Method declaration for scanning
    }

    // Class implementing both IPrintable and IScannable interfaces
    public class PrinterScanner : IPrintable, IScannable
    {
        // Implementing the Print method from IPrintable
        public void Print()
        {
            Console.WriteLine("Printing the document...");
        }

        // Implementing the Scan method from IScannable
        public void Scan()
        {
            Console.WriteLine("Scanning the document...");
        }
    }
}