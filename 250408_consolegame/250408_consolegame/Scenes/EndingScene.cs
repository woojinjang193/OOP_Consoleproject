using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame.Scenes
{
    class EndingScene : BaseScene
    {
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("     ∬⌡￣⌡⌡⌡");
            Console.WriteLine("     | ˘‿˘|");
            Console.WriteLine("     |╰╯    |");
            Console.WriteLine("     ヽ＿＿ノ");
            Console.WriteLine("      ︶ ︶");
            Console.WriteLine("    영기야 고마워.");
            Console.WriteLine("    난 이제 집에 갈게.");
            Console.WriteLine("    ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("계속하려면 아무키나 누르세요...");
            Console.ResetColor();
            Console.ReadKey(true);

            Console.Clear();
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("     ∬⌡￣⌡⌡⌡");
            Console.WriteLine("     | ˘‿˘|");
            Console.WriteLine("     |╰╯    |");
            Console.WriteLine("     ヽ＿＿ノ");
            Console.WriteLine("      ︶ ︶");
            Console.WriteLine("    다음에는 위스키 마시자.");
            Console.WriteLine("    ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    ");
            Console.WriteLine("계속하려면 아무키나 누르세요...");
            Console.ResetColor();

        }
        public override void Input()
        {
            Console.ReadKey(true);
            Console.Clear();
            Game.End();

        }
        public override void Update()
        {

        }
        public override void Result()
        {

        }

    }
}

