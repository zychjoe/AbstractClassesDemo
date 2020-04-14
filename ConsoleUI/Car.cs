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

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} in an abstract method, it is a {GetType().BaseType.Name}");
        }

        public override void DriveVirtual()
        {
            //this will keep the base implementation plus anything you add in this class
            //base.Drive(vehicle);

            //overridding the base implementation
            Console.WriteLine($"I'm driving a {GetType().Name} in a virtual method, it is a {GetType().BaseType.Name}"); 
        }        
    }
}
