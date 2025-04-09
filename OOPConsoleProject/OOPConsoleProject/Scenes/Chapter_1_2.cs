using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Chapter_1_2 : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("결국 아무것도 얻지 못했다");
            Console.WriteLine();
            Console.Write("선택지를 입력하세요 : ");
            Console.WriteLine(" 1. 텐트 안에 있는다  2. 텐트 밖으로 나간다");
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
                case ConsoleKey.D1:
                    Util.PushKey("텐트 안에 남았습니다.");
                    Game.ChangeScene("DiedScene1");
                    break;

                case ConsoleKey.D2:
                    Util.PushKey("텐트 밖 으로 이동합니다.");
                    Game.ChangeScene("OutTent1");
                    break;
            }
        }
    }
}

