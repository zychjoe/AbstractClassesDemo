using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Vehicle //: IVehicle Can demo this in the Interfaces lesson
    {
        public int NumberOfTires { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //Using abstract means you MUST provide the override keyword
        //and an implementation in the derived class        
        public abstract void DriveAbstract(Vehicle vehicle);

        //Using virtual means you DO NOT have to provide an override in the derived class
        public virtual void DriveVirtual(Vehicle vehicle) 
        {
            Console.WriteLine($"I am driving my vehicle, it is a: {vehicle.Make} {vehicle.Model}");
        }
    }
}
