using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;

namespace Project_A.Items
{
    public class Flashlight : Item // 어둠 속에서 더 잘 볼수 있음 (속도 증가, 아이템 발견 확률 증가) 
    {
        public Flashlight(ConsoleColor color, char symbol, Position position) : base(color, symbol, position)
        {          
            name = "손전등";
            description = "손전등이다.. 어두운 곳에서도 물건을 잘 찾을 수 있을 것이다";
        }

        public override void Use()
        {
            Game.Player.PlayerFlashlight();
        }
    }
}
