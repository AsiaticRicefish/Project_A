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

        public override void Render()
        {
            Console.WriteLine("복도로 나서자, 조명이 깜빡거립니다...");
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
    }
}
