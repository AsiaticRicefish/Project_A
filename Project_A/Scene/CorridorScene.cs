using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class CorridorScene : BaseScene
    {
        private ConsoleKey input;
        private string[] mapData;
        private bool[,] map;

        public CorridorScene()
        {
            mapData = new string[]
            {
            "■■■■■■■",
            "■     ■",
            "■     ■",
            "      ■",
            "■      ",
            "■■■■■■■", 
            };

            map = new bool[6, 7];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '■' ? false : true;
                }
                Console.WriteLine();
            }

        }

        public override void Render()
        {
            for (int i = 0; i < 15; i++) // 깜빡거리는 연출 넣기
            {
                Util.Print("복도로 나서자, 조명이 깜빡거린다...", ConsoleColor.White, 100);
                Console.Clear();
            }

            PrintMap();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }      
        public override void Update()
        {

        }
        public override void Result()
        {

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
