using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TitleScene : BaseScene // 추상클래스를 상속받는 클래스 구현
    {
        public override void Render() // 씬 그리기 처리
        {
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("▒§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§▒");
            Console.WriteLine("▒♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣▒");
            Console.WriteLine("▒▒▒♣♣♣♣※※  Wild Jungle  ※※♣♣♣♣▒▒▒");
            Console.WriteLine("▒▒▒♣♣♣♣※※    Survive    ※※♣♣♣♣▒▒▒");
            Console.WriteLine("▒♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣♣▒");
            Console.WriteLine("▒§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§▒");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine();
            Console.WriteLine("정글 속으로 들어가시려면\n아무키나 누르시오...");
        }

        public override void Input() // 입력 처리
        {
            Console.ReadKey();
        }

        public override void Update() // 업데이트 처리
        {
            
        }

        public override void Result() // 결과 처리
        {
            
        }
    }
}
