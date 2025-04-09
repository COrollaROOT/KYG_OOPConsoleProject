using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class OutTent1 : OutTentScene
    {

        public OutTent1()
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

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("DiedScene1", 'T', new Vector0(1, 1)));
            gameObjects.Add(new Place("Chapter_2", 'F', new Vector0(12, 2)));

            Game.Player.position = new Vector0(1, 1); // 플레잉어 위치 선정
            Game.Player.map = map;
            


        }

        public override void Render()
        {
           
            base.Render();
            Console.WriteLine("저기에 음식(F)이 있네\n한번 가볼까?");
            Console.WriteLine("방향키로 움직이시오");
            Console.WriteLine("I : 인벤토리");


        }
    }
}
