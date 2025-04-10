using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObjects
{
    class AnimalEnemy : GameObject
    {
        public AnimalEnemy(ConsoleColor color, char symbol, Vector0 position, bool oneOff) : base(color, symbol, position, oneOff)
        {
        }

        public override void Interact(Player player)
        {
            
        }
    }
}
