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
            Console.WriteLine("************************************");
            Console.WriteLine("*           병원 탈출하기          *");
            Console.WriteLine("************************************");
            Console.WriteLine("");
            Console.WriteLine("1. 게임시작");
            Console.Write("2. 게임종료");

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
