using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kClasses
{
    public class Attack
    {
        public virtual void DealDamage(int Damage, Character Target)
        {
            Target.Hp -= Damage;
        }
    }
}
