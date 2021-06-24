using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - Complete
             * The vehicle class shall have three string properties Year, Make, and Model -Complete
             * Set the defaults to something generic in the Vehicle class - Complete
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - Complete
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - Complete
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - Complete
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - Complete
             * Provide the implementations for the abstract methods - Complete
             * Only in the Motorcycle class will you override the virtual drive method - Complete
            */

            // Create a list of Vehicle called vehicles - Complete

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class - Complete
             * Set the properties with object initializer syntax - Complete
             */

            Car car1 = new Car() { Year = 2020, Make = "Chevy", Model = "Malibu", HasTrunk = true };
            vehicles.Add(car1);
            Motorcycle motor1 = new Motorcycle() {Year = 2021, Make = "Yanaha", Model = "VMAX", HasSideCart = false };
            vehicles.Add(motor1);
            Vehicle v1 = new Car() { Year = 2000, Make = "Dodge", Model = "Challenger", HasTrunk = true };
            vehicles.Add(v1);
            Vehicle v2 = new Motorcycle { Year = 1960, Make = "Suzuki", Model = "Boulevard", HasSideCart = true };
            vehicles.Add(v2);

            /*
             * Add the 4 vehicles to the list - Complete
             * Using a foreach loop iterate over each of the properties - Complete
             */
            Console.WriteLine("Car list:");
            foreach (var item in vehicles)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Year: {item.Year}");

            }
            Console.WriteLine("------------------------");

            // Call each of the drive methods for one car and one motorcycle


            //These were instances of inherited classes
            Console.WriteLine("Vehicles driving--------------------------------------");
            car1.DriveAbstract();
            car1.DriveVirtual();
            motor1.DriveAbstract();
            motor1.DriveVirtual();
            Console.WriteLine("------------------------------------------------------");
            //These are objects of the Vehicle class but use the inherited constructors

            Console.WriteLine("More vehicles driving---------------------------------");
            v1.DriveAbstract();
            v1.DriveVirtual();
            v2.DriveAbstract();
            v2.DriveVirtual();
            Console.WriteLine("------------------------------------------------------");


            #endregion            
            Console.ReadLine();
        }
    }
}
