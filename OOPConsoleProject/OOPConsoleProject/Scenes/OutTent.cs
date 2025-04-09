using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    // abstract : 여러 파생 클래스에서 공유할 수 있는 기본 클래스의 공통적인 정의를 제공
    public abstract class OutTentScene : BaseScene // 텐트 밖씬은 이동할수 있도록 맵으로 구현
    {
        private ConsoleKey input;
        // 상속된 자식 클래스는 허용 그외는 불허
        // protected
        protected string[] mapData;
        protected bool[,] map; // 맵 구성

        protected List<GameObject> gameObjects;


        public override void Render()
        {
            PrintMap(); // 맵 그려준다
            foreach (GameObject obj in gameObjects)
            {
                obj.Print(); // 게임 오브젝트 그려주기
            }
            Game.Player.Print(); // 플레이어 그려준다

            Console.SetCursorPosition(0, map.GetLength(0) + 2); // 맵 생성시 
            Game.Player.inventory.PrintALL(); // 인벤토리도 구현

            


        }

        public override void Input() // 키를 입력받아
        {
            input = Console.ReadKey(true).Key; 
        }

        public override void Update() // 입력받은 키로 움직임 구성
        {
            Game.Player.Action(input); // 입력받은 키로 플레이어 움직이게 한다
        }

        public override void Result()
        {
            foreach (GameObject obj in gameObjects)
            {
                if (Game.Player.position == obj.position)
                {
                    obj.Interact(Game.Player);
                    if (obj.oneOff == true)
                    {
                        gameObjects.Remove(obj); // 상호작용하면 지우기
                    }
                    break;
                }
            }
        }

        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' '); // 갈수 있는 지형 

                    }

                   

                    else
                    {
                        Console.Write('#'); // 갈수 없는 지형
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
