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
        public Inventory inventory;
        public bool[,] map;

        private int nowHp; // 외부에서 수정 불가
        public int NowHp { get {  return nowHp; } }
        private int maxHp;
        public int MaxHp { get { return maxHp; } } // 읽을순 있게 설정

        public Player()
        {
            inventory = new Inventory();
            maxHp = 100; // 플레이어 체력 설정
            nowHp = maxHp;
        }

        public void Heal(int amount) // 체력 회복시 설정
        {
            nowHp += amount; // 현재 체력을 회복수치까지 올림
            if (nowHp > maxHp) // 만약 넘을시
            {
                nowHp = maxHp; // 넘치게 회복 불가
            }
        }


        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }

        public void Move(ConsoleKey input) // 플레이어 움직임 구현
        {

            Vector0 targetPos = position;

            switch (input) // 입력받는 키로 움직임
            {
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
    }
}
