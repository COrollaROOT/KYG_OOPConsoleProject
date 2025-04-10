using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class BadEnding : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("'내가 저런놈을 어떻게 이겨 도망치자!!!!'");
            Thread.Sleep(3500);
            Console.WriteLine("-나는 뒤로 돌아 전속력으로 달리기 시작했다...-");
            Thread.Sleep(3500);
            Console.WriteLine("-나는 등뒤로 땀이 비오듯이 흐르는걸 느끼며 뛰는것에만 집중했다-");
            Thread.Sleep(3500);
            Console.WriteLine("-나는 팔에 흘러내리는 땀을 닦았다-");
            Thread.Sleep(3500);
            Console.WriteLine("-나는 다리의 감각이 없어 질정도로 뛰었다-");
            Thread.Sleep(3500);
            Console.WriteLine("나는...");
            Thread.Sleep(3500);
            Console.WriteLine("그렇게 생각했다.");
            Thread.Sleep(3500);
            Console.WriteLine("등을 돌아 뛰려는 순간...");
            Thread.Sleep(3500);
            Console.WriteLine("이미 검은 늑대는 나의 등을 칼날같은 손톱으로 공격하였고");
            Thread.Sleep(3500);
            Console.WriteLine("나의 목을 물어 한번에 부러트렸다.");
            Thread.Sleep(3500);
            Console.WriteLine("나의 다리는 이미 떨어져 나가 있었다.");
            Thread.Sleep(3500);
            Console.WriteLine("나는 축처진 머리로 그렇게 나의 다리였던것을\n아득해지는 정신으로 보면서 서서히 동굴 깊은곳으로 사라져 갔다.");
            Thread.Sleep(3500);
            Console.WriteLine("그렇게 당신은 우리의'야생'에 먹이 되었습니다.");
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
    

