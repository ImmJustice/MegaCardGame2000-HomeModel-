using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2kClasses
{
    class Back_Stab : SpecialAttack
    {
        public override int RollOutcome(int damage)
        {
            var vRandom = new Random();

            if (vRandom.Next(0,3) == 2)
            {
                return damage * 2;
            }
            else
            {
                return damage/2;
            }

            
        }

    }
}
