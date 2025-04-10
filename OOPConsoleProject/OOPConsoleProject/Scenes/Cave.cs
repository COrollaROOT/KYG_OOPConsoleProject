using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class Cave : OutTentScene
    {
        public Cave()
        {
            mapData = new string[]
                {
                    "####################",
                    "# #          #     #",
                    "# #### # # #   #####",
                    "# # #  ### ####    #",
                    "#     ##        #  #",
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

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("FallTent", 'C', new Vector0(1, 1)));
            gameObjects.Add(new Place("Chapter_2", 'G', new Vector0(18, 1)));
            gameObjects.Add(new Place("Chapter_1_2", 'B', new Vector0(18, 4)));
            gameObjects.Add(new Place("FallTent", 'M', new Vector0(15, 1)));            
            gameObjects.Add(new Water(ConsoleColor.Blue, 'W', new Vector0(3, 1)));

        }

        public override void Enter()
        {
            if (Game.prevSceneName == "FallTent")
            {
                Game.Player.position = new Vector0(1, 1); // 플레잉어 위치 선정
            }


            Game.Player.map = map;
        }
        public override void Render()
        {

            base.Render();
            Console.WriteLine($"-현재 체력 : {Game.Player.NowHp}");
            Console.WriteLine();
            Console.WriteLine("'이렇게 큰 동굴이 있었다니 으스스한걸 빨리 나가야겠어'");
            
            Console.WriteLine();
            Console.WriteLine("방향키로 움직이시오");
            Console.WriteLine("I : 인벤토리");


        }
    }
}

