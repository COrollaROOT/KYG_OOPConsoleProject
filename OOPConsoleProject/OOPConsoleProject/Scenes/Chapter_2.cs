using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class Chapter_2 : BaseScene
    {

        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("2");
            Console.WriteLine();
            Console.Write("선택지를 입력하세요 : ");
            Console.WriteLine(" 1. 내려간다 , 2. 그대로 있는다");
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
                    Util.PushKey("내려갑니다.");
                    Game.ChangeScene("FallTent");
                    break;
                case ConsoleKey.D2:
                    Util.PushKey("그대로 있습니다.");
                    Game.ChangeScene("Chapter_3");
                    break;
            }
        }
    }
}
