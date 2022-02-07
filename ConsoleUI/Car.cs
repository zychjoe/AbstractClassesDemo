using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }

        public Car(string year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("This Car is moving!");
        }
    }
}
