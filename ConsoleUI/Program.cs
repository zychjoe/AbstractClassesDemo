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
            //List<Vehicle> vehicles = new List<Vehicle>();

            //Vehicle car1 = new Car() { Year = 2016, Make = "BMW", Model = "328i", NumberOfTires = 4, NumberOfWindows = 5 };
            //Vehicle motor1 = new Motorcycle() { Year = 2005, Make = "Vulcan", Model = "Trumph", EngineNoise = "Vrrrrooooom" };
            //Car car2 = new Car() { Year = 1999, Make = "Dodge", Model = "Dekota", NumberOfTires = 4, NumberOfWindows = 2 };
            //Motorcycle motor2 = new Motorcycle() { };

            //vehicles.Add(motor1);
            //vehicles.Add(motor2);
            //vehicles.Add(car1);
            //vehicles.Add(car2);

            //foreach (var item in vehicles)
            //{
            //    Console.WriteLine($"{item.Year} {item.Make} {item.Model}"); // Show here that only Vehicle members are present
            //}
            
            //Console.ReadLine();
            #endregion

            #region Monsters

            //Monster genericMonster = new Monster(); This is not allowed. Cannot create an instance of an abstract class

            Monster zombie = new Zombie() { _baseHP = 75, _name = "Zombie Man" };
            zombie.Attack(); //This called the overridded method for the zombie

            Monster wereWolf = new Werewolf() { _baseHP = 125, _name = "Wolf Man" };
            wereWolf.Attack(); //This calls the overridded method for the werewolf

            Monster scientist = new MadScientist();
            scientist.Attack(); //This calls the base attack method
            Console.WriteLine($"Hp: {scientist._baseHP}");

            Console.ReadLine();
            #endregion
        }
    }
}
