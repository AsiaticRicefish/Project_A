using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;
using Project_A.Scene;

namespace Project_A
{
    public class Inventory
    {
        private List<Item> items;
        private Stack<string> stack;
        private int selectIndex;


        public Inventory()
        {
            items = new List<Item>();
            stack = new Stack<string>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public void RemoveAtItem(int index)
        {
            items.RemoveAt(index);
        }

        public void UseItem(int index)
        {
            items[index].Use();
        }

        public void Open()
        {
            stack.Push("Menu");

            while (stack.Count > 0) 
            {
                Console.Clear();
                switch (stack.Peek()) 
                {
                    case "Menu":
                        Menu();
                        break;
                    case "UseMenu":
                        UseMenu();
                        break;
                    case "UseConfirm":
                        UseConfirm();
                        break;
                }
            }
        }

        private void Menu()
        {
            PrintAll();
            Console.WriteLine("1. 사용하기");
            Console.WriteLine("2. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.Escape:
                    stack.Pop();
                    break;
            }
        }

        private void UseMenu()
        {
            PrintAll();
            Console.WriteLine("사용할 아이템을 선택하세요");
            Console.WriteLine("ESC을 눌러 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Escape)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Util.PressAnyKey("범위 내의 아이템을 선택하세요.");
                }
                else
                {
                    selectIndex = select;
                    stack.Push("UseConfirm");
                }
            }
        }


        private void UseConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine("{0}을/를 사용하시겠습니까? (Y/N)", selectItem.name);

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    selectItem.Use();
                    Util.PressAnyKey($"{selectItem.name}을/를 목에 겁니다");
                    RemoveItem(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    stack.Pop();
                    break;
            }
        }


        public void PrintAll()
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("● 현재 가지고 있는 아이템");
            if (items.Count == 0)
            {
                Console.WriteLine(" Empty");
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].name}\n{items[i].description}");
            }
            Console.WriteLine("***************************************************************");
        }
    }
}
