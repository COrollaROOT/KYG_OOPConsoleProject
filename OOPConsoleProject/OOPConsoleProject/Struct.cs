using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public struct Vector0 // x 와 y 의 위치를 가지고 있는 위치 자료형 설정
    {
        public int x; public int y;

        public Vector0(int x, int y)
        {
            this.x = x; this.y = y;
        }

        // 연산자 재정의
        // 연산자들 +, -, *, / 에서부터 ++, --, [], <, > ==, =등
        // 다양한 연산자들을 우리가 재정의해서 사용할 수 있게 해주는 방법
        public static bool operator ==(Vector0 left, Vector0 right)
        {
            return left.x == right.x && left.y == right.y;
        }

        public static bool operator !=(Vector0 left, Vector0 right)
        {
            return left.x != right.x || left.y != right.y;
        }

    }
}
