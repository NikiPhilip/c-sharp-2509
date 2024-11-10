
//Define a custom attribute DeveloperAttribute that takes the name of the developer and the date 
//when the code was last modified. Apply this attribute to a class Calculator and its method Add. 
//Retrieve and display the attribute information at runtime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class DeveloperAttribute : Attribute
    {
        public string Name { get; }
        public string LastModified { get; }

        public DeveloperAttribute(string name, string lastModified)
        {
            Name = name;
            LastModified = lastModified;
        }
    }
    [Developer("Alice Smith", "2024-10-29")]
    public class Calculator
    {
        [Developer("Bob Johnson", "2024-10-28")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}