using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;
using Project_A.Items;

namespace Project_A.Scene
{
    public class CorridorScene : BaseScene
    {
        private ConsoleKey input;
        private string[] mapData;
        private bool[,] map;

        private List<Interaction> gameObjects;

        public CorridorScene()
        {
            name = "Corridor";

            mapData = new string[]
            {
            "■■■■■■■■■■■■",
            "■          ■",
            "■          ■",
            "■       ■■■■",
            "■          ■",
            "■■■■■■■■■■■■",
            };

            map = new bool[6, 12];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '■' ? false : true;
                }
                Console.WriteLine();
            }

            gameObjects = new List<Interaction>();
            gameObjects.Add(new Place("Hospital", ConsoleColor.DarkBlue, '←', new Position(1, 3)));
            gameObjects.Add(new Place("TwoCorridor", ConsoleColor.DarkGreen, '→', new Position(9, 4)));
            gameObjects.Add(new Flashlight(ConsoleColor.Magenta, '★', new Position(7, 4)));



        }

        public override void Enter()
        {
            if (Game.prevSceneName == "Room1" || Game.prevSceneName == "Hospital")
            {
                Game.Player.position = new Position(1, 3);
            }
            else if (Game.prevSceneName == "TwoCorridor")
            {
                Game.Player.position = new Position(9, 4);
            }
            Game.Player.map = map;
        }

        public override void Render()
        {
            PrintMap();

            foreach (Interaction interaction in gameObjects) // 모든 게임 오브젝트 맵에 그리기
            {
                interaction.Print();
            }

            Game.Player.Print();  // 플레이어 출력


            Console.SetCursorPosition(0, map.GetLength(0) + 2);
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
            Console.SetCursorPosition(0, 0); // 처음으로 위치시킴

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
