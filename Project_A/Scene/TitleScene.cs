using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class TitleScene : BaseScene
    {
        private static bool gameEnd;
        private ConsoleKey input;

        public override void Render()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
■■    ■■ ■■■    ■■ ■■■■■■  ■■■■■■  ■■      ■■ ■■■■■■■ ■■      ■■  ■■■    ■■■■■■   ■■      ■■■■■■
■■    ■■ ■■■■   ■■ ■■   ■■ ■■      ■■      ■■ ■■       ■■    ■■  ■  ■    ■■   ■■  ■■      ■■
■■    ■■ ■■ ■■  ■■ ■■ ■■■■ ■■■■    ■■      ■■ ■■■■■     ■■  ■■  ■    ■   ■■ ■■■■  ■■      ■■■■
■■    ■■ ■■  ■■ ■■ ■■   ■■ ■■      ■■      ■■ ■■         ■  ■  ■■■■■■■■  ■■   ■■  ■■      ■■
 ■■■■■■  ■■   ■■■■ ■■■■■■  ■■■■■■  ■■■■■■■ ■■ ■■■■■■■     ■■  ■■      ■■ ■■■■■■■  ■■■■■■■ ■■■■■■
");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                     낯선 방에서 눈을 떴다. 이곳은 병원인가, 지옥인가...\n");
            Console.WriteLine("                                 [1번  눌러서 시작하기]");
            Console.WriteLine("                                 [2번  눌러서 종료하기]");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {

        }

        public override void Result()
        {
           
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Hospital");
                    break;
                case ConsoleKey.D2:
                    gameEnd = true;
                    break;
            }

            if (gameEnd)
            {
                Console.Clear();
                Console.WriteLine("게임을 종료합니다.");
                Environment.Exit(0);
            }

        }

     
    }
}
