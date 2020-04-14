using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Monster
    {
        public string Name = "Generic Monster";
        public float BaseHP = 100f;
        public bool IsBoss = false;
        
        public virtual void Attack()
        {
            Console.WriteLine($"Damaging the hero! You took 10 pts damage!");
        }
    }
}
