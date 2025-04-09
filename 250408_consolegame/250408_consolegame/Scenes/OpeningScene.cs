using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame.Scenes
{
    class OpeningScene : BaseScene
    {
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("     ∬∬∬∫⌡");
            Console.WriteLine("     |  ◯‿◯");
            Console.WriteLine("     |╰╯    |");
            Console.WriteLine("     ヽ＿＿ノ");
            Console.WriteLine("       ︶ ︶");
            Console.WriteLine("    내이름은 영기.");
            Console.WriteLine("    신촌에 놀러왔다.");
            Console.WriteLine("    ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("계속하려면 아무키나 누르세요...");
            Console.ResetColor();
            Console.ReadKey(true);

            Console.Clear();
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("     ∬∬∬∫⌡");
            Console.WriteLine("     |  ◯‿◯");
            Console.WriteLine("     |╰╯    |");
            Console.WriteLine("     ヽ＿＿ノ");
            Console.WriteLine("       ︶ ︶");
            Console.WriteLine("    일단 둘러보자.");
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
            Game.ChangeScene(SceneType.Map1);
            
        }
        public override void Update()
        { 

        }
        public override void Result()
        { 

        }

    }
}
