using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Zombie : Monster
    {
        //This is the overridden method for the zombie
        public override void Attack()
        {
            Console.WriteLine("You got bit by a zombie! You took 27 pts damage. Find an antidote soon or you'll turn...");
        }
    }
}
