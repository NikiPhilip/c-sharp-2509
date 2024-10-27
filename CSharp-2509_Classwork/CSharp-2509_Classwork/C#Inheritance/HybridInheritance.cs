//Create two interfaces IMovable and IRechargeable. Create a class Vehicle implementing
//IMovable and derive ElectricCar from Vehicle implementing both interfaces.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Inheritance
{
    public interface IMovable
    {
        void Move();  // Method declaration for movement
    }

    // Interface IRechargeable
    public interface IRechargeable
    {
        void Recharge();  // Method declaration for recharging
    }

    // Base class Vehicle implementing IMovable
    public class Vehicle : IMovable
    {
        // Implementing the Move method from IMovable
        public virtual void Move()
        {
            Console.WriteLine("The vehicle is moving.");
        }
    }

    // Derived class ElectricCar from Vehicle, implementing IRechargeable
    public class ElectricCar : Vehicle, IRechargeable
    {
        // Implementing the Recharge method from IRechargeable
        public void Recharge()
        {
            Console.WriteLine("The electric car is recharging.");
        }

        // Override the Move method for ElectricCar
        public override void Move()
        {
            Console.WriteLine("The electric car is moving silently.");
        }
    }
}