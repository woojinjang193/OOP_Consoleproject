using _250408_consolegame.Items;
using System;
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

        private List<GameObject> gameObjects;

        
        public Map1()
        {
            mapData = new string[]
            {
                "#########   #########",
                "#                   #",
                "#                   #",
                "                     ",
                "#                   #",
                "#                   #",
                "#########   #########",
            };

        //  int height = mapData.Length;
        //  int width = mapData[0].Length; ///???

            map = new bool[7, 21];
            for(int y = 0; y< 7; y++)  //???
            {
                for(int x= 0; x < 21; x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Soju(new Vector2(3, 3)));
            gameObjects.Add(new Soju(new Vector2(12, 5)));
            gameObjects.Add(new Soju(new Vector2(7, 1)));

            Game.Player.position = new Vector2(10, 5);
            Game.Player.map = map;
        }

        public override void Render()
        {
            PrintMap();
            Game.Player.print();
            foreach(GameObject go in gameObjects)
            {
                go.Print();
            }

            Console.SetCursorPosition(0, map.GetLength(0) + 2);
            Game.Player.inventory.PrintAll();
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
            //맵 이동
            if (Game.Player.position.x == 0)
            {
                Game.ChangeScene(SceneType.Map2);
                Game.Player.position = new Vector2(19, 3);
                Console.Clear();
            }

            if (Game.Player.position.x == 21)
            {
                Game.ChangeScene(SceneType.Map3);
                Console.Clear();
            }

            if (Game.Player.position.y == 6)
            {
                Game.ChangeScene(SceneType.Boss);
                Console.Clear();
            }

            for (int i = 0; i < gameObjects.Count; i++)
            {
                if (Game.Player.position == gameObjects[i].Position)
                {
                    gameObjects[i].Interact(Game.Player);
                    gameObjects.RemoveAt(i);
                    break; 
                }
            }

            Console.SetCursorPosition(0, map.GetLength(0) + 2);
            Game.Player.inventory.PrintAll();
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
