﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kClasses
{
    public class Player : Character
    {
        protected SpecialAttack vSpecialAttack;

        public Player(int baseDamage, int currentHealthPoints) : base(baseDamage, currentHealthPoints) { }
                   
        

        public virtual void IniateSpecial(Character Target)
        {
            vSpecialAttack.DealDamage(vSpecialAttack.RollOutcome(BaseDamage), Target);
        }

    }
}
