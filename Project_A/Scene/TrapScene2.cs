using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class TrapScene2 : BaseScene
    {
        public override void Render()
        {
            Util.Print("나는 조심스럽게 문을 열었다", ConsoleColor.White, 5000);
            Console.Clear();
            Util.Print("안에는 아무것도 없는 듯하다..", ConsoleColor.White, 3000);
            Console.Clear();
            Util.Print("갑자기 문이 닫힌다!", ConsoleColor.DarkRed, 2000);
            Console.Clear();
            Util.Print("뭐야?", ConsoleColor.White, 3000);
            Console.Clear();
            Util.Print("방 안에서 의문의 가스가 세어나오더니 방 전체를 감싼다.", ConsoleColor.DarkRed, 3000);
            Console.Clear();
            Util.Print("나는 아무것도 할 수 없이 의식을 잃고 말았다", ConsoleColor.DarkRed, 3000);
            Console.Clear();
        }

        public override void Input()
        {

        }      

        public override void Update()
        {

        }

        public override void Result()
        {
            Game.GameOver("사망하셨습니다...\n\n사망 : GAS! GAS! GAS!");
        }
    }
}
