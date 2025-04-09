using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;

namespace Project_A.Scene
{
    public class ExitScene : BaseScene
    {
        public override void Render()
        {
            Util.Print("나는 조심스럽게 문을 열었다", ConsoleColor.White, 5000);
            Console.Clear();
            Util.Print("출입문이 보인다!", ConsoleColor.White, 3000);
            Console.Clear();
            Util.Print("여기서 대체 무슨 일이 있었던 걸까?", ConsoleColor.White, 5000);
            Console.Clear();
            Util.Print("나는 왜 여기서 깨어났던 것일까?", ConsoleColor.DarkRed, 5000);
            Console.Clear();

            Console.Write("계속하려면 아무키나 누르십시오.");
        }

        public override void Input()
        {
            Console.ReadKey(true);
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            Game.GameOver("축하합니다! 탈출에 성공하셨습니다!\n\n엔딩1 : 탈출???");
        }


    }
}
