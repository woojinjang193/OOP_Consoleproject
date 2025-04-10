using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame
{
    
    public class Inventory
    {
        private Dictionary<string, Item> items;

        public Inventory()
        {
            items = new Dictionary<string, Item>();
        }
        

        public void Add(Item item)
        {
            string key = item.name;
            if (items.ContainsKey(key))
            {
                items[key].count++;
            }
            else
            {
                items[key] = item;
            }
        }

        public void Remove(Item item)
        {
            string key = item.name;
            if(items.ContainsKey(key))
            {
                items[key].count--;
                if (items[key].count <= 0)
                    items.Remove(key);
            }
        }

        public bool DoYouHaveThreeSojus()
        {
            if (items.ContainsKey("소주"))
            {
                if (items["소주"].count ==3)
                {
                    return true;
                    
                }
            }
            return false;
        }

        public void PrintAll()
        {
            Console.WriteLine("===아이템 목록===");
            foreach(var entry in items)
            {
                Console.WriteLine($"{entry.Key} x {entry.Value.count}");
            }
            Console.WriteLine();
           // Console.WriteLine("==================");
        }
    }

}
