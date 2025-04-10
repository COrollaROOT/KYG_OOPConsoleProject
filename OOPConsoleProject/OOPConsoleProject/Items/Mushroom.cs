using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Items
{
    class Mushroom : Item
    {
        
        public Mushroom(ConsoleColor color,char symbol, Vector0 position)
            : base(color,symbol, position)
        {
            name = "버섯";
            description = "먹으면 내가 버섯이될지도?";
        }

        public override void Use()
        {
            Game.Player.Heal(-5);
            Console.WriteLine($"{name}을(를) 먹고 체력이 -10 감소 되었습니다.");
        }
    }
}

    

