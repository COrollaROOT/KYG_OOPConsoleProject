using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Player // 플레이어는 포지션을 갖고 있는다
    {
        public Vector0 position;

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }

        public void Move(ConsoleKey input) // 플레이어 움직임 구현
        {
            switch (input) // 입력받는 키로 움직임
            {
                case ConsoleKey.UpArrow:
                    position.y--;
                    break;
                case ConsoleKey.DownArrow:
                    position.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    position.x--;
                    break;
                case ConsoleKey.RightArrow:
                    position.x++;
                    break;
            }
        }
    }
}
