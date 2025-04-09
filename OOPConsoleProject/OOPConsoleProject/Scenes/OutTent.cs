using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class OutTentScene : BaseScene // 텐트 밖씬은 이동할수 있도록 맵으로 구현
    {
        private ConsoleKey input;

        private string[] mapData;
        private bool[,] map; // 맵 구성

        public OutTentScene()
        {
            mapData = new string[]
                {
                    "####################",
                    "#  #       #    ####",
                    "#  #   ### #  #    #",
                    "#  ### #   ####### #",
                    "#      #           #",
                    "####################"

                };

            map = new bool[6, 20];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;

                }
            }

            Game.Player.position = new Vector0(1, 1); // 플레잉어 위치 선정
            Game.Player.map = map;
        }


        public override void Render()
        {
            PrintMap(); // 맵 그려준다
            Game.Player.Print(); // 플레이어 그려준다
        }

        public override void Input() // 키를 입력받아
        {
            input = Console.ReadKey(true).Key; 
        }

        public override void Update() // 입력받은 키로 움직임 구성
        {
            Game.Player.Move(input); // 입력받은 키로 플레이어 움직이게 한다
        }

        public override void Result()
        {

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
