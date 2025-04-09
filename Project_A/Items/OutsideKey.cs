using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;

namespace Project_A.Items
{
    public class OutsideKey : Item
    {
        public OutsideKey(ConsoleColor color, char symbol, Position position) : base(color, symbol, position)
        {
            name = "정문열쇠";
            description = "열쇠를 통해 정문으로 나갈 수 있을 수 있을 것이다.";
        }

        public override void Use()
        {
           
        }
    }
}
