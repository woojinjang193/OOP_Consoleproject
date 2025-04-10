using _250408_consolegame.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame.NPCs
{
    public class Sanghun : NPC
    {
        private int sojucount = 0;
        private int talkCount = 0;

        public Sanghun(Vector2 position)
            : base("Sanghun", ConsoleColor.Red, position)
        {
        }

        public override void Interact(Player player)
        {
            talkCount++;

            if (talkCount == 5 && sojucount < 3)
            {
                Console.SetCursorPosition(25, 2);
                Console.WriteLine("SANGHUN: 귀찮게하지마");

                return;
            }

            if (talkCount == 7 && sojucount < 3)
            {
                Console.SetCursorPosition(25, 2);
                Console.WriteLine("SANGHUN: 그러다가 혼난다?");

                return;
            }

            if (talkCount == 10 && sojucount < 3)
            {
                Console.SetCursorPosition(25, 2);
                Console.WriteLine("SANGHUN: 귀찮게하지 말라고했지");
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("  SANGHUN이 화났습니다.");
                Console.ResetColor();
                Game.End();


                return;
            }

            //소주 3개
            if(player.inventory.DoYouHaveThreeSojus())
            {
                player.inventory.Remove(new Soju(player.position)); // ???
                Console.SetCursorPosition(25, 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SANGHUN:오 소주 고마워! 아앗 취한당!");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.Clear();
                Game.ChangeScene(SceneType.Ending);
                return;
            }

            if (sojucount < 3)
            {
                Console.SetCursorPosition(25, 2);
                Console.WriteLine("SANGHUN: 소주 못봤니?");
                return;


            }


        }
    }
    }
