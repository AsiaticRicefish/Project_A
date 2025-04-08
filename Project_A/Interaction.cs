using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public abstract class Interaction : IInteractable// 맵의 아이템이나 이동 부분의 상호작용 구현
    {
        public ConsoleColor color; // 상호작용 부분 표현 색
        public char symbol; // 상호작용 부분 표현 글자
        public Position position;
        public bool oneOffItems; // 일회성 소모형 아이템

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
