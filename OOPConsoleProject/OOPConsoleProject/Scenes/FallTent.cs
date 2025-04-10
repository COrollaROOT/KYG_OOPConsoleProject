using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class FallTent : OutTentScene
    {
        public FallTent()
        {
            mapData = new string[]
                {
                    "####################",
                    "# ##  #   #     ####",
                    "# ## #  #  #      ##",
                    "# ##   ### ####  # #",
                    "#     ##           #",
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
            gameObjects.Add(new Place("Cave", 'C', new Vector0(1, 1)));
            gameObjects.Add(new Food(ConsoleColor.Blue, 'F', new Vector0(4, 1)));
            gameObjects.Add(new Mushroom(ConsoleColor.Yellow, 'M', new Vector0(18, 4)));
            gameObjects.Add(new Place("DiedScene3", 'M', new Vector0(15, 1)));


        }

        public override void Enter()
        {
            if (Game.prevSceneName == "Chapter_2")
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
            Console.WriteLine("'휴..겨우 살았네 큰일날뻔..'");
            Console.WriteLine("'여긴 어디지...일단 길을 찾아보자'\n'저기 동굴이(G)보이는걸'");
            Console.WriteLine();
            Console.WriteLine("방향키로 움직이시오");
            Console.WriteLine("I : 인벤토리");


        }
    }
}
