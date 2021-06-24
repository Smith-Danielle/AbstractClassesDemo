using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"The {Model} is in great condition. This motorcycle is ready for the streets!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"Ready to rev this {Make}!");
        }
    }
}
