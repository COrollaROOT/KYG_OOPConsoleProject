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
            Console.WriteLine("Good Ending");
            Thread.Sleep(3500);
            Console.WriteLine("따스한 햇빛이 나의 눈을 덮는다\n나는 눈을 천천히 뜬다");
            Thread.Sleep(1500);
            Console.WriteLine("눈앞엔 고요하고 드넓은 산림이 펼쳐져 있다.\n바람에 풀잎이 일렁이고\n멀리선 새소리가 아련하게 들린다.");
            Thread.Sleep(1500);
            Console.WriteLine("눈앞엔 시끄러운 소리가 나는 좁은 우리(Cage)가 펼쳐져 있다.\n바람에 피 비린네가 일렁이고\n멀리선 사람들의 소리가 들린다.");
            Thread.Sleep(1500);
            Console.WriteLine("'어이!!!김씨 여기 또 하나 잡혔어!!!!빨리 와'");
            Thread.Sleep(3500);
            Console.WriteLine("'역시 이곳이 핫 스팟 이라니깐 이렇게 희기한 '동물'들은 수요가 있다고'");
            Thread.Sleep(3500);
            Console.WriteLine("'이야! 이놈은 더 비싸게 팔리겠는걸? 이제 슬슬 마무리 하고 가자'");
            Thread.Sleep(3500);
            Console.WriteLine("'그래 잡히다 다친놈들은 안 팔리니깐 그냥 죽여'");
            Thread.Sleep(3500);
            Console.WriteLine("나는 점점 멀어져가는 총소리와 친구들의 비명소리를 뒤로하고 밤 그림자 속으로 들어갔다...");
            Thread.Sleep(3500);
            Console.WriteLine("'엄마 여기봐바 엄청 이쁜 동물이 있어!!'");
            Thread.Sleep(3500);
            Console.WriteLine("그렇게 당신은 우리안의 '갇힌' 야생이 되었습니다");
            Thread.Sleep(3500);

            Console.WriteLine();

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


            Console.Clear();
            Console.WriteLine("게임이 종료되었습니다.");
            Console.WriteLine("플레이 해주셔서 감사합니다.");
            Console.WriteLine("아무 키나 누르면 프로그램이 종료됩니다.");
            Console.ReadKey(true); // 사용자 키 입력 대기
            Environment.Exit(0); // 콘솔 창 종료


        }
    }
}