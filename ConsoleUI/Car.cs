using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Car : Vehicle
    {
        public int NumberOfWindows { get; set; }

        public override void DriveVirtual(Vehicle vehicle)
        {
            //this will keep the base implementation plus anything you add in this class
            //base.Drive(vehicle);
            Console.WriteLine($"I am driving my car, it is a {vehicle.Make} {vehicle.Model}"); // overridding the base implementation
        }

        public override void DriveAbstract(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
