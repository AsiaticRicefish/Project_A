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

        public int maxSpeed;
        public int maxView;

        private int speed;
        public int Speed { get { return speed; } set { speed = value; } }

        private int view;
        public int View { get { return view; } set { view = value; } }

        public Player()
        {
            inventory = new Inventory();
            maxSpeed = 100;
            maxView = 100;
            speed = 10;
            view = 10;
        }

        public void PlayerSpeed(int amount)
        {
            speed += amount;
            if (speed > maxSpeed)
            {
                speed = maxSpeed;
            }
        }

        public void PlayerView(int amount)
        {
            view += amount;
            if (view > maxView)
            {
                view = maxView;
            }
        }


        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine('⊙');
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

