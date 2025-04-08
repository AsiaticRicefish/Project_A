﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;

namespace Project_A.Scene
{
    public class TwoCorridorScene : BaseScene
    {
        private ConsoleKey input;
        private string[] mapData;
        private bool[,] map;

        private List<Interaction> gameObjects;


        public TwoCorridorScene()
        {

            name = "TwoCorridor";

            mapData = new string[]
           {
            "■■■■■■■■■■■■",
            "■          ■",
            "■■■■■  ■■■■■",
            "■          ■",
            "■          ■ ",
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
            gameObjects.Add(new Place("Hospital", ConsoleColor.DarkBlue, '②', new Position(1, 1)));
            gameObjects.Add(new Place("Corridor", ConsoleColor.DarkGreen, 'ⓤ', new Position(9, 4)));
        
        }

        public override void Enter()
        {
            if (Game.prevSceneName == "Corridor")
            {
                Game.Player.position = new Position(9, 4);
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
            Game.PrintInfo();

            Console.SetCursorPosition(0, map.GetLength(0) + 8);
            Game.Player.inventory.PrintAll();
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            Game.Player.Move(input);
        }
        public override void Result()
        {
            foreach (Interaction interaction in gameObjects)
            {
                if (Game.Player.position.x == interaction.position.x && Game.Player.position.y == interaction.position.y)
                {
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
