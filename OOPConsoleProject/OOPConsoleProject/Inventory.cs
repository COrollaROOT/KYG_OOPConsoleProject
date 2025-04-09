using OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    // 아이템을 가지고 있을 인벤토리 설정
    public class Inventory
    {
        private List<Item> items;
        private Stack<string> stack; // 스택으로 인벤토리 상호작용 구현
        private int selectIndex; // 어떤 아이템 선택 선언

        public Inventory()
        {
            items = new List<Item>(); // 여러 아이템 보관
            stack = new Stack<string>();
        }

        public void Add(Item item) // 아이템 추가
        {
            items.Add(item);
        }

        public void Remove(Item item) // 아이템 제거
        {
            items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }

        public void UseItem(int index) // 아이템 사용
        {
            items[index].Use();
        }

        public void Open()
        {
            stack.Push("Menu"); // 인벤토리 메뉴 뒤로가기 구현

            while (stack.Count > 0)
            {
                Console.Clear();
                switch (stack.Peek())
                {
                    case "Menu":
                        Menu();
                        break;
                    case "UseMenu":
                        UseMenu();
                        break;
                    case "DropMenu":
                        DropMenu();
                        break;
                    case "UseConfirm":
                        UseConfirm();
                        break;
                    case "DropConfirm":
                        break;
                }
            }
        }

        private void Menu()
        {
            PrintALL();
            Console.WriteLine("1. 사용하기");
            Console.WriteLine("2. 버리기");
            Console.WriteLine("0. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
            }
        }

        private void UseMenu()
        {
            PrintALL();
            Console.WriteLine("사용할 아이템을 선택 해주세요");
            Console.WriteLine("뒤로가기는 0");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1; // int로 형변환
                if (select < 0 || items.Count <= select)
                {
                    Util.PushKey("범위를 벗어난 키입니다");
                }
                else
                {
                    selectIndex = select;
                    stack.Push("UseConfirm");
                }
            }
        }

        private void DropMenu()
        {
            PrintALL();
            Console.WriteLine("버릴 아이템을 선택 해주세요");
            Console.WriteLine("뒤로가기는 0");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
            }
        }

        private void UseConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine($"{selectItem.name} 을/를 사용하시겠습니까? (y/n)");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    selectItem.Use();
                    Util.PushKey($"{selectItem.name} 을/를 사용합니다");
                    Remove(selectItem);
                    stack.Pop();
                    break;

                case ConsoleKey.N:
                    stack.Pop();
                    break;
            }
        }

        public void PrintALL()
        {
            Console.WriteLine("------소유한 아이템------");
            if (items.Count == 0) // 아이템이 없으면
            {
                Console.WriteLine(" 무소유 "); // 없음 으로 출력
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, items[i].name);
            }
            Console.WriteLine("-------------------------");
        }
    }
}
