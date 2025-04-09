using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;
using Project_A.Items;

namespace Project_A.Scene
{
    public class ChaseScene : BaseScene
    {
        private ConsoleKey input;
        private string[] mapData;
        private bool[,] map;

        private List<Interaction> gameObjects;

        public ChaseScene()
        {

            name = "Chase";

            mapData = new string[]
           {
            "■■■■■■■■■■■■■■■■■■■■",
            "■  ■       ■       ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■  ■   ■   ■   ■   ■",
            "■      ■       ■   ■",
            "■■■■■■■■■■■■■■■■■■■■",
           };

            map = new bool[15, 20];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '■' ? false : true;
                }
                Console.WriteLine();
            }

            gameObjects = new List<Interaction>();
            gameObjects.Add(new Place("TwoCorridor", ConsoleColor.DarkBlue, ' ', new Position(1, 5)));
            gameObjects.Add(new Place("Exit", ConsoleColor.DarkGreen, '↓', new Position(17, 13)));
        }



        public override void Enter()
        {
            if (Game.prevSceneName == "TwoCorridor")
            {
                Game.Player.position = new Position(1, 5);
            }
           
            Game.Player.map = map;
        }

        public override void Render()
        {
            PrintMap();

            foreach (Interaction interaction in gameObjects)
            {
                interaction.Print();
            }

            Game.Player.Print();

            Console.SetCursorPosition(0, map.GetLength(0) + 7);
            Game.Player.Inventory.PrintAll();
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            Game.Player.Action(input);
        }
        public override void Result()
        {
            foreach (Interaction interaction in gameObjects)
            {
                if (Game.Player.position.x == interaction.position.x && Game.Player.position.y == interaction.position.y)
                {
                    if (Game.Player.ExitKey == false)
                    {
                        Util.Print("열쇠가 필요합니다", ConsoleColor.Red, 1000);
                        return;
                    }
                    interaction.Interact(Game.Player);
                }
            }
        }
        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('■');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}