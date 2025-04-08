using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250408_consolegame.Scenes
{
    class TestScene2 : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("test2씬입니다");
            Console.WriteLine("1. 테스트 1로 이동");
            Console.WriteLine("3. 테스트 3로 이동");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;

        }
        public override void Update()
        {

        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene(SceneType.Map1);
                    break;

                case ConsoleKey.D3:
                    Game.ChangeScene(SceneType.Map3);
                    break;
            }

        }
    }
}