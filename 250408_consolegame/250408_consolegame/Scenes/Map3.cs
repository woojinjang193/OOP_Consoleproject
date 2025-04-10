using _250408_consolegame.Items;
using _250408_consolegame.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame.Scenes
{
    class Map3 : BaseScene
    {
        private ConsoleKey input;

        private string[] mapData;
        private bool[,] map;

        private List<GameObject> gameObjects;
        private List<NPC> npcs;


        public Map3()
        {

            mapData = new string[]
            {
                "#####################",
                "#                   #",
                "#                   #",
                "                    #",
                "#                   #",
                "#                   #",
                "#####################",
            };



            map = new bool[7, 21];
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 21; x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            //  gameObjects.Add(new Soju(new Vector2(3, 3)));
            //  gameObjects.Add(new Soju(new Vector2(12, 5)));
            gameObjects.Add(new Soju(new Vector2(7, 1)));

            npcs = new List<NPC>();
            // npcs.Add(new Sanghun(new Vector2(8, 2))); /// npc로 어떻게 바꿈 (바꿈)

            //  Game.Player.position = new Vector2(10, 5);
            Game.Player.map = map;
        }
        // map[10,5] = false;

        //       foreach(var npc in npcs)   npc충돌 만들기
        //           {
        //           map[npc.Position.x, npc.Position.x] = false;
        //       }
        //   }

        public override void Render()
        {


            PrintMap();


            foreach (GameObject soju in gameObjects)
            {
                soju.Print();
            }

            foreach (NPC npc in npcs)
            {
                npc.Print();

            }
            Console.SetCursorPosition(0, map.GetLength(0) + 2);
            Game.Player.inventory.PrintAll();
            Game.Player.print();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;

        }
        public override void Update()
        {
            Game.Player.map = this.map;
            Game.Player.Move(input);
        }
        public override void Result()
        {
            //맵 이동

            if (Game.Player.position.x == 0)
            {
                Game.ChangeScene(SceneType.Map1);
                Game.Player.position = new Vector2(19, 3);
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

            foreach (NPC npc in npcs)
            {
                if (TalkToNPC(Game.Player.position, npc.Position))
                {
                    npc.Interact(Game.Player);
                }
                else
                {
                    ClearDialogue(Game.Player.position, npc.Position);
                }
            }

            Console.SetCursorPosition(0, map.GetLength(0) + 2);
            Game.Player.inventory.PrintAll();
        }

        private bool TalkToNPC(Vector2 playerPos, Vector2 npcPos) // npc 가까이가면 말검
        {
            int dx = Math.Abs(playerPos.x - npcPos.x);
            int dy = Math.Abs(playerPos.y - npcPos.y);

            if (dx + dy == 1)
            {
                return true;
            }
            return false;

        }

        private void ClearDialogue(Vector2 playerPos, Vector2 npcPos)
        {
            int startX = 0;
            int startY = 10;

            Console.WriteLine("                                                               ");

        }



        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
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
