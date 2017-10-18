using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kClasses
{
    class Warrior : Player
    {
        public Warrior(int p, int p_2) : base (p,p_2)
        {
            vSpecialAttack = new Berserk();
        }
    }
}
