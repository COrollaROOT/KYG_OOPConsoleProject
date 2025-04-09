using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObjects
{
    public abstract class Item : GameObject // 상호작용 가능한 아이템 구현
    {

        public string name; // 아이템 이름
        public string description; // 아이템 설명

        public Item(char symbol, Vector0 position)
            : base(ConsoleColor.Blue, symbol, position, true)
        {
        }

        public override void Interact(Player player)
        {
            player.inventory.Add(this);  // 습득
        }

        public abstract void Use();
    }
}
