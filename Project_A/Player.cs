using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Player
    {
      
        public Position position;
        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }
        public bool[,] map;


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

        public void Move(ConsoleKey input) 
        {
            Position targetPos = position; 

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

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
    }
}

