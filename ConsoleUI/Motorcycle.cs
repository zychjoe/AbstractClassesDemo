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

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} which is a {GetType().BaseType} in an abstract method");
        }

        public override void DriveVirtual()
        {
            //This will keep the base implementation
            //Plus anything you add to this method
            base.DriveVirtual();
        }
    }
}
