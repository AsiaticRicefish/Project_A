using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.GameObjects
{
    public abstract class Item : Interaction
    {

        public string name;
        public string description;

        public Item(ConsoleColor color, char symbol, Position position) : base(color, symbol, position, true)
        {

        }

        public override void Interact(Player player)
        {
            player.inventory.AddItem(this);
        }

        public abstract void Use();
    }
}
