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
                case ConsoleKey.LeftArrow:
                    Util.PushKey("이전 으로 진행합니다.");
                    Game.ChangeScene("Chapter_1");
                    break;
                case ConsoleKey.RightArrow:
                    Util.PushKey("다음 으로 진행합니다.");
                    Game.ChangeScene("Chapter_3");
                    break;
            }
        }
    }
}
