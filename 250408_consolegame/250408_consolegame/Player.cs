using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _250408_consolegame
{
    public class Player
    {
        public Vector2 position;

        public void print() 
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }


        public void Move(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    position.y--;

                    break;

                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    position.y++;

                    break;

                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    position.x--;

                    break;

                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    position.x++;

                    break;

            }
        }
    }
}
