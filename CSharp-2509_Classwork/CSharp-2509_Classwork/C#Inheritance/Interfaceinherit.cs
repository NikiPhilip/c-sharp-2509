
//Create an interface IDriveable with a method Drive(). Create another interface IRaceable that
//inherits from IDriveable and adds a method Race().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public interface IDriveable
    {
        void Drive();
    }

    // Interface IRaceable that inherits from IDriveable
    public interface IRaceable : IDriveable
    {
        void Race();
    }

    // Class that implements both interfaces
    public class RaceCar : IRaceable
    {
        public void Drive()
        {
            Console.WriteLine("The race car is driving.");
        }

        public void Race()
        {
            Console.WriteLine("The race car is racing!");
        }
    }
}