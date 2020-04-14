using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Werewolf : Monster
    {
        public override void Attack()
        {
            Console.WriteLine("Looks like you were scratched by a werewolf... You take 22 pts damage and you've been frightened," +
                " you will skip your next turn.");
        }
    }
}
