using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle car1 = new Car() { Year = "2016", Make = "BMW", Model = "328i", NumberOfTires = 4, NumberOfWindows = 5 };
            Car car2 = new Car() { Year = "1999", Make = "Dodge", Model = "Dekota", NumberOfTires = 4, NumberOfWindows = 2 };
            Motorcycle motor1 = new Motorcycle() { Year = "2005", Make = "Vulcan", Model = "Trumph", EngineNoise = "Vrrrrooooom" };
            Vehicle motor2 = new Motorcycle(); // Not setting any properties, this will reflect the base defaults

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motor1);
            vehicles.Add(motor2);

            foreach (var item in vehicles)
            {
                // Show here that only Vehicle members are present
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}"); 
                Console.WriteLine();
            }

            //These methods use the GetType() to stay flexible
            car1.DriveAbstract();
            Console.WriteLine();
            car1.DriveVirtual();
            Console.WriteLine();
            motor1.DriveAbstract();
            Console.WriteLine();
            motor1.DriveVirtual();

            #endregion
            
            Console.ReadLine();
        }
    }
}
