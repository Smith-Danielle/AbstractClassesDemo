using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"The {Model} is in great condition. This car is ready for the streets!");
        }
    }
}
