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
            Thread.Sleep(1500);
            Console.WriteLine("Bad Ending");
            Thread.Sleep(1500);
            Console.WriteLine();            
            Console.WriteLine("차가운 달빛이 나의 눈을 덮는다\n나는 눈을 천천히 뜬다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("철컹!!??\n이상한 소리가 들려왔다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("그러곤 들어본 시끄러운 총소리와 함께 내 몸뚱이에 바늘이 날아와 꽂힌다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("서서히 몽롱해지는 정신을 애써 차리면서 주의를 둘러본다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("눈앞엔 좁은 우리(Cage)가 펼쳐져 있다.\n바람에 피 비린네가 일렁이고\n멀리선 사람들의 소리가 들린다.");
            Thread.Sleep(1500);
            Console.WriteLine();            
            Console.WriteLine("남1 : '어이!!!김씨 여기 또 하나 잡혔어!!!!빨리 와'");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("남2 : '역시 이곳이 핫 스팟 이라니깐 이렇게 희귀한 '동물'들은 수요가 있다고'");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("남3 : '이야! 이놈은 더 비싸게 팔리겠는걸? 이제 슬슬 마무리 하고 가자.이러다 우리가 잡혀갈라 ㅋㅋ'");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("남4 : '그래 잡히다 다친놈들은 안 팔리니깐 그냥 죽여.'");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("나는 희미해지는 정신으로 점점 멀어져가는 총소리와 친구들의 비명소리를 뒤로하고 어두운 그림자 속으로 들어갔다...");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("'엄마 여기봐바 엄청 이쁜 동물이 있어!!'");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("그렇게 당신은 '우리'안의 야생이 되었습니다.");
            Thread.Sleep(1500);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("게임이 종료되었습니다.");
            Console.WriteLine("플레이 해주셔서 감사합니다.");
            Console.WriteLine("아무 키나 두번 누르면 프로그램이 종료됩니다.");
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


            
            
            Console.ReadKey(true); // 사용자 키 입력 대기
            Environment.Exit(0); // 콘솔 창 종료


        }
    }
}