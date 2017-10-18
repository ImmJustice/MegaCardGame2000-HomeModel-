using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kClasses
{
    public class Character
    {
        public int Hp;
        public int BaseDamage;
        protected NormalAttack vNormalAttack;

        public Character(int p, int p_2)
        {
            Hp = p;
            BaseDamage = p_2;
            vNormalAttack = new NormalAttack();
        }

        public void AttackChar(Character Target)
        {
            vNormalAttack.DealDamage(BaseDamage, Target);
        }
    }

}