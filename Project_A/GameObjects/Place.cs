using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.GameObjects
{
    public class Place : Interaction  // 맵에서 장소 상호작용 구현 (그 장소로 들어갈 수 있도록)
    {
        private string scenes;

        public Place(string scenes, ConsoleColor color, char symbol, Position position) : base(color, symbol, position, false)
        {
            this.scenes = scenes;
        }
        public override void Interact(Player player)
        {
           Game.ChangeScene(this.scenes);
        }
    }
}
