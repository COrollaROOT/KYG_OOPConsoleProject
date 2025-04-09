using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class DiedScene1 : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            
            Console.WriteLine("죽었습니다");
            Console.WriteLine();
            Console.Write("선택지를 입력하세요 : ");
            Console.WriteLine(" 1.네   2. 아니요");
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
                    Util.PushKey("다시 시작합니다.");
                    Game.ChangeScene("Chapter_1_2");
                    break;

                case ConsoleKey.D2:
                    Util.PushKey("종료합니다");
                    Game.ChangeScene("Title");
                    break;
            }
        }
    }
}
