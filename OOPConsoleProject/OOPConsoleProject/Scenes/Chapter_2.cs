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
            Console.WriteLine("'으르렁..'");
            Thread.Sleep(1500);
            Console.WriteLine("낮고 무거운 소리가 동굴안에 울려 퍼진다..");
            Thread.Sleep(1500);
            Console.WriteLine("어둠속에서 한쌍의 별이 점점 커지며 서서히 그 모습을 드러낸다.");
            Thread.Sleep(1500);
            Console.WriteLine("칠흑같은 검음 갑주를 입은듯한 커다란 늑대가 나를 향해 천천히 걸어온다.");
            Thread.Sleep(1500);
            Console.WriteLine("그 압도적인 모습에 털이 곤두서는것을 온몸으로 느낀다.");
            Thread.Sleep(1500);           
            Console.WriteLine("검은 늑대는 마치 당장이라도 달려들것 처럼 자세를 고쳐 잡고는 나의 반응을 기다린다.");
            Thread.Sleep(1500);
            Console.WriteLine("마음속에서 뜨거운것이 꿈틀거리지만 이것이 용기인지...두려움인지...");
            Thread.Sleep(1500);
            Console.WriteLine("'어떡하지 엄첨 강해보이는데...이길 수 있을까? 주변에 뭔가 있을까?'");
            Thread.Sleep(1500);            
            Console.WriteLine("주위를 살펴보자 검은 늑대는 자신을 우습게 본것으로 여겼는지 달려드려 한다.");
            Thread.Sleep(1500);
            Console.WriteLine("'으악!!!'");
            Thread.Sleep(1500);

            Console.WriteLine();
            Console.Write("선택지를 입력하세요 : ");
            Console.WriteLine(" 1. 싸운다 2. 도망간다");
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
                    Util.PushKey("맞써 싸움니다.");
                    Game.ChangeScene("GoodEnding");
                    break;

                case ConsoleKey.D2:
                    Util.PushKey("등을 돌려 도망갑니다.");
                    Game.ChangeScene("BadEnding");
                    break;
            }
        }
    }
}