using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class HospitalRoom1Scene : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("침대 밑에서 피투성이 일기장을 발견했습니다.");
            Console.WriteLine("도대체 누구의 일기장이지?");
            Console.WriteLine("1. 일기장을 읽는다");
            Console.WriteLine("2. 일기장을 읽지 않고 복도로 나간다");
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
                    Game.ChangeScene("BadEnding1");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Corridor");
                    break;

            }
        }

       
    }
}
