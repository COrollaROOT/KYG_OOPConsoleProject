using OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public static class Game // 게임 시
    {
        private static Dictionary<string, BaseScene> sceneDic; // 베이스 씬 여러게 있는 씬 사전
        private static BaseScene nowScene; // 씬 변경되기 때문에 현재씬 구동

        private static bool gameOver; // 게임 오버 (참/거짓)

        public static void Run() // 구동
        {

            Start(); // 시작

            while (gameOver == false) // 게임 오버가 아니면 계속 반복
            {
                
                Console.Clear(); // 전에 있던 콘솔창 지우기
                nowScene.Render();
                Console.WriteLine(); // 줄 바꿈 추가
                nowScene.Input();
                Console.WriteLine();
                nowScene.Update();
                Console.WriteLine();
                nowScene.Result();

            }

            End(); // 종료
        }

        public static void ChangeScene(string sceneName) // 씬을 바꿔주는 기능 구현
        {
            nowScene = sceneDic[sceneName]; // 해당이름 씬으로 넘어가기 위해
        }

        private static void Start() // 게임 초기 설정 작업
        {
            gameOver = false; // 게임시작시 게임오버가 거짓

            Console.CursorVisible = false;
            sceneDic = new Dictionary<string, BaseScene>(); // 씬 설정
            sceneDic.Add("Title", new TitleScene()); // 씬 사전에 "Title" 이라는 씬 추가
            sceneDic.Add("Chapter_1", new Chapter_1());
            sceneDic.Add("Chapter_2", new Chapter_2());



            nowScene = sceneDic["Title"]; // 시작시 타이틀씬으로 시작
        }

        private static void End() // 게임 마무리 설정 작업
        {

        }
    }
}
