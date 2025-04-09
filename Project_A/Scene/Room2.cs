using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;
using Project_A.Items;

namespace Project_A.Scene
{
    public class Room2 : BaseScene
    {

        private ConsoleKey input;
        private string[] mapData;
        private bool[,] map;

        private List<Interaction> gameObjects;


        public Room2()
        {

            name = "Room2";

            mapData = new string[]
           {
            "■■■■■■■■■■■■",
            "■          ■",
            "■   ■    ■■■",
            "■   ■      ■",
            "■■■■■■■■■■■■",
           };

            map = new bool[5, 12];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '■' ? false : true;
                }
                Console.WriteLine();
            }

            gameObjects = new List<Interaction>();
            gameObjects.Add(new Place("TwoCorridor", ConsoleColor.DarkGreen, '→', new Position(9, 3)));
            gameObjects.Add(new OutsideKey(ConsoleColor.Magenta, '★', new Position(1, 1)));

        }

        public override void Enter()
        {
            if (Game.prevSceneName == "TwoCorridor")
            {
                Game.Player.position = new Position(9, 3);
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

            Console.SetCursorPosition(0, map.GetLength(0) + 2);
            Game.Player.Inventory.PrintAll();
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }


        public override void Update()
        {
            Game.Player.Move(input);
            Game.Player.Action(input);
        }

        public override void Result()
        {
            foreach (Interaction interaction in gameObjects)
            {
                if (Game.Player.position.x == interaction.position.x && Game.Player.position.y == interaction.position.y)
                {
                    interaction.Interact(Game.Player);
                    if (interaction.oneOffItems == true)
                    {
                        gameObjects.Remove(interaction);
                    }
                    break;
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
