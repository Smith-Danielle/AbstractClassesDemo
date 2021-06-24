using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        /*
        * Create an abstract class called Vehicle - Complete
        * The vehicle class shall have three string properties Year, Make, and Model - Complete
        * Set the defaults to something generic in the Vehicle class - Complete
        * Vehicle shall have an abstract method called DriveAbstract with no implementation - Complete
        * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - Complete
        */
        public Vehicle()
        { 
        }

        public int Year { get; set; } = 0;
        public string Make { get; set; } = "DEFAULT MAKE";
        public string Model { get; set; } = "DEFAULT MODEL";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"The {Make} is ready to go!");
        }
    }
}
