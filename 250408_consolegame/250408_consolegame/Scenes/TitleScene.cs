using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame.Scenes
{
    public class TitleScene : BaseScene
    {
        public override void Render()  
        {
            Console.SetCursorPosition(2, 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************");
            Console.WriteLine("  *신촌에 놀러온 영기*");
            Console.WriteLine("  ********************");
            Console.ResetColor();
        }
        public override void Input()  
        {
            Console.ReadKey(true);
            
        }
        public override void Update()  
        {

        }
        public override void Result()  
        {
            Game.ChangeScene(SceneType.Opening);

        }
    }
}
