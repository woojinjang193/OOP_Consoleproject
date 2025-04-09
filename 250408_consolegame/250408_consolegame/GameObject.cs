using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame
{
    public abstract class GameObject : IInteractable
    {
        public ConsoleColor color;
        public char symbol;
        public Vector2 Position;

        public GameObject(ConsoleColor color, char symbol, Vector2 position)
        {
            this.color = color;
            this.symbol = symbol;
            this.Position = position;
        }

        public void Print()
        {
            Console.SetCursorPosition(Position.x, Position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);
    }
}
