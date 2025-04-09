using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Items
{
    class Food : Item
    {
        public Food(char symbol, Vector0 position)
            : base('F', position)
        {
            name = "도토리";
            description = "먹어도 허기가 가시진 않는다\n죽지도 않지만...";
        }

        public override void Use()
        {
            Game.Player.Heal(10);
        }
    }
}
