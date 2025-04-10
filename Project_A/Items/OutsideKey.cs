using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;

namespace Project_A.Items
{
    public class OutsideKey : Item
    {
        public OutsideKey(ConsoleColor color, char symbol, Position position) : base(color, symbol, position)
        {
            name = "정문 열쇠";
            description = "정문 열쇠인 것 같다... 이것만 있으면 밖으로 나갈 수 있을 지도?";
        }

        public override void Use()
        {
            Game.Player.PlayerExitKey();
        }

    }
}
