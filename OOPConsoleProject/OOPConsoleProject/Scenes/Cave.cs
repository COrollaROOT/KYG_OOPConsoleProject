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
                    "# #                #",
                    "# #                #",
                    "# #    ###  ###    #",
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
            gameObjects.Add(new Place("FallTent", 'C', new Vector0(1, 1)));
            



        }

        public override void Enter()
        {
            if (Game.prevSceneName == "FallTent")
            {
                Game.Player.position = new Vector0(1, 1); // 플레잉어 위치 선정
            }


            Game.Player.map = map;
        }
    }
    }

