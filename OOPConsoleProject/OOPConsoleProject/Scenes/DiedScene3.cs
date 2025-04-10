using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class DiedScene3 : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("'아이고..떨어질때..힘을 꽉줬더니..배가 더 고파졌네'");
            Thread.Sleep(3500);
            Console.WriteLine("마침 나무들 사이에 버섯들이 잔득 피어있다");
            Thread.Sleep(3500);
            Console.WriteLine("'흠 보기엔 평소에 먹던 버섯이랑 같은거 같은데..'");
            Thread.Sleep(3500);
            Console.WriteLine("마치 배에서 어서 달라고 소리치듯 '꼬르륵' 소리가 더욱 크게 들린다");
            Thread.Sleep(3500);
            Console.WriteLine("'어제부터 제대로 된걸 먹은적이 없네 일단 먹자!!'");
            Thread.Sleep(3500);
            Console.WriteLine("그렇게");
            Thread.Sleep(3500);
            Console.WriteLine("그렇게\n한입을");
            Thread.Sleep(3500);
            Console.WriteLine("그렇게\n한입을\n베어 먹었다");
            Thread.Sleep(3500);
            Console.WriteLine("그순가 ㄷ ㅏ시 따에 떨어지and거 같피 저시니 혼MI해다.하염업히 ㅋㅋ ww 우음이 난다.");
            Thread.Sleep(3500);
            Console.WriteLine("온모미 Mushroom에 압도 되듯 마bi 되었고\n이후 ㅍ와 체액기 Mush섯을 P하듴 푸져 나아다!@!");
            Thread.Sleep(3500);
            Console.WriteLine("그렇게 당신은 주위의 버섯들과 이웃이 되었다");
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
            Console.WriteLine("아무 키나 누르면 프로그램이 종료됩니다.");
            Console.ReadKey(true); // 사용자 키 입력 대기
            Environment.Exit(0); // 콘솔 창 종료


        }
    }
}
