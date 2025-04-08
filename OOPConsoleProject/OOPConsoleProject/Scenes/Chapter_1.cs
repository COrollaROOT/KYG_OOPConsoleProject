﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class Chapter_1 : BaseScene
    {

        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("1");
            Console.WriteLine();
            Console.Write("선택지를 입력하세요 : ");
            Console.WriteLine(" <- : 이전 , -> : 다음");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.RightArrow:
                    Util.PushKey("다음 으로 이동합니다.");
                    Game.ChangeScene("Chapter_2");
                    break;

                case ConsoleKey.LeftArrow:
                    Util.PushKey("이전 으로 이동합니다.");
                    Game.ChangeScene("Title");
                    break;
            }
        }
    }
}
