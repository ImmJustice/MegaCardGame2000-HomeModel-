using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace _2kClasses
{
   public class GameControl
    {
        public Player player;
        public Character enemy;
        

        public GameControl()
        {
            // To change //

            enemy = new NPC(40,10);
        }

        public void ClassChoice(char p)
        {
            switch (p)
            {
                case 'M':
                    player = new Mage(40,10);
                    break;

                case 'W':
                    player = new Warrior(40,10);
                    break;

                case 'T':
                    player = new Thief(40,10);
                    break;

                default:
                    throw new Exception();
                    
            }
        }

        public void AttackCall(char p)
        {
            if (p == 'N')
            {
                player.AttackChar(enemy);
            }
            else
            {
                player.IniateSpecial(enemy);
            }


            if (enemy.Hp <=0)
            {
                
               if (MessageBox.Show("Game will exit","You win",MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
               
            }
            else
            {
                enemy.AttackChar(player);
            }

            if (player.Hp <= 0)
            {
                if (MessageBox.Show("Game will exit","You Lost", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }


        }
        
        
    }


    
}
