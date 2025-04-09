using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public abstract class Interaction : IInteractable
    {
        public ConsoleColor color; 
        public char symbol; 
        public Position position;
        public bool oneOffItems;

        public Interaction(ConsoleColor color, char symbol, Position position, bool oneOffItems)
        {
            this.color = color;
            this.symbol = symbol;
            this.position = position;
            this.oneOffItems = oneOffItems;
        }

        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);

    }
}
