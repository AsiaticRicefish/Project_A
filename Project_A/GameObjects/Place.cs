using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.GameObjects
{
    public class Place : Interaction
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
