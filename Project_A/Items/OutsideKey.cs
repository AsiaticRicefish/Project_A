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
            name = "카드키";
            description = "카드 형식의 마스터키이다... 여러 방을 돌아다닐 수 있을 것이다";
        }

        public override void Use()
        {
            Game.Player.PlayerExitKey();
        }

    }
}
