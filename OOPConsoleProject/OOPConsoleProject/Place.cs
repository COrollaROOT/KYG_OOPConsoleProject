using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Place : GameObject
    {
        private string scene;
        public Place(string scene, char symbol, Vector0 position)
            : base(ConsoleColor.Yellow, symbol, position)

        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene); // 장소가 할 역활 : 해당씬으로 이동
        }
    }
}
