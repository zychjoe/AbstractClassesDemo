using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Monster
    {
        public string _name = "Generic Monster";
        public float _baseHP = 100f;
        public bool _isBoss = false;
        
        public virtual void Attack()
        {
            Console.WriteLine($"Damaging the hero! You took 10 pts damage!");
        }
    }
}
