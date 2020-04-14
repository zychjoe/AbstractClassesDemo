using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Motorcycle : Vehicle
    {
        public string EngineNoise { get; set; }

        public Motorcycle()
        {
            NumberOfTires = 2;
        }

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine($"I'm driving in an abstract method");
        }

        public override void DriveVirtual(Vehicle vehicle)
        {
            //This will keep the base implementation
            //Plus anything you add to this method
            base.DriveVirtual(vehicle);
        }
    }
}
