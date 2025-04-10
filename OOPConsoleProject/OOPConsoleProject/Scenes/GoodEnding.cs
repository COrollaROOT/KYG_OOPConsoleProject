using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class GoodEnding : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Thread.Sleep(1500);
            Console.WriteLine("'그래 정신만 차리면 살수있어'");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("이내 정신을 다잡고 공격할 태새를 잡았다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("검은 늑대가 날카로운 손톱이 덮쳐든다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("미쳐 피할새도 없이 빠른 공격이였다.손톱은 나의 다리를 크게 훍고 지나갔다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("아픔이 느껴졌지만 아픔을 느낄 겨를이 없었다. 늑대는 다음 공격을 준비하고 있었다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("곧 날카로운 이빨이 나의 목을 덮쳐 왔지만 간신히 피해 목덜미는 내어주지 않았다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("이내 목덜미를 빗나간 이빨은 나의 어깨에 박혔다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("그 찰나의 순간 상대가 놓친 기회는 나의 기회가 되었다");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("공격을 위해 가까이 온 늑대의 목덜미를 이번엔 나의 무기로....");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("한번에 공격으로 치명상을 주었다.그렇게 간신히 늑대를 제압하였다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("그리고 다치고 지친 몸을 끌며 동굴을 나갔다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("따스한 햇빛이 나의 눈을 덮는다\n나는 눈을 천천히 뜬다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("눈앞엔 뜨겁고 드넓은 야생이 펼쳐져 있다.\n바람에 마음이 일렁이고\n멀리선 활기찬 야생의 소리가 들린다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("살아남았다.그리고 또 그렇게 살아 나아가야 한다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("그렇게 당신은 '우리의 야생'에 일원이 되었습니다.");
            Thread.Sleep(1500);

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
    

