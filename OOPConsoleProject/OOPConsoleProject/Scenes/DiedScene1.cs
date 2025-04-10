using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class DiedScene1 : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Thread.Sleep(1500);
            Console.WriteLine("꼬르륵...");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("배가 고파...그때 나가서 먹을걸 구해올걸...");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("엄마...아빠...흑...ㅡㅎ,");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("이대로... 나는... 짐승들의 밥이...ㄷ..ㅚ..게..ㅈ");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine("당신은 굶어 죽었습니다");
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
