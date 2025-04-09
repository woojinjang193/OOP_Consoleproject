using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame
{
    public abstract class Item : GameObject
    {
        public string name;
        public int count = 1;

        public Item(string name, ConsoleColor color, char symbol, Vector2 position) 
            : base(ConsoleColor.Yellow, symbol, position)
        {
            this.name = name;
        }

        public override void Interact(Player player)
        {
            player.inventory.Add(this);
        }

        public abstract void Use();
    }
}
