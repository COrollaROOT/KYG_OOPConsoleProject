namespace OOPConsoleProject.Scenes
{
    class Chapter_1_1 : BaseScene
    {


        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("!우!!직!");
            Thread.Sleep(1500);
            Console.WriteLine("불길한 소리가 귀에 들리더니 이내 땅이 꺼지고 시야가 빠르게 변해갔다");
            Thread.Sleep(1500);
            Console.WriteLine("'아..이런..이대로 죽는건가..'\n몸이 마치 중력에 굴복하듯 하염없이 떨어지고 있었다.");
            Thread.Sleep(1500);
            Console.WriteLine("'아냐 정신 차려 이대로 죽을순 없어'");
            Thread.Sleep(1500);
            Console.WriteLine("그 순간 시간이 느리게 흘러가는듯 했다");
            Thread.Sleep(1500);
            Console.WriteLine("그때 눈에 무엇인가 보인다.");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.Write("선택지를 입력하세요 : ");
            Console.WriteLine(" 1. 나무줄기를 잡는다 , 2. 나뭇대를 잡는다");
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
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PushKey("나무줄기를 잡았습니다.");
                    Game.ChangeScene("DiedScene2");
                    break;
                case ConsoleKey.D2:
                    Util.PushKey("나뭇대를 잡았습니다.");
                    Game.ChangeScene("FallTent");
                    break;
            }
        }
    }
}