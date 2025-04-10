using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class HospitalScene : BaseScene
    {
        private ConsoleKey input;

        public HospitalScene() 
        {
            name = "Hospital";
        }

        public override void Render()
        {
            Console.WriteLine("1. 복도로 나간다");
            Console.WriteLine("2. 침대 밑을 확인한다");
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
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Corridor");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Room1");
                    break;

            }
        }
    }
}
