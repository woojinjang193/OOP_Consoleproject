using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame.NPCs
{
    public abstract class NPC : GameObject
    {
        public string Name { get; set; }
        public NPC(string name, ConsoleColor color, Vector2 position) 
            : base(color, '⚉', position)
        {
            Name = name;
        }

        public override abstract void Interact(Player player);

    //   public void TalkToNPC(ConsoleKey key, Player player)
    //   {
    //       if (key == ConsoleKey.F ) // && 가까이 있는 경우 추가
    //       {
    //           Interact(player);
    //       }
    //   }

        

    }
        
}
