﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kClasses
{
    public class SpecialAttack : Attack
    {
        public virtual int RollOutcome(int Damage)
        {
            throw new Exception();
        }

    }
}
