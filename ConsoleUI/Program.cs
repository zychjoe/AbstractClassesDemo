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
            //Create a list of vehicles called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle car1 = new Car() { Year = "2016", Make = "BMW", Model = "328i", NumberOfTires = 4, NumberOfWindows = 5 };
            Car car2 = new Car() { Year = "1999", Make = "Dodge", Model = "Dekota", NumberOfTires = 4, NumberOfWindows = 2 };
            Vehicle motor1 = new Motorcycle() { Year = "2005", Make = "Vulcan", Model = "Trumph", EngineNoise = "Vrrrrooooom" };
            Motorcycle motor2 = new Motorcycle(); // Not setting any properties, this will reflect the base

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motor1);
            vehicles.Add(motor2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}"); // Show here that only Vehicle members are present
            }

            Console.ReadLine();
            #endregion

            #region Monsters

            List<Monster> enemies = new List<Monster>();

            //Monster genericMonster = new Monster(); This is not allowed. Cannot create an instance of an abstract class

            Monster zombie = new Zombie() { BaseHP = 75, Name = "Zombie Man" };
            Monster wereWolf = new Werewolf() { BaseHP = 125, Name = "Wolf Man", IsBoss = true };
            Monster scientist = new MadScientist(); // Not setting any properties, this will reflect the base

            enemies.Add(zombie);
            enemies.Add(wereWolf);
            enemies.Add(scientist);

            foreach (var monster in enemies)
            {
                Console.WriteLine($"{monster.Name} attacks! Their Hp is: {monster.BaseHP}, is a boss: {monster.IsBoss}");
                monster.Attack();
            }

            Console.ReadLine();
            #endregion
        }
    }
}
