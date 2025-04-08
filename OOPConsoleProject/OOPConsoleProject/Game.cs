using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public static class Game // 게임 시
    {
        private static Dictionary<string, BaseScene> sceneDic; // 베이스 씬 여러게 있는 씬 사전
        private static BaseScene curScene; // 씬 변경되기 때문에 현재씬 구동

        private static bool gameOver; // 게임 오버 (참/거짓)

        public static void Run() // 구동
        {

            Start(); // 시작

            while (gameOver == false) // 게임 오버가 아니면 계속 반복
            {
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End(); // 종료
        }

        private static void Start() // 게임 초기 설정 작업
        {
            gameOver = false; // 게임시작시 게임오버가 거짓

            sceneDic = new Dictionary<string, BaseScene>(); // 씬 설정

        }

        private static void End() // 게임 마무리 설정 작업
        {

        }
    }
}
