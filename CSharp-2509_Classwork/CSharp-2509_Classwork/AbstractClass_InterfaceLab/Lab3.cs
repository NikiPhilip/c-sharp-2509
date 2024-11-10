

//Create an interface IDrive with a method Drive(). Implement this interface in a Car and Truck 
//class, with each class having its own implementation of Drive().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_InterfaceLab
{
    //Defininginterface IDrive
    public interface IDrive
    {
        //Mthod declaration
        void Drive();
    }

    //Class Car2 implemeting interface IDrive
    public class Car2:IDrive
    {
        public string model {  get; set; }
        public Car2(string model)
        {
            this.model = model;
        }
        public void Drive()
        {
            Console.WriteLine($"The car {model} is driving smoothly");
        }
    }

    //Class Truck implements interface IDrive
    public class Truck:IDrive
    {
        public string model { get; set; }
        public Truck(string model)
        {
            this.model = model;
        }

        public void Drive()
        {
            Console.WriteLine($"The truck {model} is moving with heavy cargo");
        }
    }




}
