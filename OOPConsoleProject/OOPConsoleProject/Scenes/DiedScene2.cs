using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class DiedScene2 : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Thread.Sleep(1500);
            Console.WriteLine("!!꽈악!!");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("'나이스!!! 잡았다!!!'");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("가까스로 잡은 나무줄기 하지만 속도는 줄지 않는다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("줄지 않는 속도...그와 상호작용하듯...팽팽해지는 나무줄기...");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("그순간 '쩌저쩍' 요란한 소리를 내며 나무줄기는 끊어 졌다.\n'....아....'");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("당신은 땅에 떨어져 곤죽이 되었습니다.");
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