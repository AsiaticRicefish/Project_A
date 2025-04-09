using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;

namespace Project_A.Items
{
    public class Flashlight : Item
    {
        public Flashlight(ConsoleColor color, char symbol, Position position) : base(color, symbol, position)
        {          
            name = "손전등";
            description = "손전등이다.. 어두운 곳에서도 물건을 잘 찾을 수 있을 것이다\n목에 걸 수 있는 스트랩도 포함하는 군";
        }

        public override void Use()
        {
            Game.Player.PlayerFlashlight();
        }
    }
}
