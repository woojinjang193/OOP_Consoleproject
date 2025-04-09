using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame.Items
{
    public class Soju : Item
    {
        private Vector2 vector2;

        public Soju(Vector2 position) : base("소주", ConsoleColor.Blue, '♤', position)
        {
        }


        public override void Use()
        {
            Game.Player.Heal(30);
        }
    
    }
}
