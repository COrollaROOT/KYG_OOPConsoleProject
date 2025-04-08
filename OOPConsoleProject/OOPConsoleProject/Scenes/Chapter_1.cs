using System;
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
            Console.WriteLine("");
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
                    Game.ChangeScene("Chapter_2");
                    break;

                case ConsoleKey.D2:
                    Util.PushKey("텐트 밖 으로 이동합니다.");
                    Game.ChangeScene("OutTentScene");
                    break;
            }
        }
    }
}
