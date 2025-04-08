using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class BedEnding1Scene : BaseScene
    {
  

        public override void Render()
        {
            Util.Print("이 병원 간호사의 일기장인 모양이다", ConsoleColor.White, 3000);
            Util.Print("일기장을 천천히 읽어보았다", ConsoleColor.White, 3000);
            Util.Print("다들 나를 못잡아먹어서 안달이야...", ConsoleColor.White, 3000);
            Console.Clear();
            Util.Print("모두 다 죽었으면 좋겠다", ConsoleColor.Red, 5000);
            Console.Clear();
            Util.Print("갑자기 조명이 꺼진다.", ConsoleColor.Red, 3000);
            Util.Print("\"무슨 일이지?\"", ConsoleColor.White, 3000);
            Util.Print("누군가 다가온다", ConsoleColor.White, 5000);
            Util.Print("나는 본능적으로 숨었지만 갑자기 배가 뜨겁다...", ConsoleColor.DarkRed, 2000);
            Util.Print("다시보니 칼에 찔려있었고 피를 쏟아내며 서서히 의식을 잃었다...", ConsoleColor.DarkRed, 2000);

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
            Game.GameOver("수상한 물건을 조사할 때는 신중히 결정하십시오.");
        }

     
    }
}
