using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.GameObjects
{
    class AnimalEnemy : GameObject
    {
        public int hp; // 적 체력 설정
        public int attackPower; // 적 공격력 설정

        public AnimalEnemy(ConsoleColor color, char symbol, Vector0 position, bool oneOff, int hp, int attackPower)
            : base(color, symbol, position, oneOff)
        {
            this.hp = hp;
            this.attackPower = attackPower;
        }

        public override void Interact(Player player)
        {

            while (hp > 0 && player.NowHp > 0) // 플레이어 체력이 0과 같을때까지 반복처리 기능
            {
                Console.WriteLine("1. 공격하기");
                Console.WriteLine("2. 도망치기");

                ConsoleKey input = Console.ReadKey(true).Key;
                

            }

        }
    }
}
