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
            Console.WriteLine("따스한 햇빛이 나의 눈을 덮는다\n나는 눈을 천천히 뜬다");
            Thread.Sleep(1500);
            Console.WriteLine("눈앞엔 고요하고 드넓은 산림이 펼쳐져 있다.\n바람에 풀잎이 일렁이고\n멀리선 새소리가 아련하게 들린다.");
            Thread.Sleep(1500);
            Console.WriteLine("'캬~ 자리 하나는 기가 막히게 잡았단 말이지!'");
            Thread.Sleep(1500);
            Console.WriteLine("'역시 내가 원하던 게 이런 거였어! ㅠ.ㅠ'");
            Thread.Sleep(1500);
            Console.WriteLine("몇 번이고 혼잣말을 하며 주위를 둘러본다. 초록의 숨결이 온몸에 스며드는 기분이다.");
            Thread.Sleep(1500);
            Console.WriteLine("그렇게 한참을 감상에 빠져 있다 보니, 갑작스레 '꼬르륵' 소리가 뱃속에서 울려 퍼진다.");
            Thread.Sleep(1500);
            Console.WriteLine("'...이런, 좀 배가 고픈걸. 어제부터 뭘 제대로 못 먹었지.'");
            Thread.Sleep(1500);
            Console.WriteLine("주위를 살펴보지만 가지고 있던 식량은 다 떨어졌다.");
            Thread.Sleep(1500);
            Console.WriteLine("'쳇, 나가서 또 구해 와야겠네. 귀찮게…'");
            Thread.Sleep(1500);

            Console.WriteLine();
            Console.Write("선택지를 입력하세요 : ");
            Console.WriteLine(" 1. 찾으러간다 2. 가지 않는다");
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
                    Util.PushKey("찾으러 나갑니다.");
                    Game.ChangeScene("OutTent1");
                    break;

                case ConsoleKey.D2:
                    Util.PushKey("나가지 않습니다.");
                    Game.ChangeScene("DiedScene1");
                    break;
            }
        }
    }
}
