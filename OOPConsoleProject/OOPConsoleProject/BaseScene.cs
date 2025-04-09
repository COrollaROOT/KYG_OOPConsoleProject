using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public abstract class BaseScene // 씬을 상속 받아 여러 씬 구현할 예정 때문에 추상 클래스로 구현
    {

        public string name;

        public abstract void Render();

        public abstract void Input();

        public abstract void Update();

        public abstract void Result();

        public virtual void Enter() { } // 가상 함수로 사용하여
        public virtual void Exit() { } // 빈공간으로 두어 쓰고 싶을때 쓴다

    }
}
