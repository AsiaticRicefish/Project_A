using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Player // 게임 플레이어에 관한 설정
    {
        // 이동 기능
        public Position position;
        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }
        public bool[,] map;  // 플레이어가 맵을 뚫고 지나가는 부분을 처리


        private bool flashLight;
        public bool Flashlight { get { return flashLight; } set { flashLight = value; } }


        private bool exitKey;
        public bool ExitKey { get { return exitKey; } set { exitKey = value; } }


        public Player()
        {
            inventory = new Inventory();
           
            exitKey = false;
        }

        public void PlayerFlashlight()
        {
            flashLight = true;  
        }

        public void PlayerExitKey()
        {
            exitKey = true;
        }
       


        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine('P');
            Console.ResetColor();
        }


        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:

                case ConsoleKey.S:
                case ConsoleKey.DownArrow:

                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:

                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    Move(input);
                    break;
                case ConsoleKey.I:
                    inventory.Open();
                    break;
            }
        }

        public void Move(ConsoleKey input) // 캐릭터 움직임 구현
        {
            Position targetPos = position; // 플레이어 이동하고자 하는 위치

            switch (input)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true) // 뚫려있는 경우 움직이도록
            {
                position = targetPos;
            }
        }
    }
}

