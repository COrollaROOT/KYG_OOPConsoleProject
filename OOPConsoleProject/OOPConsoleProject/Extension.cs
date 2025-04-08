using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public static class Extension
    {
        // 콘솔 추가 기능을 구현하기위해 확장 메서드 추가
    }
    public static class Util
    {


        public static void PushKey(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("계속하시려면\n한번 더 키를 입력해 주세요.");
            Console.ReadKey(true);
        }
    }
}