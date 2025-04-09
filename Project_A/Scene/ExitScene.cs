using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{

    public class ExitScene : BaseScene
    {
        public override void Render()
        {
            Util.Print("나는 죽을 힘들 다해 도망쳤다", ConsoleColor.White, 5000);
            Console.Clear();
            Util.Print("괴물은 더 이상 따라오지 않았다", ConsoleColor.White, 5000);
            Console.Clear();
            Util.Print("여기서 대체 무슨 일이 있었던 걸까?", ConsoleColor.White, 5000);
            Console.Clear();
            Util.Print("나는 왜 여기서 깨어났던 것일까?", ConsoleColor.White, 5000);
            Console.Clear();
            Util.Print("의문이 가시질 않았고 여기저기 거리를 돌아다니며 방황했다..", ConsoleColor.White, 5000);

            Console.WriteLine();
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
            Game.GameOver("축하합니다! 탈출에 성공하셨습니다!\n\n엔딩1 : 알수 없는 탈출");
        }

      
    }
}
