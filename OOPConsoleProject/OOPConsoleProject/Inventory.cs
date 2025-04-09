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

        public Inventory()
        {
            items = new List<Item>(); // 여러 아이템 보관
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
