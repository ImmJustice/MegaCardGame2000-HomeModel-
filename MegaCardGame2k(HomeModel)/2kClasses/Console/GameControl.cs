using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2kClasses
{
   public class GameControl
    {
        private Character player;
        private Character enemy;
        
        public void Create(char Class)
        {
            player = new Player(10, 40, Class);
            GenerateNpc();

        }

        private void GenerateNpc()
        {
            //Draw enemy from deck
            throw new NotImplementedException();
        }
        
    }


    
}
