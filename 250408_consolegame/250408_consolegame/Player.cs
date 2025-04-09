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
        public Inventory inventory;
        public bool[,] map;
        private Vector2 prevPosition; //나중에 확인

        private int curHP;
        public int CurHP { get { return curHP; } }
        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        public Player()
        {
            inventory = new Inventory();
            maxHP = 100;
            curHP = maxHP;
        }

        public void Heal(int amount)
        {
            curHP += amount;
            if(curHP > maxHP)
            {
                curHP = maxHP;
            }
        }

        public void print()///?????
        {
            //플레이어 있던자리 공백으로 덮기
            Console.SetCursorPosition(prevPosition.x, prevPosition.y);
            Console.Write(' ');

            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('⚉');
            Console.ResetColor();

            prevPosition = position;
        }


        public void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    targetPos.y--;

                    break;

                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    targetPos.y++;

                    break;

                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    targetPos.x--;

                    break;

                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    targetPos.x++;

                    break;

            }
                if (map[targetPos.y, targetPos.x] == true)
                {
                    position = targetPos;
                }
            }
        }
    }

