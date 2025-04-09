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
            Console.WriteLine("!!꽈악!!");
            Thread.Sleep(3500);
            Console.WriteLine("'나이스!!! 잡았다!!!'");
            Thread.Sleep(3500);
            Console.WriteLine("가까스로 잡은 나무줄기 하지만 속도는 줄지 않는다");
            Thread.Sleep(3500);
            Console.WriteLine("줄지 않는 속도...그와 상호작용하듯...점점...타 들어갈듯 뜨워지는 손...");
            Thread.Sleep(3500);
            Console.WriteLine("'앗 뜨거'\n그 순간 잡고 있던 손을 무심코 놔버렸다.\n'....아....'");
            Thread.Sleep(3500);
            Console.WriteLine("당신은 땅에 떨어져 곤죽이 되었습니다");
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