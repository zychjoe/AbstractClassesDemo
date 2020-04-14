using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class MadScientist : Monster
    {
        //This calls the base attack method
        public override void Attack()
        {
            base.Attack();
        }
    }
}
