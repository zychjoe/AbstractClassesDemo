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

            #region Vehicle

            // Create a list of Vehicle called vehicles

            Car chevy = new Car("1990", "Chevrolet", "Cavalier");
            Motorcycle yammy = new Motorcycle("2020", "Yamaha", "Freerider");
            Vehicle saturn = new Car() { Year = "1995", Make = "Saturn", Model = "Sedan" };
            Vehicle harley = new Motorcycle() { Year = "2000", Make = "Harley Davidson", Model = "Sportster" };

            List<Vehicle> vehicleList = new List<Vehicle>();

            vehicleList.Add(chevy);
            vehicleList.Add(yammy);
            vehicleList.Add(saturn);
            vehicleList.Add(harley);

            foreach (Vehicle v in vehicleList)
            {
                Console.WriteLine($"Now this is a nice vehicle.");
                Console.WriteLine($"It's year is {v.Year}");
                Console.WriteLine($"It's make is {v.Make}");
                Console.WriteLine($"It's model is {v.Model}");
                Console.WriteLine($"And that's that vehicle.");

            }

            // Call each of the drive methods for one car and one motorcycle
            chevy.DriveAbstract();
            chevy.DriveVirtual();
            harley.DriveAbstract();
            harley.DriveVirtual();

            #endregion            
        }
    }
}
