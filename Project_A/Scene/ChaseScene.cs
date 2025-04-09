using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;
using Project_A.Items;

namespace Project_A.Scene
{
    public class Chase : Interaction
    {
        public Chase(ConsoleColor color, char symbol, Position position, bool oneOffItems) : base(color, symbol, position, oneOffItems)
        {
        }

        public void ChaseMove(Position playerPos, bool[,] map)
        {
            int dx = playerPos.x - position.x;
            int dy = playerPos.y - position.y;

            int chaseX = 0;
            int chaseY = 0;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                chaseX = Math.Sign(dx);
            }
            else
            {
                chaseY = Math.Sign(dy);
            }

            int newX = position.x + chaseX;
            int newY = position.y + chaseY;

            if (newY >= 0 && newY < map.GetLength(0) && newX >= 0 && newX < map.GetLength(1) && map[newY, newX])
            {
                position.x = newX;
                position.y = newY;
            }

        }

        public override void Interact(Player player)
        {

        }
    }


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
            "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■",
            "■ ■           ■                 ■           ■           ■     ■     ■■",
            "■ ■■■■■ ■■■■■ ■■■■■■ ■■■■■■ ■■■■■ ■■■■■ ■■■■■ ■ ■ ■ ■ ■■■ ■■■■■■■ ■  ■",
            "■ ■       ■       ■   ■       ■     ■   ■ ■   ■ ■   ■     ■     ■   ■■",
            "■ ■■■■■ ■■■■■ ■■■ ■ ■ ■■■■■ ■■■ ■■■■■ ■ ■ ■ ■ ■ ■■■■■■■■■ ■■■■■ ■ ■ ■■",
            "■     ■   ■     ■   ■     ■   ■ ■   ■ ■     ■   ■   ■         ■   ■ ■■",
            "■■■■■ ■■■ ■ ■■■■■■■■■■■ ■■■ ■ ■ ■ ■ ■■■■■■■■■ ■ ■ ■■■■■ ■ ■■■ ■ ■    ■",
            "■   ■ ■     ■       ■     ■ ■ ■   ■ ■ ■       ■   ■ ■ ■   ■ ■ ■     ■■",
            "■ ■ ■ ■■■■■■■ ■■■■■ ■ ■■■■■ ■ ■ ■ ■ ■■■■■ ■ ■■■ ■ ■■■ ■ ■ ■ ■ ■■■■■  ■",
            "■ ■   ■     ■   ■   ■   ■   ■   ■ ■ ■ ■     ■ ■ ■         ■ ■ ■     ■■",
            "■ ■■■■■ ■■■ ■■■ ■ ■■■■■ ■ ■ ■■■ ■■■ ■■■ ■ ■ ■■■■■■■ ■■■■■■■■■■■ ■    ■",
            "■ ■     ■ ■ ■   ■       ■ ■   ■   ■     ■   ■ ■ ■     ■             ■■",
            "■ ■ ■■■■■ ■ ■ ■ ■■■ ■■■ ■■■■■■■ ■■■■■ ■■■■■ ■■■■■■■ ■■■ ■■■■■■■■■    ■",
            "■   ■         ■      ■                    ■   ■         ■            ■",
            "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■",
           };

            map = new bool[15, 70];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '■' ? false : true;
                }
                Console.WriteLine();
            }

            gameObjects = new List<Interaction>();
            gameObjects.Add(new Place("Exit", ConsoleColor.DarkGreen, '?', new Position(62, 13)));
            gameObjects.Add(new Place("Trap", ConsoleColor.DarkGreen, '?', new Position(34, 5)));
            gameObjects.Add(new Place("Trap2", ConsoleColor.DarkGreen, '?', new Position(28, 11)));
            gameObjects.Add(new Place("Trap2", ConsoleColor.DarkGreen, '?', new Position(18, 7)));
            gameObjects.Add(new Place("Trap2", ConsoleColor.DarkGreen, '?', new Position(50, 3)));
            gameObjects.Add(new Chase(ConsoleColor.DarkRed, '●', new Position(12, 6), false));
            gameObjects.Add(new Chase(ConsoleColor.DarkRed, '●', new Position(20, 7), false));
            gameObjects.Add(new Chase(ConsoleColor.DarkRed, '●', new Position(62, 7), false));
            gameObjects.Add(new Chase(ConsoleColor.DarkRed, '●', new Position(64, 8), false));
        }


        public override void Enter()
        {
            if (Game.prevSceneName == "TwoCorridor")
            {
                Game.Player.position = new Position(1, 1);
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
            Game.Player.Action(input);


            foreach (Interaction interaction in gameObjects)
            {
                if (interaction is Chase chaser)
                {
                    chaser.ChaseMove(Game.Player.position, map);

                    if (chaser.position.x == Game.Player.position.x &&
                        chaser.position.y == Game.Player.position.y)
                    {
                        Console.Clear();
                        Util.Print("적에게 사로잡힌다...", ConsoleColor.White, 3000);
                        Console.Clear();
                        Util.Print("칼로 난도질 당하며 최후를 맞이한다...", ConsoleColor.DarkRed, 5000);
                        Console.Clear();
                        Game.GameOver("사망하셨습니다...\n\n사망 : 적을 피해 달아나십시오.");
                        return;
                    }
                }
            }
        }

        public override void Result()
        {
            foreach (Interaction interaction in gameObjects)
            {
                if (Game.Player.position.x == interaction.position.x && Game.Player.position.y == interaction.position.y)
                {
                    if (Game.Player.ExitKey == false)
                    {
                        Util.Print("카드키가 필요합니다", ConsoleColor.Red, 1000);
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