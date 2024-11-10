using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Anonymous_Delegates
{
    public class StringOperations
    {
        public delegate string StringOperationDelegate(string input);

        // Method to convert a string to uppercase
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        // Method to reverse a string
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Method to replace spaces with hyphens
        public static string ReplaceSpacesWithHyphens(string input)
        {
            return input.Replace(" ", "-");
        }

    }
}
