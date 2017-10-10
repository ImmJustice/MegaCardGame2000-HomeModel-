using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kClasses
{
    class Berserk : SpecialAttack
    {

        public int Roll(int damage)
        {

            var vRandom = new Random();
            if (vRandom.Next(0, 2) == 2)
            {
                return damage * 3;
            }
            else
            {
                return 0;
            }    
        }
    }
}
