using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kClasses
{
    class Player : Character
    {
        private SpecialAttack sSpecialAttack;

        public Player(int baseDamage, int currentHealthPoints, char Class) : base(baseDamage, currentHealthPoints)
        {
            switch (Class)
            {
                case 'W':
                    sSpecialAttack = new Berserk();

                    break;

                case 'M':
                    sSpecialAttack = new Fireball();

                    break;

                case 'T':
                    sSpecialAttack = new Back_Stab();

                    break;

                default:
                    throw new Exception();
            }

        }
    }
}
