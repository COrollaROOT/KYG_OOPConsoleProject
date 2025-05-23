﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public abstract class GameObject : IInteractable// 게임 오브젝트 추상 클래스로 구현
    {
        public ConsoleColor color; // 색 표현
        public char symbol; // 특정 심볼 표현
        public Vector0 position; // 위치 설정
        public bool oneOff; // 일회성 아이템 설정
        // 일회성이면 true 아니면 false

        public GameObject(ConsoleColor color, char symbol, Vector0 position, bool oneOff)
        { // 색,심볼,위치를 가져야하는 생성자 생성
            this.color = color;
            this.symbol = symbol;
            this.position = position;
            this.oneOff = oneOff;
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);
        

        
    }
}
