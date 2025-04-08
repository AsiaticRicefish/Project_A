using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_A.GameObjects;

namespace Project_A
{
    public class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
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

        public void PrintAll()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("현재 가지고 있는 아이템");
            if (items.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].name}");
            }
            Console.WriteLine("*****************************");
        }
    }
}
