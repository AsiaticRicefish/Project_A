using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class TrapScene : BaseScene
    {
        string[] ghost = new string[]
      {
            "      .-'      '-.",
            "    .'            '.",
            "   /   ‡      ◎     \\",
            "  :    ▒      ▒     :",
            "  |                 |",
            "  :    .------.    :",
            "   \\  ' ___ '     /",
            "    '.          .'",
            "      '-......-'",
            "     //      \\\\",
            "    ||        ||",
            "    ||        ||",
            "    ||        ||",
            "   /_|        |_\\"
      };

        public override void Render()
        {
            Util.Print("나는 조심스럽게 문을 열었다", ConsoleColor.White, 5000);
            Console.Clear();
            Util.Print("눈 앞의 광경을 보고 나는 믿을 수 없었다", ConsoleColor.White, 3000);
            Console.Clear();
            Util.Print("저거 내 시체인데?", ConsoleColor.DarkRed, 2000);
            Console.Clear();
            Util.Print("그럼 나는 누구지?", ConsoleColor.DarkRed, 5000);
            Console.Clear();
            Util.Print("방 안에 있는 거울을 보았다", ConsoleColor.White, 5000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (string line in ghost)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();

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
            Game.GameOver("게임을 클리어 하셨습니다...\n\n엔딩2 : 믿을 수 없는 진실");
        }

      
    }
}
