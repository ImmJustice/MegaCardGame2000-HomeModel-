using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kClasses
{
    class Fireball : SpecialAttack
    {
        public int Roll(int damage)
        {
            var vRandom = new Random();
            if (vRandom.Next(0,1) == 1)
            {
                return damage * 4;
            }
            else
            {
                return damage * -1;
            }
        }

    }
}
