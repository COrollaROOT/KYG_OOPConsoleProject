using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConsoleProject.Items
{
    class Water : Item
    {
        public Water(ConsoleColor color, char symbol, Vector0 position)
            : base(color, symbol, position)
        {
            name = " 맑은 물";
            description = "이거라도 먹어야 산다";
        }

        public override void Use()
        {
            Game.Player.Heal(5);
            Console.WriteLine($"{name}을(를) 먹고 체력이 -10 감소 되었습니다.");
        }
    }
}

