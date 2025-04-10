using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class BedEnding1Scene : BaseScene
    {
        string[] openBook = new string[]
       {
            "         .--.        ",
            "      .\"     \".     ",
            "    /  ⊙     ‡  \\     ",
            "   /   ●          \\   ",
            "  |    ●           |   ",
            "  |      ___       |    ",
            "  |     (___)      |    ",
            "   \\              /     ",
            "    \\           /      ",
            "     `.       .'        ",
       };


        public override void Render()
        {
            Util.Print("이 병원 간호사의 일기장인 모양이다", ConsoleColor.White, 3000);
            Util.Print("일기장을 천천히 읽어보았다", ConsoleColor.White, 3000);
            Util.Print("\"드디어 오늘 결심한 날이다...\"", ConsoleColor.White, 3000);
            Console.Clear();
            Util.Print("모두에게 복수할 수 있는 날...", ConsoleColor.Red, 5000);
            Console.Clear();
            Util.Print("갑자기 조명이 꺼진다.", ConsoleColor.Red, 3000);
            Util.Print("\"무슨 일이지?\"", ConsoleColor.White, 3000);
            Util.Print("누군가 다가온다", ConsoleColor.White, 2000);
            Util.Print("나는 본능적으로 숨었다", ConsoleColor.White, 7000);
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (string line in openBook)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();

            Util.Print(" ", ConsoleColor.White, 3000);
            Console.Clear();

            Util.Print("으악!!!!!!!!!", ConsoleColor.White, 3000);
            Console.Clear();
            Util.Print("그 상태에서 바로 칼에 찔렸다", ConsoleColor.DarkRed, 5000);
            Console.Clear();
            Util.Print("나는 피를 쏟아내며 서서히 의식을 잃었다...", ConsoleColor.DarkRed, 5000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (string line in openBook)
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
            Game.GameOver("사망하셨습니다...\n\n사망 : 수상한 물건을 조사할 때는 신중히 결정하십시오.");
        }


    }
}
