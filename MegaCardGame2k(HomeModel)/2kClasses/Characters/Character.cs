using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kClasses
{
    class Character
    {
        private int pBaseDamage { get; set; }
        private int pCurrentHealthPoints { get; set; }
        

        public void TakeDamage(int Damage)
        {
            pCurrentHealthPoints -= Damage;

            // To implement update of lable
        }

        public Character(int baseDamage, int currentHealthPoints )
        {
            pBaseDamage = baseDamage;
            pCurrentHealthPoints = currentHealthPoints;
        }
    }

}