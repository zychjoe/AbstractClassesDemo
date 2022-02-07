using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public Motorcycle(string year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public override void DriveAbstract()
        {
           Console.WriteLine("This Motorcycle peels out!");
        }

        public override void DriveVirtual()
        {
           Console.WriteLine("This Mortorcycle really moves!");
        }
    }
}
