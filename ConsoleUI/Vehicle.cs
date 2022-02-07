using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        private string _year = "a year";
        private string _make = "a make";
        private string _model = "a model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("The Vehicle is in motion.");
        }

        public string Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }
    }
}
