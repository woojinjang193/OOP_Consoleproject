﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame.Scenes
{
    class Map1 : BaseScene
    {
        private ConsoleKey input;

        private string[] mapData;
        private bool[,] map;
        
        public Map1()
        {
            mapData = new string[]
            {
                "###########",
                "#         #",
                "#         #",
                "#         #",
                "#         #",
                "#         #",
                "###########",
            };

            map = new bool[7, 11];
            for(int y = 0; y< map.GetLength(0); y++)  //???
            {
                for(int x= 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }

            Game.Player.position = new Vector2(1, 1);
        }

        public override void Render()
        {
            PrintMap();
            Game.Player.print();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;

        }
        public override void Update()
        {
            Game.Player.Move(input);
        }
        public override void Result()
        {
            
        }

        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)  //???
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y,x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}